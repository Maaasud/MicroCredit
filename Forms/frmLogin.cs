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
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        private bool _loginSuccess;

        public bool LoginSuccess
        {
            get { return _loginSuccess; }
            set { _loginSuccess = value; }
        }
	
        private bool _isExit;

        public bool isExit
        {
            get { return _isExit; }
            set { _isExit = value; }
        }
	    
        public frmLogin()
        {
            InitializeComponent();
            _isExit = false;
            _loginSuccess = false;
        }
        public event EventHandler LoginStatus;
        private void txtLoginID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPassword.Focus();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                CheckForLogin();
        }

        private void CheckForLogin()
        {
            DataTable dtUser = DataHelper.GetTableData("LoginUser"," Where UserName ='"+txtLoginID.Text.ToLower()+"' AND Password = '"+txtPassword.Text+"'").Tables[0];
            if (dtUser.Rows.Count > 0)
            {
                Global.UserID = dtUser.Rows[0]["IID"].ToString();
                Global.UserName = dtUser.Rows[0]["FullName"].ToString();
                Global.UserType = int.Parse(dtUser.Rows[0]["Type"].ToString());
                _loginSuccess = true;
                this.Dispose();
            }
            else
                MessageBox.Show("Invalid User ID or Password", "ProfessionBD MicroCredit", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void brnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Exit ?", "Exit to Windows", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                isExit = true;
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CheckForLogin();
        }

        private void frmLogin_Shown(object sender, EventArgs e)
        {
            for (double i = 0.01; i < 0.8; i += .01)
            {
                this.Opacity = i;
            }
            this.Opacity = 0.85;
        }
    }
}