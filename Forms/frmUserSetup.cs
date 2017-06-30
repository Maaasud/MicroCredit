using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace MicroCredit.Forms
{
    public partial class frmUserSetup : DevExpress.XtraEditors.XtraForm
    {
        public frmUserSetup()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ErrorFound())
                return;
            UserCompanyDataset dsUser = new UserCompanyDataset();
            DataRow dr = dsUser.LoginUser.NewRow();
            dr["IID"] = Guid.NewGuid();
            dr["UserName"] = txtUserID.Text.ToLower();
            dr["Password"] = txtpassword.Text;
            dr["FullName"] = txtUserName.Text;
            dr["Type"] = 1;
            dsUser.LoginUser.Rows.Add(dr);
            DataHelper.UpdateData(dsUser.LoginUser);
            this.Dispose();
        }

        private bool ErrorFound()
        {
            if (string.IsNullOrEmpty(txtUserID.Text))
            {
                MainErrorProvider.SetError(txtUserID, "Input Login ID");
                return true;
            }
            else
                MainErrorProvider.SetError(txtUserID, null);

            if (txtpassword.Text != txtCPassword.Text)
            {
                MainErrorProvider.SetError(txtCPassword, "Password Mismatch");
                MainErrorProvider.SetError(txtpassword, "Password Mismatch");
                return true;
            }
            else
            {
                MainErrorProvider.SetError(txtCPassword, null);
                MainErrorProvider.SetError(txtpassword, null);
            }
            return false;
        }

        private void txtUserID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtpassword.Focus();
        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtCPassword.Focus();
        }

        private void txtCPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtUserName.Focus();
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSave.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit without creating User ?", "User Creation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                this.Dispose();
        }
    }
}