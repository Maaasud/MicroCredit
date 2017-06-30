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
using MicroCredit.Reports;

namespace MicroCredit.Forms
{
    public partial class frmLoanStatusView : BaseEditViewForm
    {
        MemberDataset dsMembers;
        LoanDataset dsLoan;
        public frmLoanStatusView()
        {
            InitializeComponent();
            dsMembers = new MemberDataset();
            dsLoan = new LoanDataset();
            InitializaDataset();
           
        }

        private void InitializaDataset()
        {
            
            dsMembers.MembersPolicyLookup.Clear();
            dsMembers.MembersPolicyLookup.Merge(DataHelper.GetTableData(dsMembers.MembersPolicyLookup).Tables[0]);
            cmbPolicy.Properties.DataSource = dsMembers.MembersPolicyLookup.Copy();
            cmbLoanNumber.EditValue = null;
            cmbPolicy.EditValue = null;
        }

        private void cmbPolicy_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbPolicy.EditValue == null)
                return;
            
            
            dsLoan.LoanStatusViewLookup.Clear();
            dsLoan.LoanStatusViewLookup.Merge(DataHelper.GetTableData(dsLoan.LoanStatusViewLookup, " Where PolicyID = '" + cmbPolicy.EditValue.ToString() + "'").Tables[0]);
            cmbLoanNumber.Properties.DataSource = dsLoan.LoanStatusViewLookup.Copy();
            
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
        }

        private void cmbLoanNumber_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbLoanNumber.EditValue == null)
                return;

            frmLoading _loading = new frmLoading();
            _loading.Show();

            dtpLoanDate.DateTime = DateTime.Parse( cmbLoanNumber.GetColumnValue("ApproveDate").ToString());
            txtLoanAmount.Text = cmbLoanNumber.GetColumnValue("TotalLoanAmount").ToString();
            dsLoan.LoanDetails.Clear();
            dsLoan.LoanDetails.Merge(DataHelper.GetTableData(dsLoan.LoanDetails, "Where LoanID = '" + cmbLoanNumber.EditValue.ToString() + "' Order by InstallmentDate").Tables[0]);
            dgLoanStatus.DataSource = dsLoan.LoanDetails;
            _loading.Dispose();


        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            InitializaDataset();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            rpReports report = new rpReports();
            report.HeaderDataset.Clear();
            report.HeaderDataset.CompanyInfo.Merge(DataHelper.GetTableData("CompanyInfo").Tables[0]);
            report.HeaderDataset.CompanyInfo.Rows[0]["ReportName"] = "Loan Status# " + cmbLoanNumber.Text;
            
            if (gridView1.RowCount > 0)
            {
                report.AddGrid(dgLoanStatus);
                report.ShowPreviewDialog();
            }
        }

        private void cmbExport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbExport.EditValue == null)
                return;
            try
            {
                rpReports report = new rpReports();
                string _ReportName = "Loan Status# " + cmbLoanNumber.Text;
                report.HeaderDataset.Clear();
                report.HeaderDataset.CompanyInfo.Merge(DataHelper.GetTableData("CompanyInfo").Tables[0]);
                report.HeaderDataset.CompanyInfo.Rows[0]["ReportName"] = _ReportName;
                if (gridView1.RowCount > 0)
                {
                    report.AddGrid(dgLoanStatus);
                }
                else
                    return;
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
                if (location != "")
                    MessageBox.Show("Data Export successfully", "Export document", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

            }
        }
        
    }
}