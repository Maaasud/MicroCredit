namespace MicroCredit.Forms
{
    partial class frmLoanStatusView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoanStatusView));
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.imgPhoto = new System.Windows.Forms.PictureBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtLAddress = new DevExpress.XtraEditors.TextEdit();
            this.txtLDistrict = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtLpostCode = new DevExpress.XtraEditors.TextEdit();
            this.txtLPostOffice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtLThana = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtLVillage = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtLoanAmount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cmbLoanNumber = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dtpLoanDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtFatherHusbandName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtFullName = new DevExpress.XtraEditors.TextEdit();
            this.cmbPolicy = new DevExpress.XtraEditors.LookUpEdit();
            this.dgLoanStatus = new DevExpress.XtraGrid.GridControl();
            this.loanDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loanDataset = new MicroCredit.DataSets.LoanDataset();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoanID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInstallmentDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInstallmentSerial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReceiptNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCapital = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInterest = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInstallNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.cmbExport = new DevExpress.XtraEditors.ComboBoxEdit();
            this.spcMaster.Panel1.SuspendLayout();
            this.spcMaster.Panel2.SuspendLayout();
            this.spcMaster.SuspendLayout();
            this.spcNav.Panel1.SuspendLayout();
            this.spcNav.Panel2.SuspendLayout();
            this.spcNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLDistrict.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLpostCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLPostOffice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLThana.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLVillage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoanAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLoanNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpLoanDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFatherHusbandName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPolicy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLoanStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.spcMaster.Panel2.Controls.Add(this.btnRefresh);
            // 
            // spcNav
            // 
            this.spcNav.IsSplitterFixed = false;
            this.spcNav.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcNav.Panel1
            // 
            this.spcNav.Panel1.Controls.Add(this.groupControl3);
            this.spcNav.Panel1.Controls.Add(this.groupControl2);
            this.spcNav.Panel1.Controls.Add(this.groupControl1);
            // 
            // spcNav.Panel2
            // 
            this.spcNav.Panel2.Controls.Add(this.dgLoanStatus);
            this.spcNav.TabStop = true;
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
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.imgPhoto);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(678, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(296, 148);
            this.groupControl3.TabIndex = 66;
            this.groupControl3.Text = "Photo";
            // 
            // imgPhoto
            // 
            this.imgPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgPhoto.Location = new System.Drawing.Point(57, 33);
            this.imgPhoto.Name = "imgPhoto";
            this.imgPhoto.Size = new System.Drawing.Size(97, 94);
            this.imgPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPhoto.TabIndex = 54;
            this.imgPhoto.TabStop = false;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txtLAddress);
            this.groupControl2.Controls.Add(this.txtLDistrict);
            this.groupControl2.Controls.Add(this.labelControl13);
            this.groupControl2.Controls.Add(this.txtLpostCode);
            this.groupControl2.Controls.Add(this.txtLPostOffice);
            this.groupControl2.Controls.Add(this.labelControl12);
            this.groupControl2.Controls.Add(this.txtLThana);
            this.groupControl2.Controls.Add(this.labelControl11);
            this.groupControl2.Controls.Add(this.txtLVillage);
            this.groupControl2.Controls.Add(this.labelControl10);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl2.Location = new System.Drawing.Point(352, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(326, 148);
            this.groupControl2.TabIndex = 65;
            this.groupControl2.Text = "Present Address";
            // 
            // txtLAddress
            // 
            this.txtLAddress.Location = new System.Drawing.Point(74, 30);
            this.txtLAddress.Name = "txtLAddress";
            this.txtLAddress.Properties.ReadOnly = true;
            this.txtLAddress.Size = new System.Drawing.Size(206, 20);
            this.txtLAddress.TabIndex = 19;
            this.txtLAddress.TabStop = false;
            // 
            // txtLDistrict
            // 
            this.txtLDistrict.Location = new System.Drawing.Point(74, 119);
            this.txtLDistrict.Name = "txtLDistrict";
            this.txtLDistrict.Properties.ReadOnly = true;
            this.txtLDistrict.Size = new System.Drawing.Size(206, 20);
            this.txtLDistrict.TabIndex = 24;
            this.txtLDistrict.TabStop = false;
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(31, 123);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(33, 13);
            this.labelControl13.TabIndex = 28;
            this.labelControl13.Text = "District";
            // 
            // txtLpostCode
            // 
            this.txtLpostCode.Location = new System.Drawing.Point(216, 97);
            this.txtLpostCode.Name = "txtLpostCode";
            this.txtLpostCode.Properties.ReadOnly = true;
            this.txtLpostCode.Size = new System.Drawing.Size(64, 20);
            this.txtLpostCode.TabIndex = 23;
            this.txtLpostCode.TabStop = false;
            // 
            // txtLPostOffice
            // 
            this.txtLPostOffice.Location = new System.Drawing.Point(74, 97);
            this.txtLPostOffice.Name = "txtLPostOffice";
            this.txtLPostOffice.Properties.ReadOnly = true;
            this.txtLPostOffice.Size = new System.Drawing.Size(136, 20);
            this.txtLPostOffice.TabIndex = 22;
            this.txtLPostOffice.TabStop = false;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(21, 101);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(47, 13);
            this.labelControl12.TabIndex = 27;
            this.labelControl12.Text = "P/O|Code";
            // 
            // txtLThana
            // 
            this.txtLThana.Location = new System.Drawing.Point(74, 74);
            this.txtLThana.Name = "txtLThana";
            this.txtLThana.Properties.ReadOnly = true;
            this.txtLThana.Size = new System.Drawing.Size(206, 20);
            this.txtLThana.TabIndex = 21;
            this.txtLThana.TabStop = false;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(38, 78);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(30, 13);
            this.labelControl11.TabIndex = 26;
            this.labelControl11.Text = "Thana";
            // 
            // txtLVillage
            // 
            this.txtLVillage.Location = new System.Drawing.Point(74, 52);
            this.txtLVillage.Name = "txtLVillage";
            this.txtLVillage.Properties.ReadOnly = true;
            this.txtLVillage.Size = new System.Drawing.Size(206, 20);
            this.txtLVillage.TabIndex = 20;
            this.txtLVillage.TabStop = false;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(38, 56);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(30, 13);
            this.labelControl10.TabIndex = 25;
            this.labelControl10.Text = "Village";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtLoanAmount);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.cmbLoanNumber);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.dtpLoanDate);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtFatherHusbandName);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtFullName);
            this.groupControl1.Controls.Add(this.cmbPolicy);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(352, 148);
            this.groupControl1.TabIndex = 64;
            this.groupControl1.Text = "Policy && Member";
            // 
            // txtLoanAmount
            // 
            this.txtLoanAmount.Location = new System.Drawing.Point(231, 120);
            this.txtLoanAmount.Name = "txtLoanAmount";
            this.txtLoanAmount.Properties.DisplayFormat.FormatString = "{0:.00}";
            this.txtLoanAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtLoanAmount.Properties.ReadOnly = true;
            this.txtLoanAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLoanAmount.Size = new System.Drawing.Size(95, 20);
            this.txtLoanAmount.TabIndex = 63;
            this.txtLoanAmount.TabStop = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(59, 47);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(63, 13);
            this.labelControl5.TabIndex = 62;
            this.labelControl5.Text = "Loan Number";
            // 
            // cmbLoanNumber
            // 
            this.cmbLoanNumber.Location = new System.Drawing.Point(128, 44);
            this.cmbLoanNumber.Name = "cmbLoanNumber";
            this.cmbLoanNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbLoanNumber.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IID", "IID", 34, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LoanID", "LoanID", 40, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PolicyID", "PolicyID", 44, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TotalLoanAmount", "TotalLoanAmount", 90, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PerInstallmentAmount", "PerInstallmentAmount", 112, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TotalAmountPaid", "TotalAmountPaid", 87, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SaveDate", "SaveDate", 53, DevExpress.Utils.FormatType.DateTime, "M/d/yyyy", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LoanNumber", "LoanNumber", 66, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LoanStatus", "LoanStatus", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ApproveDate", "Date", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.cmbLoanNumber.Properties.DisplayMember = "LoanNumber";
            this.cmbLoanNumber.Properties.DropDownRows = 10;
            this.cmbLoanNumber.Properties.NullText = "[Select Loan]";
            this.cmbLoanNumber.Properties.ShowFooter = false;
            this.cmbLoanNumber.Properties.ShowHeader = false;
            this.cmbLoanNumber.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbLoanNumber.Properties.ValueMember = "LoanID";
            this.cmbLoanNumber.Size = new System.Drawing.Size(198, 20);
            this.cmbLoanNumber.TabIndex = 61;
            this.cmbLoanNumber.EditValueChanged += new System.EventHandler(this.cmbLoanNumber_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(55, 22);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(67, 13);
            this.labelControl3.TabIndex = 55;
            this.labelControl3.Text = "Policy Number";
            // 
            // dtpLoanDate
            // 
            this.dtpLoanDate.EditValue = null;
            this.dtpLoanDate.Location = new System.Drawing.Point(128, 120);
            this.dtpLoanDate.Name = "dtpLoanDate";
            this.dtpLoanDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpLoanDate.Properties.ReadOnly = true;
            this.dtpLoanDate.Size = new System.Drawing.Size(97, 20);
            this.dtpLoanDate.TabIndex = 60;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(48, 72);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 13);
            this.labelControl1.TabIndex = 49;
            this.labelControl1.Text = "Applicant Name";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 98);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(108, 13);
            this.labelControl2.TabIndex = 51;
            this.labelControl2.Text = "Father/Husband Name";
            // 
            // txtFatherHusbandName
            // 
            this.txtFatherHusbandName.Location = new System.Drawing.Point(128, 95);
            this.txtFatherHusbandName.Name = "txtFatherHusbandName";
            this.txtFatherHusbandName.Properties.ReadOnly = true;
            this.txtFatherHusbandName.Size = new System.Drawing.Size(198, 20);
            this.txtFatherHusbandName.TabIndex = 50;
            this.txtFatherHusbandName.TabStop = false;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(26, 122);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(96, 13);
            this.labelControl4.TabIndex = 57;
            this.labelControl4.Text = "Loan Date | Amount";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(128, 69);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Properties.ReadOnly = true;
            this.txtFullName.Size = new System.Drawing.Size(198, 20);
            this.txtFullName.TabIndex = 48;
            this.txtFullName.TabStop = false;
            // 
            // cmbPolicy
            // 
            this.cmbPolicy.Location = new System.Drawing.Point(128, 19);
            this.cmbPolicy.Name = "cmbPolicy";
            this.cmbPolicy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPolicy.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IID", "IID", 34, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PolicyNumber", "PolicyNumber", 70, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MemberID", "MemberID", 55, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullName", "FullName", 49, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.cmbPolicy.Properties.DisplayMember = "PolicyNumber";
            this.cmbPolicy.Properties.DropDownRows = 10;
            this.cmbPolicy.Properties.NullText = "[Select Policy]";
            this.cmbPolicy.Properties.ShowFooter = false;
            this.cmbPolicy.Properties.ShowHeader = false;
            this.cmbPolicy.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbPolicy.Properties.ValueMember = "IID";
            this.cmbPolicy.Size = new System.Drawing.Size(198, 20);
            this.cmbPolicy.TabIndex = 47;
            this.cmbPolicy.EditValueChanged += new System.EventHandler(this.cmbPolicy_EditValueChanged);
            // 
            // dgLoanStatus
            // 
            this.dgLoanStatus.DataSource = this.loanDetailsBindingSource;
            this.dgLoanStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgLoanStatus.EmbeddedNavigator.Name = "";
            this.dgLoanStatus.Location = new System.Drawing.Point(0, 0);
            this.dgLoanStatus.MainView = this.gridView1;
            this.dgLoanStatus.Name = "dgLoanStatus";
            this.dgLoanStatus.Size = new System.Drawing.Size(974, 374);
            this.dgLoanStatus.TabIndex = 1;
            this.dgLoanStatus.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // loanDetailsBindingSource
            // 
            this.loanDetailsBindingSource.DataMember = "LoanDetails";
            this.loanDetailsBindingSource.DataSource = this.loanDataset;
            // 
            // loanDataset
            // 
            this.loanDataset.DataSetName = "LoanDataset";
            this.loanDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIID,
            this.colLoanID,
            this.colInstallmentDate,
            this.colInstallmentSerial,
            this.colReceiptNo,
            this.colCapital,
            this.colInterest,
            this.colTotalAmount,
            this.colInstallNo});
            this.gridView1.GridControl = this.dgLoanStatus;
            this.gridView1.IndicatorWidth = 65;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIID
            // 
            this.colIID.Caption = "IID";
            this.colIID.FieldName = "IID";
            this.colIID.Name = "colIID";
            // 
            // colLoanID
            // 
            this.colLoanID.Caption = "LoanID";
            this.colLoanID.FieldName = "LoanID";
            this.colLoanID.Name = "colLoanID";
            // 
            // colInstallmentDate
            // 
            this.colInstallmentDate.Caption = "Date";
            this.colInstallmentDate.FieldName = "InstallmentDate";
            this.colInstallmentDate.Name = "colInstallmentDate";
            this.colInstallmentDate.OptionsColumn.FixedWidth = true;
            this.colInstallmentDate.SummaryItem.DisplayFormat = "Total Installment";
            this.colInstallmentDate.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            this.colInstallmentDate.Visible = true;
            this.colInstallmentDate.VisibleIndex = 0;
            this.colInstallmentDate.Width = 125;
            // 
            // colInstallmentSerial
            // 
            this.colInstallmentSerial.Caption = "InstallmentSerial";
            this.colInstallmentSerial.FieldName = "InstallmentSerial";
            this.colInstallmentSerial.Name = "colInstallmentSerial";
            // 
            // colReceiptNo
            // 
            this.colReceiptNo.Caption = "ReceiptNo";
            this.colReceiptNo.FieldName = "ReceiptNo";
            this.colReceiptNo.Name = "colReceiptNo";
            this.colReceiptNo.Visible = true;
            this.colReceiptNo.VisibleIndex = 2;
            this.colReceiptNo.Width = 375;
            // 
            // colCapital
            // 
            this.colCapital.Caption = "Capital";
            this.colCapital.DisplayFormat.FormatString = "#,###.00;(#,###.00);_";
            this.colCapital.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colCapital.FieldName = "Capital";
            this.colCapital.Name = "colCapital";
            this.colCapital.OptionsColumn.FixedWidth = true;
            this.colCapital.SummaryItem.DisplayFormat = "{0:.00}";
            this.colCapital.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colCapital.Visible = true;
            this.colCapital.VisibleIndex = 3;
            this.colCapital.Width = 125;
            // 
            // colInterest
            // 
            this.colInterest.Caption = "Interest";
            this.colInterest.DisplayFormat.FormatString = "#,###.00;(#,###.00);_";
            this.colInterest.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colInterest.FieldName = "Interest";
            this.colInterest.Name = "colInterest";
            this.colInterest.OptionsColumn.FixedWidth = true;
            this.colInterest.SummaryItem.DisplayFormat = "{0:.00}";
            this.colInterest.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colInterest.Visible = true;
            this.colInterest.VisibleIndex = 4;
            this.colInterest.Width = 125;
            // 
            // colTotalAmount
            // 
            this.colTotalAmount.Caption = "Total Amount";
            this.colTotalAmount.DisplayFormat.FormatString = "#,###.00;(#,###.00);_";
            this.colTotalAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colTotalAmount.FieldName = "TotalAmount";
            this.colTotalAmount.Name = "colTotalAmount";
            this.colTotalAmount.OptionsColumn.FixedWidth = true;
            this.colTotalAmount.SummaryItem.DisplayFormat = "{0:.00}";
            this.colTotalAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colTotalAmount.Visible = true;
            this.colTotalAmount.VisibleIndex = 5;
            this.colTotalAmount.Width = 125;
            // 
            // colInstallNo
            // 
            this.colInstallNo.AppearanceCell.Options.UseTextOptions = true;
            this.colInstallNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colInstallNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colInstallNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colInstallNo.Caption = "#";
            this.colInstallNo.FieldName = "InstallNo";
            this.colInstallNo.Name = "colInstallNo";
            this.colInstallNo.OptionsColumn.FixedWidth = true;
            this.colInstallNo.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colInstallNo.Visible = true;
            this.colInstallNo.VisibleIndex = 1;
            this.colInstallNo.Width = 30;
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageIndex = 13;
            this.btnRefresh.ImageList = this.MainImageList;
            this.btnRefresh.Location = new System.Drawing.Point(84, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::MicroCredit.Properties.Resources.PRINTER;
            this.btnPrint.ImageList = this.MainImageList;
            this.btnPrint.Location = new System.Drawing.Point(165, 5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // cmbExport
            // 
            this.cmbExport.EditValue = "Export to ...";
            this.cmbExport.Location = new System.Drawing.Point(246, 6);
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
            // frmLoanStatusView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 564);
            this.FrmText = "Individual Loan Collection";
            this.Name = "frmLoanStatusView";
            this.Text = "Individual Loan Collection";
            this.spcMaster.Panel1.ResumeLayout(false);
            this.spcMaster.Panel2.ResumeLayout(false);
            this.spcMaster.ResumeLayout(false);
            this.spcNav.Panel1.ResumeLayout(false);
            this.spcNav.Panel2.ResumeLayout(false);
            this.spcNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLDistrict.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLpostCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLPostOffice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLThana.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLVillage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoanAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLoanNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpLoanDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFatherHusbandName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPolicy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLoanStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbExport.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.PictureBox imgPhoto;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit txtLAddress;
        private DevExpress.XtraEditors.TextEdit txtLDistrict;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit txtLpostCode;
        private DevExpress.XtraEditors.TextEdit txtLPostOffice;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txtLThana;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtLVillage;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit dtpLoanDate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtFatherHusbandName;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtFullName;
        private DevExpress.XtraEditors.LookUpEdit cmbPolicy;
        private DevExpress.XtraGrid.GridControl dgLoanStatus;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LookUpEdit cmbLoanNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colIID;
        private DevExpress.XtraGrid.Columns.GridColumn colLoanID;
        private DevExpress.XtraGrid.Columns.GridColumn colInstallmentDate;
        private DevExpress.XtraGrid.Columns.GridColumn colInstallmentSerial;
        private DevExpress.XtraGrid.Columns.GridColumn colReceiptNo;
        private DevExpress.XtraGrid.Columns.GridColumn colCapital;
        private DevExpress.XtraGrid.Columns.GridColumn colInterest;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalAmount;
        private DevExpress.XtraEditors.TextEdit txtLoanAmount;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.ComboBoxEdit cmbExport;
        private System.Windows.Forms.BindingSource loanDetailsBindingSource;
        private MicroCredit.DataSets.LoanDataset loanDataset;
        private DevExpress.XtraGrid.Columns.GridColumn colInstallNo;

    }
}