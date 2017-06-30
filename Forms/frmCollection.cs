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
using DevExpress.XtraGrid.Views.Grid;
using MicroCredit.Reports;

namespace MicroCredit.Forms
{
    public partial class frmCollection : BaseEditViewForm
    {
        MemberDataset dsMembers;
        ReceiptDataset dsReceipt;
        EmployeeDataset dsEmployee;
        public frmCollection()
        {
            InitializeComponent();
            InitializaDataset();
            dtpToDate.DateTime = DateTime.Today;
            dtpFromDate.DateTime = DateTime.Today;
        }

        private void InitializaDataset()
        {
            dsMembers = new MemberDataset();
            dsReceipt = new ReceiptDataset();
            dsEmployee = new EmployeeDataset();
            dtpReceiptDate.DateTime = DateTime.Now;
            dsMembers.MembersPolicyLookup.Clear();
            dsMembers.MembersPolicyLookup.Merge(DataHelper.GetTableData(dsMembers.MembersPolicyLookup).Tables[0]);
            cmbPolicy.Properties.DataSource = dsMembers.MembersPolicyLookup.Copy();
            dsReceipt.ReceiptOthers.Clear();
            dsReceipt.ReceiptOthers.Merge(DataHelper.GetTableData(dsReceipt.ReceiptOthers).Tables[0]);
            SetDataInCombo((DataTable)dsReceipt.ReceiptOthers, "Reason");
            dsEmployee.Employee.Clear();
            dsEmployee.Employee.Merge(DataHelper.GetTableData(dsEmployee.Employee).Tables[0]);
            cmbEmployee.Properties.DataSource = dsEmployee.Employee.Copy();
        }

        private void SetDataInCombo(DataTable dataTable, string p)
        {
            cmbReason.Properties.Items.Clear();
            foreach (DataRow var in dataTable.Rows)
            {
                cmbReason.Properties.Items.Add(var[p].ToString());
            }
            
        }

        private void chkLoan_CheckedChanged(object sender, EventArgs e)
        {
            lblCapital.Visible = chkLoan.Checked;
            lblInterest.Visible = chkLoan.Checked;
            txtCapital.Visible = chkLoan.Checked;
            txtInterest.Visible = chkLoan.Checked;
            txtLoan.Visible = chkLoan.Checked;
            nubLoan.Visible = chkLoan.Checked;
            if (chkLoan.Checked)
            {
                nubLoan.Text = "1";
                txtInterest.Text = _interestPercent.ToString();
                txtCapital.Text = _capitalPercent.ToString();
                txtLoan.Text = _InstallmaentAmount.ToString();
                nubLoan.Focus();
            }
            else
            {
                txtCapital.Text = "0";
                txtLoan.Text = "0";
                txtInterest.Text = "0";
            }
        }

        private void chkDeposit_CheckedChanged(object sender, EventArgs e)
        {
            txtDeposit.Visible = chkDeposit.Checked;
            nudDeposit.Visible = chkDeposit.Checked;
            txtAmountperDeposit.Visible = chkDeposit.Checked;
            if (chkDeposit.Checked)
            {
                nudDeposit.Text = "1";
                txtAmountperDeposit.Text = _deposit.ToString();
                txtDeposit.Text = (double.Parse(nudDeposit.Text) * _deposit).ToString();
                nudDeposit.Focus();
            }
            else
            {
                txtDeposit.Text = "0";
                txtAmountperDeposit.Text = "0";
            }
        }

        private void chkPassbookForm_CheckedChanged(object sender, EventArgs e)
        {
            txtPassbook.Visible = chkPassbookForm.Checked;
            if (chkPassbookForm.Checked)
                txtPassbook.Focus();
            else
                txtPassbook.Text = "0";
        }



        private void chkAdmissionFee_CheckedChanged(object sender, EventArgs e)
        {
            txtAdmission.Visible = chkAdmissionFee.Checked;
            if (chkAdmissionFee.Checked)
                txtAdmission.Focus();
            else
                txtAdmission.Text = "0";
        }

