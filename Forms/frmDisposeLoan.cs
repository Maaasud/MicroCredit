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
    public partial class frmDisposeLoan : BaseEditViewForm
    {
        public frmDisposeLoan()
        {
            InitializeComponent();
            InitializeDatase();
        }

        private void InitializeDatase()
        {
            
        }

        private void cmbLoanNumber_EditValueChanged(object sender, EventArgs e)
        {
            FillPolicyInformation();
        }

        private void FillPolicyInformation()
        {
            if (cmbLoanNumber.EditValue == null)
            {
                clearAllText();
                return;
            }

        }

        private void clearAllText()
        {
            
        }

        private void cmbLoanNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                FillPolicyInformation();
            }
        }
    }
}