namespace WindowsFormsApp1
{
    partial class LicenseCardWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LicenseCardWithFilter));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbSearchbtn = new System.Windows.Forms.PictureBox();
            this.tbtext = new System.Windows.Forms.TextBox();
            this.cbBy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnimage = new System.Windows.Forms.ImageList(this.components);
            this.licenseCard1 = new WindowsFormsApp1.LicenseCard();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pbSearchbtn);
            this.groupBox1.Controls.Add(this.tbtext);
            this.groupBox1.Controls.Add(this.cbBy);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(1, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 59);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pbSearchbtn
            // 
            this.pbSearchbtn.Location = new System.Drawing.Point(489, 19);
            this.pbSearchbtn.Name = "pbSearchbtn";
            this.pbSearchbtn.Size = new System.Drawing.Size(32, 32);
            this.pbSearchbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearchbtn.TabIndex = 5;
            this.pbSearchbtn.TabStop = false;
            this.pbSearchbtn.Click += new System.EventHandler(this.pbSearchbtn_Click);
            this.pbSearchbtn.MouseEnter += new System.EventHandler(this.pbSearchbtn_MouseEnter);
            this.pbSearchbtn.MouseLeave += new System.EventHandler(this.pbSearchbtn_MouseLeave);
            // 
            // tbtext
            // 
            this.tbtext.Location = new System.Drawing.Point(296, 24);
            this.tbtext.Name = "tbtext";
            this.tbtext.Size = new System.Drawing.Size(183, 20);
            this.tbtext.TabIndex = 4;
            this.tbtext.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbtext_KeyDown);
            // 
            // cbBy
            // 
            this.cbBy.DisplayMember = "LicenseID";
            this.cbBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBy.FormattingEnabled = true;
            this.cbBy.Items.AddRange(new object[] {
            "LicenseID"});
            this.cbBy.Location = new System.Drawing.Point(93, 25);
            this.cbBy.Name = "cbBy";
            this.cbBy.Size = new System.Drawing.Size(183, 21);
            this.cbBy.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Find By :";
            // 
            // btnimage
            // 
            this.btnimage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("btnimage.ImageStream")));
            this.btnimage.TransparentColor = System.Drawing.Color.Transparent;
            this.btnimage.Images.SetKeyName(0, "search0.png");
            this.btnimage.Images.SetKeyName(1, "searchenter0.png");
            // 
            // licenseCard1
            // 
            this.licenseCard1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("licenseCard1.BackgroundImage")));
            this.licenseCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.licenseCard1.Location = new System.Drawing.Point(-199, 0);
            this.licenseCard1.Name = "licenseCard1";
            this.licenseCard1.Size = new System.Drawing.Size(958, 460);
            this.licenseCard1.TabIndex = 0;
            this.licenseCard1.Load += new System.EventHandler(this.licenseCard1_Load);
            // 
            // LicenseCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.licenseCard1);
            this.Name = "LicenseCardWithFilter";
            this.Size = new System.Drawing.Size(570, 412);
            this.Load += new System.EventHandler(this.LicenseCardWithFilter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchbtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LicenseCard licenseCard1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbSearchbtn;
        private System.Windows.Forms.TextBox tbtext;
        private System.Windows.Forms.ComboBox cbBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList btnimage;
    }
}
