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
    public partial class frmMembers : BaseEditorForm
    {
        MemberDataset dsMember;
        public frmMembers()
        {
            InitializeComponent();
            InitializeDataset();
            EnableFDRProperties(false);
            dtpEnlistedDate.EditValue = DateTime.Today;
        }

        private void InitializeDataset()
        {
            dsMember = new MemberDataset();
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
        string _PhotoNoMinee1;
        Bitmap imagePhotoNoMinee1;
        

        private void lnkNomineePhoto1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _PhotoNoMinee1 = openFileDialog.FileName;
                if (_PhotoNoMinee1 != "" && _PhotoNoMinee1 != "openFileDialog")
                {
                    try
                    {
                        imagePhotoNoMinee1 = new Bitmap(_PhotoNoMinee1);
                        imgNomineePhoto1.Image = imagePhotoNoMinee1;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Select a Image/ Picture");
                        return;
                    }
                }
            }
        }
        string _SignNominee1;
        Bitmap imageSignnominee1;
        
        private void lnkNomineeSign1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _SignNominee1 = openFileDialog.FileName;
                if (_SignNominee1 != "" && _SignNominee1 != "openFileDialog")
                {
                    try
                    {
                        imageSignnominee1 = new Bitmap(_SignNominee1);
                        imgNomineeSign1.Image = imageSignnominee1;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Select a Image/ Picture");
                        return;
                    }
                }
            }
        }
        string _PhotoNoMinee2;
        Bitmap imagePhotoNoMinee2;
       

        private void lnkNomineePhoto2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _PhotoNoMinee2 = openFileDialog.FileName;
                if (_PhotoNoMinee2 != "" && _PhotoNoMinee2 != "openFileDialog")
                {
                    try
                    {
                        imagePhotoNoMinee2 = new Bitmap(_PhotoNoMinee2);
                        imgNomineePhoto2.Image = imagePhotoNoMinee2;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Select a Image/ Picture");
                        return;
                    }
                }
            }
        }
        string _SignNominee2;
        Bitmap imageSignnominee2;

        private void lnkNomineeSign2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _SignNominee2 = openFileDialog.FileName;
                if (_SignNominee2 != "" && _SignNominee2 != "openFileDialog")
                {
                    try
                    {
                        imageSignnominee2 = new Bitmap(_SignNominee2);
                        imgNomineeSign2.Image = imageSignnominee2;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Select a Image/ Picture");
                        return;
                    }
                }
            }
        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("You want to cancel without saving ?","Confirm Cancel",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
                ClearAll();
        }

        private void ClearAll()
        {
            txtAge.Text = "";
            txtEnergencyContact.Text = "";
            txtFatherHusbandName.Text = "";
            txtFullName.Text = "";
            txtIncomeAmount.Text = "";
            txtLAddress.Text = "";
            txtLDistrict.Text = "";
            txtLpostCode.Text = "";
            txtLPostOffice.Text = "";
            txtLThana.Text = "";
            txtLVillage.Text = "";
            txtMotherName.Text = "";
            txtNationality.Text = "";
            txtNomiName1.Text = "";
            txtNomiName2.Text = "";
            txtNomineeAddress1.Text = "";
            txtNomineeAddress2.Text = "";
            txtNomineeAge1.Text = "";
            txtNomineeAge2.Text = "";
            txtNomineeAmount1.Text = "";
            txtNomineeAmount2.Text = "";
            txtNomineeRelation1.Text = "";
            txtNomineeRelation2.Text = "";
            txtPAddress.Text = "";
            txtPDistrict.Text = "";
            txtPolicyNumber.Text = "";
            txtPPostCode.Text = "";
            txtPPostOffice.Text = "";
            txtProfession.Text = "";
            txtPThana.Text = "";
            txtPVillage.Text = "";
            txtSaveAmount.Text = "";
            txtSavingRatio.Text = "";
            txtTelephone.Text = "";
            txtFormNumber.Text = "";
            txtMembersCode.Text = "";
            txtNationalID.Text = "";
            dtpDoB.EditValue = null;
            dtpEnlistedDate.EditValue = null;
            imgNomineePhoto1.Image = null;
            imgNomineePhoto2.Image = null;
            imgNomineeSign1.Image = null;
            imgNomineeSign2.Image = null;
            imgPhoto.Image = null;
            imgSignature.Image = null;

            _Photo = "";
            _PhotoNoMinee1 = "";
            _PhotoNoMinee2 = "";
            _Sign = "";
            _SignNominee1 = "";
            _SignNominee2 = "";
            chkFDR.Checked = false;
            EnableFDRProperties(false);
            txtFormNumber.Focus();
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            if (ErrorFound())
                return;
            SavaInformation();
            MessageBox.Show("Members Information save Successfully", "Data Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ErrorFound()
        {
            if (string.IsNullOrEmpty(txtFormNumber.Text))
            {
                MainErrorProvider.SetError(txtFormNumber, "Input Form Number");
                return true;
            }
            else
                MainErrorProvider.SetError(txtFormNumber, null);

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

            if (string.IsNullOrEmpty(txtNomiName1.Text) )
            {
                MainErrorProvider.SetError(txtNomiName1, "Input Nominee# 1 Name");
                return true;
            }
            else
                MainErrorProvider.SetError(txtNomiName1, null);

            if (string.IsNullOrEmpty(txtNomineeAddress1.Text))
            {
                MainErrorProvider.SetError(txtNomineeAddress1, "Input Nominee# 1 Address");
                return true;
            }
            else
                MainErrorProvider.SetError(txtNomineeAddress1, null);

            if (string.IsNullOrEmpty(txtNomineeAge1.Text))
            {
                MainErrorProvider.SetError(txtNomineeAge1, "Input Nominee# 1 Age");
                return true;
            }
            else
                MainErrorProvider.SetError(txtNomineeAge1, null);

            if (string.IsNullOrEmpty(txtNomineeRelation1.Text))
            {
                MainErrorProvider.SetError(txtNomineeRelation1, "Input Nominee# 1 Relation");
                return true;
            }
            else
                MainErrorProvider.SetError(txtNomineeRelation1, null);

            if (string.IsNullOrEmpty(txtMembersCode.Text))
            {
                MainErrorProvider.SetError(txtMembersCode, "Input Members Code");
                return true;
            }
            else
                MainErrorProvider.SetError(txtMembersCode, null);
            if (dtpEnlistedDate.EditValue == null)
            {
                MainErrorProvider.SetError(dtpEnlistedDate,"Select Enlisted date");
                return true;
            }
            else
                MainErrorProvider.SetError(dtpEnlistedDate, null);

            if (!chkFDR.Checked)
            {
                if (string.IsNullOrEmpty(txtPolicyNumber.Text))
                {
                    MainErrorProvider.SetError(txtPolicyNumber, "Input Policy Number");
                    return true;
                }
                else
                    MainErrorProvider.SetError(txtPolicyNumber, null);


                if (string.IsNullOrEmpty(txtSavingRatio.Text))
                {
                    MainErrorProvider.SetError(txtSavingRatio, "Input Saving Ratio");
                    return true;
                }
                else
                    MainErrorProvider.SetError(txtSavingRatio, null);

                if (dtpEnlistedDate.DateTime.Year == 1 || dtpEnlistedDate.DateTime.Year == 9999)
                {
                    MainErrorProvider.SetError(dtpEnlistedDate, "Input Enlisted Date");
                    return true;
                }
                else
                    MainErrorProvider.SetError(dtpEnlistedDate, null);
            }
            else
            {
                if (string.IsNullOrEmpty(txtFDRNumber.Text))
                {
                    MainErrorProvider.SetError(txtFDRNumber, "Input FDR Number");
                    return true;
                }
                else
                    MainErrorProvider.SetError(txtFDRNumber, null);
                if (string.IsNullOrEmpty(txtFDRAmount.Text))
                {
                    MainErrorProvider.SetError(txtFDRAmount, "Input FDR Amount");
                    return true;
                }
                else
                    MainErrorProvider.SetError(txtFDRAmount, null);

                if (string.IsNullOrEmpty(txtFDRMonthlyProfit.Text))
                {
                    MainErrorProvider.SetError(txtFDRMonthlyProfit, "Input Mothly profit amount");
                    return true;
                }
                else
                    MainErrorProvider.SetError(txtFDRMonthlyProfit, null);
            }

            return false;
        }

        private void SavaInformation()
        {
#region MembersDataSave

            DataRow drMember = dsMember.Members.NewRow();
            drMember["IID"] = Guid.NewGuid();
            drMember["FullName"] = txtFullName.Text;
            drMember["MemberCode"] = txtMembersCode.Text;
            drMember["FatherHusbandName"] = txtFatherHusbandName.Text;
            drMember["MotherName"] = txtMotherName.Text;
            drMember["Age"] = txtAge.Text;
            if(dtpDoB.DateTime.Year != 1 && dtpDoB.DateTime.Year != 9999)
                drMember["DOB"] = dtpDoB.DateTime.ToShortDateString();
            drMember["Nationality"] = txtNationality.Text;
            drMember["Profession"] = txtProfession.Text;
            drMember["Telephone"] = txtTelephone.Text;
            drMember["EmergencyContact"] = txtEnergencyContact.Text;
            drMember["NationalID"] = txtNationalID.Text;
            drMember["LLocation"] = txtLAddress.Text;
            drMember["LVillage"] = txtLVillage.Text;
            drMember["LThana"] = txtLThana.Text;
            drMember["LPostOffice"] = txtLPostOffice.Text;
            drMember["LPostCode"] = txtLpostCode.Text;
            drMember["LDistrict"] = txtLDistrict.Text;
            drMember["PLocation"] = txtPAddress.Text;
            drMember["PVillage"] = txtPVillage.Text;
            drMember["PThana"] = txtPThana.Text;
            drMember["PPostOffice"] = txtPPostOffice.Text;
            drMember["PPostCode"] = txtPPostCode.Text;
            drMember["PDistrict"] = txtPDistrict.Text;
            
            if(rdoInDaily.Checked)
                drMember["IncomeAmount"] = txtIncomeAmount.Text;
            else if(rdoInWeekly.Checked)
                drMember["IncomeAmount"] = double.Parse(txtIncomeAmount.Text)/7;
            else
                drMember["IncomeAmount"] = double.Parse(txtIncomeAmount.Text)/30;
            
            if(rdoSaDaily.Checked)
                drMember["SavingsAmount"] = txtSaveAmount.Text;
            else if(rdoSaWeekly.Checked)
                drMember["SavingsAmount"] = double.Parse(txtSaveAmount.Text)/7;
            else
                drMember["SavingsAmount"] = double.Parse(txtSaveAmount.Text)/30;

            if (_Photo != null)
            {
                System.IO.FileStream file = new System.IO.FileStream(_Photo, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read);
                byte[] image1 = new byte[file.Length];
                file.Read(image1, 0, Convert.ToInt32(file.Length));
                drMember["Photo"] = image1;
            }
           if (_Sign != null)
            {
                System.IO.FileStream file = new System.IO.FileStream(_Sign, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read);
                byte[] image1 = new byte[file.Length];
                file.Read(image1, 0, Convert.ToInt32(file.Length));
                drMember["Signature"] = image1;
            }
            dsMember.Members.Rows.Add(drMember);
#endregion
            DataRow drPolicy = dsMember.Policy.NewRow();
            DataRow drFDR = dsMember.FDR.NewRow();
            if (!chkFDR.Checked)
            {
                #region PolicyDataSsave
                
                drPolicy["IID"] = Guid.NewGuid();
                drPolicy["MemberID"] = drMember["IID"];
                drPolicy["FormNumber"] = txtFormNumber.Text;
                drPolicy["PolicyNumber"] = txtPolicyNumber.Text;
                drPolicy["SavingRatio"] = txtSavingRatio.Text;
                drPolicy["EnlistedDate"] = dtpEnlistedDate.DateTime.ToShortDateString();
                dsMember.Policy.Rows.Add(drPolicy);
                #endregion
            }
            else
            {
                #region FDR
                
                drFDR["IID"] = Guid.NewGuid();
                drFDR["MemberID"] = drMember["IID"];
                drFDR["FormNUmber"] = txtFormNumber.Text;
                drFDR["FDRAmount"] = txtFDRAmount.EditValue.ToString();
                drFDR["MonthlyProfitAmount"] = txtFDRMonthlyProfit.EditValue.ToString();
                drFDR["DepositForYears"] = nudFDRYears.EditValue.ToString();
                drFDR["DepositDate"] = dtpEnlistedDate.EditValue;
                drFDR["FDRNumber"] = txtFDRNumber.Text;
                drFDR["Status"] = true;
                dsMember.FDR.Rows.Add(drFDR);

                #endregion
            }

#region NomineeDataSave
            
            //nominee # 1

            DataRow drNominee = dsMember.Nominee.NewRow();
            drNominee["IID"] = Guid.NewGuid();
            if (!chkFDR.Checked)
                drNominee["PolicyID"] = drPolicy["IID"];
            else
                drNominee["FDRID"] = drFDR["IID"];
            drNominee["NomineeName"] = txtNomiName1.Text;
            drNominee["Address"] = txtNomineeAddress1.Text;
            drNominee["Age"] = txtNomineeAge1.Text;
            drNominee["Relation"] = txtNomineeRelation1.Text;
            drNominee["Amount"] = txtNomineeAmount1.Text;
            drNominee["SaveDate"] = DateTime.Now;
            if (_PhotoNoMinee1 != null)
            {
                System.IO.FileStream file = new System.IO.FileStream(_PhotoNoMinee1, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read);
                byte[] image1 = new byte[file.Length];
                file.Read(image1, 0, Convert.ToInt32(file.Length));
                drNominee["Photo"] = image1;
            }
            if (_SignNominee1 != null)
            {
                System.IO.FileStream file = new System.IO.FileStream(_SignNominee1, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read);
                byte[] image1 = new byte[file.Length];
                file.Read(image1, 0, Convert.ToInt32(file.Length));
                drNominee["Signature"] = image1;
            }
            dsMember.Nominee.Rows.Add(drNominee);
            
            //nominee # 2
            if (!string.IsNullOrEmpty(txtNomiName2.Text))
            {
                drNominee = dsMember.Nominee.NewRow();
                drNominee["IID"] = Guid.NewGuid();
                if (!chkFDR.Checked)
                    drNominee["PolicyID"] = drPolicy["IID"];
                else
                    drNominee["FDRID"] = drFDR["IID"];
                drNominee["NomineeName"] = txtNomiName2.Text;
                drNominee["Address"] = txtNomineeAddress2.Text;
                drNominee["Age"] = txtNomineeAge2.Text;
                drNominee["Relation"] = txtNomineeRelation2.Text;
                drNominee["Amount"] = txtNomineeAmount2.Text;
                drNominee["SaveDate"] = DateTime.Now;
                if (_PhotoNoMinee2 != null)
                {
                    System.IO.FileStream file = new System.IO.FileStream(_PhotoNoMinee2, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read);
                    byte[] image1 = new byte[file.Length];
                    file.Read(image1, 0, Convert.ToInt32(file.Length));
                    drNominee["Photo"] = image1;
                }
                if (_SignNominee2 != null)
                {
                    System.IO.FileStream file = new System.IO.FileStream(_SignNominee2, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read);
                    byte[] image1 = new byte[file.Length];
                    file.Read(image1, 0, Convert.ToInt32(file.Length));
                    drNominee["Signature"] = image1;
                }
                dsMember.Nominee.Rows.Add(drNominee);
            }
#endregion

            DataHelper.UpdateData(dsMember.Members);
            if (!chkFDR.Checked)
                DataHelper.UpdateData(dsMember.Policy);
            else
                DataHelper.UpdateData(dsMember.FDR);
            DataHelper.UpdateData(dsMember.Nominee);
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

        private void chkFDR_CheckedChanged(object sender, EventArgs e)
        {
             EnableFDRProperties(chkFDR.Checked);
        }

        private void EnableFDRProperties(bool val)
        {
            txtFDRAmount.Properties.ReadOnly = !val;
            txtFDRMonthlyProfit.Properties.ReadOnly = !val;
            nudFDRYears.Properties.ReadOnly = !val;
            txtFDRNumber.Properties.ReadOnly = !val;
        }
    }
}