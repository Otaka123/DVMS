namespace WindowsFormsApp1
{
    partial class personCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(personCard));
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbcountry = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbPersonId = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbBirthofdate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbGendor = new System.Windows.Forms.Label();
            this.lbnationalId = new System.Windows.Forms.Label();
            this.lbaddress = new System.Windows.Forms.Label();
            this.lbsecodname = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.ImageList(this.components);
            this.lblastname = new System.Windows.Forms.Label();
            this.lbthirdname = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.Transparent;
            this.pbImage.Location = new System.Drawing.Point(135, 106);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(97, 122);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 84;
            this.pbImage.TabStop = false;
            this.pbImage.MouseEnter += new System.EventHandler(this.pbImage_MouseEnter);
            this.pbImage.MouseLeave += new System.EventHandler(this.pbImage_MouseLeave);
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.BackColor = System.Drawing.Color.Transparent;
            this.lbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(138, 272);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(43, 15);
            this.lbPhone.TabIndex = 83;
            this.lbPhone.Text = "Phone";
            // 
            // lbcountry
            // 
            this.lbcountry.AutoSize = true;
            this.lbcountry.BackColor = System.Drawing.Color.Transparent;
            this.lbcountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcountry.Location = new System.Drawing.Point(281, 272);
            this.lbcountry.Name = "lbcountry";
            this.lbcountry.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbcountry.Size = new System.Drawing.Size(23, 15);
            this.lbcountry.TabIndex = 82;
            this.lbcountry.Text = "البلد";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(310, 272);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 81;
            this.label6.Text = "بلد الاقامة :  ";
            // 
            // lbPersonId
            // 
            this.lbPersonId.BackColor = System.Drawing.Color.Transparent;
            this.lbPersonId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPersonId.Location = new System.Drawing.Point(422, 65);
            this.lbPersonId.Name = "lbPersonId";
            this.lbPersonId.Size = new System.Drawing.Size(66, 15);
            this.lbPersonId.TabIndex = 80;
            this.lbPersonId.Text = "PersonID";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(476, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 79;
            this.label5.Text = " :  PersonID";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoEllipsis = true;
            this.lbEmail.BackColor = System.Drawing.Color.Transparent;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(299, 234);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(183, 15);
            this.lbEmail.TabIndex = 78;
            this.lbEmail.Text = "البريد";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(479, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 77;
            this.label4.Text = "  : البريد الالكتروني";
            // 
            // lbBirthofdate
            // 
            this.lbBirthofdate.AutoEllipsis = true;
            this.lbBirthofdate.BackColor = System.Drawing.Color.Transparent;
            this.lbBirthofdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBirthofdate.Location = new System.Drawing.Point(238, 203);
            this.lbBirthofdate.Name = "lbBirthofdate";
            this.lbBirthofdate.Size = new System.Drawing.Size(185, 22);
            this.lbBirthofdate.TabIndex = 76;
            this.lbBirthofdate.Text = "تاريخ الميلاد";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(427, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 75;
            this.label3.Text = "  : تاريخ الميلاد";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 74;
            this.label2.Text = "  : النوع   ";
            // 
            // lbGendor
            // 
            this.lbGendor.BackColor = System.Drawing.Color.Transparent;
            this.lbGendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGendor.Location = new System.Drawing.Point(144, 247);
            this.lbGendor.Name = "lbGendor";
            this.lbGendor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbGendor.Size = new System.Drawing.Size(40, 15);
            this.lbGendor.TabIndex = 73;
            this.lbGendor.Text = "النوع";
            // 
            // lbnationalId
            // 
            this.lbnationalId.AutoSize = true;
            this.lbnationalId.BackColor = System.Drawing.Color.Transparent;
            this.lbnationalId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnationalId.Location = new System.Drawing.Point(356, 112);
            this.lbnationalId.Name = "lbnationalId";
            this.lbnationalId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbnationalId.Size = new System.Drawing.Size(56, 15);
            this.lbnationalId.TabIndex = 72;
            this.lbnationalId.Text = "[??????}";
            // 
            // lbaddress
            // 
            this.lbaddress.AutoEllipsis = true;
            this.lbaddress.BackColor = System.Drawing.Color.Transparent;
            this.lbaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbaddress.Location = new System.Drawing.Point(356, 260);
            this.lbaddress.Name = "lbaddress";
            this.lbaddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbaddress.Size = new System.Drawing.Size(206, 35);
            this.lbaddress.TabIndex = 71;
            this.lbaddress.Text = "العنوان";
            // 
            // lbsecodname
            // 
            this.lbsecodname.BackColor = System.Drawing.Color.Transparent;
            this.lbsecodname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsecodname.Location = new System.Drawing.Point(482, 158);
            this.lbsecodname.Name = "lbsecodname";
            this.lbsecodname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbsecodname.Size = new System.Drawing.Size(68, 22);
            this.lbsecodname.TabIndex = 70;
            this.lbsecodname.Text = "اسم الاب";
            // 
            // lbname
            // 
            this.lbname.BackColor = System.Drawing.Color.Transparent;
            this.lbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.Location = new System.Drawing.Point(415, 134);
            this.lbname.Name = "lbname";
            this.lbname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbname.Size = new System.Drawing.Size(138, 22);
            this.lbname.TabIndex = 69;
            this.lbname.Text = "الاسم الاول";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 68;
            this.label1.Text = "National ID / الرقم القومي";
            // 
            // image
            // 
            this.image.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image.ImageStream")));
            this.image.TransparentColor = System.Drawing.Color.Transparent;
            this.image.Images.SetKeyName(0, "profile.png");
            this.image.Images.SetKeyName(1, "profileEnter.png");
            this.image.Images.SetKeyName(2, "profileFemale.png");
            this.image.Images.SetKeyName(3, "profilefemaleEnter.png");
            this.image.Images.SetKeyName(4, "check1.png");
            this.image.Images.SetKeyName(5, "checkEnter.png");
            // 
            // lblastname
            // 
            this.lblastname.BackColor = System.Drawing.Color.Transparent;
            this.lblastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblastname.Location = new System.Drawing.Point(272, 158);
            this.lblastname.Name = "lblastname";
            this.lblastname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblastname.Size = new System.Drawing.Size(87, 22);
            this.lblastname.TabIndex = 86;
            this.lblastname.Text = "اللقب";
            // 
            // lbthirdname
            // 
            this.lbthirdname.BackColor = System.Drawing.Color.Transparent;
            this.lbthirdname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbthirdname.Location = new System.Drawing.Point(365, 158);
            this.lbthirdname.Name = "lbthirdname";
            this.lbthirdname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbthirdname.Size = new System.Drawing.Size(111, 22);
            this.lbthirdname.TabIndex = 87;
            this.lbthirdname.Text = "اسم الجد";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(286, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 24);
            this.label7.TabIndex = 88;
            this.label7.Text = "البطاقة الشخصية";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(258, 98);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(175, 13);
            this.linkLabel1.TabIndex = 89;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "للتعديل علي بيانات الشخص اضغط هنا";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // personCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbthirdname);
            this.Controls.Add(this.lblastname);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbcountry);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbPersonId);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbBirthofdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbGendor);
            this.Controls.Add(this.lbnationalId);
            this.Controls.Add(this.lbaddress);
            this.Controls.Add(this.lbsecodname);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.label1);
            this.Name = "personCard";
            this.Size = new System.Drawing.Size(674, 336);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbcountry;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbPersonId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbBirthofdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbGendor;
        private System.Windows.Forms.Label lbnationalId;
        private System.Windows.Forms.Label lbaddress;
        private System.Windows.Forms.Label lbsecodname;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList image;
        private System.Windows.Forms.Label lblastname;
        private System.Windows.Forms.Label lbthirdname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
