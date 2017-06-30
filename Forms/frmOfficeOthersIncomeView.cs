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
    public partial class frmOfficeOthersIncomeView : BaseEditViewForm
    {
        ReceiptDataset dsReceipt;
        public frmOfficeOthersIncomeView()
        {
            InitializeComponent();
            dsReceipt = new ReceiptDataset();
            dtpFromDate.DateTime = DateTime.Today;
            dtpToDate.DateTime = DateTime.Today;
            InitializaDataset();
        }

        private void InitializaDataset()
        {
            ShowOfficeIncome();
        }

        private void ShowOfficeIncome()
        {
            dsReceipt.OfficeIncome.Clear();
            dsReceipt.OfficeIncome.Merge(DataHelper.GetTableData(dsReceipt.OfficeIncome, " Where IncomeDate >='" + dtpFromDate.DateTime.ToShortDateString() + "' AND IncomeDate <= '" + dtpToDate.DateTime.ToShortDateString() + "' Order by IncomeDate").Tables[0]);
            foreach (DataRow var in dsReceipt.OfficeIncome.Rows)
            {
                var["Total"] = double.Parse(var["Passbook"].ToString())+double.Parse(var["Admission"].ToString())+double.Parse(var["Others"].ToString());
            }
                
            dgOfficeOthersIncome.DataSource = dsReceipt.OfficeIncome;
        }

        private void nbiShow_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ShowOfficeIncome();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            ShowOfficeIncome();
        }

        private void nbiRefresh_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ShowOfficeIncome();
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

        private void cmbExport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbExport.EditValue == null)
                return;
            try
            {
                rpReports report = new rpReports();
                string _ReportName = "Office Income ";
                report.HeaderDataset.Clear();
                report.HeaderDataset.CompanyInfo.Merge(DataHelper.GetTableData("CompanyInfo").Tables[0]);
                report.HeaderDataset.CompanyInfo.Rows[0]["ReportName"] = _ReportName;
                if (dtpFromDate.DateTime.ToShortDateString() == dtpToDate.DateTime.ToShortDateString())
                    report.HeaderDataset.CompanyInfo.Rows[0]["Date"] = dtpFromDate.DateTime.ToShortDateString();
                else
                    report.HeaderDataset.CompanyInfo.Rows[0]["Date"] = dtpFromDate.DateTime.ToShortDateString() + " to " + dtpToDate.DateTime.ToShortDateString();
                report.AddGrid(dgOfficeOthersIncome);
                string location="";
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            rpReports report = new rpReports();
            report.HeaderDataset.Clear();
            report.HeaderDataset.CompanyInfo.Merge(DataHelper.GetTableData("CompanyInfo").Tables[0]);
            report.HeaderDataset.CompanyInfo.Rows[0]["ReportName"] = "Office Income";
            if (dtpFromDate.DateTime.ToShortDateString() == dtpToDate.DateTime.ToShortDateString())
                report.HeaderDataset.CompanyInfo.Rows[0]["Date"] = dtpFromDate.DateTime.ToShortDateString();
            else
                report.HeaderDataset.CompanyInfo.Rows[0]["Date"] = dtpFromDate.DateTime.ToShortDateString() + " to " + dtpToDate.DateTime.ToShortDateString();
            report.AddGrid(dgOfficeOthersIncome);
            report.ShowPreviewDialog();
        }
    }
}