namespace WindowsFormsApp1.Licensess
{
    partial class ReplaceDamaged_lost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReplaceDamaged_lost));
            this.lbtitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.licenseCardWithFilter1 = new WindowsFormsApp1.LicenseCardWithFilter();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pbSave = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.buttonsimage = new System.Windows.Forms.ImageList(this.components);
            this.rbdamage = new System.Windows.Forms.RadioButton();
            this.rblost = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbfees = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbtitle
            // 
            this.lbtitle.AutoSize = true;
            this.lbtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitle.Location = new System.Drawing.Point(190, 103);
            this.lbtitle.Name = "lbtitle";
            this.lbtitle.Size = new System.Drawing.Size(424, 37);
            this.lbtitle.TabIndex = 0;
            this.lbtitle.Text = "Replace for Damaged or lost";
            this.lbtitle.Click += new System.EventHandler(this.lbtitle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(330, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // licenseCardWithFilter1
            // 
            this.licenseCardWithFilter1.Location = new System.Drawing.Point(117, 153);
            this.licenseCardWithFilter1.Name = "licenseCardWithFilter1";
            this.licenseCardWithFilter1.Size = new System.Drawing.Size(570, 412);
            this.licenseCardWithFilter1.TabIndex = 2;
            this.licenseCardWithFilter1.OnLicenseSelected += new System.Action<int, int>(this.licenseCardWithFilter1_OnLicenseSelected);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Cornsilk;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(410, 655);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 185;
            this.label6.Text = "Save";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Cornsilk;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(344, 655);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 184;
            this.label5.Text = "Close";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Cornsilk;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.pbSave);
            this.panel5.Controls.Add(this.pbClose);
            this.panel5.Location = new System.Drawing.Point(296, 646);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 78);
            this.panel5.TabIndex = 183;
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
            // rbdamage
            // 
            this.rbdamage.AutoSize = true;
            this.rbdamage.Location = new System.Drawing.Point(23, 16);
            this.rbdamage.Name = "rbdamage";
            this.rbdamage.Size = new System.Drawing.Size(71, 17);
            this.rbdamage.TabIndex = 186;
            this.rbdamage.TabStop = true;
            this.rbdamage.Text = "Damaged";
            this.rbdamage.UseVisualStyleBackColor = true;
            this.rbdamage.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rblost
            // 
            this.rblost.AutoSize = true;
            this.rblost.Location = new System.Drawing.Point(23, 35);
            this.rblost.Name = "rblost";
            this.rblost.Size = new System.Drawing.Size(41, 17);
            this.rblost.TabIndex = 187;
            this.rblost.TabStop = true;
            this.rblost.Text = "lost";
            this.rblost.UseVisualStyleBackColor = true;
            this.rblost.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbfees);
            this.groupBox1.Controls.Add(this.rbdamage);
            this.groupBox1.Controls.Add(this.rblost);
            this.groupBox1.Location = new System.Drawing.Point(296, 580);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 60);
            this.groupBox1.TabIndex = 188;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 189;
            this.label2.Text = "Fees";
            // 
            // lbfees
            // 
            this.lbfees.AutoSize = true;
            this.lbfees.Location = new System.Drawing.Point(149, 35);
            this.lbfees.Name = "lbfees";
            this.lbfees.Size = new System.Drawing.Size(25, 13);
            this.lbfees.TabIndex = 188;
            this.lbfees.Text = "???";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(42, 673);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(193, 20);
            this.linkLabel1.TabIndex = 189;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Go to Driverlicense history";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // ReplaceDamaged_lost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 736);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.licenseCardWithFilter1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbtitle);
            this.Name = "ReplaceDamaged_lost";
            this.Text = "ReplaceDamaged_lost";
            this.Load += new System.EventHandler(this.ReplaceDamaged_lost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbtitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private LicenseCardWithFilter licenseCardWithFilter1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pbSave;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.ImageList buttonsimage;
        private System.Windows.Forms.RadioButton rbdamage;
        private System.Windows.Forms.RadioButton rblost;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbfees;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}