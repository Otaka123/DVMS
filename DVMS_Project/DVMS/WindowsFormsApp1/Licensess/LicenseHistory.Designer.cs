namespace WindowsFormsApp1
{
    partial class LicenseHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LicenseHistory));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tcDriverLicense = new System.Windows.Forms.TabControl();
            this.tLocal = new System.Windows.Forms.TabPage();
            this.international = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvlocal = new System.Windows.Forms.DataGridView();
            this.lblocalrows = new System.Windows.Forms.Label();
            this.lbinterows = new System.Windows.Forms.Label();
            this.dgvinternational = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.personCard1 = new WindowsFormsApp1.personCard();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tcDriverLicense.SuspendLayout();
            this.tLocal.SuspendLayout();
            this.international.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinternational)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "LicenseHistory";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(304, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tcDriverLicense
            // 
            this.tcDriverLicense.Controls.Add(this.tLocal);
            this.tcDriverLicense.Controls.Add(this.international);
            this.tcDriverLicense.Location = new System.Drawing.Point(12, 515);
            this.tcDriverLicense.Name = "tcDriverLicense";
            this.tcDriverLicense.SelectedIndex = 0;
            this.tcDriverLicense.Size = new System.Drawing.Size(759, 236);
            this.tcDriverLicense.TabIndex = 3;
            // 
            // tLocal
            // 
            this.tLocal.Controls.Add(this.lblocalrows);
            this.tLocal.Controls.Add(this.dgvlocal);
            this.tLocal.Controls.Add(this.label2);
            this.tLocal.Location = new System.Drawing.Point(4, 22);
            this.tLocal.Name = "tLocal";
            this.tLocal.Padding = new System.Windows.Forms.Padding(3);
            this.tLocal.Size = new System.Drawing.Size(751, 210);
            this.tLocal.TabIndex = 0;
            this.tLocal.Text = "Local";
            this.tLocal.UseVisualStyleBackColor = true;
            // 
            // international
            // 
            this.international.Controls.Add(this.lbinterows);
            this.international.Controls.Add(this.dgvinternational);
            this.international.Controls.Add(this.label4);
            this.international.Location = new System.Drawing.Point(4, 22);
            this.international.Name = "international";
            this.international.Padding = new System.Windows.Forms.Padding(3);
            this.international.Size = new System.Drawing.Size(751, 210);
            this.international.TabIndex = 1;
            this.international.Text = "international";
            this.international.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "LocalLicense History :";
            // 
            // dgvlocal
            // 
            this.dgvlocal.AllowUserToAddRows = false;
            this.dgvlocal.AllowUserToDeleteRows = false;
            this.dgvlocal.AllowUserToOrderColumns = true;
            this.dgvlocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlocal.Location = new System.Drawing.Point(9, 25);
            this.dgvlocal.Name = "dgvlocal";
            this.dgvlocal.ReadOnly = true;
            this.dgvlocal.Size = new System.Drawing.Size(736, 150);
            this.dgvlocal.TabIndex = 1;
            // 
            // lblocalrows
            // 
            this.lblocalrows.AutoSize = true;
            this.lblocalrows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblocalrows.Location = new System.Drawing.Point(19, 184);
            this.lblocalrows.Name = "lblocalrows";
            this.lblocalrows.Size = new System.Drawing.Size(39, 16);
            this.lblocalrows.TabIndex = 2;
            this.lblocalrows.Text = "????";
            // 
            // lbinterows
            // 
            this.lbinterows.AutoSize = true;
            this.lbinterows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbinterows.Location = new System.Drawing.Point(19, 187);
            this.lbinterows.Name = "lbinterows";
            this.lbinterows.Size = new System.Drawing.Size(39, 16);
            this.lbinterows.TabIndex = 5;
            this.lbinterows.Text = "????";
            // 
            // dgvinternational
            // 
            this.dgvinternational.AllowUserToAddRows = false;
            this.dgvinternational.AllowUserToDeleteRows = false;
            this.dgvinternational.AllowUserToOrderColumns = true;
            this.dgvinternational.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinternational.Location = new System.Drawing.Point(9, 28);
            this.dgvinternational.Name = "dgvinternational";
            this.dgvinternational.ReadOnly = true;
            this.dgvinternational.Size = new System.Drawing.Size(736, 150);
            this.dgvinternational.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "internationlLicense History :";
            // 
            // personCard1
            // 
            this.personCard1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("personCard1.BackgroundImage")));
            this.personCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.personCard1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.personCard1.Location = new System.Drawing.Point(57, 153);
            this.personCard1.Name = "personCard1";
            this.personCard1.Size = new System.Drawing.Size(674, 336);
            this.personCard1.TabIndex = 0;
            // 
            // LicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 781);
            this.Controls.Add(this.tcDriverLicense);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.personCard1);
            this.Name = "LicenseHistory";
            this.Text = "LicenseHistory";
            this.Load += new System.EventHandler(this.LicenseHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tcDriverLicense.ResumeLayout(false);
            this.tLocal.ResumeLayout(false);
            this.tLocal.PerformLayout();
            this.international.ResumeLayout(false);
            this.international.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinternational)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private personCard personCard1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tcDriverLicense;
        private System.Windows.Forms.TabPage tLocal;
        private System.Windows.Forms.TabPage international;
        private System.Windows.Forms.Label lblocalrows;
        private System.Windows.Forms.DataGridView dgvlocal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbinterows;
        private System.Windows.Forms.DataGridView dgvinternational;
        private System.Windows.Forms.Label label4;
    }
}