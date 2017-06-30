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
    public partial class frmNewLoan : BaseEditorForm
    {
        MemberDataset dsMembers;
        LoanDataset dsLoan;
        public frmNewLoan()
        {
            InitializeComponent();
            InitializeDataset();
        }

        private void InitializeDataset()
        {
            dsMembers = new MemberDataset();
            dsLoan = new LoanDataset();
            dsMembers.MembersPolicyLookup.Clear();
            dsMembers.MembersPolicyLookup.Merge(DataHelper.GetTableData(dsMembers.MembersPolicyLookup).Tables[0]);
            cmbPolicy.Properties.DataSource = dsMembers.MembersPolicyLookup.Copy();
            cmbPolicyGranter1.Properties.DataSource = dsMembers.MembersPolicyLookup.Copy();
            cmbPolicyGranter2.Properties.DataSource = dsMembers.MembersPolicyLookup.Copy();
            dtpApproveDate.DateTime = DateTime.Now;
        }
        string MemberID = "";
        private void cmbPolicy_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbPolicy.EditValue == null)
                return;
            dsLoan.LoanStatus.Clear();
            dsLoan.LoanStatus.Merge(DataHelper.GetTableData(dsLoan.LoanStatus, " Where PolicyID = '" + cmbPolicy.EditValue.ToString() + "' AND Status = 'true'").Tables[0]);
            if (dsLoan.LoanStatus.Rows.Count > 0)
            {
                MessageBox.Show("This Policy is Continuing a loan... No loan can be approved now...", "Multiple Loan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbPolicy.EditValue = null;
                return;
            }
            dsMembers.Members.Clear();
            dsMembers.Members.Merge(DataHelper.GetTableData(dsMembers.Members, " Where IID = '" + cmbPolicy.GetColumnValue("MemberID").ToString() + "'").Tables[0]);
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
        }
        string GranterID1 = "";
        private void cmbPolicyGranter1_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbPolicyGranter1.EditValue == null)
                return;
            if (cmbPolicyGranter1.GetColumnValue("MemberID").ToString() == MemberID)
            {
                MessageBox.Show("Loan Applicant can not a granter", "Invalid Granter", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            dsMembers.Members.Clear();
            dsMembers.Members.Merge(DataHelper.GetTableData(dsMembers.Members, " Where IID = '" + cmbPolicyGranter1.GetColumnValue("MemberID").ToString() + "'").Tables[0]);
            DataRow dr = dsMembers.Members.Rows[0];
            GranterID1 = dr["IID"].ToString();
            txtGrtName1.Text = dr["FullName"].ToString();
            txtGrtFatherHusband1.Text = dr["FatherHusbandName"].ToString();
            txtGrtLAddress1.Text = dr["LLocation"].ToString();
            txtGrtDistrict1.Text = dr["LDistrict"].ToString();
            txtGrtPostCode1.Text = dr["LPostCode"].ToString();
            txtGrtPostOffice1.Text = dr["LPostOffice"].ToString();
            txtGrtThana1.Text = dr["LThana"].ToString();
            txtGrtVillage1.Text = dr["LVillage"].ToString();
        }
        String GranterID2 = "";
        private void cmbPolicyGranter2_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbPolicyGranter2.EditValue == null)
                return;
            if (cmbPolicyGranter2.GetColumnValue("MemberID").ToString() == MemberID)
            {
                MessageBox.Show("Loan Applicant can not a granter", "Invalid Granter", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //cmbPolicyGranter2.EditValue = null;
                cmbPolicyGranter2.Text = "[Select Granter Policy]";
                return;
            }
            dsMembers.Members.Clear();
            dsMembers.Members.Merge(DataHelper.GetTableData(dsMembers.Members, " Where IID = '" + cmbPolicyGranter2.GetColumnValue("MemberID").ToString() + "'").Tables[0]);
            DataRow dr = dsMembers.Members.Rows[0];
            GranterID2 = dr["IID"].ToString();
            txtGrtName2.Text = dr["FullName"].ToString();
            txtGrtFatherHusband2.Text = dr["FatherHusbandName"].ToString();
            txtGrtLAddress2.Text = dr["LLocation"].ToString();
            txtGrtDistrict2.Text = dr["LDistrict"].ToString();
            txtGrtPostCode2.Text = dr["LPostCode"].ToString();
            txtGrtPostOffice2.Text = dr["LPostOffice"].ToString();
            txtGrtThana2.Text = dr["LThana"].ToString();
            txtGrtVillage2.Text = dr["LVillage"].ToString();
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            if (ErrorFound())
                return;
            SaveLoanInformation();
        }

        private void SaveLoanInformation()
        {
            DataRow drLoan = dsLoan.Loan.NewRow();
            drLoan["IID"] = Guid.NewGuid();
            drLoan["PolicyID"] = cmbPolicy.EditValue;
            drLoan["MemberID"] = MemberID;
            drLoan["LegalDocument"] = txtLegalDocument.Text;
            drLoan["LoanDuration"] = txtLoanDuration.Text;
            drLoan["LoanAmount"] = txtLoanAmount.Text;
            drLoan["LoanPurpose"] = txtLoanPurpose.Text;
            drLoan["GranterID1"] = cmbPolicyGranter1.EditValue;
            drLoan["GranterMemberID1"] = GranterID1;
            if (cmbPolicyGranter2.EditValue != null)
            {
                drLoan["GranterID2"] = cmbPolicyGranter2.EditValue;
                drLoan["GranterMemberID2"] = GranterID2;
            }
            drLoan["LoanNumber"] = txtLoanNumber.Text;
            drLoan["VoucherNumber"] = txtVoucherNumber.Text;
            drLoan["ApproveDate"] = dtpApproveDate.DateTime.ToShortDateString();
            drLoan["ApproveAmount"] = txtLoanAmountApproved.Text;
            drLoan["ApproveDuration"] = txtLoanDurationApproved.Text + " " + cmbDurationUnit.Text;
            drLoan["CapitalInstallmentPercent"] = txtCapitalperInstallment.Text;
            drLoan["InterestInstallmentPercent"] = txtInterestperInstallment.Text;
            drLoan["AmountInstallment"] = txtAmountperInstallment.Text;
            drLoan["TotalPayableAmount"] = txtTotalAmountPayable.Text;
            dsLoan.Loan.Rows.Add(drLoan);

            DataRow drStatus = dsLoan.LoanStatus.NewRow();
            drStatus["IID"] = Guid.NewGuid();
            drStatus["LoanID"] = drLoan["IID"];
            drStatus["PolicyID"] = drLoan["PolicyID"];
            drStatus["TotalLoanAmount"] = txtLoanAmountApproved.Text;
            drStatus["PerInstallmentAmount"] = txtAmountperInstallment.Text;
            drStatus["TotalAmountPaid"] = 0;
            drStatus["Status"] = true;
            dsLoan.LoanStatus.Rows.Add(drStatus);
            DataHelper.UpdateData(dsLoan.Loan);
            DataHelper.UpdateData(dsLoan.LoanStatus);

            DataRow drCash = dsLoan.CashBook.NewRow();
            drCash["IID"] = Guid.NewGuid();
            drCash["ReceiptVoucher"] = txtVoucherNumber.Text;
            drCash["Withdraw"] = txtLoanAmountApproved.Text;
            drCash["TrDate"] = dtpApproveDate.DateTime.ToShortDateString();
            drCash["Description"] = "Loan to# " + cmbPolicy.Text + " (" + txtFullName.Text + ") Form # " + txtFormNumber.Text;
            dsLoan.CashBook.Rows.Add(drCash);
            DataHelper.UpdateData(dsLoan.CashBook);

            MessageBox.Show("Loan Information Saved successfully","Loan Info.",MessageBoxButtons.OK,MessageBoxIcon.Information);
            clearallText();
        }

        private void clearallText()
        {
            txtAmountperInstallment.Text = "";
            txtCapitalperInstallment.Text = "";
            txtFatherHusbandName.Text = "";
            txtFormNumber.Text = "";
            txtFullName.Text = "";
            txtGrtDistrict1.Text = "";
            txtGrtDistrict2.Text = "";
            txtGrtFatherHusband1.Text = "";
            txtGrtFatherHusband2.Text = "";
            txtGrtLAddress1.Text = "";
            txtGrtLAddress2.Text = "";
            txtGrtName1.Text = "";
            txtGrtName2.Text = "";
            txtGrtPostCode1.Text = "";
            txtGrtPostCode2.Text = "";
            txtGrtPostOffice1.Text = "";
            txtGrtPostOffice2.Text = "";
            txtGrtThana1.Text = "";
            txtGrtThana2.Text = "";
            txtGrtVillage1.Text = "";
            txtGrtVillage2.Text = "";
            txtInterestperInstallment.Text = "";
            txtLAddress.Text = "";
            txtLDistrict.Text = "";
            txtLegalDocument.Text = "";
            txtLoanAmount.Text = "";
            txtLoanAmountApproved.Text = "";
            txtLoanDuration.Text = "";
            txtLoanDurationApproved.Text = "";
            txtLoanNumber.Text = "";
            txtLoanPurpose.Text = "";
            txtLpostCode.Text = "";
            txtLPostOffice.Text = "";
            txtLThana.Text = "";
            txtLVillage.Text = "";
            txtPAddress.Text = "";
            txtPDistrict.Text = "";
            txtPPostCode.Text = "";
            txtPPostOffice.Text = "";
            txtPThana.Text = "";
            txtPVillage.Text = "";
            txtTelephone.Text = "";
            txtTotalAmountPayable.Text = "";
            txtVoucherNumber.Text = "";

            cmbPolicy.EditValue = null;
            cmbPolicyGranter1.EditValue = null;
            cmbPolicyGranter2.EditValue = null;
            imgPhoto.Image = null;
            dtpApproveDate.DateTime = DateTime.Today;
            MemberID = "";
            GranterID1 = "";
            GranterID2 = "";
            cmbPolicy.Focus();
        }

        private bool ErrorFound()
        {
            if (cmbPolicy.EditValue == null)
            {
                MainErrorProvider.SetError(cmbPolicy, "Select Loan Applicant policy");
                return true;
            }
            else
                MainErrorProvider.SetError(cmbPolicy, null);

            if (string.IsNullOrEmpty(txtFormNumber.Text))
            {
                MainErrorProvider.SetError(txtFormNumber, "Input Appliation Form number");
                return true;
            }
            else
                MainErrorProvider.SetError(txtFormNumber, null);

            if (string.IsNullOrEmpty(txtLegalDocument.Text))
            {
                MainErrorProvider.SetError(txtLegalDocument, "Input Legal document Number");
                return true;
            }
            else
                MainErrorProvider.SetError(txtLegalDocument, null);

            if (string.IsNullOrEmpty(txtLoanPurpose.Text))
            {
                MainErrorProvider.SetError(txtLoanPurpose, "Input Loan Purpose");
                return true;
            }
            else
                MainErrorProvider.SetError(txtLoanPurpose, null);

            if (cmbPolicyGranter1.EditValue == null)
            {
                MainErrorProvider.SetError(cmbPolicyGranter1, "Select Loan Granter policy");
                return true;
            }
            else
                MainErrorProvider.SetError(cmbPolicyGranter1, null);
            if (string.IsNullOrEmpty(txtLoanNumber.Text))
            {
                MainErrorProvider.SetError(txtLoanNumber, "Input Loan number");
                return true;
            }
            else
                MainErrorProvider.SetError(txtLoanNumber, null);

            if (string.IsNullOrEmpty(txtVoucherNumber.Text))
            {
                MainErrorProvider.SetError(txtVoucherNumber, "Input voucher number");
                return true;
            }
            else
                MainErrorProvider.SetError(txtVoucherNumber, null);
            
            if (string.IsNullOrEmpty(txtLoanAmountApproved.Text))
            {
                MainErrorProvider.SetError(txtLoanAmountApproved, "Input Approved loan Amount");
                return true;
            }
            else
                MainErrorProvider.SetError(txtLoanAmountApproved, null);

            if (string.IsNullOrEmpty(txtLoanDurationApproved.Text))
            {
                MainErrorProvider.SetError(txtLoanDurationApproved, "Input Approved loan Duration");
                return true;
            }
            else
                MainErrorProvider.SetError(txtLoanDurationApproved, null);

            if (string.IsNullOrEmpty(txtCapitalperInstallment.Text))
            {
                MainErrorProvider.SetError(txtCapitalperInstallment, "Input Capital per Installment");
                return true;
            }
            else
                MainErrorProvider.SetError(txtCapitalperInstallment, null);

            if (string.IsNullOrEmpty(txtInterestperInstallment.Text))
            {
                MainErrorProvider.SetError(txtInterestperInstallment, "Input Interest per Installment");
                return true;
            }
            else
                MainErrorProvider.SetError(txtInterestperInstallment, null);

            if (string.IsNullOrEmpty(txtAmountperInstallment.Text))
            {
                MainErrorProvider.SetError(txtAmountperInstallment, "Input Total amount per Installment");
                return true;
            }
            else
                MainErrorProvider.SetError(txtAmountperInstallment, null);
            
            return false;
        }

        private void txtLoanAmount_Leave(object sender, EventArgs e)
        {
            try
            {
                double d = double.Parse(((DevExpress.XtraEditors.TextEdit)(sender)).Text);
                MainErrorProvider.SetError(((DevExpress.XtraEditors.TextEdit)(sender)), null);
            }
            catch (Exception ex)
            {
                MainErrorProvider.SetError(((DevExpress.XtraEditors.TextEdit)(sender)), "Input Valid amount");
            }
        }

        private void txtCapitalperInstallment_Leave(object sender, EventArgs e)
        {
            try
            {
                double d = double.Parse(txtCapitalperInstallment.Text);
                MainErrorProvider.SetError(txtCapitalperInstallment, null);
            }
            catch (Exception ex)
            {
                MainErrorProvider.SetError(txtCapitalperInstallment, "Input Valid percentage");
            }
        }

        private void txtLoanDurationApproved_Leave(object sender, EventArgs e)
        {
            try
            {
                double d = double.Parse(txtLoanDurationApproved.Text);
                MainErrorProvider.SetError(txtLoanDurationApproved, null);
                if (!string.IsNullOrEmpty(txtAmountperInstallment.Text))
                {
                    txtTotalAmountPayable.Text = (d * double.Parse(txtAmountperInstallment.Text)).ToString();
                }
            }
            catch (Exception ex)
            {
                MainErrorProvider.SetError(txtLoanDurationApproved, "Input Valid Duration");
            }
        }

        private void txtAmountperInstallment_Leave(object sender, EventArgs e)
        {
            try
            {
                double d = double.Parse(txtAmountperInstallment.Text);
                MainErrorProvider.SetError(txtAmountperInstallment, null);
                if (!string.IsNullOrEmpty(txtLoanDurationApproved.Text))
                {
                    txtTotalAmountPayable.Text = (d * double.Parse(txtLoanDurationApproved.Text)).ToString();
                    MainErrorProvider.SetError(txtLoanDurationApproved, null);
                }
                else
                    MainErrorProvider.SetError(txtLoanDurationApproved, "Input Loan Duration");
            }
            catch (Exception ex)
            {
                MainErrorProvider.SetError(txtAmountperInstallment, "Input Valid Amount");
            }
        }

        private void imgPhoto_DoubleClick(object sender, EventArgs e)
        {
            new ShowImagefrm(((System.Windows.Forms.PictureBox)(sender)).Image).ShowDialog(this);
        }

        private void txtInterestperInstallment_Leave(object sender, EventArgs e)
        {
            try
            {
                double d = double.Parse(txtInterestperInstallment.Text);
                MainErrorProvider.SetError(txtInterestperInstallment, null);
                txtAmountperInstallment.Text = (double.Parse(txtInterestperInstallment.Text) + double.Parse(txtCapitalperInstallment.Text)).ToString();

                double d1 = double.Parse(txtAmountperInstallment.Text);
                if (!string.IsNullOrEmpty(txtLoanDurationApproved.Text))
                {
                    txtTotalAmountPayable.Text = (d1 * double.Parse(txtLoanDurationApproved.Text)).ToString();
                    MainErrorProvider.SetError(txtLoanDurationApproved, null);
                }
                else
                    MainErrorProvider.SetError(txtLoanDurationApproved, "Input Loan Duration");
            
            }
            catch (Exception ex)
            {
                MainErrorProvider.SetError(txtInterestperInstallment, "Input Valid percentage");
            }
        }
    }
}