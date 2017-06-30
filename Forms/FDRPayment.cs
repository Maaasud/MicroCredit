using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MicroCredit.BaseControl;
using MicroCredit.DataSets;

namespace MicroCredit.Forms
{
    public partial class frmFDRPayment : BaseEditViewForm
    {
        PaymentDataset dsExpenses; 
        public frmFDRPayment()
        {
            InitializeComponent();
            dtpReceiptDate.DateTime = DateTime.Today;
            dsExpenses = new PaymentDataset();
            InitializaDataset();
        }
        private void InitializaDataset()
        {
            dsExpenses.FDRMemberLookup.Clear();
            dsExpenses.FDRMemberLookup.Merge(DataHelper.GetTableData(dsExpenses.FDRMemberLookup).Tables[0]);
            cmbFDRMember.Properties.DataSource = dsExpenses.FDRMemberLookup;
        }

        private void cmbFDRMember_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbFDRMember.EditValue != null)
            {
                txtPaidTo.Text = cmbFDRMember.GetColumnValue("FullName").ToString();
                txtAmount.Text = cmbFDRMember.GetColumnValue("MonthlyProfitAmount").ToString();
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (ErrorFound())
                return;
            DataRow drCash = dsExpenses.CashBook.NewRow();
            drCash["IID"] = Guid.NewGuid();
            drCash["ReceiptVoucher"] = txtReceiptNo.Text;
            drCash["Withdraw"] = txtAmount.Text;
            drCash["TrDate"] = dtpReceiptDate.DateTime.ToShortDateString();
            drCash["FDRID"] = cmbFDRMember.EditValue.ToString();
            drCash["Description"] = MakeDescription();
            dsExpenses.CashBook.Rows.Add(drCash);
            DataHelper.UpdateData(dsExpenses.CashBook);

            MessageBox.Show("Transaction Saved Successfully", "FDR Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearAllText();
        }

        private string MakeDescription()
        {
            string st = "";
            st += "To " + txtPaidTo.Text + " for FDR No# " + cmbFDRMember.GetColumnValue("FDRNumber").ToString() + " ref# " + txtReceiptNo.Text;
            return st;
        }

        private bool ErrorFound()
        {
            if (string.IsNullOrEmpty(txtReceiptNo.Text))
            {
                MainErrorProvider.SetError(txtReceiptNo, "Input Voucher number");
                return true;
            }
            else
                MainErrorProvider.SetError(txtReceiptNo, null);
            if (cmbFDRMember.EditValue == null)
            {
                MainErrorProvider.SetError(cmbFDRMember, "Select FRD");
                return true;
            }
            else
                MainErrorProvider.SetError(cmbFDRMember, null);

            if (string.IsNullOrEmpty(txtPaidTo.Text))
            {
                MainErrorProvider.SetError(txtPaidTo, "Input Paid to Information");
                return true;
            }
            else
                MainErrorProvider.SetError(txtPaidTo, null);
            if (double.Parse(txtAmount.Text) == 0)
            {
                MainErrorProvider.SetError(txtAmount, "Input valid Amount");
                return true;
            }
            else
                MainErrorProvider.SetError(txtAmount, null);

            return false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearAllText();
        }

        private void clearAllText()
        {
            txtPaidTo.Text = "";
            txtReceiptNo.Text = "";
            txtReference.Text = "";
            txtAmount.Text = "";
            cmbFDRMember.EditValue = null;
            txtReceiptNo.Focus();
        }
    }
}
