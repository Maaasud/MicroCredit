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
    public partial class frmCashDisbursement : BaseEditViewForm
    {
        PaymentDataset dsPayment;
        MemberDataset dsMember;
        public frmCashDisbursement()
        {
            InitializeComponent();
            dtpReceiptDate.DateTime = DateTime.Today;
            InitializaDataset();
        }

        private void InitializaDataset()
        {
            dsPayment = new PaymentDataset();
            dsMember = new MemberDataset();
            dtpReceiptDate.DateTime = DateTime.Now;

            dsMember.MembersPolicyLookup.Clear();
            dsMember.MembersPolicyLookup.Merge(DataHelper.GetTableData(dsMember.MembersPolicyLookup).Tables[0]);
            cmbPolicy.Properties.DataSource = dsMember.MembersPolicyLookup.Copy();
        }

        private void txtArea_Leave(object sender, EventArgs e)
        {
            txtArea.Text = txtArea.Text.ToUpper();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (ErrorFound())
                return;
            double reqAmount = double.Parse(txtAmount.Text);

            if (double.Parse(dsPayment.TotalAmountPolicyLookup.Rows[0]["TotalAmount"].ToString()) < reqAmount + 100)
            {
                MessageBox.Show("This policy does not contain enough money to withdraw", "Insufficient Balance", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataRow dr = dsPayment.DepositDetails.NewRow();
            dr["IID"] = Guid.NewGuid();
            dr["MasterID"] = cmbPolicy.EditValue;
            dr["Dateof"] = dtpReceiptDate.DateTime.ToShortDateString();
            if(string.IsNullOrEmpty(txtDescription.Text))
                dr["Description"] = "Withdraw";
            else
                dr["Description"] = txtDescription.Text;
            dr["ReceiptNo"] = txtReceiptNo.Text;
            dr["Withdrawal"] = txtAmount.Text;
            dsPayment.DepositDetails.Rows.Add(dr);
            DataHelper.UpdateData(dsPayment.DepositDetails);

            DataRow drCash = dsPayment.CashBook.NewRow();
            drCash["IID"] = Guid.NewGuid();
            drCash["ReceiptVoucher"] = txtReceiptNo.Text;
            drCash["Withdraw"] = txtAmount.Text;
            drCash["TrDate"] = dtpReceiptDate.DateTime.ToShortDateString();
            drCash["Description"] = "Withdraw by Policy# " + cmbPolicy.Text + " (" + txtMemberName.Text + ") Area# "+txtArea.Text ;
            dsPayment.CashBook.Rows.Add(drCash);
            DataHelper.UpdateData(dsPayment.CashBook);

            MessageBox.Show("Saved Successfully");
            clearAllText();
        }

        private bool ErrorFound()
        {
            if (string.IsNullOrEmpty(txtReceiptNo.Text))
            {
                MainErrorProvider.SetError(txtReceiptNo, "Input Voucher Number");
                return true;
            }
            else
                MainErrorProvider.SetError(txtReceiptNo, null);

            if (cmbPolicy.EditValue == null)
            {
                MainErrorProvider.SetError(cmbPolicy, "Select policy number");
                return true;
            }
            else
                MainErrorProvider.SetError(cmbPolicy, null);
            if (string.IsNullOrEmpty(txtAmount.Text))
            {
                MainErrorProvider.SetError(txtAmount, "Input Valid Amount");
                return true;
            }
            else
                MainErrorProvider.SetError(txtAmount, null);

            return false;
        }

        private void cmbPolicy_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbPolicy.EditValue == null)
            {
                txtMemberName.Text = "";
                return;
            }
            txtMemberName.Text = cmbPolicy.GetColumnValue("FullName").ToString();
            dsPayment.TotalAmountPolicyLookup.Clear();
            dsPayment.TotalAmountPolicyLookup.Merge(DataHelper.GetTableData(dsPayment.TotalAmountPolicyLookup, " Where MasterID = '" + cmbPolicy.EditValue.ToString() + "'").Tables[0]);
            if (dsPayment.TotalAmountPolicyLookup.Rows.Count == 0)
            {
                MessageBox.Show("There is no transaction against this policy... No Amount can withdraw from this policy");
                cmbPolicy.EditValue = null;
            }
           
        }

        private void txtAmount_Validated(object sender, EventArgs e)
        {
            try
            {
                double d = double.Parse(txtAmount.Text);
                MainErrorProvider.SetError(txtAmount, null);
            }
            catch (Exception cx)
            {
                MainErrorProvider.SetError(txtAmount, "Input Valid Amount");
                txtAmount.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearAllText();
        }

        private void clearAllText()
        {
            txtAmount.Text = "0";
            txtArea.Text = "";
            txtDescription.Text = "";
            txtMemberName.Text = "";
            txtReceiptNo.Text = "";
            cmbPolicy.EditValue = null;
            txtReceiptNo.Focus();
        }

        private void txtReceiptNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                dtpReceiptDate.Focus();
        }

        private void dtpReceiptDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cmbPolicy.Focus();
        }

        private void cmbPolicy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtArea.Focus();
        }

        private void txtArea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtDescription.Focus();
        }

        private void txtAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnWithdraw.Focus();
        }
    }
}