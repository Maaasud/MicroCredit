using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MicroCredit.BaseControl;
using MicroCredit.DataSets;

namespace MicroCredit.Forms
{
    public partial class frmPolicyEditView : BaseEditViewForm
    {
        MemberDataset dsMembers;
        public frmPolicyEditView()
        {
            InitializeComponent();
            dsMembers = new MemberDataset();
            InitializaDatset();
        }

        private void InitializaDatset()
        {

            dsMembers.MembersPolicyLookup.Clear();
            dsMembers.MembersPolicyLookup.Merge(DataHelper.GetTableData(dsMembers.MembersPolicyLookup).Tables[0]);
            cmbPolicy.Properties.DataSource = dsMembers.MembersPolicyLookup.Copy();
        }

        private void cmbPolicy_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbPolicy.EditValue == null)
                return;
            dsMembers.Members.Clear();
            dsMembers.Members.Merge(DataHelper.GetTableData(dsMembers.Members, " Where IID = '" + cmbPolicy.GetColumnValue("MemberID").ToString() + "'").Tables[0]);
            DataRow dr = dsMembers.Members.Rows[0];
            txtFatherHusbandName.Text = dr["FatherHusbandName"].ToString();
            txtFullName.Text = dr["FullName"].ToString();
            txtLAddress.Text = dr["LLocation"].ToString();
            txtLDistrict.Text = dr["LDistrict"].ToString();
            txtLpostCode.Text = dr["LPostCode"].ToString();
            txtLPostOffice.Text = dr["LPostOffice"].ToString();
            txtLThana.Text = dr["LThana"].ToString();
            txtLVillage.Text = dr["LVillage"].ToString();
            
            txtTelephone.Text = dr["Telephone"].ToString();
            if (dr["Photo"].ToString() != "")
            {
                byte[] image = (byte[])dr["Photo"];
                System.IO.MemoryStream stream = new System.IO.MemoryStream(image, 0, image.Length, false);
                this.imgPhoto.Image = System.Drawing.Image.FromStream(stream);
            }
            else
            {
                imgPhoto.Image = null;
            }
            dsMembers.Policy.Clear();
            dsMembers.Policy.Merge(DataHelper.GetTableData(dsMembers.Policy, " Where IID = '" + cmbPolicy.EditValue.ToString() + "'").Tables[0]);
            txtSavingRatio.Text = dsMembers.Policy.Rows[0]["SavingRatio"].ToString();
            dtpEnlistedDate.DateTime = (DateTime)dsMembers.Policy.Rows[0]["EnlistedDate"];
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ErrorFound())
                return;
            if (MessageBox.Show("Do you want to change policy Info?", "Update Policy", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            dsMembers.Policy.Rows[0]["SavingRatio"] = txtSavingRatio.Text;
            dsMembers.Policy.Rows[0]["EnlistedDate"] = dtpEnlistedDate.DateTime.ToShortDateString();
            DataHelper.UpdateData(dsMembers.Policy);
            clearAllText();
        }

        private bool ErrorFound()
        {
            if (cmbPolicy.EditValue == null) 
            {
                MainErrorProvider.SetError(cmbPolicy, "Select Policy Number");
                return true;
            }
            else
                MainErrorProvider.SetError(cmbPolicy, null);
            
            if (string.IsNullOrEmpty(txtSavingRatio.Text))
            {
                MainErrorProvider.SetError(txtSavingRatio, "Input Valid Amount");
                return true;
            }
            else
                MainErrorProvider.SetError(txtSavingRatio, null);

            if (dtpEnlistedDate.DateTime.Year == 9999 || dtpEnlistedDate.DateTime.Year == 1)
            {
                MainErrorProvider.SetError(dtpEnlistedDate, "Select Date");
                return true;
            }
            else
                MainErrorProvider.SetError(dtpEnlistedDate, null);
            return false;
        }

        private void clearAllText()
        {
            cmbPolicy.EditValue = null;
            txtFatherHusbandName.Text = "";
            txtFullName.Text = "";
            txtLAddress.Text = "";
            txtLDistrict.Text = "";
            txtLpostCode.Text = "";
            txtLPostOffice.Text = "";
            txtLThana.Text = "";
            txtLVillage.Text = "";
            txtSavingRatio.Text = "";
            txtTelephone.Text = "";
            dtpEnlistedDate.DeselectAll();
        }

        private void txtSavingRatio_Validated(object sender, EventArgs e)
        {
            try
            {
                double d = double.Parse(txtSavingRatio.Text);
                MainErrorProvider.SetError(txtSavingRatio, null);
            }
            catch (Exception ex)
            {
                MainErrorProvider.SetError(txtSavingRatio, "Input Valid Amount");
                txtSavingRatio.Focus();
            }   
        }

        private void imgPhoto_DoubleClick(object sender, EventArgs e)
        {
            new ShowImagefrm(((System.Windows.Forms.PictureBox)(sender)).Image).ShowDialog(this);
        }
    }
}