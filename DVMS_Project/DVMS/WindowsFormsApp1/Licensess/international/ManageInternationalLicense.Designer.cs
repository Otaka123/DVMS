namespace WindowsFormsApp1
{
    partial class ManageInternationalLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageInternationalLicense));
            this.lbRowsNum = new System.Windows.Forms.Label();
            this.pbAddApp = new System.Windows.Forms.PictureBox();
            this.dgvApp = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.searchBar1 = new WindowsFormsApp1.SearchBar();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbRowsNum
            // 
            this.lbRowsNum.AutoSize = true;
            this.lbRowsNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRowsNum.Location = new System.Drawing.Point(6, 683);
            this.lbRowsNum.Name = "lbRowsNum";
            this.lbRowsNum.Size = new System.Drawing.Size(57, 20);
            this.lbRowsNum.TabIndex = 11;
            this.lbRowsNum.Text = "label2";
            // 
            // pbAddApp
            // 
            this.pbAddApp.Location = new System.Drawing.Point(1171, 219);
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
            this.dgvApp.Location = new System.Drawing.Point(10, 308);
            this.dgvApp.Name = "dgvApp";
            this.dgvApp.ReadOnly = true;
            this.dgvApp.Size = new System.Drawing.Size(1255, 345);
            this.dgvApp.TabIndex = 8;
            this.dgvApp.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvApp_CellMouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(517, 50);
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
            this.label1.Location = new System.Drawing.Point(374, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(601, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "international Driving License Applications";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "0a.png");
            this.imageList1.Images.SetKeyName(1, "resume0025.png");
            // 
            // searchBar1
            // 
            this.searchBar1.BackColor = System.Drawing.Color.Transparent;
            this.searchBar1.Location = new System.Drawing.Point(410, 256);
            this.searchBar1.Name = "searchBar1";
            this.searchBar1.NationalNo = null;
            this.searchBar1.Size = new System.Drawing.Size(467, 40);
            this.searchBar1.TabIndex = 9;
            // 
            // ManageInternationalLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 752);
            this.Controls.Add(this.lbRowsNum);
            this.Controls.Add(this.pbAddApp);
            this.Controls.Add(this.searchBar1);
            this.Controls.Add(this.dgvApp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "ManageInternationalLicense";
            this.Text = "ManageInternationalLicense";
            this.Load += new System.EventHandler(this.ManageInternationalLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAddApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}