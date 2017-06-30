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
    public partial class frmDisposePolicy : BaseEditViewForm
    {
        MemberDataset dsMembers;
        ReceiptDataset dsDeposite;
        DisposeDataset dsDespose;

        public frmDisposePolicy()
        {
            InitializeComponent();
            dsMembers = new MemberDataset();
            dsDeposite = new ReceiptDataset();
            dsDespose = new DisposeDataset();
            
            InitializeDatset();
        }

        private void InitializeDatset()
        {
            
            dsMembers.MembersPolicyLookup.Clear();
            dsMembers.MembersPolicyLookup.Merge(DataHelper.GetTableData(dsMembers.MembersPolicyLookup).Tables[0]);
            cmbPolicy.Properties.DataSource = dsMembers.MembersPolicyLookup.Copy();
        }

        private void cmbPolicy_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbPolicy.EditValue != null)
            {
                frmLoading _loading = new frmLoading();
                _loading.Show();
                dsMembers.Members.Clear();
                dsMembers.Members.Merge(DataHelper.GetTableData(dsMembers.Members, " Where IID = '" + cmbPolicy.GetColumnValue("MemberID").ToString() + "'").Tables[0]);
                DataRow dr = dsMembers.Members.Rows[0];
                // MemberID = dr["IID"].ToString();
                txtFatherHusbandName.Text = dr["FatherHusbandName"].ToString();
                txtFullName.Text = dr["FullName"].ToString();
                txtLAddress.Text = dr["LLocation"].ToString();
                txtLDistrict.Text = dr["LDistrict"].ToString();
                txtLpostCode.Text = dr["LPostCode"].ToString();
                txtLPostOffice.Text = dr["LPostOffice"].ToString();
                txtLThana.Text = dr["LThana"].ToString();
                txtLVillage.Text = dr["LVillage"].ToString();
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
                dsMembers.Policy.Clear();
                dsMembers.Policy.Merge(DataHelper.GetTableData(dsMembers.Policy, " WHERE IID = '" + cmbPolicy.EditValue.ToString() + "'").Tables[0]);
                dtpEnlistedDate.DateTime = (DateTime)dsMembers.Policy.Rows[0]["EnlistedDate"];
                txtDepositRatio.Text = dsMembers.Policy.Rows[0]["SavingRatio"].ToString();
                
                DataTable dt = DataHelper.GetData("SELECT COUNT(*) AS TotalDeposite FROM dbo.DepositDetails Where MasterID = '"+cmbPolicy.EditValue.ToString()+"' AND Description = 'Deposit'").Tables[0];
                double TInstall = double.Parse( dt.Rows[0][0].ToString());

                dt = DataHelper.GetData("SELECT COUNT(*) AS TotalDeposite FROM dbo.DepositDetails Where MasterID = '"+cmbPolicy.EditValue.ToString()+"' AND Description = 'Withdraw'").Tables[0];
                double TWithdraw = double.Parse( dt.Rows[0][0].ToString());

                dt = DataHelper.GetData("SELECT  ISNULL(SUM(DepositProfit), 0) AS TotalDeposit, ISNULL(SUM(Withdrawal), 0) AS TotalWithdraw FROM dbo.DepositDetails Where MasterID = '" + cmbPolicy.EditValue.ToString() + "'").Tables[0];
                double TInAmount = double.Parse(dt.Rows[0]["TotalDeposit"].ToString());
                double TWthAmount = double.Parse(dt.Rows[0]["TotalWithdraw"].ToString());

                txtTotalInstall.Text = TInstall.ToString();
                txtTotalWithdraw.Text = TWithdraw.ToString();
                txtTotalDepositAmount.Text = TInAmount.ToString();
                txtTotalWithdrawAmount.Text = TWthAmount.ToString();

                txtNetDepositAmount.Text = (TInAmount - TWthAmount).ToString();
                txtNetDepositAmount2.Text = txtNetDepositAmount.Text;
                txtAvgInstall.Text = ((TInAmount - TWthAmount) / double.Parse(txtDepositRatio.Text)).ToString();
                _loading.Dispose();
                LoanDataset dsLoan = new LoanDataset();
                dsLoan.LoanStatus.Clear();
                dsLoan.LoanStatus.Merge(DataHelper.GetTableData(dsLoan.LoanStatus, " Where PolicyID = '" + cmbPolicy.EditValue.ToString() + "' AND Status = 'true'").Tables[0]);
                if (!(bool)dsMembers.Policy.Rows[0]["Status"])
                {
                    MessageBox.Show("This is a closed policy...", "Disposed Policy", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btnSave.Enabled = false;
                    return;
                }
                
                if (dsLoan.LoanStatus.Rows.Count > 0)
                {
                    MessageBox.Show("This Policy is Continuing a loan... You can not despose this policy...", "Loan Exist", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btnSave.Enabled = false;
                    return;
                }
                btnSave.Enabled = true;
            }
        }

        private void txtPercent_Leave(object sender, EventArgs e)
        {
            txtPercentAmount.Text = (double.Parse(txtNetDepositAmount2.Text) * double.Parse(txtPercent.Text) / 100).ToString();
        }

        private void txtServiceCharge_Validated(object sender, EventArgs e)
        {
            try
            {
                double d = double.Parse(((TextEdit)sender).Text);
                MainErrorProvider.SetError((TextEdit)sender, null);
            }
            catch (Exception ex)
            {
                MainErrorProvider.SetError((TextEdit)sender, "Input Valid Amount");
                ((TextEdit)sender).Focus();
            }
        }

        private void txtPercentAmount_Leave(object sender, EventArgs e)
        {
            if (rdoDeduct.Checked)
            {
                txtNetPayable.Text = (double.Parse(txtNetDepositAmount2.Text) - double.Parse(txtPercentAmount.Text) -double.Parse(txtServiceCharge.Text)).ToString();
            }
            else
                txtNetPayable.Text = (double.Parse(txtNetDepositAmount2.Text) + double.Parse(txtPercentAmount.Text)-double.Parse(txtServiceCharge.Text)).ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ErrorFound())
                return;
            if (MessageBox.Show("Do you want to close the policy ?", "Confirm Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            dsMembers.Policy.Clear();
            dsMembers.Policy.Merge(DataHelper.GetTableData(dsMembers.Policy, "Where IID = '" + cmbPolicy.EditValue.ToString() + "'").Tables[0]);
            if ((bool)dsMembers.Policy.Rows[0]["Status"] == false)
            {
                MessageBox.Show("This policy is already closed");
                return;
            }
            dsMembers.Policy.Rows[0]["Status"] = false;
            DataHelper.UpdateData(dsMembers.Policy);  

            dsDespose.PolicyClose.Clear();
            DataRow dr = dsDespose.PolicyClose.NewRow();
            dr["IID"] = Guid.NewGuid();
            dr["PolicyID"] = cmbPolicy.EditValue.ToString();
            dr["TotalDeposit"] = txtTotalDepositAmount.Text;
            dr["TotalWithdraw"] = txtTotalWithdrawAmount.Text;
            if (rdoDeduct.Checked)
                dr["Deduct"] = txtPercentAmount.Text;
            else
                dr["Interest"] = txtPercentAmount.Text;
            dr["ClosingDate"] = dtpClosingDate.DateTime.ToShortDateString();
            dsDespose.PolicyClose.Rows.Add(dr);
            DataHelper.UpdateData(dsDespose.PolicyClose);

            if (double.Parse(txtServiceCharge.Text) != 0)
            {
                DataRow drOI = dsDeposite.OfficeIncome.NewRow();
                drOI["IID"] = Guid.NewGuid();
                drOI["IncomeDate"] = dtpClosingDate.DateTime.ToShortDateString();
                drOI["ReceiptNo"] = txtVoucher.Text;
                drOI["Others"] = txtServiceCharge.Text;
                drOI["Reason"] = "Service Charge";
                dsDeposite.OfficeIncome.Rows.Add(drOI);
                DataHelper.UpdateData(dsDeposite.OfficeIncome);
            }
            DataRow drCash = dsDeposite.CashBook.NewRow();
            drCash["IID"] = Guid.NewGuid();
            drCash["ReceiptVoucher"] = txtVoucher.Text;
            if (double.Parse(txtServiceCharge.Text) != 0)
                drCash["Deposit"] = txtServiceCharge.Text;
            
            
        }

        private bool ErrorFound()
        {
            if (cmbPolicy.EditValue == null)
            {
                MainErrorProvider.SetError(cmbPolicy,"Select policy Number");
                return true;
            }
            else
                MainErrorProvider.SetError(cmbPolicy, null);

            if(string.IsNullOrEmpty(txtVoucher.Text))
            {
                MainErrorProvider.SetError(txtVoucher,"Enter Voucher#");
                return true;
            }
            else
                MainErrorProvider.SetError(txtVoucher,null);
            if (dtpClosingDate.DateTime.Year == 1 || dtpClosingDate.DateTime.Year == 9999)
            {
                MainErrorProvider.SetError(dtpClosingDate, "Select Closing Date");
                return true;
            }
            else
                MainErrorProvider.SetError(dtpClosingDate, null);
            return false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAllText();
        }

        private void ClearAllText()
        {
            txtAvgInstall.Text = "";
            txtDepositRatio.Text = "";
            txtFatherHusbandName.Text = "";
            txtFullName.Text = "";
            txtLAddress.Text = "";
            txtLDistrict.Text = "";
            txtLpostCode.Text = "";
            txtLPostOffice.Text = "";
            txtLThana.Text = "";
            txtLVillage.Text = "";
            txtNetDepositAmount.Text = "0";
            txtNetDepositAmount2.Text = "0";
            txtNetPayable.Text = "0";
            txtPercent.Text = "0";
            txtPercentAmount.Text = "0";
            txtServiceCharge.Text = "0";
            txtTotalDepositAmount.Text = "";
            txtTotalInstall.Text = "";
            txtTotalWithdraw.Text = "";
            txtTotalWithdrawAmount.Text = "";
            cmbPolicy.EditValue = null;
            imgPhoto.Image = null;
        }

        private void imgPhoto_DoubleClick(object sender, EventArgs e)
        {
            new ShowImagefrm(((System.Windows.Forms.PictureBox)(sender)).Image).ShowDialog(this);
        }

        private void rdoInterest_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDeduct.Checked)
            {
                txtNetPayable.Text = (double.Parse(txtNetDepositAmount2.Text) - double.Parse(txtPercentAmount.Text) - double.Parse(txtServiceCharge.Text)).ToString();
            }
            else
                txtNetPayable.Text = (double.Parse(txtNetDepositAmount2.Text) + double.Parse(txtPercentAmount.Text) - double.Parse(txtServiceCharge.Text)).ToString();
        }
    }
}