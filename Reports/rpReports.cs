using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;

namespace MicroCredit.Reports
{
    public partial class rpReports : DevExpress.XtraReports.UI.XtraReport
    {
        public rpReports()
        {
            InitializeComponent();
            lblPrintDate.Text = DateTime.Now.ToShortDateString();
        }

        private void rpReports_DataSourceRowChanged(object sender, DataSourceRowEventArgs e)
        {
            //if(HeaderDataset.CompanyInfo.Rows.Count > 0)
            //    if (HeaderDataset.CompanyInfo.Rows[0]["Logo"].ToString() != "")
            //    {
            //        byte[] image = (byte[])HeaderDataset.CompanyInfo.Rows[0]["Logo"];
            //        System.IO.MemoryStream stream = new System.IO.MemoryStream(image, 0, image.Length, false);
            //        this.Watermark.Image = System.Drawing.Image.FromStream(stream);
            //        this.Watermark.ImageTransparency = 200;
            //    }
            
        }
        public void AddGrid(Control control)
        {
            WinControlContainer wcc = new WinControlContainer();
            wcc.WinControl = control;
            this.Detail.Controls.Add(wcc);
        }
    }
}
