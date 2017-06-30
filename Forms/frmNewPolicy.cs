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
    public partial class frmNewPolicy : BaseEditorForm
    {
        MemberDataset dsMembers;
        public frmNewPolicy()
        {
            InitializeComponent();
            InitializeDataSet();
        }

        private void InitializeDataSet()
        {
            dsMembers = new MemberDataset();
            dsMembers.MembersLookup.Clear();
            dsMembers.MembersLookup.Merge(DataHelper.GetTableData(dsMembers.MembersLookup).Tables[0]);
            cmbMemberCode.Properties.DataSource = dsMembers.MembersLookup.Copy();
        }

        private void txtPPostCode_EditValueChanged(object sender, EventArgs e)
        {

        }
        string MemberID = "";
        byte[] _photoNominee1;
        byte[] _SignNominee1;
        byte[] _photoNominee2;
        byte[] _SignNominee2 ;
        private void cmbMemberCode_EditValueChanged(object sender, EventArgs e)
        {
            dsMembers.Members.Clear();
            dsMembers.Members.Merge(DataHelper.GetTableData(dsMembers.Members, " Where IID = '" + cmbMemberCode.EditValue.ToString() + "'").Tables[0]);
            DataRow dr = dsMembers.Members.Rows[0];
            MemberID = dr["IID"].ToString();
            txtFatherHusbandName.Text = dr["FatherHusbandName"].ToString();
            txtFullName.Text = dr["FullName"].ToString();
            txtLAddress.Text = dr["LLocation"].ToString();
            txtLDistrict.Text = dr["LDistrict"].ToString();
            txtLpostCode.Text = dr["LPostCode"].ToString();
            txtLPostOffice.Text = dr["LPostOffice"].ToString();
            txtLThana.Text = dr["LThana"].ToString();
            txtLVillage.Text = dr["LVillage"].ToString();
            txtPAddress.Text = dr["PLocation"].ToString();
            txtPDistrict.Text = dr["PDistrict"].ToString();
            txtPPostCode.Text = dr["PPostCode"].ToString();
            txtPPostOffice.Text = dr["PPostOffice"].ToString();
            txtPThana.Text = dr["PThana"].ToString();
            txtPVillage.Text = dr["PVillage"].ToString();
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
            dsMembers.MemberNomineeLookup.Clear();
            dsMembers.MemberNomineeLookup.Merge(DataHelper.GetTableData(dsMembers.MemberNomineeLookup, " Where MemberID = '" + cmbMemberCode.EditValue.ToString() + "'").Tables[0]);
            
            DataRow drN1 = dsMembers.MemberNomineeLookup.Rows[0];
            txtNomiName1.Text = drN1["NomineeName"].ToString();
            txtNomineeAddress1.Text = drN1["Address"].ToString();
            txtNomineeAge1.Text = drN1["Age"].ToString();
            txtNomineeAmount1.Text = drN1["Amount"].ToString();
            txtNomineeRelation1.Text = drN1["Relation"].ToString();
            if (drN1["Photo"].ToString() != "")
            {
                byte[] image = (byte[])drN1["Photo"];
                _photoNominee1 = image;
                System.IO.MemoryStream stream = new System.IO.MemoryStream(image, 0, image.Length, false);
                this.imgNomineePhoto1.Image = System.Drawing.Image.FromStream(stream);
            }
            else
                imgNomineePhoto1.Image = null;
            if (drN1["Signature"].ToString() != "")
            {
                byte[] image = (byte[])drN1["Signature"];
                _SignNominee1 = image;
                System.IO.MemoryStream stream = new System.IO.MemoryStream(image, 0, image.Length, false);
                this.imgNomineeSign1.Image = System.Drawing.Image.FromStream(stream);
            }
            else
                imgNomineeSign1.Image = null;
            if (dsMembers.MemberNomineeLookup.Rows.Count > 1)
            {
                DataRow drN2 = dsMembers.MemberNomineeLookup.Rows[1];
                txtNomiName2.Text = drN2["NomineeName"].ToString();
                txtNomineeAddress2.Text = drN2["Address"].ToString();
                txtNomineeAge2.Text = drN2["Age"].ToString();
                txtNomineeAmount2.Text = drN2["Amount"].ToString();
                txtNomineeRelation2.Text = drN2["Relation"].ToString();
                if (drN2["Photo"].ToString() != "")
                {
                    byte[] image = (byte[])drN2["Photo"];
                    _photoNominee2 = image;
                    System.IO.MemoryStream stream = new System.IO.MemoryStream(image, 0, image.Length, false);
                    this.imgNomineePhoto2.Image = System.Drawing.Image.FromStream(stream);
                }
                else
                    imgNomineePhoto2.Image = null;
                if (drN2["Signature"].ToString() != "")
                {
                    byte[] image = (byte[])drN2["Signature"];
                    _SignNominee2 = image;
                    System.IO.MemoryStream stream = new System.IO.MemoryStream(image, 0, image.Length, false);
                    this.imgNomineeSign2.Image = System.Drawing.Image.FromStream(stream);
                }
                else
                    imgNomineeSign2.Image = null;
            }

            txtFormNumber.Focus();
            
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            if(ErrorFound())
                return;
            SavePolicyToDB();
        }

        private void SavePolicyToDB()
        {
            #region PolicyDataSsave
            DataRow drPolicy = dsMembers.Policy.NewRow();
            drPolicy["IID"] = Guid.NewGuid();
            drPolicy["MemberID"] = cmbMemberCode.EditValue.ToString();
            drPolicy["FormNumber"] = txtFormNumber.Text;
            drPolicy["PolicyNumber"] = txtPolicyNumber.Text;
            drPolicy["SavingRatio"] = txtSavingRatio.Text;
            drPolicy["EnlistedDate"] = dtpEnlistedDate.DateTime.ToShortDateString();
            dsMembers.Policy.Rows.Add(drPolicy);
            #endregion
            #region NomineeDataSave

            //nominee # 1

            DataRow drNominee = dsMembers.Nominee.NewRow();
            drNominee["IID"] = Guid.NewGuid();
            drNominee["PolicyID"] = drPolicy["IID"];
            drNominee["NomineeName"] = txtNomiName1.Text;
            drNominee["Address"] = txtNomineeAddress1.Text;
            drNominee["Age"] = txtNomineeAge1.Text;
            drNominee["Relation"] = txtNomineeRelation1.Text;
            drNominee["Amount"] = txtNomineeAmount1.Text;
            if (imgNomineePhoto1.Image != null)
            {
                drNominee["Photo"] = _photoNominee1;
            }
            if (imgNomineeSign1.Image != null)
            {
                drNominee["Signature"] = _SignNominee1;
            }
            dsMembers.Nominee.Rows.Add(drNominee);

            //nominee # 2
            if (!string.IsNullOrEmpty(txtNomiName2.Text))
            {
                drNominee = dsMembers.Nominee.NewRow();
                drNominee["IID"] = Guid.NewGuid();
                drNominee["PolicyID"] = drPolicy["IID"];
                drNominee["NomineeName"] = txtNomiName2.Text;
                drNominee["Address"] = txtNomineeAddress2.Text;
                drNominee["Age"] = txtNomineeAge2.Text;
                drNominee["Relation"] = txtNomineeRelation2.Text;
                drNominee["Amount"] = txtNomineeAmount2.Text;
                if (imgNomineePhoto2.Image != null)
                {
                    drNominee["Photo"] = _photoNominee2;
                }
                if (imgNomineeSign2.Image != null)
                {
                    drNominee["Signature"] = _SignNominee2;
                }
                dsMembers.Nominee.Rows.Add(drNominee);
            }

            #endregion
            DataHelper.UpdateData(dsMembers.Policy);
            DataHelper.UpdateData(dsMembers.Nominee);
        }

        private bool ErrorFound()
        {
            if (cmbMemberCode.EditValue == null)
            {
                MainErrorProvider.SetError(cmbMemberCode, "Select a Member");
                return true;
            }
            else
                MainErrorProvider.SetError(cmbMemberCode, null);

            if (string.IsNullOrEmpty(txtFormNumber.Text))
            {
                MainErrorProvider.SetError(txtFormNumber, "Input Form Number");
                return true;
            }
            else
                MainErrorProvider.SetError(txtFormNumber, null);

            if (string.IsNullOrEmpty(txtNomiName1.Text))
            {
                MainErrorProvider.SetError(txtNomiName1, "Input a Nominee");
                return true;
            }
            else
                MainErrorProvider.SetError(txtNomiName1, null);

            if (string.IsNullOrEmpty(txtNomineeAddress1.Text))
            {
                MainErrorProvider.SetError(txtNomineeAddress1, "Input Nominee Address");
                return true;
            }
            else
                MainErrorProvider.SetError(txtNomineeAddress1, null);

            if (string.IsNullOrEmpty(txtNomineeAge1.Text))
            {
                MainErrorProvider.SetError(txtNomineeAge1, "Input Nominee Age");
                return true;
            }
            else
                MainErrorProvider.SetError(txtNomineeAge1, null);

            if (string.IsNullOrEmpty(txtNomineeRelation1.Text))
            {
                MainErrorProvider.SetError(txtNomineeRelation1, "Input Nominee relation");
                return true;
            }
            else
                MainErrorProvider.SetError(txtNomineeRelation1, null);

            if (string.IsNullOrEmpty(txtNomineeAmount1.Text) || double.Parse(txtNomineeAmount1.Text)== 0)
            {
                MainErrorProvider.SetError(txtNomineeAmount1, "Input Nominee Amount");
                return true;
            }
            else
                MainErrorProvider.SetError(txtNomineeAmount1, null);
            return false;
        }

        private void lnkNomineePhoto1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string _IMG = openFileDialog.FileName;
                if (_IMG != "" && _IMG != "openFileDialog")
                {
                    try
                    {
                        imgNomineeSign2.Image = new Bitmap(_IMG);
                        System.IO.FileStream file = new System.IO.FileStream(_IMG, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read);
                        _photoNominee1 = new byte[file.Length];
                        file.Read(_photoNominee1, 0, Convert.ToInt32(file.Length));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Select a Image/ Picture");
                        return;
                    }
                }
            }
        }

        private void lnkNomineeSign1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string _IMG = openFileDialog.FileName;
                if (_IMG != "" && _IMG != "openFileDialog")
                {
                    try
                    {
                        imgNomineeSign2.Image = new Bitmap(_IMG);
                        System.IO.FileStream file = new System.IO.FileStream(_IMG, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read);
                        _SignNominee1 = new byte[file.Length];
                        file.Read(_SignNominee1, 0, Convert.ToInt32(file.Length));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Select a Image/ Picture");
                        return;
                    }
                }
            }
        }

        private void lnkNomineePhoto2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string _IMG = openFileDialog.FileName;
                if (_IMG != "" && _IMG != "openFileDialog")
                {
                    try
                    {
                        imgNomineeSign2.Image = new Bitmap(_IMG);
                        System.IO.FileStream file = new System.IO.FileStream(_IMG, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read);
                        _photoNominee2 = new byte[file.Length];
                        file.Read(_photoNominee2, 0, Convert.ToInt32(file.Length));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Select a Image/ Picture");
                        return;
                    }
                }
            }
        }

        private void lnkNomineeSign2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string _IMG = openFileDialog.FileName;
                if (_IMG != "" && _IMG != "openFileDialog")
                {
                    try
                    {
                        imgNomineeSign2.Image = new Bitmap(_IMG);
                        System.IO.FileStream file = new System.IO.FileStream(_IMG, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read);
                        _SignNominee2 = new byte[file.Length];
                        file.Read(_SignNominee2, 0, Convert.ToInt32(file.Length));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Select a Image/ Picture");
                        return;
                    }
                }
            }
        }

        private void imgPhoto_DoubleClick(object sender, EventArgs e)
        {
            new ShowImagefrm(((System.Windows.Forms.PictureBox)(sender)).Image).ShowDialog(this);
        }
    }
}