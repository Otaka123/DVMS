namespace WindowsFormsApp1
{
    partial class issueInternational
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(issueInternational));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbissuelicense = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pbclose = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.licenseCardWithFilter1 = new WindowsFormsApp1.LicenseCardWithFilter();
            this.applicationCard1 = new WindowsFormsApp1.ApplicationCard();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbissuelicense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbclose)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(493, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(425, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "InternationalLicense";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1016, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "اصدار رخصة";
            // 
            // pbissuelicense
            // 
            this.pbissuelicense.BackColor = System.Drawing.Color.Transparent;
            this.pbissuelicense.Location = new System.Drawing.Point(1011, 92);
            this.pbissuelicense.Name = "pbissuelicense";
            this.pbissuelicense.Size = new System.Drawing.Size(68, 55);
            this.pbissuelicense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbissuelicense.TabIndex = 22;
            this.pbissuelicense.TabStop = false;
            this.pbissuelicense.Click += new System.EventHandler(this.pbissuelicense_Click);
            this.pbissuelicense.MouseEnter += new System.EventHandler(this.pbissuelicense_MouseEnter);
            this.pbissuelicense.MouseLeave += new System.EventHandler(this.pbissuelicense_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(936, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "اغلاق";
            // 
            // pbclose
            // 
            this.pbclose.Location = new System.Drawing.Point(919, 92);
            this.pbclose.Name = "pbclose";
            this.pbclose.Size = new System.Drawing.Size(68, 55);
            this.pbclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbclose.TabIndex = 20;
            this.pbclose.TabStop = false;
            this.pbclose.Click += new System.EventHandler(this.pbclose_Click);
            this.pbclose.MouseEnter += new System.EventHandler(this.pbclose_MouseEnter);
            this.pbclose.MouseLeave += new System.EventHandler(this.pbclose_MouseLeave);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "checked (1)enterrr.png");
            this.imageList1.Images.SetKeyName(1, "checked0003.png");
            this.imageList1.Images.SetKeyName(2, "delete11.png");
            this.imageList1.Images.SetKeyName(3, "delete (1)00.png");
            // 
            // licenseCardWithFilter1
            // 
            this.licenseCardWithFilter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.licenseCardWithFilter1.Location = new System.Drawing.Point(540, 169);
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
            this.applicationCard1.Location = new System.Drawing.Point(-171, 169);
            this.applicationCard1.Name = "applicationCard1";
            this.applicationCard1.Size = new System.Drawing.Size(870, 419);
            this.applicationCard1.TabIndex = 24;
            // 
            // issueInternational
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 574);
            this.Controls.Add(this.licenseCardWithFilter1);
            this.Controls.Add(this.applicationCard1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbissuelicense);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbclose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "issueInternational";
            this.Text = "issueInternational";
            this.Load += new System.EventHandler(this.personLicenseHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbissuelicense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbclose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LicenseCardWithFilter licenseCardWithFilter1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbissuelicense;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbclose;
        private System.Windows.Forms.ImageList imageList1;
        private ApplicationCard applicationCard1;
    }
}