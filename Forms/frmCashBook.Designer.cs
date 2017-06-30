namespace MicroCredit.Forms
{
    partial class frmCashBook
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCashBook));
            this.dgCashBook = new DevExpress.XtraGrid.GridControl();
            this.cashBookLookupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cashBookDataset = new MicroCredit.DataSets.CashBookDataset();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReceiptVoucher = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeposit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWithdraw = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.navBarGeneral = new DevExpress.XtraNavBar.NavBarControl();
            this.nbgGenerals = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiShow = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiRefresh = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiClose = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroupControlContainer1 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnGo = new DevExpress.XtraEditors.SimpleButton();
            this.dtpFromDate = new DevExpress.XtraEditors.DateEdit();
            this.dtpToDate = new DevExpress.XtraEditors.DateEdit();
            this.navBarTask = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.cmbExport = new DevExpress.XtraEditors.ComboBoxEdit();
            this.spcMaster.Panel1.SuspendLayout();
            this.spcMaster.Panel2.SuspendLayout();
            this.spcMaster.SuspendLayout();
            this.spcNav.Panel1.SuspendLayout();
            this.spcNav.Panel2.SuspendLayout();
            this.spcNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCashBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashBookLookupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashBookDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarGeneral)).BeginInit();
            this.navBarGeneral.SuspendLayout();
            this.navBarGroupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbExport.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // spcMaster
            // 
            // 
            // spcMaster.Panel2
            // 
            this.spcMaster.Panel2.Controls.Add(this.btnPrint);
            this.spcMaster.Panel2.Controls.Add(this.cmbExport);
            // 
            // spcNav
            // 
            // 
            // spcNav.Panel1
            // 
            this.spcNav.Panel1.Controls.Add(this.navBarGeneral);
            // 
            // spcNav.Panel2
            // 
            this.spcNav.Panel2.Controls.Add(this.dgCashBook);
            // 
            // MainImageList
            // 
            this.MainImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MainImageList.ImageStream")));
            this.MainImageList.Images.SetKeyName(0, "CHECKMRK.ICO");
            this.MainImageList.Images.SetKeyName(1, "DeleteFolderHS.png");
            this.MainImageList.Images.SetKeyName(2, "DeleteHS.png");
            this.MainImageList.Images.SetKeyName(3, "EditInformationHS.png");
            this.MainImageList.Images.SetKeyName(4, "error1.ico");
            this.MainImageList.Images.SetKeyName(5, "error.ico");
            this.MainImageList.Images.SetKeyName(6, "EXIT2.ICO");
            this.MainImageList.Images.SetKeyName(7, "FindHS.png");
            this.MainImageList.Images.SetKeyName(8, "groupH.ico");
            this.MainImageList.Images.SetKeyName(9, "INFO.ICO");
            this.MainImageList.Images.SetKeyName(10, "keys.ico");
            this.MainImageList.Images.SetKeyName(11, "MISC20.ICO");
            this.MainImageList.Images.SetKeyName(12, "PropertiesHS.png");
            this.MainImageList.Images.SetKeyName(13, "RefreshDocViewHS.png");
            this.MainImageList.Images.SetKeyName(14, "saveHS.png");
            this.MainImageList.Images.SetKeyName(15, "SETUP1.ICO");
            this.MainImageList.Images.SetKeyName(16, "ShowGridlinesHS.png");
            this.MainImageList.Images.SetKeyName(17, "ShowRulelinesHS.png");
            this.MainImageList.Images.SetKeyName(18, "TaskHS.png");
            this.MainImageList.Images.SetKeyName(19, "TaskNotHS.png");
            this.MainImageList.Images.SetKeyName(20, "TOOLS.ICO");
            this.MainImageList.Images.SetKeyName(21, "user.ico");
            this.MainImageList.Images.SetKeyName(22, "W95MBX01.ICO");
            this.MainImageList.Images.SetKeyName(23, "W95MBX02.ICO");
            this.MainImageList.Images.SetKeyName(24, "W95MBX03.ICO");
            this.MainImageList.Images.SetKeyName(25, "W95MBX04.ICO");
            this.MainImageList.Images.SetKeyName(26, "WRENCH.ICO");
            // 
            // dgCashBook
            // 
            this.dgCashBook.DataSource = this.cashBookLookupBindingSource;
            this.dgCashBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCashBook.EmbeddedNavigator.Name = "";
            this.dgCashBook.Location = new System.Drawing.Point(0, 0);
            this.dgCashBook.MainView = this.gridView1;
            this.dgCashBook.Name = "dgCashBook";
            this.dgCashBook.Size = new System.Drawing.Size(822, 526);
            this.dgCashBook.TabIndex = 0;
            this.dgCashBook.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // cashBookLookupBindingSource
            // 
            this.cashBookLookupBindingSource.DataMember = "CashBookLookup";
            this.cashBookLookupBindingSource.DataSource = this.cashBookDataset;
            // 
            // cashBookDataset
            // 
            this.cashBookDataset.DataSetName = "CashBookDataset";
            this.cashBookDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIID,
            this.colReceiptVoucher,
            this.colDeposit,
            this.colWithdraw,
            this.colTrDate,
            this.colDescription,
            this.colTotal});
            this.gridView1.GridControl = this.dgCashBook;
            this.gridView1.IndicatorWidth = 50;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            // 
            // colIID
            // 
            this.colIID.Caption = "IID";
            this.colIID.FieldName = "IID";
            this.colIID.Name = "colIID";
            // 
            // colReceiptVoucher
            // 
            this.colReceiptVoucher.Caption = "Voucher";
            this.colReceiptVoucher.FieldName = "ReceiptVoucher";
            this.colReceiptVoucher.Name = "colReceiptVoucher";
            this.colReceiptVoucher.OptionsColumn.FixedWidth = true;
            this.colReceiptVoucher.Visible = true;
            this.colReceiptVoucher.VisibleIndex = 1;
            this.colReceiptVoucher.Width = 95;
            // 
            // colDeposit
            // 
            this.colDeposit.Caption = "Deposit";
            this.colDeposit.DisplayFormat.FormatString = "#,###.00;(#,###.00);_";
            this.colDeposit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDeposit.FieldName = "Deposit";
            this.colDeposit.Name = "colDeposit";
            this.colDeposit.OptionsColumn.FixedWidth = true;
            this.colDeposit.SummaryItem.DisplayFormat = "{0:.00}";
            this.colDeposit.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colDeposit.Visible = true;
            this.colDeposit.VisibleIndex = 3;
            this.colDeposit.Width = 85;
            // 
            // colWithdraw
            // 
            this.colWithdraw.Caption = "Withdraw";
            this.colWithdraw.DisplayFormat.FormatString = "#,###.00;(#,###.00);_";
            this.colWithdraw.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colWithdraw.FieldName = "Withdraw";
            this.colWithdraw.Name = "colWithdraw";
            this.colWithdraw.OptionsColumn.FixedWidth = true;
            this.colWithdraw.SummaryItem.DisplayFormat = "{0:.00}";
            this.colWithdraw.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colWithdraw.Visible = true;
            this.colWithdraw.VisibleIndex = 4;
            this.colWithdraw.Width = 85;
            // 
            // colTrDate
            // 
            this.colTrDate.Caption = "Date";
            this.colTrDate.FieldName = "TrDate";
            this.colTrDate.Name = "colTrDate";
            this.colTrDate.OptionsColumn.FixedWidth = true;
            this.colTrDate.Visible = true;
            this.colTrDate.VisibleIndex = 0;
            this.colTrDate.Width = 85;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.SummaryItem.DisplayFormat = "Total {0} Row(s)";
            this.colDescription.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            this.colDescription.Width = 351;
            // 
            // colTotal
            // 
            this.colTotal.Caption = "Total";
            this.colTotal.DisplayFormat.FormatString = "#,###.00;(#,###.00);_";
            this.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.OptionsColumn.FixedWidth = true;
            this.colTotal.OptionsColumn.ReadOnly = true;
            this.colTotal.SummaryItem.DisplayFormat = "{0:.00}";
            this.colTotal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 5;
            this.colTotal.Width = 100;
            // 
            // navBarGeneral
            // 
            this.navBarGeneral.ActiveGroup = this.nbgGenerals;
            this.navBarGeneral.Controls.Add(this.navBarGroupControlContainer1);
            this.navBarGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarGeneral.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.nbgGenerals,
            this.navBarTask});
            this.navBarGeneral.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.nbiShow,
            this.nbiRefresh,
            this.nbiClose});
            this.navBarGeneral.LargeImages = this.MainImageList;
            this.navBarGeneral.Location = new System.Drawing.Point(0, 0);
            this.navBarGeneral.Name = "navBarGeneral";
            this.navBarGeneral.Size = new System.Drawing.Size(148, 526);
            this.navBarGeneral.SmallImages = this.MainImageList;
            this.navBarGeneral.TabIndex = 1;
            this.navBarGeneral.Text = "navBarControl1";
            // 
            // nbgGenerals
            // 
            this.nbgGenerals.Caption = "Generals";
            this.nbgGenerals.Expanded = true;
            this.nbgGenerals.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiShow),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiRefresh),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiClose)});
            this.nbgGenerals.Name = "nbgGenerals";
            // 
            // nbiShow
            // 
            this.nbiShow.Caption = "Show";
            this.nbiShow.Name = "nbiShow";
            this.nbiShow.SmallImageIndex = 16;
            this.nbiShow.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiShow_LinkClicked);
            // 
            // nbiRefresh
            // 
            this.nbiRefresh.Caption = "Refrsh";
            this.nbiRefresh.Name = "nbiRefresh";
            this.nbiRefresh.SmallImageIndex = 13;
            this.nbiRefresh.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiRefresh_LinkClicked);
            // 
            // nbiClose
            // 
            this.nbiClose.Caption = "Close";
            this.nbiClose.Name = "nbiClose";
            this.nbiClose.SmallImageIndex = 22;
            this.nbiClose.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiClose_LinkClicked);
            // 
            // navBarGroupControlContainer1
            // 
            this.navBarGroupControlContainer1.Controls.Add(this.labelControl5);
            this.navBarGroupControlContainer1.Controls.Add(this.btnGo);
            this.navBarGroupControlContainer1.Controls.Add(this.dtpFromDate);
            this.navBarGroupControlContainer1.Controls.Add(this.dtpToDate);
            this.navBarGroupControlContainer1.Name = "navBarGroupControlContainer1";
            this.navBarGroupControlContainer1.Size = new System.Drawing.Size(145, 96);
            this.navBarGroupControlContainer1.TabIndex = 0;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(68, 26);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(12, 13);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "To";
            // 
            // btnGo
            // 
            this.btnGo.ImageIndex = 16;
            this.btnGo.ImageList = this.MainImageList;
            this.btnGo.Location = new System.Drawing.Point(44, 68);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(60, 23);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Show";
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.EditValue = null;
            this.dtpFromDate.Location = new System.Drawing.Point(24, 3);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFromDate.Size = new System.Drawing.Size(100, 20);
            this.dtpFromDate.TabIndex = 1;
            // 
            // dtpToDate
            // 
            this.dtpToDate.EditValue = null;
            this.dtpToDate.Location = new System.Drawing.Point(24, 42);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpToDate.Size = new System.Drawing.Size(100, 20);
            this.dtpToDate.TabIndex = 0;
            // 
            // navBarTask
            // 
            this.navBarTask.Caption = "Task";
            this.navBarTask.ControlContainer = this.navBarGroupControlContainer1;
            this.navBarTask.Expanded = true;
            this.navBarTask.GroupClientHeight = 100;
            this.navBarTask.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.navBarTask.Name = "navBarTask";
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::MicroCredit.Properties.Resources.PRINTER;
            this.btnPrint.ImageList = this.MainImageList;
            this.btnPrint.Location = new System.Drawing.Point(84, 5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // cmbExport
            // 
            this.cmbExport.EditValue = "Export to ...";
            this.cmbExport.Location = new System.Drawing.Point(165, 6);
            this.cmbExport.Name = "cmbExport";
            this.cmbExport.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbExport.Properties.Items.AddRange(new object[] {
            "Excel",
            "PDF",
            "Word"});
            this.cmbExport.Size = new System.Drawing.Size(100, 20);
            this.cmbExport.TabIndex = 5;
            this.cmbExport.SelectedIndexChanged += new System.EventHandler(this.cmbExport_SelectedIndexChanged);
            // 
            // frmCashBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 564);
            this.FrmText = "Cash Book";
            this.Name = "frmCashBook";
            this.Text = "Cash Book";
            this.spcMaster.Panel1.ResumeLayout(false);
            this.spcMaster.Panel2.ResumeLayout(false);
            this.spcMaster.ResumeLayout(false);
            this.spcNav.Panel1.ResumeLayout(false);
            this.spcNav.Panel2.ResumeLayout(false);
            this.spcNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCashBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashBookLookupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashBookDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarGeneral)).EndInit();
            this.navBarGeneral.ResumeLayout(false);
            this.navBarGroupControlContainer1.ResumeLayout(false);
            this.navBarGroupControlContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbExport.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgCashBook;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource cashBookLookupBindingSource;
        private MicroCredit.DataSets.CashBookDataset cashBookDataset;
        private DevExpress.XtraGrid.Columns.GridColumn colIID;
        private DevExpress.XtraGrid.Columns.GridColumn colReceiptVoucher;
        private DevExpress.XtraGrid.Columns.GridColumn colDeposit;
        private DevExpress.XtraGrid.Columns.GridColumn colWithdraw;
        private DevExpress.XtraGrid.Columns.GridColumn colTrDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraNavBar.NavBarControl navBarGeneral;
        private DevExpress.XtraNavBar.NavBarGroup nbgGenerals;
        private DevExpress.XtraNavBar.NavBarItem nbiShow;
        private DevExpress.XtraNavBar.NavBarItem nbiRefresh;
        private DevExpress.XtraNavBar.NavBarItem nbiClose;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnGo;
        private DevExpress.XtraEditors.DateEdit dtpFromDate;
        private DevExpress.XtraEditors.DateEdit dtpToDate;
        private DevExpress.XtraNavBar.NavBarGroup navBarTask;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.ComboBoxEdit cmbExport;
    }
}