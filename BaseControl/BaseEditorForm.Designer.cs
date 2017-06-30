namespace MicroCredit.BaseControl
{
    partial class BaseEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseEditorForm));
            this.spcMaster = new System.Windows.Forms.SplitContainer();
            this.btnCancel1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.spcMaster.Panel2.SuspendLayout();
            this.spcMaster.SuspendLayout();
            this.SuspendLayout();
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
            // spcMaster
            // 
            this.spcMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcMaster.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.spcMaster.IsSplitterFixed = true;
            this.spcMaster.Location = new System.Drawing.Point(0, 0);
            this.spcMaster.Name = "spcMaster";
            this.spcMaster.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcMaster.Panel2
            // 
            this.spcMaster.Panel2.Controls.Add(this.btnCancel1);
            this.spcMaster.Panel2.Controls.Add(this.btnSave1);
            this.spcMaster.Panel2.Controls.Add(this.btnClose);
            this.spcMaster.Size = new System.Drawing.Size(897, 576);
            this.spcMaster.SplitterDistance = 537;
            this.spcMaster.TabIndex = 0;
            this.spcMaster.TabStop = false;
            // 
            // btnCancel1
            // 
            this.btnCancel1.ImageIndex = 2;
            this.btnCancel1.ImageList = this.MainImageList;
            this.btnCancel1.Location = new System.Drawing.Point(87, 5);
            this.btnCancel1.Name = "btnCancel1";
            this.btnCancel1.Size = new System.Drawing.Size(75, 23);
            this.btnCancel1.TabIndex = 1;
            this.btnCancel1.Text = "Cancel";
            // 
            // btnSave1
            // 
            this.btnSave1.ImageIndex = 14;
            this.btnSave1.ImageList = this.MainImageList;
            this.btnSave1.Location = new System.Drawing.Point(6, 5);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(75, 23);
            this.btnSave1.TabIndex = 0;
            this.btnSave1.Text = "Save";
            // 
            // btnClose
            // 
            this.btnClose.ImageIndex = 22;
            this.btnClose.ImageList = this.MainImageList;
            this.btnClose.Location = new System.Drawing.Point(168, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // BaseEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 576);
            this.Controls.Add(this.spcMaster);
            this.FrmText = "BaseEditorForm";
            this.Name = "BaseEditorForm";
            this.Text = "BaseEditorForm";
            this.Load += new System.EventHandler(this.BaseEditorForm_Load);
            this.spcMaster.Panel2.ResumeLayout(false);
            this.spcMaster.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.SplitContainer spcMaster;
        public DevExpress.XtraEditors.SimpleButton btnCancel1;
        public DevExpress.XtraEditors.SimpleButton btnSave1;
        public DevExpress.XtraEditors.SimpleButton btnClose;
    }
}