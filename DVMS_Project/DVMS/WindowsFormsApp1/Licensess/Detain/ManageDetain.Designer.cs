namespace WindowsFormsApp1.Licensess.Detain
{
    partial class ManageDetain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageDetain));
            this.lbRowsNum = new System.Windows.Forms.Label();
            this.pbAddApp = new System.Windows.Forms.PictureBox();
            this.dgvApp = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licensesHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.releaseLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pbrelease = new System.Windows.Forms.PictureBox();
            this.searchBar1 = new WindowsFormsApp1.SearchBar();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApp)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbrelease)).BeginInit();
            this.SuspendLayout();
            // 
            // lbRowsNum
            // 
            this.lbRowsNum.AutoSize = true;
            this.lbRowsNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRowsNum.Location = new System.Drawing.Point(8, 640);
            this.lbRowsNum.Name = "lbRowsNum";
            this.lbRowsNum.Size = new System.Drawing.Size(57, 20);
            this.lbRowsNum.TabIndex = 11;
            this.lbRowsNum.Text = "label2";
            // 
            // pbAddApp
            // 
            this.pbAddApp.Location = new System.Drawing.Point(1173, 176);
            this.pbAddApp.Name = "pbAddApp";
            this.pbAddApp.Size = new System.Drawing.Size(80, 85);
            this.pbAddApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAddApp.TabIndex = 10;
            this.pbAddApp.TabStop = false;
            this.pbAddApp.Click += new System.EventHandler(this.pbAddApp_Click);
            this.pbAddApp.MouseEnter += new System.EventHandler(this.pbAddApp_MouseEnter);
            this.pbAddApp.MouseLeave += new System.EventHandler(this.pbAddApp_MouseLeave);
            // 
            // dgvApp
            // 
            this.dgvApp.AllowUserToAddRows = false;
            this.dgvApp.AllowUserToDeleteRows = false;
            this.dgvApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApp.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvApp.Location = new System.Drawing.Point(12, 265);
            this.dgvApp.Name = "dgvApp";
            this.dgvApp.ReadOnly = true;
            this.dgvApp.Size = new System.Drawing.Size(1255, 345);
            this.dgvApp.TabIndex = 8;
            this.dgvApp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvApp_CellClick);
            this.dgvApp.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvApp_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonInfoToolStripMenuItem,
            this.showLicenseInfoToolStripMenuItem,
            this.licensesHistoryToolStripMenuItem,
            this.toolStripSeparator1,
            this.releaseLicenseToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 120);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showPersonInfoToolStripMenuItem
            // 
            this.showPersonInfoToolStripMenuItem.Name = "showPersonInfoToolStripMenuItem";
            this.showPersonInfoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.showPersonInfoToolStripMenuItem.Text = "Show Person Info";
            this.showPersonInfoToolStripMenuItem.Click += new System.EventHandler(this.showPersonInfoToolStripMenuItem_Click);
            // 
            // showLicenseInfoToolStripMenuItem
            // 
            this.showLicenseInfoToolStripMenuItem.Name = "showLicenseInfoToolStripMenuItem";
            this.showLicenseInfoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.showLicenseInfoToolStripMenuItem.Text = "Show License info";
            this.showLicenseInfoToolStripMenuItem.Click += new System.EventHandler(this.showLicenseInfoToolStripMenuItem_Click);
            // 
            // licensesHistoryToolStripMenuItem
            // 
            this.licensesHistoryToolStripMenuItem.Name = "licensesHistoryToolStripMenuItem";
            this.licensesHistoryToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.licensesHistoryToolStripMenuItem.Text = "Licenses History";
            this.licensesHistoryToolStripMenuItem.Click += new System.EventHandler(this.licensesHistoryToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(166, 6);
            // 
            // releaseLicenseToolStripMenuItem
            // 
            this.releaseLicenseToolStripMenuItem.Name = "releaseLicenseToolStripMenuItem";
            this.releaseLicenseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.releaseLicenseToolStripMenuItem.Text = "Release License";
            this.releaseLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseLicenseToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(519, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Manage Detained Licenses";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "handcuffs.png");
            this.imageList1.Images.SetKeyName(1, "handcuffs (1).png");
            this.imageList1.Images.SetKeyName(2, "unlocked.png");
            this.imageList1.Images.SetKeyName(3, "unlocked (1).png");
            // 
            // pbrelease
            // 
            this.pbrelease.Location = new System.Drawing.Point(1078, 176);
            this.pbrelease.Name = "pbrelease";
            this.pbrelease.Size = new System.Drawing.Size(80, 85);
            this.pbrelease.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbrelease.TabIndex = 13;
            this.pbrelease.TabStop = false;
            this.pbrelease.Click += new System.EventHandler(this.pbrelease_Click);
            this.pbrelease.MouseEnter += new System.EventHandler(this.pbrelease_MouseEnter);
            this.pbrelease.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // searchBar1
            // 
            this.searchBar1.BackColor = System.Drawing.Color.Transparent;
            this.searchBar1.Location = new System.Drawing.Point(412, 213);
            this.searchBar1.Name = "searchBar1";
            this.searchBar1.NationalNo = null;
            this.searchBar1.Size = new System.Drawing.Size(467, 40);
            this.searchBar1.TabIndex = 9;
            // 
            // ManageDetain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 667);
            this.Controls.Add(this.pbrelease);
            this.Controls.Add(this.lbRowsNum);
            this.Controls.Add(this.pbAddApp);
            this.Controls.Add(this.searchBar1);
            this.Controls.Add(this.dgvApp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "ManageDetain";
            this.Text = "ManageDetain";
            this.Load += new System.EventHandler(this.ManageDetain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAddApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApp)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbrelease)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRowsNum;
        private System.Windows.Forms.PictureBox pbAddApp;
        private SearchBar searchBar1;
        private System.Windows.Forms.DataGridView dgvApp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPersonInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licensesHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem releaseLicenseToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbrelease;
    }
}