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
    public partial class frmFDRStatusView : BaseEditViewForm
    {
        MemberDataset dsMembers;
        PaymentDataset dsCashBook;

        public frmFDRStatusView()
        {
            InitializeComponent();
            InitializeDatset();
        }

        private void InitializeDatset()
        {
            dsMembers = new MemberDataset();
            dsCashBook = new PaymentDataset();
            dsMembers.FDRMemberLookup.Clear();
            dsMembers.FDRMemberLookup.Merge(DataHelper.GetTableData(dsMembers.FDRMemberLookup).Tables[0]);
            cmbFDR.Properties.DataSource = dsMembers.FDRMemberLookup.Copy();
        }

        private void cmbFDR_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbFDR.EditValue != null)
            {
                frmLoading _loading = new frmLoading();
                _loading.Show();
                dsMembers.Members.Clear();
                dsMembers.Members.Merge(DataHelper.GetTableData(dsMembers.Members, " Where IID IN (select MemberID from FDR where IID = '" + cmbFDR.EditValue.ToString() + "')").Tables[0]);
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
                dsMembers.FDR.Clear();
                dsMembers.FDR.Merge(DataHelper.GetTableData(dsMembers.FDR, " WHERE IID = '" + cmbFDR.EditValue.ToString() + "'").Tables[0]);
                dtpEnlistedDate.DateTime = (DateTime)dsMembers.FDR.Rows[0]["DepositDate"];
                txtDepositRatio.Text = dsMembers.FDR.Rows[0]["FDRAmount"].ToString();

                dsCashBook.CashBook.Clear();
                dsCashBook.CashBook.Merge(DataHelper.GetTableData(dsCashBook.CashBook, " Where FDRID = '" + cmbFDR.EditValue.ToString() + "' Order by TrDate").Tables[0]);
                double _lastBalance = 0;
                foreach (DataRow var in dsCashBook.CashBook.Rows)
                {
                    double widt = var["Withdraw"].ToString() == "" ? 0 : double.Parse(var["Withdraw"].ToString());
                    _lastBalance +=  widt;
                }
                dgMembersDeposite.DataSource = dsCashBook.CashBook.Copy();
                _loading.Dispose();
            }
        }

        private void imgPhoto_DoubleClick(object sender, EventArgs e)
        {
            new ShowImagefrm(((System.Windows.Forms.PictureBox)(sender)).Image).ShowDialog(this);
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
            report.HeaderDataset.CompanyInfo.Rows[0]["ReportName"] = "Policy Deposit# " + cmbFDR.Text;
            
            if (gridView1.RowCount > 0)
            {
                report.AddGrid(dgMembersDeposite);
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
                string _ReportName = "Policy Deposit# " + cmbFDR.Text;
                report.HeaderDataset.Clear();
                report.HeaderDataset.CompanyInfo.Merge(DataHelper.GetTableData("CompanyInfo").Tables[0]);
                report.HeaderDataset.CompanyInfo.Rows[0]["ReportName"] = _ReportName;
                
                if (gridView1.RowCount > 0)
                {
                    report.AddGrid(dgMembersDeposite);
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