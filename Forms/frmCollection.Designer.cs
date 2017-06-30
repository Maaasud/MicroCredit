namespace MicroCredit.Forms
{
    partial class frmCollection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCollection));
            this.spcBody = new System.Windows.Forms.SplitContainer();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.nubLoan = new DevExpress.XtraEditors.SpinEdit();
            this.txtAmountperDeposit = new DevExpress.XtraEditors.TextEdit();
            this.nudDeposit = new DevExpress.XtraEditors.SpinEdit();
            this.txtLoan = new DevExpress.XtraEditors.TextEdit();
            this.cmbReason = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtOthers = new DevExpress.XtraEditors.TextEdit();
            this.txtInterest = new DevExpress.XtraEditors.TextEdit();
            this.lblCapital = new DevExpress.XtraEditors.LabelControl();
            this.txtAdmission = new DevExpress.XtraEditors.TextEdit();
            this.txtCapital = new DevExpress.XtraEditors.TextEdit();
            this.chkAdmissionFee = new DevExpress.XtraEditors.CheckEdit();
            this.chkOthers = new DevExpress.XtraEditors.CheckEdit();
            this.lblInterest = new DevExpress.XtraEditors.LabelControl();
            this.chkPassbookForm = new DevExpress.XtraEditors.CheckEdit();
            this.txtPassbook = new DevExpress.XtraEditors.TextEdit();
            this.chkLoan = new DevExpress.XtraEditors.CheckEdit();
            this.chkDeposit = new DevExpress.XtraEditors.CheckEdit();
            this.txtDeposit = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cmbPolicy = new DevExpress.XtraEditors.LookUpEdit();
            this.txtReceiptNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtpReceiptDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMemberName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dgReceipt = new DevExpress.XtraGrid.GridControl();
            this.ctxExpCol = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.expandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPolicyID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMemberID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMemberCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReceiptNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdmissionFee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassbookFormFee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeposit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoanCapital = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoanProfit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOtherCharges = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPolicyNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.receiptDataset1 = new MicroCredit.DataSets.ReceiptDataset();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.cmbExport = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbEmployee = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.employeeDataset = new MicroCredit.DataSets.EmployeeDataset();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colEmployee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spcMaster.Panel1.SuspendLayout();
            this.spcMaster.Panel2.SuspendLayout();
            this.spcMaster.SuspendLayout();
            this.spcNav.Panel1.SuspendLayout();
            this.spcNav.Panel2.SuspendLayout();
            this.spcNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainErrorProvider)).BeginInit();
            this.spcBody.Panel1.SuspendLayout();
            this.spcBody.Panel2.SuspendLayout();
            this.spcBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nubLoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmountperDeposit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeposit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbReason.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOthers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInterest.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdmission.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapital.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAdmissionFee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkOthers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPassbookForm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassbook.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkLoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDeposit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeposit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPolicy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReceiptNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpReceiptDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpReceiptDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMemberName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReceipt)).BeginInit();
            this.ctxExpCol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarGeneral)).BeginInit();
            this.navBarGeneral.SuspendLayout();
            this.navBarGroupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptDataset1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbExport.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEmployee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // spcMaster
            // 
            // 
            // spcMaster.Panel2
            // 
            this.spcMaster.Panel2.Controls.Add(this.btnPrint);
            this.spcMaster.Panel2.Controls.Add(this.cmbExport);
            this.spcMaster.Size = new System.Drawing.Size(1117, 564);
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
            this.spcNav.Panel2.Controls.Add(this.spcBody);
            this.spcNav.Size = new System.Drawing.Size(1117, 526);
            // 
            // btnClose
            // 
            this.btnClose.TabIndex = 0;
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
            // spcBody
            // 
            this.spcBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcBody.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spcBody.IsSplitterFixed = true;
            this.spcBody.Location = new System.Drawing.Point(0, 0);
            this.spcBody.Name = "spcBody";
            this.spcBody.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcBody.Panel1
            // 
            this.spcBody.Panel1.Controls.Add(this.groupControl2);
            this.spcBody.Panel1.Controls.Add(this.groupControl1);
            // 
            // spcBody.Panel2
            // 
            this.spcBody.Panel2.Controls.Add(this.dgReceipt);
            this.spcBody.Size = new System.Drawing.Size(965, 526);
            this.spcBody.SplitterDistance = 149;
            this.spcBody.TabIndex = 0;
            this.spcBody.TabStop = false;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.nubLoan);
            this.groupControl2.Controls.Add(this.txtAmountperDeposit);
            this.groupControl2.Controls.Add(this.nudDeposit);
            this.groupControl2.Controls.Add(this.txtLoan);
            this.groupControl2.Controls.Add(this.cmbReason);
            this.groupControl2.Controls.Add(this.btnCancel);
            this.groupControl2.Controls.Add(this.btnSave);
            this.groupControl2.Controls.Add(this.txtOthers);
            this.groupControl2.Controls.Add(this.txtInterest);
            this.groupControl2.Controls.Add(this.lblCapital);
            this.groupControl2.Controls.Add(this.txtAdmission);
            this.groupControl2.Controls.Add(this.txtCapital);
            this.groupControl2.Controls.Add(this.chkAdmissionFee);
            this.groupControl2.Controls.Add(this.chkOthers);
            this.groupControl2.Controls.Add(this.lblInterest);
            this.groupControl2.Controls.Add(this.chkPassbookForm);
            this.groupControl2.Controls.Add(this.txtPassbook);
            this.groupControl2.Controls.Add(this.chkLoan);
            this.groupControl2.Controls.Add(this.chkDeposit);
            this.groupControl2.Controls.Add(this.txtDeposit);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(263, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(702, 149);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Details";
            // 
            // nubLoan
            // 
            this.nubLoan.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nubLoan.Location = new System.Drawing.Point(138, 31);
            this.nubLoan.Name = "nubLoan";
            this.nubLoan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.nubLoan.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nubLoan.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nubLoan.Size = new System.Drawing.Size(44, 20);
            this.nubLoan.TabIndex = 1;
            this.nubLoan.EditValueChanged += new System.EventHandler(this.nubLoan_EditValueChanged);
            this.nubLoan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nubLoan_KeyDown);
            // 
            // txtAmountperDeposit
            // 
            this.txtAmountperDeposit.EditValue = "0";
            this.txtAmountperDeposit.Location = new System.Drawing.Point(188, 78);
            this.txtAmountperDeposit.Name = "txtAmountperDeposit";
            this.txtAmountperDeposit.Properties.ReadOnly = true;
            this.txtAmountperDeposit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAmountperDeposit.Size = new System.Drawing.Size(45, 20);
            this.txtAmountperDeposit.TabIndex = 18;
            this.txtAmountperDeposit.TabStop = false;
            this.txtAmountperDeposit.EditValueChanged += new System.EventHandler(this.txtAmountperDeposit_EditValueChanged);
            // 
            // nudDeposit
            // 
            this.nudDeposit.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDeposit.Location = new System.Drawing.Point(138, 78);
            this.nudDeposit.Name = "nudDeposit";
            this.nudDeposit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.nudDeposit.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudDeposit.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDeposit.Size = new System.Drawing.Size(44, 20);
            this.nudDeposit.TabIndex = 3;
            this.nudDeposit.EditValueChanged += new System.EventHandler(this.nudDeposit_EditValueChanged);
            this.nudDeposit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudDeposit_KeyDown);
            // 
            // txtLoan
            // 
            this.txtLoan.EditValue = "0";
            this.txtLoan.Location = new System.Drawing.Point(216, 31);
            this.txtLoan.Name = "txtLoan";
            this.txtLoan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLoan.Size = new System.Drawing.Size(68, 20);
            this.txtLoan.TabIndex = 1;
            this.txtLoan.TabStop = false;
            this.txtLoan.Visible = false;
            this.txtLoan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLoan_KeyDown);
            this.txtLoan.Leave += new System.EventHandler(this.txtLoan_Leave);
            this.txtLoan.Validated += new System.EventHandler(this.txtLoan_Validated);
            // 
            // cmbReason
            // 
            this.cmbReason.Location = new System.Drawing.Point(386, 78);
            this.cmbReason.Name = "cmbReason";
            this.cmbReason.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbReason.Size = new System.Drawing.Size(105, 20);
            this.cmbReason.TabIndex = 9;
            this.cmbReason.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.ImageIndex = 2;
            this.btnCancel.ImageList = this.MainImageList;
            this.btnCancel.Location = new System.Drawing.Point(319, 108);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageIndex = 14;
            this.btnSave.ImageList = this.MainImageList;
            this.btnSave.Location = new System.Drawing.Point(237, 108);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtOthers
            // 
            this.txtOthers.EditValue = "0";
            this.txtOthers.Location = new System.Drawing.Point(497, 78);
            this.txtOthers.Name = "txtOthers";
            this.txtOthers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtOthers.Size = new System.Drawing.Size(45, 20);
            this.txtOthers.TabIndex = 10;
            this.txtOthers.Visible = false;
            this.txtOthers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOthers_KeyDown);
            this.txtOthers.Leave += new System.EventHandler(this.txtCapital_Leave);
            this.txtOthers.Validated += new System.EventHandler(this.txtLoan_Validated);
            // 
            // txtInterest
            // 
            this.txtInterest.EditValue = "0";
            this.txtInterest.Location = new System.Drawing.Point(239, 55);
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtInterest.Size = new System.Drawing.Size(45, 20);
            this.txtInterest.TabIndex = 3;
            this.txtInterest.TabStop = false;
            this.txtInterest.Visible = false;
            this.txtInterest.Leave += new System.EventHandler(this.txtCapital_Leave);
            this.txtInterest.Validated += new System.EventHandler(this.txtLoan_Validated);
            // 
            // lblCapital
            // 
            this.lblCapital.Location = new System.Drawing.Point(99, 59);
            this.lblCapital.Name = "lblCapital";
            this.lblCapital.Size = new System.Drawing.Size(33, 13);
            this.lblCapital.TabIndex = 14;
            this.lblCapital.Text = "Capital";
            this.lblCapital.Visible = false;
            // 
            // txtAdmission
            // 
            this.txtAdmission.EditValue = "0";
            this.txtAdmission.Location = new System.Drawing.Point(497, 55);
            this.txtAdmission.Name = "txtAdmission";
            this.txtAdmission.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAdmission.Size = new System.Drawing.Size(45, 20);
            this.txtAdmission.TabIndex = 7;
            this.txtAdmission.Visible = false;
            this.txtAdmission.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAdmission_KeyDown);
            this.txtAdmission.Leave += new System.EventHandler(this.txtCapital_Leave);
            this.txtAdmission.Validated += new System.EventHandler(this.txtLoan_Validated);
            // 
            // txtCapital
            // 
            this.txtCapital.EditValue = "0";
            this.txtCapital.Location = new System.Drawing.Point(138, 55);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Properties.ReadOnly = true;
            this.txtCapital.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCapital.Size = new System.Drawing.Size(45, 20);
            this.txtCapital.TabIndex = 2;
            this.txtCapital.TabStop = false;
            this.txtCapital.Visible = false;
            this.txtCapital.Leave += new System.EventHandler(this.txtCapital_Leave);
            this.txtCapital.Validated += new System.EventHandler(this.txtLoan_Validated);
            // 
            // chkAdmissionFee
            // 
            this.chkAdmissionFee.Location = new System.Drawing.Point(322, 56);
            this.chkAdmissionFee.Name = "chkAdmissionFee";
            this.chkAdmissionFee.Properties.Caption = "Admission";
            this.chkAdmissionFee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkAdmissionFee.Size = new System.Drawing.Size(72, 19);
            this.chkAdmissionFee.TabIndex = 6;
            this.chkAdmissionFee.CheckedChanged += new System.EventHandler(this.chkAdmissionFee_CheckedChanged);
            // 
            // chkOthers
            // 
            this.chkOthers.Location = new System.Drawing.Point(322, 79);
            this.chkOthers.Name = "chkOthers";
            this.chkOthers.Properties.Caption = "Others";
            this.chkOthers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkOthers.Size = new System.Drawing.Size(57, 19);
            this.chkOthers.TabIndex = 8;
            this.chkOthers.CheckedChanged += new System.EventHandler(this.chkOthers_CheckedChanged);
            // 
            // lblInterest
            // 
            this.lblInterest.Location = new System.Drawing.Point(194, 59);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(39, 13);
            this.lblInterest.TabIndex = 16;
            this.lblInterest.Text = "Interest";
            this.lblInterest.Visible = false;
            // 
            // chkPassbookForm
            // 
            this.chkPassbookForm.Location = new System.Drawing.Point(322, 32);
            this.chkPassbookForm.Name = "chkPassbookForm";
            this.chkPassbookForm.Properties.Caption = "Pass Book/ Form";
            this.chkPassbookForm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkPassbookForm.Size = new System.Drawing.Size(105, 19);
            this.chkPassbookForm.TabIndex = 4;
            this.chkPassbookForm.CheckedChanged += new System.EventHandler(this.chkPassbookForm_CheckedChanged);
            // 
            // txtPassbook
            // 
            this.txtPassbook.EditValue = "0";
            this.txtPassbook.Location = new System.Drawing.Point(497, 31);
            this.txtPassbook.Name = "txtPassbook";
            this.txtPassbook.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPassbook.Size = new System.Drawing.Size(45, 20);
            this.txtPassbook.TabIndex = 5;
            this.txtPassbook.Visible = false;
            this.txtPassbook.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassbook_KeyDown);
            this.txtPassbook.Leave += new System.EventHandler(this.txtCapital_Leave);
            this.txtPassbook.Validated += new System.EventHandler(this.txtLoan_Validated);
            // 
            // chkLoan
            // 
            this.chkLoan.Location = new System.Drawing.Point(64, 32);
            this.chkLoan.Name = "chkLoan";
            this.chkLoan.Properties.Caption = "Loan";
            this.chkLoan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkLoan.Size = new System.Drawing.Size(51, 19);
            this.chkLoan.TabIndex = 0;
            this.chkLoan.CheckedChanged += new System.EventHandler(this.chkLoan_CheckedChanged);
            // 
            // chkDeposit
            // 
            this.chkDeposit.EditValue = true;
            this.chkDeposit.Location = new System.Drawing.Point(64, 79);
            this.chkDeposit.Name = "chkDeposit";
            this.chkDeposit.Properties.Caption = "Deposite";
            this.chkDeposit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkDeposit.Size = new System.Drawing.Size(72, 19);
            this.chkDeposit.TabIndex = 2;
            this.chkDeposit.CheckedChanged += new System.EventHandler(this.chkDeposit_CheckedChanged);
            // 
            // txtDeposit
            // 
            this.txtDeposit.EditValue = "0";
            this.txtDeposit.Location = new System.Drawing.Point(239, 78);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDeposit.Size = new System.Drawing.Size(45, 20);
            this.txtDeposit.TabIndex = 5;
            this.txtDeposit.TabStop = false;
            this.txtDeposit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDeposit_KeyDown);
            this.txtDeposit.Leave += new System.EventHandler(this.txtCapital_Leave);
            this.txtDeposit.Validated += new System.EventHandler(this.txtLoan_Validated);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cmbEmployee);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.cmbPolicy);
            this.groupControl1.Controls.Add(this.txtReceiptNo);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.dtpReceiptDate);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtMemberName);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(263, 149);
            this.groupControl1.TabIndex = 0;
            // 
            // cmbPolicy
            // 
            this.cmbPolicy.Location = new System.Drawing.Point(100, 96);
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
            this.cmbPolicy.Size = new System.Drawing.Size(115, 20);
            this.cmbPolicy.TabIndex = 2;
            this.cmbPolicy.EditValueChanged += new System.EventHandler(this.cmbPolicy_EditValueChanged);
            // 
            // txtReceiptNo
            // 
            this.txtReceiptNo.Location = new System.Drawing.Point(100, 50);
            this.txtReceiptNo.Name = "txtReceiptNo";
            this.txtReceiptNo.Size = new System.Drawing.Size(115, 20);
            this.txtReceiptNo.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(42, 53);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Receipt No";
            // 
            // dtpReceiptDate
            // 
            this.dtpReceiptDate.EditValue = null;
            this.dtpReceiptDate.Location = new System.Drawing.Point(100, 73);
            this.dtpReceiptDate.Name = "dtpReceiptDate";
            this.dtpReceiptDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpReceiptDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpReceiptDate.Size = new System.Drawing.Size(115, 20);
            this.dtpReceiptDate.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(71, 76);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(23, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Date";
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(100, 119);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Properties.ReadOnly = true;
            this.txtMemberName.Size = new System.Drawing.Size(115, 20);
            this.txtMemberName.TabIndex = 3;
            this.txtMemberName.TabStop = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(51, 99);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Policy No";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(19, 122);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(75, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Member\'s Name";
            // 
            // dgReceipt
            // 
            this.dgReceipt.ContextMenuStrip = this.ctxExpCol;
            this.dgReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgReceipt.EmbeddedNavigator.Name = "";
            this.dgReceipt.Location = new System.Drawing.Point(0, 0);
            this.dgReceipt.MainView = this.gridView1;
            this.dgReceipt.Name = "dgReceipt";
            this.dgReceipt.Size = new System.Drawing.Size(965, 373);
            this.dgReceipt.TabIndex = 0;
            this.dgReceipt.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // ctxExpCol
            // 
            this.ctxExpCol.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expandToolStripMenuItem,
            this.collupsToolStripMenuItem});
            this.ctxExpCol.Name = "ctxExpCol";
            this.ctxExpCol.Size = new System.Drawing.Size(137, 48);
            // 
            // expandToolStripMenuItem
            // 
            this.expandToolStripMenuItem.Image = global::MicroCredit.Properties.Resources.ShowGridlinesHS;
            this.expandToolStripMenuItem.Name = "expandToolStripMenuItem";
            this.expandToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.expandToolStripMenuItem.Text = "Expand All";
            this.expandToolStripMenuItem.Click += new System.EventHandler(this.expandToolStripMenuItem_Click);
            // 
            // collupsToolStripMenuItem
            // 
            this.collupsToolStripMenuItem.Image = global::MicroCredit.Properties.Resources.ShowRulelinesHS;
            this.collupsToolStripMenuItem.Name = "collupsToolStripMenuItem";
            this.collupsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.collupsToolStripMenuItem.Text = "Collapse All";
            this.collupsToolStripMenuItem.Click += new System.EventHandler(this.collupsToolStripMenuItem_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIID,
            this.colPolicyID,
            this.colMemberID,
            this.colMemberCode,
            this.colReceiptNo,
            this.colTrDate,
            this.colAdmissionFee,
            this.colPassbookFormFee,
            this.colDeposit,
            this.colLoanCapital,
            this.colLoanProfit,
            this.colOtherCharges,
            this.colPolicyNumber,
            this.colFullName,
            this.colTotal,
            this.colEmployee});
            this.gridView1.GridControl = this.dgReceipt;
            this.gridView1.GroupCount = 1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", null, " (Total # {0:.00})"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AdmissionFee", this.colAdmissionFee, "{0:.00}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PassbookFormFee", this.colPassbookFormFee, "{0:.00}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Deposit", this.colDeposit, "{0:.00}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LoanCapital", this.colLoanCapital, "{0:.00}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LoanProfit", this.colLoanProfit, "{0:.00}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OtherCharges", this.colOtherCharges, "{0:.00}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", this.colTotal, "{0:.00}")});
            this.gridView1.IndicatorWidth = 50;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupedColumns = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTrDate, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colReceiptNo, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            // 
            // colIID
            // 
            this.colIID.Caption = "IID";
            this.colIID.FieldName = "IID";
            this.colIID.Name = "colIID";
            this.colIID.Width = 55;
            // 
            // colPolicyID
            // 
            this.colPolicyID.Caption = "PolicyID";
            this.colPolicyID.FieldName = "PolicyID";
            this.colPolicyID.Name = "colPolicyID";
            this.colPolicyID.Width = 74;
            // 
            // colMemberID
            // 
            this.colMemberID.Caption = "MemberID";
            this.colMemberID.FieldName = "MemberID";
            this.colMemberID.Name = "colMemberID";
            this.colMemberID.Width = 69;
            // 
            // colMemberCode
            // 
            this.colMemberCode.Caption = "MemberCode";
            this.colMemberCode.FieldName = "MemberCode";
            this.colMemberCode.Name = "colMemberCode";
            this.colMemberCode.Width = 51;
            // 
            // colReceiptNo
            // 
            this.colReceiptNo.Caption = "Receipt#";
            this.colReceiptNo.FieldName = "ReceiptNo";
            this.colReceiptNo.Name = "colReceiptNo";
            this.colReceiptNo.OptionsColumn.FixedWidth = true;
            this.colReceiptNo.SummaryItem.DisplayFormat = "Total {0} Row(s)";
            this.colReceiptNo.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            this.colReceiptNo.Visible = true;
            this.colReceiptNo.VisibleIndex = 0;
            this.colReceiptNo.Width = 100;
            // 
            // colTrDate
            // 
            this.colTrDate.Caption = "Date";
            this.colTrDate.FieldName = "TrDate";
            this.colTrDate.Name = "colTrDate";
            this.colTrDate.Width = 20;
            // 
            // colAdmissionFee
            // 
            this.colAdmissionFee.Caption = "Admission";
            this.colAdmissionFee.DisplayFormat.FormatString = "#,###.00;(#,###.00);_";
            this.colAdmissionFee.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colAdmissionFee.FieldName = "AdmissionFee";
            this.colAdmissionFee.Name = "colAdmissionFee";
            this.colAdmissionFee.OptionsColumn.FixedWidth = true;
            this.colAdmissionFee.SummaryItem.DisplayFormat = "{0:.00}";
            this.colAdmissionFee.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colAdmissionFee.Visible = true;
            this.colAdmissionFee.VisibleIndex = 3;
            this.colAdmissionFee.Width = 96;
            // 
            // colPassbookFormFee
            // 
            this.colPassbookFormFee.Caption = "Book/Form";
            this.colPassbookFormFee.DisplayFormat.FormatString = "#,###.00;(#,###.00);_";
            this.colPassbookFormFee.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colPassbookFormFee.FieldName = "PassbookFormFee";
            this.colPassbookFormFee.Name = "colPassbookFormFee";
            this.colPassbookFormFee.OptionsColumn.FixedWidth = true;
            this.colPassbookFormFee.SummaryItem.DisplayFormat = "{0:.00}";
            this.colPassbookFormFee.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colPassbookFormFee.Visible = true;
            this.colPassbookFormFee.VisibleIndex = 4;
            this.colPassbookFormFee.Width = 65;
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
            this.colDeposit.VisibleIndex = 5;
            this.colDeposit.Width = 65;
            // 
            // colLoanCapital
            // 
            this.colLoanCapital.Caption = "Capital";
            this.colLoanCapital.DisplayFormat.FormatString = "#,###.00;(#,###.00);_";
            this.colLoanCapital.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colLoanCapital.FieldName = "LoanCapital";
            this.colLoanCapital.Name = "colLoanCapital";
            this.colLoanCapital.OptionsColumn.FixedWidth = true;
            this.colLoanCapital.SummaryItem.DisplayFormat = "{0:.00}";
            this.colLoanCapital.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colLoanCapital.Visible = true;
            this.colLoanCapital.VisibleIndex = 6;
            this.colLoanCapital.Width = 65;
            // 
            // colLoanProfit
            // 
            this.colLoanProfit.Caption = "Profit";
            this.colLoanProfit.DisplayFormat.FormatString = "#,###.00;(#,###.00);_";
            this.colLoanProfit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colLoanProfit.FieldName = "LoanProfit";
            this.colLoanProfit.Name = "colLoanProfit";
            this.colLoanProfit.OptionsColumn.FixedWidth = true;
            this.colLoanProfit.SummaryItem.DisplayFormat = "{0:.00}";
            this.colLoanProfit.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colLoanProfit.Visible = true;
            this.colLoanProfit.VisibleIndex = 7;
            this.colLoanProfit.Width = 65;
            // 
            // colOtherCharges
            // 
            this.colOtherCharges.Caption = "Other";
            this.colOtherCharges.DisplayFormat.FormatString = "#,###.00;(#,###.00);_";
            this.colOtherCharges.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colOtherCharges.FieldName = "OtherCharges";
            this.colOtherCharges.Name = "colOtherCharges";
            this.colOtherCharges.OptionsColumn.FixedWidth = true;
            this.colOtherCharges.SummaryItem.DisplayFormat = "{0:.00}";
            this.colOtherCharges.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colOtherCharges.Visible = true;
            this.colOtherCharges.VisibleIndex = 8;
            this.colOtherCharges.Width = 65;
            // 
            // colPolicyNumber
            // 
            this.colPolicyNumber.Caption = "Policy#";
            this.colPolicyNumber.FieldName = "PolicyNumber";
            this.colPolicyNumber.Name = "colPolicyNumber";
            this.colPolicyNumber.OptionsColumn.FixedWidth = true;
            this.colPolicyNumber.Visible = true;
            this.colPolicyNumber.VisibleIndex = 2;
            this.colPolicyNumber.Width = 100;
            // 
            // colFullName
            // 
            this.colFullName.Caption = "Name";
            this.colFullName.FieldName = "FullName";
            this.colFullName.Name = "colFullName";
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 1;
            this.colFullName.Width = 65;
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
            this.colTotal.VisibleIndex = 9;
            this.colTotal.Width = 85;
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
            this.navBarGeneral.OptionsNavPane.ExpandedWidth = 148;
            this.navBarGeneral.Size = new System.Drawing.Size(148, 526);
            this.navBarGeneral.SmallImages = this.MainImageList;
            this.navBarGeneral.TabIndex = 0;
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
            this.dtpFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
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
            this.dtpToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
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
            // receiptDataset1
            // 
            this.receiptDataset1.DataSetName = "ReceiptDataset";
            this.receiptDataset1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::MicroCredit.Properties.Resources.PRINTER;
            this.btnPrint.ImageList = this.MainImageList;
            this.btnPrint.Location = new System.Drawing.Point(84, 5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 1;
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
            this.cmbExport.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbExport.Size = new System.Drawing.Size(100, 20);
            this.cmbExport.TabIndex = 2;
            this.cmbExport.SelectedIndexChanged += new System.EventHandler(this.cmbExport_SelectedIndexChanged);
            this.cmbExport.EditValueChanged += new System.EventHandler(this.cmbExport_EditValueChanged);
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.Location = new System.Drawing.Point(100, 26);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEmployee.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IID", "IID", 34, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.cmbEmployee.Properties.DataSource = this.employeeBindingSource;
            this.cmbEmployee.Properties.DisplayMember = "Name";
            this.cmbEmployee.Properties.DropDownRows = 10;
            this.cmbEmployee.Properties.NullText = "[Select Employee]";
            this.cmbEmployee.Properties.ShowFooter = false;
            this.cmbEmployee.Properties.ShowHeader = false;
            this.cmbEmployee.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbEmployee.Properties.ValueMember = "IID";
            this.cmbEmployee.Size = new System.Drawing.Size(115, 20);
            this.cmbEmployee.TabIndex = 5;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(48, 29);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(46, 13);
            this.labelControl6.TabIndex = 6;
            this.labelControl6.Text = "Employee";
            // 
            // employeeDataset
            // 
            this.employeeDataset.DataSetName = "EmployeeDataset";
            this.employeeDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.employeeDataset;
            // 
            // colEmployee
            // 
            this.colEmployee.Caption = "Collected by";
            this.colEmployee.FieldName = "Name";
            this.colEmployee.Name = "colEmployee";
            this.colEmployee.Visible = true;
            this.colEmployee.VisibleIndex = 10;
            // 
            // frmCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 564);
            this.FrmText = "Collection Receipt";
            this.Name = "frmCollection";
            this.Text = "Collection Receipt";
            this.Controls.SetChildIndex(this.spcMaster, 0);
            this.spcMaster.Panel1.ResumeLayout(false);
            this.spcMaster.Panel2.ResumeLayout(false);
            this.spcMaster.ResumeLayout(false);
            this.spcNav.Panel1.ResumeLayout(false);
            this.spcNav.Panel2.ResumeLayout(false);
            this.spcNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainErrorProvider)).EndInit();
            this.spcBody.Panel1.ResumeLayout(false);
            this.spcBody.Panel2.ResumeLayout(false);
            this.spcBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nubLoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmountperDeposit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeposit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbReason.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOthers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInterest.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdmission.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapital.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAdmissionFee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkOthers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPassbookForm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassbook.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkLoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDeposit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeposit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPolicy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReceiptNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpReceiptDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpReceiptDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMemberName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReceipt)).EndInit();
            this.ctxExpCol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarGeneral)).EndInit();
            this.navBarGeneral.ResumeLayout(false);
            this.navBarGroupControlContainer1.ResumeLayout(false);
            this.navBarGroupControlContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptDataset1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbExport.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEmployee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcBody;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtMemberName;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtReceiptNo;
        private DevExpress.XtraEditors.DateEdit dtpReceiptDate;
        private DevExpress.XtraEditors.CheckEdit chkAdmissionFee;
        private DevExpress.XtraEditors.CheckEdit chkLoan;
        private DevExpress.XtraEditors.CheckEdit chkDeposit;
        private DevExpress.XtraEditors.CheckEdit chkPassbookForm;
        private DevExpress.XtraEditors.TextEdit txtOthers;
        private DevExpress.XtraEditors.TextEdit txtAdmission;
        private DevExpress.XtraEditors.TextEdit txtPassbook;
        private DevExpress.XtraEditors.TextEdit txtDeposit;
        private DevExpress.XtraEditors.TextEdit txtInterest;
        private DevExpress.XtraEditors.LabelControl lblInterest;
        private DevExpress.XtraEditors.TextEdit txtCapital;
        private DevExpress.XtraEditors.LabelControl lblCapital;
        private DevExpress.XtraEditors.CheckEdit chkOthers;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbReason;
        private DevExpress.XtraEditors.LookUpEdit cmbPolicy;
        private DevExpress.XtraEditors.TextEdit txtLoan;
        private DevExpress.XtraGrid.GridControl dgReceipt;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIID;
        private DevExpress.XtraGrid.Columns.GridColumn colPolicyID;
        private DevExpress.XtraGrid.Columns.GridColumn colMemberID;
        private DevExpress.XtraGrid.Columns.GridColumn colMemberCode;
        private DevExpress.XtraGrid.Columns.GridColumn colReceiptNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTrDate;
        private DevExpress.XtraGrid.Columns.GridColumn colAdmissionFee;
        private DevExpress.XtraGrid.Columns.GridColumn colPassbookFormFee;
        private DevExpress.XtraGrid.Columns.GridColumn colDeposit;
        private DevExpress.XtraGrid.Columns.GridColumn colLoanCapital;
        private DevExpress.XtraGrid.Columns.GridColumn colLoanProfit;
        private DevExpress.XtraGrid.Columns.GridColumn colOtherCharges;
        private DevExpress.XtraGrid.Columns.GridColumn colPolicyNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraNavBar.NavBarControl navBarGeneral;
        private DevExpress.XtraNavBar.NavBarGroup nbgGenerals;
        private DevExpress.XtraNavBar.NavBarItem nbiRefresh;
        private DevExpress.XtraNavBar.NavBarItem nbiShow;
        private DevExpress.XtraNavBar.NavBarItem nbiClose;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer1;
        private DevExpress.XtraNavBar.NavBarGroup navBarTask;
        private MicroCredit.DataSets.ReceiptDataset receiptDataset1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnGo;
        private DevExpress.XtraEditors.DateEdit dtpFromDate;
        private DevExpress.XtraEditors.DateEdit dtpToDate;
        private DevExpress.XtraEditors.SpinEdit nudDeposit;
        private DevExpress.XtraEditors.TextEdit txtAmountperDeposit;
        private System.Windows.Forms.ContextMenuStrip ctxExpCol;
        private System.Windows.Forms.ToolStripMenuItem expandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collupsToolStripMenuItem;
        private DevExpress.XtraEditors.SpinEdit nubLoan;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.ComboBoxEdit cmbExport;
        private DevExpress.XtraEditors.LookUpEdit cmbEmployee;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private DataSets.EmployeeDataset employeeDataset;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployee;
    }
}