        private void chkOthers_CheckedChanged(object sender, EventArgs e)
        {
            cmbReason.Visible = chkOthers.Checked;
            txtOthers.Visible = chkOthers.Checked;
            if (chkOthers.Checked)
                cmbReason.Focus();
            else
                txtOthers.Text = "0";
        }

        private void txtCapital_Leave(object sender, EventArgs e)
        {
            try
            {
                double d = double.Parse(((DevExpress.XtraEditors.TextEdit)sender).Text);
                MainErrorProvider.SetError(((DevExpress.XtraEditors.TextEdit)sender), null);
            }
            catch (Exception ex)
            {
                MainErrorProvider.SetError(((DevExpress.XtraEditors.TextEdit)sender), "Input Valid Amount");
                ((DevExpress.XtraEditors.TextEdit)sender).Focus();
            }
        }

        double _InstallmaentAmount = 0;
        double _capitalPercent = 0;
        double _interestPercent = 0;
        double _deposit = 0;
        string LoanID = "";
        string LoanStatusID = "";
        private void cmbPolicy_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbPolicy.EditValue != null)
            {
                txtMemberName.Text = cmbPolicy.GetColumnValue("FullName").ToString();
                dsReceipt.LoanStatusLookup.Clear();
                dsReceipt.LoanStatusLookup.Merge(DataHelper.GetTableData(dsReceipt.LoanStatusLookup, " Where PolicyID = '" + cmbPolicy.EditValue.ToString() + "' AND Status = 'true'").Tables[0]);
                if (dsReceipt.LoanStatusLookup.Rows.Count > 0)
                {
                    DataRow dr = dsReceipt.LoanStatusLookup.Rows[0];
                    chkLoan.Checked = true;
                    _InstallmaentAmount = double.Parse(dr["PerInstallmentAmount"].ToString());
                    _capitalPercent = double.Parse(dr["CapitalInstallmentPercent"].ToString());
                    _interestPercent = double.Parse(dr["InterestInstallmentPercent"].ToString());
                    txtLoan.Text = _InstallmaentAmount.ToString();
                    LoanID = dr["LoanID"].ToString();
                    LoanStatusID = dr["StatusID"].ToString();
                    txtCapital.Text = _capitalPercent .ToString();
                    txtInterest.Text =  _interestPercent .ToString();
                }
                else
                {
                    chkLoan.Checked = false;
                    _InstallmaentAmount = 0;
                    _capitalPercent = 0;
                    _interestPercent = 0;
                }

                DataTable dtSaveRatio = DataHelper.GetData("Select SavingRatio from Policy where IID = '" + cmbPolicy.EditValue.ToString() + "' And Status = 'true'").Tables[0];
                if (dtSaveRatio.Rows.Count > 0)
                {
                    txtAmountperDeposit.Text = dtSaveRatio.Rows[0][0].ToString();
                    _deposit = double.Parse(txtAmountperDeposit.Text);
                    chkDeposit.Checked = true;
                    nudDeposit.Focus();
                }
                else
                {
                    chkDeposit.Checked = false;
                    _deposit = 0;
                }

                
            }
            chkLoan.Focus();
        }

        private void txtLoan_Leave(object sender, EventArgs e)
        {
            try
            {
                double d = double.Parse(txtLoan.Text);
                MainErrorProvider.SetError(txtLoan, null);
                txtCapital.Text = (_capitalPercent * d / 100).ToString();
                txtInterest.Text = (_interestPercent * d / 100).ToString();
            }
            catch (Exception ex)
            {
                MainErrorProvider.SetError(txtLoan, "Input valid Amount");
                txtLoan.Focus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ErrorFound())
                return;
            SaveReceipt();
            
        }

        private void SaveReceipt()
        {
            DataRow drReceipt = dsReceipt.CollectionReceipt.NewRow();
            drReceipt["IID"] = Guid.NewGuid();
            drReceipt["ReceiptNo"] = string.IsNullOrEmpty(txtReceiptNo.Text) == false ? txtReceiptNo.Text : " ";
            drReceipt["TrDate"] = dtpReceiptDate.DateTime.ToShortDateString();
            drReceipt["PolicyID"] = cmbPolicy.EditValue;
            drReceipt["AdmissionFee"] = txtAdmission.Text;
            drReceipt["PassbookFormFee"] = txtPassbook.Text;
            drReceipt["Deposit"] = double.Parse( txtDeposit.Text) * double.Parse(nudDeposit.Text);
            drReceipt["LoanCapital"] = txtCapital.Text;
            drReceipt["LoanProfit"] = txtInterest.Text;
            drReceipt["OtherReason"] = cmbReason.Text;
            drReceipt["OtherCharges"] = txtOthers.Text;
            drReceipt["EmployeeID"] = cmbEmployee.EditValue;
            dsReceipt.CollectionReceipt.Rows.Add(drReceipt);
            DataRow drReason = dsReceipt.ReceiptOthers.Rows.Find(cmbReason.Text);
            DataHelper.UpdateData(dsReceipt.CollectionReceipt);
            if (drReason == null)
            { 
                DataRow drOReason = dsReceipt.ReceiptOthers.NewRow();
                drOReason["Reason"] = cmbReason.Text;
                dsReceipt.ReceiptOthers.Rows.Add(drOReason);
                DataHelper.UpdateData(dsReceipt.ReceiptOthers);
                dsReceipt.ReceiptOthers.Merge(DataHelper.GetTableData(dsReceipt.ReceiptOthers).Tables[0]);
            }
            
            if (chkDeposit.Checked)
            {
                for (int i = 0; i < int.Parse(nudDeposit.Text); i++)
                {
                    DataRow dr = dsReceipt.DepositDetails.NewRow();
                    dr["IID"] = Guid.NewGuid();
                    dr["MasterID"] = cmbPolicy.EditValue;
                    dr["Dateof"] = dtpReceiptDate.DateTime.ToShortDateString();
                    dr["Description"] = "Deposit";
                    dr["InstallmentSL"] = nudDeposit.Text;
                    dr["ReceiptNo"] = txtReceiptNo.Text;
                    dr["DepositProfit"] = txtAmountperDeposit.Text;
                    dsReceipt.DepositDetails.Rows.Add(dr);
                }
                DataHelper.UpdateData(dsReceipt.DepositDetails);
            }
            if (chkLoan.Checked)
            {
                DataRow drLo = dsReceipt.LoanDetails.NewRow();
                drLo["IID"] = Guid.NewGuid();
                drLo["LoanID"] = LoanID;
                drLo["InstallmentDate"] = dtpReceiptDate.DateTime.ToShortDateString();
                drLo["ReceiptNo"] = txtReceiptNo.Text;
                drLo["Capital"] = txtCapital.Text;
                drLo["Interest"] = txtInterest.Text;
                drLo["InstallNo"] = int.Parse(nubLoan.Text);
                drLo["TotalAmount"] = txtLoan.Text;
                dsReceipt.LoanDetails.Rows.Add(drLo);
                DataHelper.UpdateData(dsReceipt.LoanDetails);

                dsReceipt.LoanStatus.Clear();
                dsReceipt.LoanStatus.Merge(DataHelper.GetTableData(dsReceipt.LoanStatus, " Where IID = '" + LoanStatusID + "'").Tables[0]);
                dsReceipt.LoanStatus.Rows[0]["TotalAmountPaid"] = double.Parse(dsReceipt.LoanStatus.Rows[0]["TotalAmountPaid"].ToString()) + double.Parse(txtLoan.Text);
                DataHelper.UpdateData(dsReceipt.LoanStatus);
            }
            if (chkAdmissionFee.Checked || chkOthers.Checked || chkPassbookForm.Checked)
            {
                DataRow drIncome = dsReceipt.OfficeIncome.NewRow();
                drIncome["IID"] = Guid.NewGuid();
                drIncome["IncomeDate"] = dtpReceiptDate.DateTime.ToShortDateString();
                drIncome["ReceiptNo"] = txtReceiptNo.Text;
                drIncome["Passbook"] = txtPassbook.Text;
                drIncome["Admission"] = txtAdmission.Text;
                drIncome["Others"] = txtOthers.Text;
                drIncome["Reason"] = cmbReason.Text;
                dsReceipt.OfficeIncome.Rows.Add(drIncome);
                DataHelper.UpdateData(dsReceipt.OfficeIncome);
            }

            DataRow RecLookup = dsReceipt.CollectionReceiptLookup.NewRow();
            RecLookup["IID"] = drReceipt["IID"];
            RecLookup["ReceiptNo"] = txtReceiptNo.Text;
            RecLookup["TrDate"] = dtpReceiptDate.DateTime.ToShortDateString();
            RecLookup["PolicyID"] = cmbPolicy.EditValue;
            RecLookup["AdmissionFee"] = txtAdmission.Text;
            RecLookup["PassbookFormFee"] = txtPassbook.Text;
            RecLookup["Deposit"] = txtDeposit.Text;
            RecLookup["LoanCapital"] = txtCapital.Text;
            RecLookup["LoanProfit"] = txtInterest.Text;
            RecLookup["PolicyNumber"] = cmbPolicy.Text;
            RecLookup["FullName"] = txtMemberName.Text;
            RecLookup["OtherCharges"] = txtOthers.Text;
            RecLookup["Total"] = double.Parse(txtAdmission.Text) + double.Parse(txtPassbook.Text) + double.Parse(txtDeposit.Text) + double.Parse(txtCapital.Text) + double.Parse(txtInterest.Text) + double.Parse(txtOthers.Text);
            RecLookup["Name"] = cmbEmployee.GetColumnValue("Name") + "["+cmbEmployee.GetColumnValue("Code")+"]";
            dsReceipt.CollectionReceiptLookup.Rows.Add(RecLookup);
            dgReceipt.DataSource = dsReceipt.CollectionReceiptLookup;

            DataRow drCash = dsReceipt.CashBook.NewRow();
            drCash["IID"] = Guid.NewGuid();
            drCash["ReceiptVoucher"] = txtReceiptNo.Text;
            drCash["Deposit"] = double.Parse(txtLoan.Text) + double.Parse(txtDeposit.Text) + double.Parse(txtPassbook.Text) + double.Parse(txtAdmission.Text) + double.Parse(txtOthers.Text);
            drCash["TrDate"] = dtpReceiptDate.DateTime.ToShortDateString();
            drCash["Description"] = MakeDescription();
            dsReceipt.CashBook.Rows.Add(drCash);
            DataHelper.UpdateData(dsReceipt.CashBook);
            ClearAlltext();
        }

        private string MakeDescription()
        {
            string D = "";
            if (chkLoan.Checked)
                D += "Loan# " + txtLoan.Text+"/ ";
            if (chkDeposit.Checked)
                D += "Deposit# " + txtDeposit.Text+"/ ";
            if (chkAdmissionFee.Checked)
                D += "Admission# " + txtAdmission.Text + "/ ";
            if (chkPassbookForm.Checked)
                D += "Passbook/Form# " + txtPassbook.Text + "/ ";
            if (chkOthers.Checked)
                D += "Others# (" +cmbReason.Text+ ")"+txtAdmission.Text + "/";

            return D;

        }

        private bool ErrorFound()
        {
            //if (string.IsNullOrEmpty(txtReceiptNo.Text))
            //{
            //    MainErrorProvider.SetError(txtReceiptNo, "Input Receipt number");
            //    return true;
            //}
            //else
            //    MainErrorProvider.SetError(txtReceiptNo, null);

            if (cmbPolicy.EditValue == null)
            {
                MainErrorProvider.SetError(cmbPolicy, "Select Policy number");
                return true;
            }
            else
                MainErrorProvider.SetError(cmbPolicy, null);
            if (chkLoan.Checked && (double.Parse(txtLoan.Text) == 0) &&  (double.Parse(txtCapital.Text) == 0) && ( double.Parse(txtInterest.Text) == 0))
            {
                MainErrorProvider.SetError(txtLoan, "Input Valid Amount");
                MainErrorProvider.SetError(txtCapital, "Input Valid Amount");
                MainErrorProvider.SetError(txtInterest, "Input Valid Amount");
                return true;
            }
            else
            {
                MainErrorProvider.SetError(txtLoan, null);
                MainErrorProvider.SetError(txtCapital, null);
                MainErrorProvider.SetError(txtInterest, null);
            }

            if (chkDeposit.Checked && double.Parse(txtDeposit.Text) == 0)
            {
                MainErrorProvider.SetError(txtDeposit, "Input Valid Amount");
                return true;
            }
            else
                MainErrorProvider.SetError(txtDeposit, null);

            if (chkPassbookForm.Checked && double.Parse(txtPassbook.Text) == 0)
            {
                MainErrorProvider.SetError(txtPassbook, "Input Valid Amount");
                return true;
            }
            else
                MainErrorProvider.SetError(txtPassbook, null);
            

            if (chkAdmissionFee.Checked && double.Parse(txtAdmission.Text) == 0)
            {
                MainErrorProvider.SetError(txtAdmission, "Input valid Amount");
                return true;
            }
            else
                MainErrorProvider.SetError(txtAdmission, null);

            if (chkOthers.Checked && double.Parse(txtOthers.Text) == 0)
            {
                MainErrorProvider.SetError(txtOthers, "Input valid Amount");
                return true;
            }
            else
                MainErrorProvider.SetError(txtOthers, null);
            if (!chkLoan.Checked && !chkOthers.Checked && !chkPassbookForm.Checked && !chkDeposit.Checked && !chkAdmissionFee.Checked)
            {
                MessageBox.Show("You Must collect some amount in the receipt", "Zero Receipt Amount", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }
            return false;
        }

        private void txtLoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                chkLoan.Checked = false;
                chkLoan.Focus();
            }
        }

        private void txtDeposit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                chkDeposit.Checked = false;
                chkDeposit.Focus();
            }
        }

        private void txtPassbook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                chkPassbookForm.Checked = false;
                chkPassbookForm.Focus();
            }
        }

        

        private void txtAdmission_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                chkAdmissionFee.Checked = false;
                chkAdmissionFee.Focus();
            }
        }

        private void txtOthers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                chkOthers.Checked = false;
                chkOthers.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAlltext();
        }

        private void ClearAlltext()
        {
            chkAdmissionFee.Checked = false;
            chkDeposit.Checked = true;
            chkLoan.Checked = false;
            chkOthers.Checked = false;
            chkPassbookForm.Checked = false;
            
            cmbReason.SelectedIndex = -1;
            cmbPolicy.EditValue = null;
            LoanID = "";
            LoanStatusID = "";
            txtAdmission.Text = "0";
            txtCapital.Text = "0";
            txtDeposit.Text = "0";
            txtAmountperDeposit.Text = "0";
            txtInterest.Text = "0";
            txtLoan.Text = "0";
            txtMemberName.Text = "";
            txtOthers.Text = "0";
            txtPassbook.Text = "0";
            txtReceiptNo.Text = "";
            txtReceiptNo.Focus();
            dtpToDate.DateTime = DateTime.Today;
            dtpFromDate.DateTime = DateTime.Today;
        }

        private void txtLoan_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(((DevExpress.XtraEditors.TextEdit)sender).Text))
                MainErrorProvider.SetError(((DevExpress.XtraEditors.TextEdit)sender), null);
        }

        private void nbiShow_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ShowReceipt();
        }

        private void ShowReceipt()
        {
            dsReceipt.CollectionReceiptLookup.Clear();
            dsReceipt.CollectionReceiptLookup.Merge(DataHelper.GetTableData(dsReceipt.CollectionReceiptLookup, " Where TrDate >= '" + dtpFromDate.DateTime.ToShortDateString() + "' AND TrDate <= '" + dtpToDate.DateTime.ToShortDateString() + "' ORDER BY ReceiptNo").Tables[0]);
            dgReceipt.DataSource = dsReceipt.CollectionReceiptLookup;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            ShowReceipt();
        }

        private void nbiRefresh_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            InitializaDataset();
        }

        private void nbiClose_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.Dispose();
        }

        private void nudDeposit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode== Keys.Tab)
                txtDeposit.Focus();
        }

        private void nudDeposit_EditValueChanged(object sender, EventArgs e)
        {
            txtDeposit.Text = (double.Parse(nudDeposit.Text) * (double.Parse(txtAmountperDeposit.Text))).ToString();
        }

        private void txtAmountperDeposit_EditValueChanged(object sender, EventArgs e)
        {
            txtDeposit.Text = (double.Parse(nudDeposit.Text) * (double.Parse(txtAmountperDeposit.Text))).ToString();
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            GridView view = (GridView)sender;
            if (e.Info.IsRowIndicator && e.RowHandle > -1)
            {
                if (e.RowHandle < 0)
                    e.Info.DisplayText = "1";
                else
                    e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void expandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView1.ExpandAllGroups();
        }

        private void collupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView1.CollapseAllGroups();
        }

        private void nubLoan_EditValueChanged(object sender, EventArgs e)
        {
            txtLoan.Text = (double.Parse(nubLoan.Text) * _InstallmaentAmount).ToString();
            txtCapital.Text = (double.Parse(nubLoan.Text) * _capitalPercent).ToString();
            txtInterest.Text = (double.Parse(nubLoan.Text) * _interestPercent).ToString();
        }

        private void nubLoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                chkLoan.Checked = false;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            rpReports report = new rpReports();
            report.HeaderDataset.Clear();
            report.HeaderDataset.CompanyInfo.Merge(DataHelper.GetTableData("CompanyInfo").Tables[0]);
            report.HeaderDataset.CompanyInfo.Rows[0]["ReportName"] = "Daily Collecton";
            if(dtpFromDate.DateTime.ToShortDateString() == dtpToDate.DateTime.ToShortDateString())
                report.HeaderDataset.CompanyInfo.Rows[0]["Date"] = dtpFromDate.DateTime.ToShortDateString();
            else
                report.HeaderDataset.CompanyInfo.Rows[0]["Date"] = dtpFromDate.DateTime.ToShortDateString() + " to " + dtpToDate.DateTime.ToShortDateString();
            report.AddGrid(dgReceipt);
            report.ShowPreviewDialog();
        }

        private void cmbExport_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbExport.EditValue == null)
                return;
            try
            {
                rpReports report = new rpReports();
                string _ReportName = "Daily Collecton";
                report.HeaderDataset.Clear();
                report.HeaderDataset.CompanyInfo.Merge(DataHelper.GetTableData("CompanyInfo").Tables[0]);
                report.HeaderDataset.CompanyInfo.Rows[0]["ReportName"] = _ReportName;
                if (dtpFromDate.DateTime.ToShortDateString() == dtpToDate.DateTime.ToShortDateString())
                    report.HeaderDataset.CompanyInfo.Rows[0]["Date"] = dtpFromDate.DateTime.ToShortDateString();
                else
                    report.HeaderDataset.CompanyInfo.Rows[0]["Date"] = dtpFromDate.DateTime.ToShortDateString() + " to " + dtpToDate.DateTime.ToShortDateString();
                report.AddGrid(dgReceipt);
                if (cmbExport.EditValue == "Excel")
                {
                    FolderBrowserDialog fd = new FolderBrowserDialog();
                    fd.ShowDialog();

                    string location = fd.SelectedPath;
                    if (location != "")
                    {
                        string FileName = _ReportName + DateTime.Now.Year.ToString().Substring(2) + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + ".xls";
                        report.ExportToXls(location + "\\" + FileName);
                    }
                }
                else if (cmbExport.EditValue == "Word")
                {
                    FolderBrowserDialog fd = new FolderBrowserDialog();
                    fd.ShowDialog();

                    string location = fd.SelectedPath;
                    if (location != "")
                    {
                        string FileName = _ReportName + DateTime.Now.Year.ToString().Substring(2) + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + ".doc";
                        report.ExportToRtf(location + "\\" + FileName);
                    }
                }
                else if (cmbExport.EditValue == "PDF")
                {
                    FolderBrowserDialog fd = new FolderBrowserDialog();
                    fd.ShowDialog();

                    string location = fd.SelectedPath;
                    if (location != "")
                    {
                        string FileName = _ReportName + DateTime.Now.Year.ToString().Substring(2) + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + ".pdf";
                        report.ExportToPdf(location + "\\" + FileName);
                    }
                }
                cmbExport.EditValue = null;
            }
            catch (Exception ex)
            { 
            
            }
            MessageBox.Show("Data Export successfully", "Export document", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbExport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbExport.EditValue == null)
                return;
            try
            {
                rpReports report = new rpReports();
                string _ReportName = "Collection ";
                report.HeaderDataset.Clear();
                report.HeaderDataset.CompanyInfo.Merge(DataHelper.GetTableData("CompanyInfo").Tables[0]);
                report.HeaderDataset.CompanyInfo.Rows[0]["ReportName"] = _ReportName;
                if (dtpFromDate.DateTime.ToShortDateString() == dtpToDate.DateTime.ToShortDateString())
                    report.HeaderDataset.CompanyInfo.Rows[0]["Date"] = dtpFromDate.DateTime.ToShortDateString();
                else
                    report.HeaderDataset.CompanyInfo.Rows[0]["Date"] = dtpFromDate.DateTime.ToShortDateString() + " to " + dtpToDate.DateTime.ToShortDateString();
                report.AddGrid(dgReceipt);
                string location = "";
                if (cmbExport.EditValue == "Excel")
                {
                    FolderBrowserDialog fd = new FolderBrowserDialog();
                    fd.ShowDialog();

                    location = fd.SelectedPath;
                    if (location != "")
                    {
                        string FileName = _ReportName + DateTime.Now.Year.ToString().Substring(2) + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + ".xls";
                        report.ExportToXls(location + "\\" + FileName);
                    }
                }
                else if (cmbExport.EditValue == "Word")
                {
                    FolderBrowserDialog fd = new FolderBrowserDialog();
                    fd.ShowDialog();

                    location = fd.SelectedPath;
                    if (location != "")
                    {
                        string FileName = _ReportName + DateTime.Now.Year.ToString().Substring(2) + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + ".doc";
                        report.ExportToRtf(location + "\\" + FileName);
                    }
                }
                else if (cmbExport.EditValue == "PDF")
                {
                    FolderBrowserDialog fd = new FolderBrowserDialog();
                    fd.ShowDialog();

                    location = fd.SelectedPath;
                    if (location != "")
                    {
                        string FileName = _ReportName + DateTime.Now.Year.ToString().Substring(2) + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + ".pdf";
                        report.ExportToPdf(location + "\\" + FileName);
                    }
                }
                cmbExport.EditValue = null;
                if(location != "")
                    MessageBox.Show("Data Export successfully", "Export document", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

            }
            
        }
    }
}