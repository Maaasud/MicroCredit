namespace MicroCredit.Forms
{
    partial class frmNewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewUser));
            this.spcUser = new System.Windows.Forms.SplitContainer();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnApply = new DevExpress.XtraEditors.SimpleButton();
            this.cmbUserType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtpassword = new DevExpress.XtraEditors.TextEdit();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtUserID = new DevExpress.XtraEditors.TextEdit();
            this.txtCPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dgUser = new DevExpress.XtraGrid.GridControl();
            this.loginUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userCompanyDataset = new MicroCredit.UserCompanyDataset();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colSaveDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiNew = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiEdit = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiDelete = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiRefresh = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiClose = new DevExpress.XtraNavBar.NavBarItem();
            this.spcMaster.Panel1.SuspendLayout();
            this.spcMaster.Panel2.SuspendLayout();
            this.spcMaster.SuspendLayout();
            this.spcNav.Panel1.SuspendLayout();
            this.spcNav.Panel2.SuspendLayout();
            this.spcNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainErrorProvider)).BeginInit();
            this.spcUser.Panel1.SuspendLayout();
            this.spcUser.Panel2.SuspendLayout();
            this.spcUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUserType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCompanyDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // spcMaster
            // 
            // 
            // spcNav
            // 
            // 
            // spcNav.Panel1
            // 
            this.spcNav.Panel1.Controls.Add(this.navBarControl1);
            // 
            // spcNav.Panel2
            // 
            this.spcNav.Panel2.Controls.Add(this.spcUser);
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
            // spcUser
            // 
            this.spcUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcUser.Location = new System.Drawing.Point(0, 0);
            this.spcUser.Name = "spcUser";
            this.spcUser.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcUser.Panel1
            // 
            this.spcUser.Panel1.Controls.Add(this.btnCancel);
            this.spcUser.Panel1.Controls.Add(this.btnApply);
            this.spcUser.Panel1.Controls.Add(this.cmbUserType);
            this.spcUser.Panel1.Controls.Add(this.labelControl5);
            this.spcUser.Panel1.Controls.Add(this.txtpassword);
            this.spcUser.Panel1.Controls.Add(this.txtUserName);
            this.spcUser.Panel1.Controls.Add(this.labelControl1);
            this.spcUser.Panel1.Controls.Add(this.labelControl4);
            this.spcUser.Panel1.Controls.Add(this.txtUserID);
            this.spcUser.Panel1.Controls.Add(this.txtCPassword);
            this.spcUser.Panel1.Controls.Add(this.labelControl2);
            this.spcUser.Panel1.Controls.Add(this.labelControl3);
            // 
            // spcUser.Panel2
            // 
            this.spcUser.Panel2.Controls.Add(this.dgUser);
            this.spcUser.Size = new System.Drawing.Size(822, 526);
            this.spcUser.SplitterDistance = 122;
            this.spcUser.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.ImageIndex = 2;
            this.btnCancel.ImageList = this.MainImageList;
            this.btnCancel.Location = new System.Drawing.Point(517, 80);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.ImageIndex = 14;
            this.btnApply.ImageList = this.MainImageList;
            this.btnApply.Location = new System.Drawing.Point(436, 81);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "Apply";
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // cmbUserType
            // 
            this.cmbUserType.EditValue = "Select Type...";
            this.cmbUserType.Location = new System.Drawing.Point(445, 52);
            this.cmbUserType.Name = "cmbUserType";
            this.cmbUserType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbUserType.Properties.Items.AddRange(new object[] {
            "Administrator",
            "User"});
            this.cmbUserType.Size = new System.Drawing.Size(147, 20);
            this.cmbUserType.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(390, 56);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(49, 13);
            this.labelControl5.TabIndex = 42;
            this.labelControl5.Text = "User Type";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(183, 52);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Properties.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(147, 20);
            this.txtpassword.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(445, 26);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(147, 20);
            this.txtUserName.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(138, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 13);
            this.labelControl1.TabIndex = 38;
            this.labelControl1.Text = "Login ID";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(387, 30);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(52, 13);
            this.labelControl4.TabIndex = 41;
            this.labelControl4.Text = "User Name";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(183, 26);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(147, 20);
            this.txtUserID.TabIndex = 0;
            // 
            // txtCPassword
            // 
            this.txtCPassword.Location = new System.Drawing.Point(183, 77);
            this.txtCPassword.Name = "txtCPassword";
            this.txtCPassword.Properties.PasswordChar = '*';
            this.txtCPassword.Size = new System.Drawing.Size(147, 20);
            this.txtCPassword.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(131, 56);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 39;
            this.labelControl2.Text = "Password";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(87, 81);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(90, 13);
            this.labelControl3.TabIndex = 40;
            this.labelControl3.Text = "Re-Type Password";
            // 
            // dgUser
            // 
            this.dgUser.DataSource = this.loginUserBindingSource;
            this.dgUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgUser.EmbeddedNavigator.Name = "";
            this.dgUser.Location = new System.Drawing.Point(0, 0);
            this.dgUser.MainView = this.gridView1;
            this.dgUser.Name = "dgUser";
            this.dgUser.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            this.dgUser.Size = new System.Drawing.Size(822, 400);
            this.dgUser.TabIndex = 0;
            this.dgUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // loginUserBindingSource
            // 
            this.loginUserBindingSource.DataMember = "LoginUser";
            this.loginUserBindingSource.DataSource = this.userCompanyDataset;
            // 
            // userCompanyDataset
            // 
            this.userCompanyDataset.DataSetName = "UserCompanyDataset";
            this.userCompanyDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIID,
            this.colUserName,
            this.colPassword,
            this.colFullName,
            this.colType,
            this.colSaveDate});
            this.gridView1.GridControl = this.dgUser;
            this.gridView1.IndicatorWidth = 60;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colIID
            // 
            this.colIID.Caption = "IID";
            this.colIID.FieldName = "IID";
            this.colIID.Name = "colIID";
            // 
            // colUserName
            // 
            this.colUserName.Caption = "Login ID";
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.OptionsColumn.FixedWidth = true;
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 0;
            this.colUserName.Width = 200;
            // 
            // colPassword
            // 
            this.colPassword.Caption = "Password";
            this.colPassword.FieldName = "Password";
            this.colPassword.Name = "colPassword";
            // 
            // colFullName
            // 
            this.colFullName.Caption = "Full Name";
            this.colFullName.FieldName = "FullName";
            this.colFullName.Name = "colFullName";
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 1;
            this.colFullName.Width = 483;
            // 
            // colType
            // 
            this.colType.Caption = "Type";
            this.colType.ColumnEdit = this.repositoryItemComboBox1;
            this.colType.FieldName = "Type";
            this.colType.Name = "colType";
            this.colType.OptionsColumn.FixedWidth = true;
            this.colType.Visible = true;
            this.colType.VisibleIndex = 2;
            this.colType.Width = 120;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // colSaveDate
            // 
            this.colSaveDate.Caption = "SaveDate";
            this.colSaveDate.FieldName = "SaveDate";
            this.colSaveDate.Name = "colSaveDate";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.nbiNew,
            this.nbiEdit,
            this.nbiDelete,
            this.nbiRefresh,
            this.nbiClose});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.Size = new System.Drawing.Size(148, 526);
            this.navBarControl1.SmallImages = this.MainImageList;
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Task";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiNew),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiEdit),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiDelete)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // nbiNew
            // 
            this.nbiNew.Caption = "New";
            this.nbiNew.Name = "nbiNew";
            this.nbiNew.SmallImageIndex = 3;
            this.nbiNew.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiNew_LinkClicked);
            // 
            // nbiEdit
            // 
            this.nbiEdit.Caption = "Edit";
            this.nbiEdit.Name = "nbiEdit";
            this.nbiEdit.SmallImageIndex = 20;
            this.nbiEdit.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiEdit_LinkClicked);
            // 
            // nbiDelete
            // 
            this.nbiDelete.Caption = "Delete";
            this.nbiDelete.Name = "nbiDelete";
            this.nbiDelete.SmallImageIndex = 1;
            this.nbiDelete.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiDelete_LinkClicked);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Generals";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiRefresh),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiClose)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // nbiRefresh
            // 
            this.nbiRefresh.Caption = "Refresh";
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
            // frmNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 564);
            this.FrmText = "New User Form";
            this.Name = "frmNewUser";
            this.Text = "New User Form";
            this.spcMaster.Panel1.ResumeLayout(false);
            this.spcMaster.Panel2.ResumeLayout(false);
            this.spcMaster.ResumeLayout(false);
            this.spcNav.Panel1.ResumeLayout(false);
            this.spcNav.Panel2.ResumeLayout(false);
            this.spcNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainErrorProvider)).EndInit();
            this.spcUser.Panel1.ResumeLayout(false);
            this.spcUser.Panel1.PerformLayout();
            this.spcUser.Panel2.ResumeLayout(false);
            this.spcUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbUserType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCompanyDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcUser;
        private DevExpress.XtraEditors.ComboBoxEdit cmbUserType;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtpassword;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtUserID;
        private DevExpress.XtraEditors.TextEdit txtCPassword;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnApply;
        private DevExpress.XtraGrid.GridControl dgUser;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem nbiNew;
        private DevExpress.XtraNavBar.NavBarItem nbiEdit;
        private DevExpress.XtraNavBar.NavBarItem nbiDelete;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem nbiRefresh;
        private DevExpress.XtraNavBar.NavBarItem nbiClose;
        private System.Windows.Forms.BindingSource loginUserBindingSource;
        private UserCompanyDataset userCompanyDataset;
        private DevExpress.XtraGrid.Columns.GridColumn colIID;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraGrid.Columns.GridColumn colSaveDate;

    }
}