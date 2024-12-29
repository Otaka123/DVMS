namespace WindowsFormsApp1
{
    partial class peopleMangement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(peopleMangement));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvpeople = new System.Windows.Forms.DataGridView();
            this.pbAddNewperson = new System.Windows.Forms.PictureBox();
            this.pbpeoplemanage = new System.Windows.Forms.PictureBox();
            this.lbRowsNum = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Showditailmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBar = new WindowsFormsApp1.SearchBar();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddNewperson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpeoplemanage)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(417, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage people";
            // 
            // dgvpeople
            // 
            this.dgvpeople.AllowUserToAddRows = false;
            this.dgvpeople.AllowUserToDeleteRows = false;
            this.dgvpeople.AllowUserToOrderColumns = true;
            this.dgvpeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpeople.Location = new System.Drawing.Point(2, 199);
            this.dgvpeople.Name = "dgvpeople";
            this.dgvpeople.ReadOnly = true;
            this.dgvpeople.Size = new System.Drawing.Size(1152, 298);
            this.dgvpeople.TabIndex = 1;
            this.dgvpeople.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpeople_CellClick);
            this.dgvpeople.CellContextMenuStripChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpeople_CellContextMenuStripChanged);
            this.dgvpeople.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvpeople_CellMouseDown);
            this.dgvpeople.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvpeople_MouseDown);
            // 
            // pbAddNewperson
            // 
            this.pbAddNewperson.Image = global::WindowsFormsApp1.Properties.Resources.add_friend;
            this.pbAddNewperson.Location = new System.Drawing.Point(1035, 129);
            this.pbAddNewperson.Name = "pbAddNewperson";
            this.pbAddNewperson.Size = new System.Drawing.Size(80, 55);
            this.pbAddNewperson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddNewperson.TabIndex = 2;
            this.pbAddNewperson.TabStop = false;
            this.pbAddNewperson.Click += new System.EventHandler(this.pbAddNewperson_Click);
            this.pbAddNewperson.MouseEnter += new System.EventHandler(this.pbAddNewperson_MouseEnter);
            this.pbAddNewperson.MouseLeave += new System.EventHandler(this.pbAddNewperson_MouseLeave);
            // 
            // pbpeoplemanage
            // 
            this.pbpeoplemanage.Image = ((System.Drawing.Image)(resources.GetObject("pbpeoplemanage.Image")));
            this.pbpeoplemanage.Location = new System.Drawing.Point(497, 106);
            this.pbpeoplemanage.Name = "pbpeoplemanage";
            this.pbpeoplemanage.Size = new System.Drawing.Size(145, 87);
            this.pbpeoplemanage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbpeoplemanage.TabIndex = 3;
            this.pbpeoplemanage.TabStop = false;
            this.pbpeoplemanage.Click += new System.EventHandler(this.pbpeoplemanage_Click);
            // 
            // lbRowsNum
            // 
            this.lbRowsNum.AutoSize = true;
            this.lbRowsNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRowsNum.Location = new System.Drawing.Point(41, 520);
            this.lbRowsNum.Name = "lbRowsNum";
            this.lbRowsNum.Size = new System.Drawing.Size(39, 20);
            this.lbRowsNum.TabIndex = 4;
            this.lbRowsNum.Text = "???";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Showditailmenu,
            this.addNewPersonToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.sendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(163, 136);
            // 
            // Showditailmenu
            // 
            this.Showditailmenu.Image = ((System.Drawing.Image)(resources.GetObject("Showditailmenu.Image")));
            this.Showditailmenu.Name = "Showditailmenu";
            this.Showditailmenu.Size = new System.Drawing.Size(162, 22);
            this.Showditailmenu.Text = "Show details";
            this.Showditailmenu.Click += new System.EventHandler(this.Showditailmenu_Click);
            // 
            // addNewPersonToolStripMenuItem
            // 
            this.addNewPersonToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewPersonToolStripMenuItem.Image")));
            this.addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            this.addNewPersonToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addNewPersonToolStripMenuItem.Text = "Add New person";
            this.addNewPersonToolStripMenuItem.Click += new System.EventHandler(this.addNewPersonToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem.Image")));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sendEmailToolStripMenuItem.Image")));
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            this.sendEmailToolStripMenuItem.Click += new System.EventHandler(this.sendEmailToolStripMenuItem_Click);
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("phoneCallToolStripMenuItem.Image")));
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.phoneCallToolStripMenuItem.Text = "Phone Call";
            this.phoneCallToolStripMenuItem.Click += new System.EventHandler(this.phoneCallToolStripMenuItem_Click);
            // 
            // searchBar
            // 
            this.searchBar.BackColor = System.Drawing.Color.Transparent;
            this.searchBar.Location = new System.Drawing.Point(12, 124);
            this.searchBar.Name = "searchBar";
            this.searchBar.NationalNo = null;
            this.searchBar.Size = new System.Drawing.Size(479, 69);
            this.searchBar.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1035, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Add New";
            // 
            // peopleMangement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 562);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.lbRowsNum);
            this.Controls.Add(this.pbpeoplemanage);
            this.Controls.Add(this.pbAddNewperson);
            this.Controls.Add(this.dgvpeople);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "peopleMangement";
            this.Text = "peopleMangement";
            this.Load += new System.EventHandler(this.peopleMangement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddNewperson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpeoplemanage)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvpeople;
        private System.Windows.Forms.PictureBox pbAddNewperson;
        private System.Windows.Forms.PictureBox pbpeoplemanage;
        private System.Windows.Forms.Label lbRowsNum;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Showditailmenu;
        private System.Windows.Forms.ToolStripMenuItem addNewPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private SearchBar searchBar;
        private System.Windows.Forms.Label label2;
    }
}