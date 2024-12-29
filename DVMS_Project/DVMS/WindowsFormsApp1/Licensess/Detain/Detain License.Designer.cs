namespace WindowsFormsApp1.Licensess
{
    partial class Detain_License
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detain_License));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pbSave = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbtitle = new System.Windows.Forms.Label();
            this.buttonsimage = new System.Windows.Forms.ImageList(this.components);
            this.tbfees = new System.Windows.Forms.TextBox();
            this.Succed = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.licenseCardWithFilter1 = new WindowsFormsApp1.LicenseCardWithFilter();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Succed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(49, 660);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(193, 20);
            this.linkLabel1.TabIndex = 197;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Go to Driverlicense history";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(319, 582);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 189;
            this.label2.Text = "Fees : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Cornsilk;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(417, 642);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 195;
            this.label6.Text = "Save";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Cornsilk;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(351, 642);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 194;
            this.label5.Text = "Close";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Cornsilk;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.pbSave);
            this.panel5.Controls.Add(this.pbClose);
            this.panel5.Location = new System.Drawing.Point(303, 633);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 78);
            this.panel5.TabIndex = 193;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(337, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 191;
            this.pictureBox1.TabStop = false;
            // 
            // lbtitle
            // 
            this.lbtitle.AutoSize = true;
            this.lbtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitle.Location = new System.Drawing.Point(276, 90);
            this.lbtitle.Name = "lbtitle";
            this.lbtitle.Size = new System.Drawing.Size(227, 37);
            this.lbtitle.TabIndex = 190;
            this.lbtitle.Text = "Detain License";
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
            // tbfees
            // 
            this.tbfees.Location = new System.Drawing.Point(364, 580);
            this.tbfees.Name = "tbfees";
            this.tbfees.Size = new System.Drawing.Size(100, 20);
            this.tbfees.TabIndex = 198;
            this.tbfees.TextChanged += new System.EventHandler(this.tbfees_TextChanged);
            this.tbfees.Validating += new System.ComponentModel.CancelEventHandler(this.tbfees_Validating);
            // 
            // Succed
            // 
            this.Succed.ContainerControl = this;
            this.Succed.Icon = ((System.Drawing.Icon)(resources.GetObject("Succed.Icon")));
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // licenseCardWithFilter1
            // 
            this.licenseCardWithFilter1.Location = new System.Drawing.Point(124, 140);
            this.licenseCardWithFilter1.Name = "licenseCardWithFilter1";
            this.licenseCardWithFilter1.Size = new System.Drawing.Size(570, 412);
            this.licenseCardWithFilter1.TabIndex = 192;
            this.licenseCardWithFilter1.OnLicenseSelected += new System.Action<int, int>(this.licenseCardWithFilter1_OnLicenseSelected);
            // 
            // Detain_License
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 742);
            this.Controls.Add(this.tbfees);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.licenseCardWithFilter1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbtitle);
            this.Name = "Detain_License";
            this.Text = "Detain_License";
            this.Load += new System.EventHandler(this.Detain_License_Load);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Succed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pbSave;
        private System.Windows.Forms.PictureBox pbClose;
        private LicenseCardWithFilter licenseCardWithFilter1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbtitle;
        private System.Windows.Forms.ImageList buttonsimage;
        private System.Windows.Forms.TextBox tbfees;
        private System.Windows.Forms.ErrorProvider Succed;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}