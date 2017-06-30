namespace MicroCredit.BaseControl
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.MainImageList = new System.Windows.Forms.ImageList(this.components);
            this.MainErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MainErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // MainImageList
            // 
            this.MainImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MainImageList.ImageStream")));
            this.MainImageList.TransparentColor = System.Drawing.Color.Transparent;
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
            // MainErrorProvider
            // 
            this.MainErrorProvider.ContainerControl = this;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BaseForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.MainErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.ImageList MainImageList;
        public System.Windows.Forms.ErrorProvider MainErrorProvider;


    }
}