namespace WindowsFormsApp1
{
    partial class PersonCardWithFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonCardWithFilter));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbSearchbtn = new System.Windows.Forms.PictureBox();
            this.tbtext = new System.Windows.Forms.TextBox();
            this.cbBy = new System.Windows.Forms.ComboBox();
            this.pbaddUser = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.personCard = new WindowsFormsApp1.personCard();
            this.btnimage = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbaddUser)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add-User0.png");
            this.imageList1.Images.SetKeyName(1, "addUserEnter.png");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbSearchbtn);
            this.groupBox1.Controls.Add(this.tbtext);
            this.groupBox1.Controls.Add(this.cbBy);
            this.groupBox1.Controls.Add(this.pbaddUser);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(27, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 59);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
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
            this.cbBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBy.Enabled = false;
            this.cbBy.FormattingEnabled = true;
            this.cbBy.Items.AddRange(new object[] {
            "NationalNo"});
            this.cbBy.Location = new System.Drawing.Point(93, 25);
            this.cbBy.Name = "cbBy";
            this.cbBy.Size = new System.Drawing.Size(183, 21);
            this.cbBy.TabIndex = 3;
            // 
            // pbaddUser
            // 
            this.pbaddUser.Location = new System.Drawing.Point(528, 19);
            this.pbaddUser.Name = "pbaddUser";
            this.pbaddUser.Size = new System.Drawing.Size(32, 32);
            this.pbaddUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbaddUser.TabIndex = 2;
            this.pbaddUser.TabStop = false;
            this.pbaddUser.Click += new System.EventHandler(this.pbaddUser_Click);
            this.pbaddUser.MouseEnter += new System.EventHandler(this.pbaddUser_MouseEnter);
            this.pbaddUser.MouseLeave += new System.EventHandler(this.pbaddUser_MouseLeave);
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
            // personCard
            // 
            this.personCard.BackColor = System.Drawing.Color.AntiqueWhite;
            this.personCard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("personCard.BackgroundImage")));
            this.personCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.personCard.Location = new System.Drawing.Point(-9, 70);
            this.personCard.Name = "personCard";
            this.personCard.Size = new System.Drawing.Size(674, 334);
            this.personCard.TabIndex = 3;
            this.personCard.Load += new System.EventHandler(this.personCard_Load);
            // 
            // btnimage
            // 
            this.btnimage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("btnimage.ImageStream")));
            this.btnimage.TransparentColor = System.Drawing.Color.Transparent;
            this.btnimage.Images.SetKeyName(0, "search0.png");
            this.btnimage.Images.SetKeyName(1, "searchenter0.png");
            // 
            // PersonCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.personCard);
            this.Name = "PersonCardWithFilter";
            this.Size = new System.Drawing.Size(665, 404);
            this.Load += new System.EventHandler(this.PersonCardWithFilter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbaddUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private personCard personCard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbaddUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbSearchbtn;
        private System.Windows.Forms.TextBox tbtext;
        private System.Windows.Forms.ComboBox cbBy;
        private System.Windows.Forms.ImageList btnimage;
    }
}
