namespace MicroCredit.Forms
{
    partial class frmOfficeOthersIncomeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOfficeOthersIncomeView));
            this.dgOfficeOthersIncome = new DevExpress.XtraGrid.GridControl();
            this.officeIncomeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receiptDataset = new MicroCredit.DataSets.ReceiptDataset();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIncomeDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReceiptNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassbook = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdmission = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOthers = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReason = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgOfficeOthersIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeIncomeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptDataset)).BeginInit();
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
            this.spcMaster.Size = new System.Drawing.Size(1004, 574);
            this.spcMaster.SplitterDistance = 536;
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
            this.spcNav.Panel2.Controls.Add(this.dgOfficeOthersIncome);
            this.spcNav.Size = new System.Drawing.Size(1004, 536);
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
            // dgOfficeOthersIncome
            // 
            this.dgOfficeOthersIncome.DataSource = this.officeIncomeBindingSource;
            this.dgOfficeOthersIncome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgOfficeOthersIncome.EmbeddedNavigator.Name = "";
            this.dgOfficeOthersIncome.Location = new System.Drawing.Point(0, 0);
            this.dgOfficeOthersIncome.MainView = this.gridView1;
            this.dgOfficeOthersIncome.Name = "dgOfficeOthersIncome";
            this.dgOfficeOthersIncome.Size = new System.Drawing.Size(852, 536);
            this.dgOfficeOthersIncome.TabIndex = 0;
            this.dgOfficeOthersIncome.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // officeIncomeBindingSource
            // 
            this.officeIncomeBindingSource.DataMember = "OfficeIncome";
            this.officeIncomeBindingSource.DataSource = this.receiptDataset;
            // 
            // receiptDataset
            // 
            this.receiptDataset.DataSetName = "ReceiptDataset";
            this.receiptDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIID,
            this.colIncomeDate,
            this.colReceiptNo,
            this.colPassbook,
            this.colAdmission,
            this.colOthers,
            this.colReason,
            this.colTotal});
            this.gridView1.GridControl = this.dgOfficeOthersIncome;
            this.gridView1.IndicatorWidth = 55;
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
            // colIncomeDate
            // 
            this.colIncomeDate.Caption = "Date";
            this.colIncomeDate.FieldName = "IncomeDate";
            this.colIncomeDate.Name = "colIncomeDate";
            this.colIncomeDate.OptionsColumn.FixedWidth = true;
            this.colIncomeDate.Visible = true;
            this.colIncomeDate.VisibleIndex = 0;
            this.colIncomeDate.Width = 85;
            // 
            // colReceiptNo
            // 
            this.colReceiptNo.Caption = "Receipt/Voucher#";
            this.colReceiptNo.FieldName = "ReceiptNo";
            this.colReceiptNo.Name = "colReceiptNo";
            this.colReceiptNo.OptionsColumn.FixedWidth = true;
            this.colReceiptNo.SummaryItem.DisplayFormat = "{0} Row(s)    Total";
            this.colReceiptNo.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            this.colReceiptNo.Visible = true;
            this.colReceiptNo.VisibleIndex = 1;
            this.colReceiptNo.Width = 125;
            // 
            // colPassbook
            // 
            this.colPassbook.Caption = "Pass Book";
            this.colPassbook.DisplayFormat.FormatString = "#,###.00;(#,###.00);_";
            this.colPassbook.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colPassbook.FieldName = "Passbook";
            this.colPassbook.Name = "colPassbook";
            this.colPassbook.OptionsColumn.FixedWidth = true;
            this.colPassbook.SummaryItem.DisplayFormat = "{0:.00}";
            this.colPassbook.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colPassbook.Visible = true;
            this.colPassbook.VisibleIndex = 2;
            this.colPassbook.Width = 125;
            // 
            // colAdmission
            // 
            this.colAdmission.Caption = "Admission";
            this.colAdmission.DisplayFormat.FormatString = "#,###.00;(#,###.00);_";
            this.colAdmission.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colAdmission.FieldName = "Admission";
            this.colAdmission.Name = "colAdmission";
            this.colAdmission.OptionsColumn.FixedWidth = true;
            this.colAdmission.SummaryItem.DisplayFormat = "{0:.00}";
            this.colAdmission.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colAdmission.Visible = true;
            this.colAdmission.VisibleIndex = 3;
            this.colAdmission.Width = 125;
            // 
            // colOthers
            // 
            this.colOthers.Caption = "Others";
            this.colOthers.DisplayFormat.FormatString = "#,###.00;(#,###.00);_";
            this.colOthers.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colOthers.FieldName = "Others";
            this.colOthers.Name = "colOthers";
            this.colOthers.OptionsColumn.FixedWidth = true;
            this.colOthers.SummaryItem.DisplayFormat = "{0:.00}";
            this.colOthers.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colOthers.Visible = true;
            this.colOthers.VisibleIndex = 4;
            this.colOthers.Width = 125;
            // 
            // colReason
            // 
            this.colReason.AppearanceCell.Options.UseTextOptions = true;
            this.colReason.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colReason.AppearanceHeader.Options.UseTextOptions = true;
            this.colReason.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colReason.Caption = "Reason";
            this.colReason.FieldName = "Reason";
            this.colReason.Name = "colReason";
            this.colReason.Visible = true;
            this.colReason.VisibleIndex = 5;
            this.colReason.Width = 133;
            // 
            // colTotal
            // 
            this.colTotal.Caption = "Total";
            this.colTotal.DisplayFormat.FormatString = "#,###.00;(#,###.00);_";
            this.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.OptionsColumn.FixedWidth = true;
            this.colTotal.SummaryItem.DisplayFormat = "{0:.00}";
            this.colTotal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 6;
            this.colTotal.Width = 125;
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
            this.navBarGeneral.Size = new System.Drawing.Size(148, 536);
            this.navBarGeneral.SmallImages = this.MainImageList;
            this.navBarGeneral.TabIndex = 2;
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
            this.btnPrint.TabIndex = 2;
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
            this.cmbExport.TabIndex = 3;
            this.cmbExport.SelectedIndexChanged += new System.EventHandler(this.cmbExport_SelectedIndexChanged);
            // 
            // frmOfficeOthersIncomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 574);
            this.FrmText = "Office Others Income[View]";
            this.Name = "frmOfficeOthersIncomeView";
            this.Text = "Office Others Income[View]";
            this.spcMaster.Panel1.ResumeLayout(false);
            this.spcMaster.Panel2.ResumeLayout(false);
            this.spcMaster.ResumeLayout(false);
            this.spcNav.Panel1.ResumeLayout(false);
            this.spcNav.Panel2.ResumeLayout(false);
            this.spcNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOfficeOthersIncome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeIncomeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptDataset)).EndInit();
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

        private DevExpress.XtraGrid.GridControl dgOfficeOthersIncome;
        private System.Windows.Forms.BindingSource officeIncomeBindingSource;
        private MicroCredit.DataSets.ReceiptDataset receiptDataset;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIID;
        private DevExpress.XtraGrid.Columns.GridColumn colIncomeDate;
        private DevExpress.XtraGrid.Columns.GridColumn colReceiptNo;
        private DevExpress.XtraGrid.Columns.GridColumn colPassbook;
        private DevExpress.XtraGrid.Columns.GridColumn colAdmission;
        private DevExpress.XtraGrid.Columns.GridColumn colOthers;
        private DevExpress.XtraGrid.Columns.GridColumn colReason;
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
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.ComboBoxEdit cmbExport;
    }
}