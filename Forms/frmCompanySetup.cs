using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MicroCredit.DataSets;

namespace MicroCredit.Forms
{
    public partial class frmCompanySetup : DevExpress.XtraEditors.XtraForm
    {
        UserCompanyDataset dsCompany;
        private bool _cancel;

        public bool Cancel
        {
            get { return _cancel; }
            set { _cancel = value; }
        }
	
        public frmCompanySetup()
        {
            InitializeComponent();
            dsCompany = new UserCompanyDataset();
            _cancel = false;
        }

        string _Photo;
        Bitmap imagePhoto;
        private void lnkBrowsePhoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _Photo = openFileDialog.FileName;
                if (_Photo != "" && _Photo != "openFileDialog")
                {
                    try
                    {
                        imagePhoto = new Bitmap(_Photo);
                        imgLogo.Image = imagePhoto;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Select a Image/ Picture");
                        return;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ErrorFound())
                return;
            
            DataRow dr = dsCompany.CompanyInfo.NewRow();
            dr["IID"] = Guid.NewGuid();
            dr["Name"] = txtCompanyName.Text;
            dr["Address"] = txtAddress.Text;
            dr["Phone"] = txtPhone.Text;
            if (_Photo != null)
            {
                System.IO.FileStream file = new System.IO.FileStream(_Photo, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read);
                byte[] image1 = new byte[file.Length];
                file.Read(image1, 0, Convert.ToInt32(file.Length));
                dr["Logo"] = image1;
            }
            dsCompany.CompanyInfo.Rows.Add(dr);
            DataHelper.UpdateData(dsCompany.CompanyInfo);
            DemoSecurityDataSet dsSecurity = new DemoSecurityDataSet();
            DataRow drs = dsSecurity.SecurityCheck.NewRow();
            drs = dsSecurity.SecurityCheck.NewRow();
            drs["IID"] = Guid.NewGuid();
            drs["MachineID"] = "";
            drs["SetupDate"] = DateTime.Now;
            drs["EndDate"] = DateTime.Now.AddDays(15);
            drs["Active"] = false;
            drs["AccessTime"] = DateTime.Now;
            drs["AccessLimit"] = 30;
            drs["IsDemo"] = true;
            dsSecurity.SecurityCheck.Rows.Add(drs);
            DataHelper.UpdateData(dsSecurity.SecurityCheck);

            MessageBox.Show("Company Setup Successfully", "Company Setup", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _cancel = false;
            this.Dispose();
        }

        private bool ErrorFound()
        {
            if (string.IsNullOrEmpty(txtCompanyName.Text))
            {
                MainErrorProvider.SetError(txtCompanyName, "Input Comapny Name");
                return true;
            }
            else
                MainErrorProvider.SetError(txtCompanyName, null);
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                MainErrorProvider.SetError(txtAddress, "Input Comapny Address");
                return true;
            }
            else
                MainErrorProvider.SetError(txtAddress, null);
            return false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want to Exit without Company Setup ?", "Company Setup", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                _cancel = true;
                this.Dispose();    
            }
        }
    }
}