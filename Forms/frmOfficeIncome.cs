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
    public partial class frmOfficeIncome :BaseEditViewForm
    {
        PaymentDataset dsExpenses; 
        
        public frmOfficeIncome()
        {
            InitializeComponent();
            dtpReceiptDate.DateTime = DateTime.Today;
            dsExpenses = new PaymentDataset();
            InitializaDataset();
        }

        private void InitializaDataset()
        {
            dsExpenses.ExpensesReason.Clear();
            dsExpenses.ExpensesReason.Merge(DataHelper.GetTableData(dsExpenses.ExpensesReason).Tables[0]);
            LoadDatainCmb(cmbExpensesReason, (DataTable)dsExpenses.ExpensesReason, "Reason");
        }
        
        private void LoadDatainCmb(ComboBoxEdit cmbExpensesReason, DataTable dataTable, string p)
        {
            cmbExpensesReason.Properties.Items.Clear();
            foreach (DataRow var in dataTable.Rows)
            {
                cmbExpensesReason.Properties.Items.Add(var[p].ToString());
            }
        }
        
        private void txtAmount_Validated(object sender, EventArgs e)
        {
            try
            {
                double d = double.Parse(txtAmount.Text);
                MainErrorProvider.SetError(txtAmount, null);
            }
            catch (Exception ex)
            {
                MainErrorProvider.SetError(txtAmount, "Imput Valid Amount");
                txtAmount.Focus();
            }
        }
        
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (ErrorFound())
                return;
            
            DataRow drCash = dsExpenses.CashBook.NewRow();
            drCash["IID"] = Guid.NewGuid();
            drCash["ReceiptVoucher"] = txtReceiptNo.Text;
            drCash["Deposit"] = txtAmount.Text;
            drCash["TrDate"] = dtpReceiptDate.DateTime.ToShortDateString();
            drCash["Description"] = MakeDescription();
            dsExpenses.CashBook.Rows.Add(drCash);
            DataHelper.UpdateData(dsExpenses.CashBook);

            DataRow drExp = dsExpenses.ExpensesReason.Rows.Find(cmbExpensesReason.Text.ToLower());
            if (drExp == null)
            {
                DataRow dre = dsExpenses.ExpensesReason.NewRow();
                dre["Reason"] = cmbExpensesReason.Text;
                dsExpenses.ExpensesReason.Rows.Add(dre);
                DataHelper.UpdateData(dsExpenses.ExpensesReason);
            }
            MessageBox.Show("Transaction Saved Successfully", "Office Expense", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearallText();
        }
        
        private string MakeDescription()
        {
            string st = "";
            st += "From " + txtPaidTo.Text + " for " + cmbExpensesReason.Text + " ref# " + txtReference.Text;
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
                MainErrorProvider.SetError(txtAmount,null);

            return false;
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearallText();
        }

        private void ClearallText()
        {
            txtAmount.Text = "0";
            txtPaidTo.Text = "";
            txtReceiptNo.Text = "";
            txtReference.Text = "";
            dtpReceiptDate.DateTime = DateTime.Now;
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
                txtPaidTo.Focus();
        }

        private void txtPaidTo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cmbExpensesReason.Focus();
        }

        private void cmbExpensesReason_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtReference.Focus();
        }

        private void txtReference_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtAmount.Focus();
        }

        private void txtAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnWithdraw.Focus();
        }

    }
}