namespace MicroCredit.Reports
{
    partial class rpReports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rpReports));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtReportDate = new DevExpress.XtraReports.UI.XRLabel();
            this.HeaderDataset = new MicroCredit.DataSets.ReportHeaderDataSet();
            this.txtReportName = new DevExpress.XtraReports.UI.XRLabel();
            this.lblPrintDate = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtPhone = new DevExpress.XtraReports.UI.XRLabel();
            this.txtAddress = new DevExpress.XtraReports.UI.XRLabel();
            this.txtCompanyName = new DevExpress.XtraReports.UI.XRLabel();
            this.imgLogo = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Height = 61;
            this.Detail.Name = "Detail";
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel7,
            this.txtReportDate,
            this.txtReportName,
            this.lblPrintDate,
            this.xrLabel4,
            this.txtPhone,
            this.txtAddress,
            this.txtCompanyName,
            this.imgLogo,
            this.xrLine2,
            this.xrLine1});
            this.PageHeader.Height = 108;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrLabel7
            // 
            this.xrLabel7.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrLabel7.Location = new System.Drawing.Point(8, 83);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.ParentStyleUsing.UseFont = false;
            this.xrLabel7.Size = new System.Drawing.Size(84, 17);
            this.xrLabel7.Text = "Report Date :";
            // 
            // txtReportDate
            // 
            this.txtReportDate.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.HeaderDataset, "CompanyInfo.Date", "")});
            this.txtReportDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtReportDate.Location = new System.Drawing.Point(92, 83);
            this.txtReportDate.Name = "txtReportDate";
            this.txtReportDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtReportDate.ParentStyleUsing.UseFont = false;
            this.txtReportDate.Size = new System.Drawing.Size(142, 17);
            this.txtReportDate.Text = "txtReportDate";
            // 
            // HeaderDataset
            // 
            this.HeaderDataset.DataSetName = "ReportHeaderDataSet";
            this.HeaderDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtReportName
            // 
            this.txtReportName.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.HeaderDataset, "CompanyInfo.ReportName", "")});
            this.txtReportName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtReportName.Location = new System.Drawing.Point(225, 67);
            this.txtReportName.Name = "txtReportName";
            this.txtReportName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtReportName.ParentStyleUsing.UseFont = false;
            this.txtReportName.Size = new System.Drawing.Size(525, 25);
            this.txtReportName.Text = "txtReportName";
            this.txtReportName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lblPrintDate
            // 
            this.lblPrintDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblPrintDate.Location = new System.Drawing.Point(92, 67);
            this.lblPrintDate.Name = "lblPrintDate";
            this.lblPrintDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPrintDate.ParentStyleUsing.UseFont = false;
            this.lblPrintDate.Size = new System.Drawing.Size(82, 17);
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrLabel4.Location = new System.Drawing.Point(8, 67);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.ParentStyleUsing.UseFont = false;
            this.xrLabel4.Size = new System.Drawing.Size(66, 17);
            this.xrLabel4.Text = "Print Date :";
            // 
            // txtPhone
            // 
            this.txtPhone.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.HeaderDataset, "CompanyInfo.Phone", "")});
            this.txtPhone.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtPhone.Location = new System.Drawing.Point(100, 42);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtPhone.ParentStyleUsing.UseFont = false;
            this.txtPhone.Size = new System.Drawing.Size(650, 17);
            this.txtPhone.Text = "txtPhone";
            this.txtPhone.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // txtAddress
            // 
            this.txtAddress.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.HeaderDataset, "CompanyInfo.Address", "")});
            this.txtAddress.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtAddress.Location = new System.Drawing.Point(100, 25);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtAddress.ParentStyleUsing.UseFont = false;
            this.txtAddress.Size = new System.Drawing.Size(650, 17);
            this.txtAddress.Text = "txtAddress";
            this.txtAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.HeaderDataset, "CompanyInfo.Name", "")});
            this.txtCompanyName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyName.Location = new System.Drawing.Point(100, 0);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtCompanyName.ParentStyleUsing.UseFont = false;
            this.txtCompanyName.Size = new System.Drawing.Size(650, 25);
            this.txtCompanyName.Text = "txtCompanyName";
            this.txtCompanyName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // imgLogo
            // 
            this.imgLogo.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Image", this.HeaderDataset, "CompanyInfo.Logo", "")});
            this.imgLogo.Location = new System.Drawing.Point(0, 0);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(83, 58);
            this.imgLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            // 
            // xrLine2
            // 
            this.xrLine2.ForeColor = System.Drawing.Color.Silver;
            this.xrLine2.Location = new System.Drawing.Point(0, 83);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.ParentStyleUsing.UseForeColor = false;
            this.xrLine2.Size = new System.Drawing.Size(767, 25);
            // 
            // xrLine1
            // 
            this.xrLine1.ForeColor = System.Drawing.Color.Silver;
            this.xrLine1.Location = new System.Drawing.Point(0, 50);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.ParentStyleUsing.UseForeColor = false;
            this.xrLine1.Size = new System.Drawing.Size(767, 25);
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel6,
            this.xrPictureBox1});
            this.PageFooter.Height = 26;
            this.PageFooter.Name = "PageFooter";
            // 
            // xrLabel6
            // 
            this.xrLabel6.Font = new System.Drawing.Font("Tahoma", 6.75F);
            this.xrLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.xrLabel6.Location = new System.Drawing.Point(500, 0);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.ParentStyleUsing.UseFont = false;
            this.xrLabel6.ParentStyleUsing.UseForeColor = false;
            this.xrLabel6.Size = new System.Drawing.Size(258, 17);
            this.xrLabel6.Text = "Copyright © ProfessionBD Limited 2008. Phone: 01720335200";
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox1.Image")));
            this.xrPictureBox1.Location = new System.Drawing.Point(425, 0);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.Size = new System.Drawing.Size(58, 25);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            // 
            // rpReports
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.PageHeader,
            this.PageFooter});
            this.DataMember = "CompanyInfo";
            this.DataSource = this.HeaderDataset;
            this.Margins = new System.Drawing.Printing.Margins(50, 35, 20, 50);
            this.DataSourceRowChanged += new DevExpress.XtraReports.UI.DataSourceRowEventHandler(this.rpReports_DataSourceRowChanged);
            ((System.ComponentModel.ISupportInitialize)(this.HeaderDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRPictureBox imgLogo;
        private DevExpress.XtraReports.UI.XRLabel txtCompanyName;
        private DevExpress.XtraReports.UI.XRLabel txtAddress;
        private DevExpress.XtraReports.UI.XRLabel txtPhone;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel lblPrintDate;
        private DevExpress.XtraReports.UI.XRLabel txtReportName;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel txtReportDate;
        private DevExpress.XtraReports.UI.XRLine xrLine2;
        public MicroCredit.DataSets.ReportHeaderDataSet HeaderDataset;
    }
}
