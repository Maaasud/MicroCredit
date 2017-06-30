namespace MicroCredit.Forms
{
    partial class frmOfficeExpenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOfficeExpenses));
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.txtReference = new DevExpress.XtraEditors.TextEdit();
            this.btnWithdraw = new DevExpress.XtraEditors.SimpleButton();
            this.txtReceiptNo = new DevExpress.XtraEditors.TextEdit();
            this.txtAmount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.dtpReceiptDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtPaidTo = new DevExpress.XtraEditors.TextEdit();
            this.rdoWithdraw = new System.Windows.Forms.RadioButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cmbExpensesReason = new DevExpress.XtraEditors.ComboBoxEdit();
            this.spcMaster.Panel1.SuspendLayout();
            this.spcMaster.Panel2.SuspendLayout();
            this.spcMaster.SuspendLayout();
            this.spcNav.Panel2.SuspendLayout();
            this.spcNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReference.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReceiptNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpReceiptDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaidTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbExpensesReason.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // spcMaster
            // 
            this.spcMaster.Size = new System.Drawing.Size(636, 541);
            this.spcMaster.SplitterDistance = 503;
            // 
            // spcNav
            // 
            this.spcNav.Panel1Collapsed = true;
            // 
            // spcNav.Panel2
            // 
            this.spcNav.Panel2.Controls.Add(this.cmbExpensesReason);
            this.spcNav.Panel2.Controls.Add(this.btnCancel);
            this.spcNav.Panel2.Controls.Add(this.txtReference);
            this.spcNav.Panel2.Controls.Add(this.btnWithdraw);
            this.spcNav.Panel2.Controls.Add(this.txtReceiptNo);
            this.spcNav.Panel2.Controls.Add(this.txtAmount);
            this.spcNav.Panel2.Controls.Add(this.labelControl1);
            this.spcNav.Panel2.Controls.Add(this.labelControl8);
            this.spcNav.Panel2.Controls.Add(this.dtpReceiptDate);
            this.spcNav.Panel2.Controls.Add(this.labelControl2);
            this.spcNav.Panel2.Controls.Add(this.labelControl6);
            this.spcNav.Panel2.Controls.Add(this.txtPaidTo);
            this.spcNav.Panel2.Controls.Add(this.rdoWithdraw);
            this.spcNav.Panel2.Controls.Add(this.labelControl3);
            this.spcNav.Panel2.Controls.Add(this.labelControl4);
            this.spcNav.Size = new System.Drawing.Size(636, 503);
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
            // btnCancel
            // 
            this.btnCancel.ImageIndex = 2;
            this.btnCancel.ImageList = this.MainImageList;
            this.btnCancel.Location = new System.Drawing.Point(359, 303);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtReference
            // 
            this.txtReference.Location = new System.Drawing.Point(276, 242);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(133, 20);
            this.txtReference.TabIndex = 4;
            this.txtReference.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReference_KeyDown);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.ImageIndex = 14;
            this.btnWithdraw.ImageList = this.MainImageList;
            this.btnWithdraw.Location = new System.Drawing.Point(276, 303);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(75, 23);
            this.btnWithdraw.TabIndex = 6;
            this.btnWithdraw.Text = "Save";
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // txtReceiptNo
            // 
            this.txtReceiptNo.Location = new System.Drawing.Point(276, 138);
            this.txtReceiptNo.Name = "txtReceiptNo";
            this.txtReceiptNo.Size = new System.Drawing.Size(133, 20);
            this.txtReceiptNo.TabIndex = 0;
            this.txtReceiptNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReceiptNo_KeyDown);
            // 
            // txtAmount
            // 
            this.txtAmount.EditValue = "0";
            this.txtAmount.Location = new System.Drawing.Point(276, 268);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAmount.Size = new System.Drawing.Size(78, 20);
            this.txtAmount.TabIndex = 5;
            this.txtAmount.Validated += new System.EventHandler(this.txtAmount_Validated);
            this.txtAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmount_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(201, 142);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Voucher No";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(219, 272);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(37, 13);
            this.labelControl8.TabIndex = 24;
            this.labelControl8.Text = "Amount";
            // 
            // dtpReceiptDate
            // 
            this.dtpReceiptDate.EditValue = null;
            this.dtpReceiptDate.Location = new System.Drawing.Point(276, 164);
            this.dtpReceiptDate.Name = "dtpReceiptDate";
            this.dtpReceiptDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpReceiptDate.Size = new System.Drawing.Size(133, 20);
            this.dtpReceiptDate.TabIndex = 1;
            this.dtpReceiptDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpReceiptDate_KeyDown);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(233, 168);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(23, 13);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Date";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(206, 245);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(50, 13);
            this.labelControl6.TabIndex = 18;
            this.labelControl6.Text = "Reference";
            // 
            // txtPaidTo
            // 
            this.txtPaidTo.Location = new System.Drawing.Point(276, 190);
            this.txtPaidTo.Name = "txtPaidTo";
            this.txtPaidTo.Size = new System.Drawing.Size(133, 20);
            this.txtPaidTo.TabIndex = 2;
            this.txtPaidTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPaidTo_KeyDown);
            // 
            // rdoWithdraw
            // 
            this.rdoWithdraw.AutoSize = true;
            this.rdoWithdraw.Checked = true;
            this.rdoWithdraw.Location = new System.Drawing.Point(276, 115);
            this.rdoWithdraw.Name = "rdoWithdraw";
            this.rdoWithdraw.Size = new System.Drawing.Size(98, 17);
            this.rdoWithdraw.TabIndex = 12;
            this.rdoWithdraw.TabStop = true;
            this.rdoWithdraw.Text = "Cash Withdraw";
            this.rdoWithdraw.UseVisualStyleBackColor = true;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(176, 219);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(80, 13);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "Expense Reason";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(223, 193);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(33, 13);
            this.labelControl4.TabIndex = 17;
            this.labelControl4.Text = "Paid to";
            // 
            // cmbExpensesReason
            // 
            this.cmbExpensesReason.Location = new System.Drawing.Point(276, 216);
            this.cmbExpensesReason.Name = "cmbExpensesReason";
            this.cmbExpensesReason.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbExpensesReason.Size = new System.Drawing.Size(133, 20);
            this.cmbExpensesReason.TabIndex = 3;
            this.cmbExpensesReason.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbExpensesReason_KeyDown);
            // 
            // frmOfficeExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 541);
            this.FrmText = "Office Expenses";
            this.Name = "frmOfficeExpenses";
            this.Text = "Office Expenses";
            this.spcMaster.Panel1.ResumeLayout(false);
            this.spcMaster.Panel2.ResumeLayout(false);
            this.spcMaster.ResumeLayout(false);
            this.spcNav.Panel2.ResumeLayout(false);
            this.spcNav.Panel2.PerformLayout();
            this.spcNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReference.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReceiptNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpReceiptDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaidTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbExpensesReason.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cmbExpensesReason;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.TextEdit txtReference;
        private DevExpress.XtraEditors.SimpleButton btnWithdraw;
        private DevExpress.XtraEditors.TextEdit txtReceiptNo;
        private DevExpress.XtraEditors.TextEdit txtAmount;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.DateEdit dtpReceiptDate;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtPaidTo;
        private System.Windows.Forms.RadioButton rdoWithdraw;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}