namespace WindowsFormsApp1
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.systemimage = new System.Windows.Forms.ImageList(this.components);
            this.pbpeople = new System.Windows.Forms.PictureBox();
            this.pbAcountSeittnngs = new System.Windows.Forms.PictureBox();
            this.cmsAccountSettings = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsAccountcurrentUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsAcountchangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsAccountlogout = new System.Windows.Forms.ToolStripMenuItem();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.pbDrivers = new System.Windows.Forms.PictureBox();
            this.pbApplication = new System.Windows.Forms.PictureBox();
            this.cmsApplications = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.drivingLicensesServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.replacementForLostOrDamageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.releaseDetainedDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.manageApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localDrivingLicenseApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalLicenseApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.detainLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDetainedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTestTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbpeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAcountSeittnngs)).BeginInit();
            this.cmsAccountSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApplication)).BeginInit();
            this.cmsApplications.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // systemimage
            // 
            this.systemimage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("systemimage.ImageStream")));
            this.systemimage.TransparentColor = System.Drawing.Color.Transparent;
            this.systemimage.Images.SetKeyName(0, "people.png");
            this.systemimage.Images.SetKeyName(1, "peopleonEnter.png");
            this.systemimage.Images.SetKeyName(2, "Application.png");
            this.systemimage.Images.SetKeyName(3, "ApplicationEnter.png");
            this.systemimage.Images.SetKeyName(4, "driver.png");
            this.systemimage.Images.SetKeyName(5, "driverEnter.png");
            this.systemimage.Images.SetKeyName(6, "Users.png");
            this.systemimage.Images.SetKeyName(7, "Usersenter.png");
            this.systemimage.Images.SetKeyName(8, "account-settings (1).png");
            this.systemimage.Images.SetKeyName(9, "account-settings.png");
            // 
            // pbpeople
            // 
            this.pbpeople.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbpeople.Location = new System.Drawing.Point(30, 10);
            this.pbpeople.Name = "pbpeople";
            this.pbpeople.Size = new System.Drawing.Size(125, 102);
            this.pbpeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbpeople.TabIndex = 0;
            this.pbpeople.TabStop = false;
            this.pbpeople.Click += new System.EventHandler(this.pbpeople_Click);
            this.pbpeople.MouseEnter += new System.EventHandler(this.pbpeople_MouseEnter);
            this.pbpeople.MouseLeave += new System.EventHandler(this.pbpeople_MouseLeave);
            // 
            // pbAcountSeittnngs
            // 
            this.pbAcountSeittnngs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAcountSeittnngs.ContextMenuStrip = this.cmsAccountSettings;
            this.pbAcountSeittnngs.Location = new System.Drawing.Point(34, 10);
            this.pbAcountSeittnngs.Name = "pbAcountSeittnngs";
            this.pbAcountSeittnngs.Size = new System.Drawing.Size(116, 113);
            this.pbAcountSeittnngs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAcountSeittnngs.TabIndex = 1;
            this.pbAcountSeittnngs.TabStop = false;
            this.pbAcountSeittnngs.Click += new System.EventHandler(this.pbAcountSeittnngs_Click);
            this.pbAcountSeittnngs.MouseEnter += new System.EventHandler(this.pbAcountSeittnngs_MouseEnter);
            this.pbAcountSeittnngs.MouseLeave += new System.EventHandler(this.pbAcountSeittnngs_MouseLeave);
            // 
            // cmsAccountSettings
            // 
            this.cmsAccountSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsAccountcurrentUserInfo,
            this.cmsAcountchangePassword,
            this.cmsAccountlogout});
            this.cmsAccountSettings.Name = "cmsAccountSettings";
            this.cmsAccountSettings.Size = new System.Drawing.Size(169, 70);
            // 
            // cmsAccountcurrentUserInfo
            // 
            this.cmsAccountcurrentUserInfo.Image = ((System.Drawing.Image)(resources.GetObject("cmsAccountcurrentUserInfo.Image")));
            this.cmsAccountcurrentUserInfo.Name = "cmsAccountcurrentUserInfo";
            this.cmsAccountcurrentUserInfo.Size = new System.Drawing.Size(168, 22);
            this.cmsAccountcurrentUserInfo.Text = "Current User Info";
            this.cmsAccountcurrentUserInfo.Click += new System.EventHandler(this.cmsAccountcurrentUserInfo_Click);
            // 
            // cmsAcountchangePassword
            // 
            this.cmsAcountchangePassword.Image = ((System.Drawing.Image)(resources.GetObject("cmsAcountchangePassword.Image")));
            this.cmsAcountchangePassword.Name = "cmsAcountchangePassword";
            this.cmsAcountchangePassword.Size = new System.Drawing.Size(168, 22);
            this.cmsAcountchangePassword.Text = "Change password";
            this.cmsAcountchangePassword.Click += new System.EventHandler(this.cmsAcountchangePassword_Click);
            // 
            // cmsAccountlogout
            // 
            this.cmsAccountlogout.Image = ((System.Drawing.Image)(resources.GetObject("cmsAccountlogout.Image")));
            this.cmsAccountlogout.Name = "cmsAccountlogout";
            this.cmsAccountlogout.Size = new System.Drawing.Size(168, 22);
            this.cmsAccountlogout.Text = "log out";
            this.cmsAccountlogout.Click += new System.EventHandler(this.cmsAccountlogout_Click);
            // 
            // pbUser
            // 
            this.pbUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbUser.Location = new System.Drawing.Point(32, 10);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(125, 102);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUser.TabIndex = 2;
            this.pbUser.TabStop = false;
            this.pbUser.Click += new System.EventHandler(this.pbUser_Click);
            this.pbUser.MouseEnter += new System.EventHandler(this.pbUser_MouseEnter);
            this.pbUser.MouseLeave += new System.EventHandler(this.pbUser_MouseLeave);
            // 
            // pbDrivers
            // 
            this.pbDrivers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDrivers.Location = new System.Drawing.Point(29, 10);
            this.pbDrivers.Name = "pbDrivers";
            this.pbDrivers.Size = new System.Drawing.Size(125, 102);
            this.pbDrivers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDrivers.TabIndex = 3;
            this.pbDrivers.TabStop = false;
            this.pbDrivers.Click += new System.EventHandler(this.pbDrivers_Click);
            this.pbDrivers.MouseEnter += new System.EventHandler(this.pbDrivers_MouseEnter);
            this.pbDrivers.MouseLeave += new System.EventHandler(this.pbDrivers_MouseLeave);
            // 
            // pbApplication
            // 
            this.pbApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbApplication.ContextMenuStrip = this.cmsApplications;
            this.pbApplication.Location = new System.Drawing.Point(27, 10);
            this.pbApplication.Name = "pbApplication";
            this.pbApplication.Size = new System.Drawing.Size(125, 102);
            this.pbApplication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbApplication.TabIndex = 4;
            this.pbApplication.TabStop = false;
            this.pbApplication.Click += new System.EventHandler(this.pbApplication_Click);
            this.pbApplication.MouseEnter += new System.EventHandler(this.pbApplication_MouseEnter);
            this.pbApplication.MouseLeave += new System.EventHandler(this.pbApplication_MouseLeave);
            // 
            // cmsApplications
            // 
            this.cmsApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drivingLicensesServicesToolStripMenuItem,
            this.toolStripSeparator1,
            this.manageApplicationsToolStripMenuItem,
            this.toolStripSeparator2,
            this.detainLicensesToolStripMenuItem,
            this.manageApplicationTypesToolStripMenuItem,
            this.manageTestTypesToolStripMenuItem});
            this.cmsApplications.Name = "cmsApplications";
            this.cmsApplications.Size = new System.Drawing.Size(213, 148);
            this.cmsApplications.Opening += new System.ComponentModel.CancelEventHandler(this.cmsApplications_Opening);
            // 
            // drivingLicensesServicesToolStripMenuItem
            // 
            this.drivingLicensesServicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDrivingLicenseToolStripMenuItem,
            this.renewDrivingLicenseToolStripMenuItem,
            this.toolStripSeparator3,
            this.replacementForLostOrDamageToolStripMenuItem,
            this.toolStripSeparator4,
            this.releaseDetainedDrivingLicenseToolStripMenuItem});
            this.drivingLicensesServicesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("drivingLicensesServicesToolStripMenuItem.Image")));
            this.drivingLicensesServicesToolStripMenuItem.Name = "drivingLicensesServicesToolStripMenuItem";
            this.drivingLicensesServicesToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.drivingLicensesServicesToolStripMenuItem.Text = "Driving License services";
            // 
            // newDrivingLicenseToolStripMenuItem
            // 
            this.newDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localLicenseToolStripMenuItem,
            this.internationalLicenseToolStripMenuItem});
            this.newDrivingLicenseToolStripMenuItem.Name = "newDrivingLicenseToolStripMenuItem";
            this.newDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.newDrivingLicenseToolStripMenuItem.Text = "New Driving license";
            this.newDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.newDrivingLicenseToolStripMenuItem_Click);
            // 
            // localLicenseToolStripMenuItem
            // 
            this.localLicenseToolStripMenuItem.Name = "localLicenseToolStripMenuItem";
            this.localLicenseToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.localLicenseToolStripMenuItem.Text = "Local License";
            this.localLicenseToolStripMenuItem.Click += new System.EventHandler(this.localLicenseToolStripMenuItem_Click);
            // 
            // internationalLicenseToolStripMenuItem
            // 
            this.internationalLicenseToolStripMenuItem.Name = "internationalLicenseToolStripMenuItem";
            this.internationalLicenseToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.internationalLicenseToolStripMenuItem.Text = "International License";
            this.internationalLicenseToolStripMenuItem.Click += new System.EventHandler(this.internationalLicenseToolStripMenuItem_Click);
            // 
            // renewDrivingLicenseToolStripMenuItem
            // 
            this.renewDrivingLicenseToolStripMenuItem.Name = "renewDrivingLicenseToolStripMenuItem";
            this.renewDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.renewDrivingLicenseToolStripMenuItem.Text = "Renew Driving License";
            this.renewDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.renewDrivingLicenseToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(293, 6);
            // 
            // replacementForLostOrDamageToolStripMenuItem
            // 
            this.replacementForLostOrDamageToolStripMenuItem.Name = "replacementForLostOrDamageToolStripMenuItem";
            this.replacementForLostOrDamageToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.replacementForLostOrDamageToolStripMenuItem.Text = "Replacement for Lost or Damaged License";
            this.replacementForLostOrDamageToolStripMenuItem.Click += new System.EventHandler(this.replacementForLostOrDamageToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(293, 6);
            // 
            // releaseDetainedDrivingLicenseToolStripMenuItem
            // 
            this.releaseDetainedDrivingLicenseToolStripMenuItem.Name = "releaseDetainedDrivingLicenseToolStripMenuItem";
            this.releaseDetainedDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.releaseDetainedDrivingLicenseToolStripMenuItem.Text = "Release Detained Driving License";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(209, 6);
            // 
            // manageApplicationsToolStripMenuItem
            // 
            this.manageApplicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localDrivingLicenseApplicationsToolStripMenuItem,
            this.internationalLicenseApplicationToolStripMenuItem});
            this.manageApplicationsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manageApplicationsToolStripMenuItem.Image")));
            this.manageApplicationsToolStripMenuItem.Name = "manageApplicationsToolStripMenuItem";
            this.manageApplicationsToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.manageApplicationsToolStripMenuItem.Text = "Manage Applications";
            // 
            // localDrivingLicenseApplicationsToolStripMenuItem
            // 
            this.localDrivingLicenseApplicationsToolStripMenuItem.Name = "localDrivingLicenseApplicationsToolStripMenuItem";
            this.localDrivingLicenseApplicationsToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.localDrivingLicenseApplicationsToolStripMenuItem.Text = "Local Driving License Applications";
            this.localDrivingLicenseApplicationsToolStripMenuItem.Click += new System.EventHandler(this.localDrivingLicenseApplicationsToolStripMenuItem_Click);
            // 
            // internationalLicenseApplicationToolStripMenuItem
            // 
            this.internationalLicenseApplicationToolStripMenuItem.Name = "internationalLicenseApplicationToolStripMenuItem";
            this.internationalLicenseApplicationToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.internationalLicenseApplicationToolStripMenuItem.Text = "International License Application";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(209, 6);
            // 
            // detainLicensesToolStripMenuItem
            // 
            this.detainLicensesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageDetainedLicenseToolStripMenuItem,
            this.detainedLicenseToolStripMenuItem,
            this.releaseLicenseToolStripMenuItem});
            this.detainLicensesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("detainLicensesToolStripMenuItem.Image")));
            this.detainLicensesToolStripMenuItem.Name = "detainLicensesToolStripMenuItem";
            this.detainLicensesToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.detainLicensesToolStripMenuItem.Text = "Detain Licenses";
            // 
            // manageDetainedLicenseToolStripMenuItem
            // 
            this.manageDetainedLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manageDetainedLicenseToolStripMenuItem.Image")));
            this.manageDetainedLicenseToolStripMenuItem.Name = "manageDetainedLicenseToolStripMenuItem";
            this.manageDetainedLicenseToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.manageDetainedLicenseToolStripMenuItem.Text = "Manage Detained License";
            this.manageDetainedLicenseToolStripMenuItem.Click += new System.EventHandler(this.manageDetainedLicenseToolStripMenuItem_Click);
            // 
            // detainedLicenseToolStripMenuItem
            // 
            this.detainedLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("detainedLicenseToolStripMenuItem.Image")));
            this.detainedLicenseToolStripMenuItem.Name = "detainedLicenseToolStripMenuItem";
            this.detainedLicenseToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.detainedLicenseToolStripMenuItem.Text = "Detained License";
            this.detainedLicenseToolStripMenuItem.Click += new System.EventHandler(this.detainedLicenseToolStripMenuItem_Click);
            // 
            // releaseLicenseToolStripMenuItem
            // 
            this.releaseLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("releaseLicenseToolStripMenuItem.Image")));
            this.releaseLicenseToolStripMenuItem.Name = "releaseLicenseToolStripMenuItem";
            this.releaseLicenseToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.releaseLicenseToolStripMenuItem.Text = "Release License";
            this.releaseLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseLicenseToolStripMenuItem_Click);
            // 
            // manageApplicationTypesToolStripMenuItem
            // 
            this.manageApplicationTypesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manageApplicationTypesToolStripMenuItem.Image")));
            this.manageApplicationTypesToolStripMenuItem.Name = "manageApplicationTypesToolStripMenuItem";
            this.manageApplicationTypesToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.manageApplicationTypesToolStripMenuItem.Text = "Manage Application types";
            this.manageApplicationTypesToolStripMenuItem.Click += new System.EventHandler(this.manageApplicationTypesToolStripMenuItem_Click);
            // 
            // manageTestTypesToolStripMenuItem
            // 
            this.manageTestTypesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manageTestTypesToolStripMenuItem.Image")));
            this.manageTestTypesToolStripMenuItem.Name = "manageTestTypesToolStripMenuItem";
            this.manageTestTypesToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.manageTestTypesToolStripMenuItem.Text = "Manage test types";
            this.manageTestTypesToolStripMenuItem.Click += new System.EventHandler(this.manageTestTypesToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1943, 164);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.pbApplication);
            this.panel5.Location = new System.Drawing.Point(213, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(184, 158);
            this.panel5.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Manage Applications";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.pbpeople);
            this.panel4.Location = new System.Drawing.Point(841, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(184, 158);
            this.panel4.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Manage people";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.pbDrivers);
            this.panel6.Location = new System.Drawing.Point(488, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(184, 158);
            this.panel6.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Manage Drivers";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pbUser);
            this.panel3.Location = new System.Drawing.Point(1158, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(184, 158);
            this.panel3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Manage Users";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pbAcountSeittnngs);
            this.panel2.Location = new System.Drawing.Point(1475, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 158);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "AccountSettings";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 773);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbpeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAcountSeittnngs)).EndInit();
            this.cmsAccountSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApplication)).EndInit();
            this.cmsApplications.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList systemimage;
        private System.Windows.Forms.PictureBox pbpeople;
        private System.Windows.Forms.PictureBox pbAcountSeittnngs;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.PictureBox pbDrivers;
        private System.Windows.Forms.PictureBox pbApplication;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip cmsAccountSettings;
        private System.Windows.Forms.ToolStripMenuItem cmsAccountcurrentUserInfo;
        private System.Windows.Forms.ToolStripMenuItem cmsAcountchangePassword;
        private System.Windows.Forms.ToolStripMenuItem cmsAccountlogout;
        private System.Windows.Forms.ContextMenuStrip cmsApplications;
        private System.Windows.Forms.ToolStripMenuItem drivingLicensesServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem detainLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTestTypesToolStripMenuItem;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem newDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renewDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replacementForLostOrDamageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainedDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localDrivingLicenseApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalLicenseApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDetainedLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainedLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseLicenseToolStripMenuItem;
    }
}

