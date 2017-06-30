namespace MicroCredit.Forms
{
    partial class frmCashDisbursement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCashDisbursement));
            this.spcBody = new System.Windows.Forms.SplitContainer();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.txtArea = new DevExpress.XtraEditors.TextEdit();
            this.cmbPolicy = new DevExpress.XtraEditors.LookUpEdit();
            this.btnWithdraw = new DevExpress.XtraEditors.SimpleButton();
            this.txtReceiptNo = new DevExpress.XtraEditors.TextEdit();
            this.txtAmount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.dtpReceiptDate = new DevExpress.XtraEditors.DateEdit();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtMemberName = new DevExpress.XtraEditors.TextEdit();
            this.rdoWithdraw = new System.Windows.Forms.RadioButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.spcMaster.Panel1.SuspendLayout();
            this.spcMaster.Panel2.SuspendLayout();
            this.spcMaster.SuspendLayout();
            this.spcNav.Panel2.SuspendLayout();
            this.spcNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainErrorProvider)).BeginInit();
            this.spcBody.Panel1.SuspendLayout();
            this.spcBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtArea.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPolicy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReceiptNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpReceiptDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMemberName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // spcMaster
            // 
            this.spcMaster.Size = new System.Drawing.Size(764, 456);
            this.spcMaster.SplitterDistance = 418;
            // 
            // spcNav
            // 
            this.spcNav.Panel1Collapsed = true;
            // 
            // spcNav.Panel2
            // 
            this.spcNav.Panel2.Controls.Add(this.spcBody);
            this.spcNav.Size = new System.Drawing.Size(764, 418);
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
            this.spcBody.Location = new System.Drawing.Point(0, 0);
            this.spcBody.Name = "spcBody";
            this.spcBody.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcBody.Panel1
            // 
            this.spcBody.Panel1.Controls.Add(this.groupControl1);
            this.spcBody.Panel2Collapsed = true;
            this.spcBody.Size = new System.Drawing.Size(764, 418);
            this.spcBody.SplitterDistance = 133;
            this.spcBody.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnCancel);
            this.groupControl1.Controls.Add(this.txtArea);
            this.groupControl1.Controls.Add(this.cmbPolicy);
            this.groupControl1.Controls.Add(this.btnWithdraw);
            this.groupControl1.Controls.Add(this.txtReceiptNo);
            this.groupControl1.Controls.Add(this.txtAmount);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.dtpReceiptDate);
            this.groupControl1.Controls.Add(this.txtDescription);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txtMemberName);
            this.groupControl1.Controls.Add(this.rdoWithdraw);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(764, 418);
            this.groupControl1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.ImageIndex = 2;
            this.btnCancel.ImageList = this.MainImageList;
            this.btnCancel.Location = new System.Drawing.Point(352, 289);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(269, 190);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(38, 20);
            this.txtArea.TabIndex = 3;
            this.txtArea.Leave += new System.EventHandler(this.txtArea_Leave);
            this.txtArea.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtArea_KeyDown);
            // 
            // cmbPolicy
            // 
            this.cmbPolicy.Location = new System.Drawing.Point(269, 138);
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
            this.cmbPolicy.Size = new System.Drawing.Size(133, 20);
            this.cmbPolicy.TabIndex = 2;
            this.cmbPolicy.EditValueChanged += new System.EventHandler(this.cmbPolicy_EditValueChanged);
            this.cmbPolicy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbPolicy_KeyDown);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.ImageIndex = 14;
            this.btnWithdraw.ImageList = this.MainImageList;
            this.btnWithdraw.Location = new System.Drawing.Point(269, 289);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(75, 23);
            this.btnWithdraw.TabIndex = 6;
            this.btnWithdraw.Text = "Save";
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // txtReceiptNo
            // 
            this.txtReceiptNo.Location = new System.Drawing.Point(269, 86);
            this.txtReceiptNo.Name = "txtReceiptNo";
            this.txtReceiptNo.Size = new System.Drawing.Size(133, 20);
            this.txtReceiptNo.TabIndex = 0;
            this.txtReceiptNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReceiptNo_KeyDown);
            // 
            // txtAmount
            // 
            this.txtAmount.EditValue = "0";
            this.txtAmount.Location = new System.Drawing.Point(269, 254);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAmount.Size = new System.Drawing.Size(78, 20);
            this.txtAmount.TabIndex = 5;
            this.txtAmount.Validated += new System.EventHandler(this.txtAmount_Validated);
            this.txtAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmount_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(194, 90);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Voucher No";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(212, 258);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(37, 13);
            this.labelControl8.TabIndex = 7;
            this.labelControl8.Text = "Amount";
            // 
            // dtpReceiptDate
            // 
            this.dtpReceiptDate.EditValue = null;
            this.dtpReceiptDate.Location = new System.Drawing.Point(269, 112);
            this.dtpReceiptDate.Name = "dtpReceiptDate";
            this.dtpReceiptDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpReceiptDate.Size = new System.Drawing.Size(133, 20);
            this.dtpReceiptDate.TabIndex = 1;
            this.dtpReceiptDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpReceiptDate_KeyDown);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(269, 216);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(200, 32);
            this.txtDescription.TabIndex = 4;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(107, 216);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(142, 13);
            this.labelControl7.TabIndex = 5;
            this.labelControl7.Text = "Withdraw Reason/Description";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(226, 116);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(23, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Date";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(226, 194);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(23, 13);
            this.labelControl6.TabIndex = 4;
            this.labelControl6.Text = "Area";
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(269, 164);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Properties.ReadOnly = true;
            this.txtMemberName.Size = new System.Drawing.Size(133, 20);
            this.txtMemberName.TabIndex = 3;
            this.txtMemberName.TabStop = false;
            // 
            // rdoWithdraw
            // 
            this.rdoWithdraw.AutoSize = true;
            this.rdoWithdraw.Checked = true;
            this.rdoWithdraw.Location = new System.Drawing.Point(269, 63);
            this.rdoWithdraw.Name = "rdoWithdraw";
            this.rdoWithdraw.Size = new System.Drawing.Size(98, 17);
            this.rdoWithdraw.TabIndex = 2;
            this.rdoWithdraw.TabStop = true;
            this.rdoWithdraw.Text = "Cash Withdraw";
            this.rdoWithdraw.UseVisualStyleBackColor = true;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(206, 142);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Policy No";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(174, 168);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(75, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Member\'s Name";
            // 
            // frmCashDisbursement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 456);
            this.FrmText = "Cash Withdraw [Against Policy]";
            this.Name = "frmCashDisbursement";
            this.Text = "Cash Withdraw [Against Policy]";
            this.spcMaster.Panel1.ResumeLayout(false);
            this.spcMaster.Panel2.ResumeLayout(false);
            this.spcMaster.ResumeLayout(false);
            this.spcNav.Panel2.ResumeLayout(false);
            this.spcNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainErrorProvider)).EndInit();
            this.spcBody.Panel1.ResumeLayout(false);
            this.spcBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtArea.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPolicy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReceiptNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpReceiptDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMemberName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcBody;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LookUpEdit cmbPolicy;
        private DevExpress.XtraEditors.TextEdit txtReceiptNo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dtpReceiptDate;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtMemberName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.RadioButton rdoWithdraw;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtAmount;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private DevExpress.XtraEditors.SimpleButton btnWithdraw;
        private DevExpress.XtraEditors.TextEdit txtArea;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}