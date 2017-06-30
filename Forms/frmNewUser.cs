using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MicroCredit.BaseControl;

namespace MicroCredit.Forms
{
    public partial class frmNewUser : BaseEditViewForm
    {
        
        public frmNewUser()
        {
            InitializeComponent();
            dsUser = new UserCompanyDataset();
            InitializaDataset();
            LockAllText(true);
        }
        UserCompanyDataset dsUser;
        bool _isNew = false;
        bool _isUpdate = false;
        string _EditID = "";
        string _DeleteID = "";
        
        private void InitializaDataset()
        {
            dsUser.LoginUser.Clear();
            if (Global.UserType == 2)
            {
                nbiNew.Enabled = false;
                nbiDelete.Enabled = false;
                dsUser.LoginUser.Merge(DataHelper.GetTableData(dsUser.LoginUser, " Where IID = '" + Global.UserID + "'").Tables[0]);
            }
            else
            {
                nbiNew.Enabled = true;
                nbiDelete.Enabled = true;
                dsUser.LoginUser.Merge(DataHelper.GetTableData(dsUser.LoginUser).Tables[0]);
            }
            dgUser.DataSource = dsUser.LoginUser;
        }

        private void nbiClose_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.Dispose();
        }

        private void nbiRefresh_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            MakeRefresh();
        }

        private void MakeRefresh()
        {
            InitializaDataset();
        }

        private void nbiEdit_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue(colIID) == null)
                return;
            if (Global.UserType == 2)
            {
                txtUserID.Properties.ReadOnly = true;
                txtUserName.Properties.ReadOnly = true;
                txtpassword.Properties.ReadOnly = false;
                txtCPassword.Properties.ReadOnly = false;
                cmbUserType.Enabled = false;
                cmbUserType.SelectedIndex = 1;
            }
            else
            {
                cmbUserType.Enabled = true;
                cmbUserType.SelectedIndex = 0;
                LockAllText(false);
            }
            _EditID = gridView1.GetFocusedRowCellValue(colIID).ToString();
            txtpassword.Text = gridView1.GetFocusedRowCellValue(colPassword).ToString();
            txtCPassword.Text = gridView1.GetFocusedRowCellValue(colPassword).ToString();
            _isUpdate = true;
            _isNew = false;
            btnApply.Enabled = true;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (ErrorFound())
                return;
            if (_isUpdate)
            {
                if (MessageBox.Show("Do you want to update user information", "User Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;   
                DataRow dr = dsUser.LoginUser.Rows.Find(_EditID);
                dr["UserName"] = txtUserID.Text.ToLower();
                dr["FullName"] = txtUserName.Text;
                dr["Password"] = txtpassword.Text;
                dr["Type"] = cmbUserType.SelectedIndex + 1;
                DataHelper.UpdateData(dsUser.LoginUser);
                btnApply.Enabled = false;
                LockAllText(true);
            }
            else if (_isNew)
            {

                DataRow[] dr1 = dsUser.LoginUser.Select("UserName = '" + txtUserID.Text.ToLower() + "'");
                if (dr1.Length > 0)
                {
                    MainErrorProvider.SetError(txtUserID, "Login ID already Used");
                    return;
                }
                else
                    MainErrorProvider.SetError(txtUserID, null);

                DataRow dr = dsUser.LoginUser.NewRow();
                dr["IID"] = Guid.NewGuid();
                dr["UserName"] = txtUserID.Text.ToLower();
                dr["FullName"] = txtUserName.Text;
                dr["Password"] = txtpassword.Text;
                dr["Type"] = cmbUserType.SelectedIndex + 1;
                dsUser.LoginUser.Rows.Add(dr);
                DataHelper.UpdateData(dsUser.LoginUser);
            }

        }

        private void LockAllText(bool p)
        {
            txtUserID.Properties.ReadOnly = p;
            txtUserName.Properties.ReadOnly = p;
            txtCPassword.Properties.ReadOnly = p;
            txtpassword.Properties.ReadOnly = p;
            cmbUserType.Enabled = !p;
            btnApply.Enabled = !p;
        }


        private bool ErrorFound()
        {
            if(string.IsNullOrEmpty(txtUserID.Text))
            {
                MainErrorProvider.SetError(txtUserID,"Input Login ID");
                return true;
            }
            else
                MainErrorProvider.SetError(txtUserID,null);

            
            if (txtpassword.Text != txtCPassword.Text)
            {
                MainErrorProvider.SetError(txtCPassword, "Password mismatch");
                MainErrorProvider.SetError(txtpassword, "Password mismatch");
                return true;
            }
            else
            {
                MainErrorProvider.SetError(txtCPassword,null);
                MainErrorProvider.SetError(txtpassword, null);
            }
            if (cmbUserType.SelectedIndex == -1)
            {
                MainErrorProvider.SetError(cmbUserType, "Select User Type");
                return true;
            }
            else
                MainErrorProvider.SetError(cmbUserType, null);
            return false;
        }

        private void nbiNew_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            _isNew = true;
            _isUpdate = false;
            btnApply.Enabled = true;
            LockAllText(false);
            ClearallText();
            txtUserID.Focus();
        }

        private void ClearallText()
        {
            txtUserID.Text = "";
            txtUserName.Text = "";
            txtpassword.Text = "";
            txtCPassword.Text = "";
            cmbUserType.SelectedIndex = -1;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue(colIID) != null)
                FillRow();
        }

        private void FillRow()
        {
            txtUserID.Text = gridView1.GetFocusedRowCellValue(colUserName).ToString();
            txtUserName.Text = gridView1.GetFocusedRowCellValue(colFullName).ToString();
            txtpassword.Text = "";
            txtCPassword.Text = "";
            cmbUserType.SelectedIndex = int.Parse(gridView1.GetFocusedRowCellValue(colType).ToString()) - 1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LockAllText(true);
            MainErrorProvider.SetError(txtCPassword, null);
            MainErrorProvider.SetError(txtpassword, null);
            MainErrorProvider.SetError(txtUserName, null);
            MainErrorProvider.SetError(txtUserID, null);
            MainErrorProvider.SetError(cmbUserType, null);
            gridView1.Focus();
        }

        private void nbiDelete_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue(colIID) == null)
                return;
            _DeleteID = gridView1.GetFocusedRowCellValue(colIID).ToString();
            if (MessageBox.Show("Do you want to delete this User ?", "User Delete Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            dsUser.LoginUser.Rows.Find(_DeleteID).Delete();
            try
            {
                DataHelper.UpdateData(dsUser.LoginUser);
            }
            catch (Exception ex)
            {
                MessageBox.Show("This user contains enough transactions... this can't be delete","unable to delete",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        }
    }
}