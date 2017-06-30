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
    public partial class frmCashBook : BaseEditViewForm
    {
        CashBookDataset dsCashBook;
        public frmCashBook()
        {
            InitializeComponent();
            dtpFromDate.DateTime = DateTime.Today;
            dtpToDate.DateTime = DateTime.Today;
            dsCashBook = new CashBookDataset();
            InitializaDataset();
        }

        private void InitializaDataset()
        {
            MakeBalance(MakeQry());
        }

        private string MakeQry()
        {
            return "Select ISNULL(SUM(ISNULL(Deposit, 0)), 0) AS D, ISNULL(SUM(ISNULL(Withdraw, 0)), 0) AS W From CashBook Where TrDate >= '1/1/1900' AND Trdate < '" + dtpFromDate.DateTime.ToShortDateString() + "'";
        }

        private void MakeBalance(string qry)
        {
            DataTable dt = DataHelper.GetData(qry).Tables[0];
            double d = double.Parse(dt.Rows[0]["D"].ToString());
            double w = double.Parse(dt.Rows[0]["W"].ToString());
            double bal = d - w;
            dsCashBook.CashBookLookup.Clear();
            DataRow drBal = dsCashBook.CashBookLookup.NewRow();
            drBal["IID"] = Guid.NewGuid();
            drBal["ReceiptVoucher"] = "--";
            drBal["Description"] = "Balance Forword [B/F]";
            drBal["Deposit"] = d;
            drBal["Withdraw"] = w;
            
            drBal["Total"] = bal;
            drBal["TrDate"] = dtpFromDate.DateTime.ToShortDateString();
            dsCashBook.CashBookLookup.Rows.Add(drBal);

            dsCashBook.CashBookLookup.Merge(DataHelper.GetTableData(dsCashBook.CashBookLookup, " Where TrDate >= '" + dtpFromDate.DateTime.ToShortDateString() + "' AND TrDate <= '" + dtpToDate.DateTime.ToShortDateString() + "' Order by ReceiptVoucher").Tables[0]);
            foreach (DataRow var in dsCashBook.CashBookLookup.Rows)
            {
                bal = +double.Parse(var["Deposit"].ToString()) - double.Parse(var["Withdraw"].ToString());
                var["Total"] = bal;
            }
            dgCashBook.DataSource = dsCashBook.CashBookLookup.Copy();
        }

        private void nbiShow_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
           MakeBalance( MakeQry());
        }

        private void nbiRefresh_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }

        private void nbiClose_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.Dispose();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            MakeBalance(MakeQry());
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            rpReports report = new rpReports();
            report.HeaderDataset.Clear();
            report.HeaderDataset.CompanyInfo.Merge(DataHelper.GetTableData("CompanyInfo").Tables[0]);
            report.HeaderDataset.CompanyInfo.Rows[0]["ReportName"] = "Daily Collecton";
            if (dtpFromDate.DateTime.ToShortDateString() == dtpToDate.DateTime.ToShortDateString())
                report.HeaderDataset.CompanyInfo.Rows[0]["Date"] = dtpFromDate.DateTime.ToShortDateString();
            else
                report.HeaderDataset.CompanyInfo.Rows[0]["Date"] = dtpFromDate.DateTime.ToShortDateString() + " to " + dtpToDate.DateTime.ToShortDateString();
            report.AddGrid(dgCashBook);
            report.ShowPreviewDialog();
        }

        private void cmbExport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbExport.EditValue == null)
                return;
            try
            {
                rpReports report = new rpReports();
                string _ReportName = "Cash Book";
                report.HeaderDataset.Clear();
                report.HeaderDataset.CompanyInfo.Merge(DataHelper.GetTableData("CompanyInfo").Tables[0]);
                report.HeaderDataset.CompanyInfo.Rows[0]["ReportName"] = _ReportName;
                if (dtpFromDate.DateTime.ToShortDateString() == dtpToDate.DateTime.ToShortDateString())
                    report.HeaderDataset.CompanyInfo.Rows[0]["Date"] = dtpFromDate.DateTime.ToShortDateString();
                else
                    report.HeaderDataset.CompanyInfo.Rows[0]["Date"] = dtpFromDate.DateTime.ToShortDateString() + " to " + dtpToDate.DateTime.ToShortDateString();
                report.AddGrid(dgCashBook);
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
    }
}