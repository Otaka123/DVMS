namespace WindowsFormsApp1
{
    partial class RenewDrivingLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenewDrivingLicense));
            this.lblTitle = new System.Windows.Forms.Label();
            this.licenseCardWithFilter1 = new WindowsFormsApp1.LicenseCardWithFilter();
            this.applicationCard1 = new WindowsFormsApp1.ApplicationCard();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pbSave = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.buttonsimage = new System.Windows.Forms.ImageList(this.components);
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(172, 52);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(875, 39);
            this.lblTitle.TabIndex = 177;
            this.lblTitle.Text = "Renew License Application";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // licenseCardWithFilter1
            // 
            this.licenseCardWithFilter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.licenseCardWithFilter1.Location = new System.Drawing.Point(713, 128);
            this.licenseCardWithFilter1.Name = "licenseCardWithFilter1";
            this.licenseCardWithFilter1.Size = new System.Drawing.Size(570, 412);
            this.licenseCardWithFilter1.TabIndex = 0;
            this.licenseCardWithFilter1.OnLicenseSelected += new System.Action<int, int>(this.licenseCardWithFilter1_OnLicenseSelected);
            // 
            // applicationCard1
            // 
            this.applicationCard1.Appid = 0;
            this.applicationCard1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("applicationCard1.BackgroundImage")));
            this.applicationCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.applicationCard1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.applicationCard1.Location = new System.Drawing.Point(-141, 126);
            this.applicationCard1.Name = "applicationCard1";
            this.applicationCard1.Size = new System.Drawing.Size(870, 419);
            this.applicationCard1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(1, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1277, 12);
            this.panel1.TabIndex = 178;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(3, 538);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1277, 12);
            this.panel2.TabIndex = 179;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(1, 117);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(13, 428);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(1268, 121);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(13, 428);
            this.panel4.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Cornsilk;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(682, 596);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 182;
            this.label6.Text = "Save";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Cornsilk;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(616, 596);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 181;
            this.label5.Text = "Close";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Cornsilk;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.pbSave);
            this.panel5.Controls.Add(this.pbClose);
            this.panel5.Location = new System.Drawing.Point(568, 587);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 78);
            this.panel5.TabIndex = 180;
            // 
            // pbSave
            // 
            this.pbSave.Location = new System.Drawing.Point(106, 27);
            this.pbSave.Name = "pbSave";
            this.pbSave.Size = new System.Drawing.Size(55, 40);
            this.pbSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSave.TabIndex = 5;
            this.pbSave.TabStop = false;
            this.pbSave.Click += new System.EventHandler(this.pbSave_Click);
            this.pbSave.MouseEnter += new System.EventHandler(this.pbSave_MouseEnter);
            this.pbSave.MouseLeave += new System.EventHandler(this.pbSave_MouseLeave);
            // 
            // pbClose
            // 
            this.pbClose.Location = new System.Drawing.Point(41, 26);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(55, 40);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 4;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            this.pbClose.MouseEnter += new System.EventHandler(this.pbClose_MouseEnter);
            this.pbClose.MouseLeave += new System.EventHandler(this.pbClose_MouseLeave);
            // 
            // buttonsimage
            // 
            this.buttonsimage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("buttonsimage.ImageStream")));
            this.buttonsimage.TransparentColor = System.Drawing.Color.Transparent;
            this.buttonsimage.Images.SetKeyName(0, "cross (1).png");
            this.buttonsimage.Images.SetKeyName(1, "cross (2).png");
            this.buttonsimage.Images.SetKeyName(2, "download (1).png");
            this.buttonsimage.Images.SetKeyName(3, "download (2).png");
            // 
            // RenewDrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 752);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.licenseCardWithFilter1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.applicationCard1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.Name = "RenewDrivingLicense";
            this.Text = "RenewDrivingLicense";
            this.Load += new System.EventHandler(this.RenewDrivingLicense_Load);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LicenseCardWithFilter licenseCardWithFilter1;
        private ApplicationCard applicationCard1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pbSave;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.ImageList buttonsimage;
    }
}