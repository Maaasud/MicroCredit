namespace MicroCredit.BaseControl
{
    partial class BaseEditViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseEditViewForm));
            this.spcMaster = new System.Windows.Forms.SplitContainer();
            this.spcNav = new System.Windows.Forms.SplitContainer();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.spcMaster.Panel1.SuspendLayout();
            this.spcMaster.Panel2.SuspendLayout();
            this.spcMaster.SuspendLayout();
            this.spcNav.SuspendLayout();
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
            // spcMaster.Panel1
            // 
            this.spcMaster.Panel1.Controls.Add(this.spcNav);
            // 
            // spcMaster.Panel2
            // 
            this.spcMaster.Panel2.Controls.Add(this.btnClose);
            this.spcMaster.Size = new System.Drawing.Size(974, 564);
            this.spcMaster.SplitterDistance = 526;
            this.spcMaster.TabIndex = 0;
            this.spcMaster.TabStop = false;
            // 
            // spcNav
            // 
            this.spcNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcNav.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spcNav.IsSplitterFixed = true;
            this.spcNav.Location = new System.Drawing.Point(0, 0);
            this.spcNav.Name = "spcNav";
            this.spcNav.Size = new System.Drawing.Size(974, 526);
            this.spcNav.SplitterDistance = 148;
            this.spcNav.TabIndex = 0;
            this.spcNav.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.ImageIndex = 22;
            this.btnClose.ImageList = this.MainImageList;
            this.btnClose.Location = new System.Drawing.Point(3, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // BaseEditViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 564);
            this.Controls.Add(this.spcMaster);
            this.FrmText = "BaseEditViewForm";
            this.Name = "BaseEditViewForm";
            this.Text = "BaseEditViewForm";
            this.spcMaster.Panel1.ResumeLayout(false);
            this.spcMaster.Panel2.ResumeLayout(false);
            this.spcMaster.ResumeLayout(false);
            this.spcNav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.SplitContainer spcMaster;
        public System.Windows.Forms.SplitContainer spcNav;
        public DevExpress.XtraEditors.SimpleButton btnClose;
    }
}