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
    public partial class frmPolicyNominee : BaseEditViewForm
    {
        MemberDataset dsMembers;
        public frmPolicyNominee()
        {
            InitializeComponent();
            dsMembers = new MemberDataset();
            InitializaDatset();
        }

        private void InitializaDatset()
        {
            dsMembers.MembersPolicyLookup.Clear();
            dsMembers.MembersPolicyLookup.Merge(DataHelper.GetTableData(dsMembers.MembersPolicyLookup).Tables[0]);
            cmbPolicy.Properties.DataSource = dsMembers.MembersPolicyLookup;
        }
        byte[] _photoNominee1;
        byte[] _SignNominee1;
        byte[] _photoNominee2;
        byte[] _SignNominee2;

        string NomineeID1 = "";
        string NomineeID2 = "";

        private void cmbPolicy_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbPolicy.EditValue == null)
                return;
            dsMembers.Members.Clear();
            dsMembers.Members.Merge(DataHelper.GetTableData(dsMembers.Members, " Where IID = '" + cmbPolicy.GetColumnValue("MemberID").ToString() + "'").Tables[0]);
            DataRow dr = dsMembers.Members.Rows[0];
            
            txtFatherHusbandName.Text = dr["FatherHusbandName"].ToString();
            txtFullName.Text = dr["FullName"].ToString();
            
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
            dsMembers.MemberNomineeLookup.Clear();
            dsMembers.MemberNomineeLookup.Merge(DataHelper.GetTableData(dsMembers.MemberNomineeLookup, " Where PolicyID = '" + cmbPolicy.EditValue.ToString() + "'").Tables[0]);

            DataRow drN1 = dsMembers.MemberNomineeLookup.Rows[0];
            txtNomiName1.Text = drN1["NomineeName"].ToString();
            txtNomineeAddress1.Text = drN1["Address"].ToString();
            txtNomineeAge1.Text = drN1["Age"].ToString();
            txtNomineeAmount1.Text = drN1["Amount"].ToString();
            txtNomineeRelation1.Text = drN1["Relation"].ToString();
            NomineeID1 = drN1["IID"].ToString();
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
                NomineeID2 = drN2["IID"].ToString();
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
            else
                NomineeID2 = "";
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
                        imgNomineePhoto1.Image = new Bitmap(_IMG);
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
                        imgNomineeSign1.Image = new Bitmap(_IMG);
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
                        imgNomineePhoto2.Image = new Bitmap(_IMG);
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

        private void imgNomineePhoto1_DoubleClick(object sender, EventArgs e)
        {
            new ShowImagefrm(((System.Windows.Forms.PictureBox)(sender)).Image).ShowDialog(this);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ErrorFound())
                return;
            if(MessageBox.Show("Do you want to change the Nominee Information?","Nominee Info",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.No)
                return;
            dsMembers.Nominee.Clear();
            dsMembers.Nominee.Merge(DataHelper.GetTableData( dsMembers.Nominee, "Where PolicyID = '" + cmbPolicy.EditValue.ToString() + "'").Tables[0]);
            foreach (DataRow var in dsMembers.Nominee.Rows)
                var.Delete();
            #region NomineeDataSave

            //nominee # 1

            DataRow drNominee = dsMembers.Nominee.NewRow();
            drNominee["IID"] = Guid.NewGuid();
            drNominee["PolicyID"] = cmbPolicy.EditValue.ToString();
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
                drNominee["PolicyID"] = cmbPolicy.EditValue.ToString();
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
            DataHelper.UpdateData(dsMembers.Nominee);
            #endregion
           

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

            if (string.IsNullOrEmpty(txtNomineeAmount1.Text))
            {
                MainErrorProvider.SetError(txtNomineeAmount1, "Input Nominee Amount");
                return true;
            }
            else
                MainErrorProvider.SetError(txtNomineeAmount1, null);
            return false;
        }

        private void lnkCancel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearNominee2();
        }

        private void ClearNominee1()
        {
 	        txtNomiName1.Text="";
            txtNomineeAddress1.Text="";
            txtNomineeAge1.Text="";
            txtNomineeAmount1.Text="0";
            txtNomineeRelation1.Text="";
            imgNomineePhoto1.Image = null;
            imgNomineeSign1.Image = null;
        }

        private void ClearNominee2()
        {
 	        txtNomiName2.Text="";
            txtNomineeAddress2.Text="";
            txtNomineeAge2.Text="";
            txtNomineeAmount2.Text="0";
            txtNomineeRelation2.Text="";
            imgNomineePhoto2.Image = null;
            imgNomineeSign2.Image = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cmbPolicy.EditValue = null;
            ClearNominee1();
            ClearNominee2();
            ClearMember();
            cmbPolicy.Focus();
        }

        private void ClearMember()
        {
            txtFatherHusbandName.Text = "";
            txtFullName.Text = "";
            txtTelephone.Text = "";
            imgPhoto.Image = null;
        }
    }
}