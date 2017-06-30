
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MicroCredit.BaseControl;
using System.Configuration;
using MicroCredit.DataSets;

namespace MicroCredit.Forms
{
    public partial class frmMembersEditView : BaseEditorForm
    {
        MemberDataset dsMember;
        public frmMembersEditView()
        {
            InitializeComponent();
            InitializeDataset();

        }

        private void InitializeDataset()
        {
            dsMember = new MemberDataset();
            frmLoading lod = new frmLoading();
            lod.Show();
            dsMember.MemberEditLookup.Clear();
            dsMember.MemberEditLookup.Merge(DataHelper.GetTableData(dsMember.MemberEditLookup   ).Tables[0]);
            dgMembers.DataSource = dsMember.MemberEditLookup;
            lod.Dispose();
        }
        string _Photo;
        Bitmap imagePhoto;
        private void lnkPhoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _Photo = openFileDialog.FileName;
                if (_Photo != "" && _Photo != "openFileDialog")
                {
                    try
                    {
                        imagePhoto = new Bitmap(_Photo);
                        imgPhoto.Image = imagePhoto;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Select a Image/ Picture");
                        return;
                    }
                }
            }
        }
        
        string _Sign;
        Bitmap imageSign;
        
        private void lnkSignature_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _Sign = openFileDialog.FileName;
                if (_Sign != "" && _Sign != "openFileDialog")
                {
                    try
                    {
                        imageSign = new Bitmap(_Sign);
                        imgSignature.Image = imageSign;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Select a Image/ Picture");
                        return;
                    }
                }
            }
        }
       
       
        private void ClearAll()
        {
            txtAge.Text = "";
            txtEnergencyContact.Text = "";
            txtFatherHusbandName.Text = "";
            txtFullName.Text = "";
           
            txtLAddress.Text = "";
            txtLDistrict.Text = "";
            txtLpostCode.Text = "";
            txtLPostOffice.Text = "";
            txtLThana.Text = "";
            txtLVillage.Text = "";
            txtMotherName.Text = "";
            txtNationality.Text = "";
            txtPAddress.Text = "";
            txtPDistrict.Text = "";
           
            txtPPostCode.Text = "";
            txtPPostOffice.Text = "";
            txtProfession.Text = "";
            txtPThana.Text = "";
            txtPVillage.Text = "";
            
            txtTelephone.Text = "";
            
            dtpDoB.EditValue = null;
           
            imgPhoto.Image = null;
            imgSignature.Image = null;

            _Photo = "";
           
            _Sign = "";
            
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            if (ErrorFound())
                return;
            SavaInformation();
            MessageBox.Show("Members Information update Successfully", "Data Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ErrorFound()
        {
            

            if (string.IsNullOrEmpty(txtFullName.Text))
            {
                MainErrorProvider.SetError(txtFullName, "Input Member's Name");
                return true;
            }
            else
                MainErrorProvider.SetError(txtFullName, null);

            if (string.IsNullOrEmpty(txtFatherHusbandName.Text))
            {
                MainErrorProvider.SetError(txtFatherHusbandName, "Input Father/Husband's Name");
                return true;
            }
            else
                MainErrorProvider.SetError(txtFatherHusbandName, null);
            
            if (string.IsNullOrEmpty(txtAge.Text))
            {
                MainErrorProvider.SetError(txtAge, "Input Member's Age");
                return true;
            }
            else
                MainErrorProvider.SetError(txtAge, null);

            //if (string.IsNullOrEmpty(txtEnergencyContact.Text))
            //{
            //    MainErrorProvider.SetError(txtEnergencyContact, "Input Emergency Contact");
            //    return true;
            //}
            //else
            //    MainErrorProvider.SetError(txtEnergencyContact, null);

            if (string.IsNullOrEmpty(txtLAddress.Text) && string.IsNullOrEmpty(txtLVillage.Text))
            {
                MainErrorProvider.SetError(txtLVillage, "Input Input Present Address");
                return true;
            }
            else
                MainErrorProvider.SetError(txtLVillage, null);

            if (string.IsNullOrEmpty(txtPAddress.Text) && string.IsNullOrEmpty(txtPVillage.Text))
            {
                MainErrorProvider.SetError(txtPVillage, "Input Permanent Address");
                return true;
            }
            else
                MainErrorProvider.SetError(txtPVillage, null);

            
            return false;
        }

        private void SavaInformation()
        {
#region MembersDataSave


            _drEdit["FullName"] = txtFullName.Text;
            _EditView["FullName"] = txtFullName.Text;
            
            _drEdit["MemberCode"] = txtMemberCode.Text;
            _EditView["MemberCode"] = txtMemberCode.Text;
            
            _drEdit["FatherHusbandName"] = txtFatherHusbandName.Text;
            _EditView["FatherHusbandName"] = txtFatherHusbandName.Text;

            _drEdit["MotherName"] = txtMotherName.Text;
            _drEdit["Age"] = txtAge.Text;
            if(dtpDoB.DateTime.Year != 1 && dtpDoB.DateTime.Year != 9999)
                _drEdit["DOB"] = dtpDoB.DateTime.ToShortDateString();
            _drEdit["Nationality"] = txtNationality.Text;
            _drEdit["Profession"] = txtProfession.Text;
            _drEdit["Telephone"] = txtTelephone.Text;
            _drEdit["EmergencyContact"] = txtEnergencyContact.Text;
            _drEdit["NationalID"] = txtNationalID.Text;
            _drEdit["LLocation"] = txtLAddress.Text;
            _drEdit["LVillage"] = txtLVillage.Text;
            _drEdit["LThana"] = txtLThana.Text;
            _drEdit["LPostOffice"] = txtLPostOffice.Text;
            _drEdit["LPostCode"] = txtLpostCode.Text;
            _drEdit["LDistrict"] = txtLDistrict.Text;
            _drEdit["PLocation"] = txtPAddress.Text;
            _drEdit["PVillage"] = txtPVillage.Text;
            _drEdit["PThana"] = txtPThana.Text;
            _drEdit["PPostOffice"] = txtPPostOffice.Text;
            _drEdit["PPostCode"] = txtPPostCode.Text;
            _drEdit["PDistrict"] = txtPDistrict.Text;

            if (_Photo != null)
            {
                System.IO.FileStream file = new System.IO.FileStream(_Photo, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read);
                byte[] image1 = new byte[file.Length];
                file.Read(image1, 0, Convert.ToInt32(file.Length));
                _drEdit["Photo"] = image1;
                _EditView["Photo"] = image1;
            }
           if (_Sign != null)
            {
                System.IO.FileStream file = new System.IO.FileStream(_Sign, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read);
                byte[] image1 = new byte[file.Length];
                file.Read(image1, 0, Convert.ToInt32(file.Length));
                _drEdit["Signature"] = image1;
            }
          //  dsMember.Members.Rows.Add(drMember);
#endregion
            DataHelper.UpdateData(dsMember.Members);
            

            ClearAll();
        }

        private void dtpDoB_EditValueChanged(object sender, EventArgs e)
        {
            txtAge.Text = getAge(dtpDoB.DateTime);
        }
        private string getAge(DateTime dateTime)
        {
            int y = DateTime.Now.Year - dateTime.Year;
            int m = DateTime.Now.Month - dateTime.Month;
            if (m < 0)
            {
                if (y != 0)
                    y--;
                m = 12 + m;
            }
            return y.ToString() + " Year(s) " + m.ToString() + " Month(s)";

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FillRow();
        }
        string _editID = "";
        DataRow _drEdit;
        DataRow _EditView;
        private void FillRow()
        {
            if (gridView1.GetFocusedRowCellValue("IID") == null)
                return;
            _editID = gridView1.GetFocusedRowCellValue("IID").ToString();
            dsMember.Members.Clear();
            dsMember.Members.Merge(DataHelper.GetTableData(dsMember.Members, " Where IID = '" + _editID + "'").Tables[0]);
            _drEdit = dsMember.Members.Rows[0];
            _EditView = dsMember.MemberEditLookup.Rows.Find(_editID);
            txtFullName.Text = _drEdit["FullName"].ToString();
            txtMemberCode.Text =_drEdit["MemberCode"].ToString();
            txtFatherHusbandName.Text = _drEdit["FatherHusbandName"].ToString();
            txtMotherName.Text = _drEdit["MotherName"].ToString();
            
             txtAge.Text = _drEdit["Age"].ToString();
            if(_drEdit["DOB"].ToString()!="")
                dtpDoB.DateTime = (DateTime)_drEdit["DOB"] ;
            
            txtNationality.Text = _drEdit["Nationality"].ToString();
            txtProfession.Text = _drEdit["Profession"].ToString();
            txtTelephone.Text = _drEdit["Telephone"].ToString();
            txtEnergencyContact.Text = _drEdit["EmergencyContact"].ToString();
            txtNationalID.Text = _drEdit["NationalID"].ToString();
            txtLAddress.Text = _drEdit["LLocation"].ToString();
            txtLVillage.Text =_drEdit["LVillage"].ToString();
            txtLThana.Text = _drEdit["LThana"].ToString();
            txtLPostOffice.Text = _drEdit["LPostOffice"].ToString();
            txtLpostCode.Text = _drEdit["LPostCode"].ToString();
            txtLDistrict.Text =  _drEdit["LDistrict"].ToString();
            txtPAddress.Text =_drEdit["PLocation"].ToString();
            txtPVillage.Text = _drEdit["PVillage"].ToString();
            txtPThana.Text = _drEdit["PThana"].ToString();
            txtPPostOffice.Text = _drEdit["PPostOffice"].ToString();
            txtPPostCode.Text = _drEdit["PPostCode"].ToString();
            txtPDistrict.Text = _drEdit["PDistrict"].ToString();
            if (_drEdit["Photo"].ToString() != "")
            {
                byte[] image = (byte[])_drEdit["Photo"];
                System.IO.MemoryStream stream = new System.IO.MemoryStream(image, 0, image.Length, false);
                this.imgPhoto.Image = System.Drawing.Image.FromStream(stream);
            }
            else
            {
                imgPhoto.Image = null;
            }
            if (_drEdit["Signature"].ToString() != "")
            {
                byte[] image = (byte[])_drEdit["Signature"];
                System.IO.MemoryStream stream = new System.IO.MemoryStream(image, 0, image.Length, false);
                this.imgSignature.Image = System.Drawing.Image.FromStream(stream);
            }
            else
            {
                imgSignature.Image = null;
            }

        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                FillRow();
        }

        private void imgPhoto_DoubleClick(object sender, EventArgs e)
        {
            new ShowImagefrm(((System.Windows.Forms.PictureBox)(sender)).Image).ShowDialog(this);
        }
    }
}