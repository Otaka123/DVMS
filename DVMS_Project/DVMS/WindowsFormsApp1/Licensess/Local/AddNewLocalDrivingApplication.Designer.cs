namespace WindowsFormsApp1
{
    partial class AddNewLocalDrivingApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewLocalDrivingApplication));
            this.pbNext = new System.Windows.Forms.PictureBox();
            this.buttonsimage = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pbback = new System.Windows.Forms.PictureBox();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.lbcreatedby = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.tap2 = new System.Windows.Forms.TabPage();
            this.lbfees = new System.Windows.Forms.Label();
            this.lbD_l_Appid = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.personCardWithFilter1 = new WindowsFormsApp1.PersonCardWithFilter();
            this.back = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Label();
            this.tabPersonInfot = new System.Windows.Forms.TabControl();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbSave = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbtitle = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbback)).BeginInit();
            this.tap2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPersonInfot.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // pbNext
            // 
            this.pbNext.BackColor = System.Drawing.Color.Transparent;
            this.pbNext.Location = new System.Drawing.Point(673, 602);
            this.pbNext.Name = "pbNext";
            this.pbNext.Size = new System.Drawing.Size(55, 50);
            this.pbNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNext.TabIndex = 29;
            this.pbNext.TabStop = false;
            this.pbNext.Click += new System.EventHandler(this.pbNext_Click);
            this.pbNext.MouseEnter += new System.EventHandler(this.pbNext_MouseEnter);
            this.pbNext.MouseLeave += new System.EventHandler(this.pbNext_MouseLeave);
            // 
            // buttonsimage
            // 
            this.buttonsimage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("buttonsimage.ImageStream")));
            this.buttonsimage.TransparentColor = System.Drawing.Color.Transparent;
            this.buttonsimage.Images.SetKeyName(0, "next-button (4).png");
            this.buttonsimage.Images.SetKeyName(1, "next-button (1).png");
            this.buttonsimage.Images.SetKeyName(2, "cross (1).png");
            this.buttonsimage.Images.SetKeyName(3, "cross (2).png");
            this.buttonsimage.Images.SetKeyName(4, "download (1).png");
            this.buttonsimage.Images.SetKeyName(5, "download (2).png");
            this.buttonsimage.Images.SetKeyName(6, "Back (2).png");
            this.buttonsimage.Images.SetKeyName(7, "Back (1).png");
            this.buttonsimage.Images.SetKeyName(8, "login.png");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add-User0.png");
            this.imageList1.Images.SetKeyName(1, "addUserEnter.png");
            // 
            // pbback
            // 
            this.pbback.BackColor = System.Drawing.Color.Transparent;
            this.pbback.Location = new System.Drawing.Point(612, 602);
            this.pbback.Name = "pbback";
            this.pbback.Size = new System.Drawing.Size(55, 50);
            this.pbback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbback.TabIndex = 34;
            this.pbback.TabStop = false;
            this.pbback.Click += new System.EventHandler(this.pbback_Click);
            this.pbback.MouseEnter += new System.EventHandler(this.pbback_MouseEnter);
            this.pbback.MouseLeave += new System.EventHandler(this.pbback_MouseLeave);
            // 
            // cbClass
            // 
            this.cbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(230, 123);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(166, 21);
            this.cbClass.TabIndex = 14;
            // 
            // lbcreatedby
            // 
            this.lbcreatedby.AutoSize = true;
            this.lbcreatedby.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcreatedby.Location = new System.Drawing.Point(226, 227);
            this.lbcreatedby.Name = "lbcreatedby";
            this.lbcreatedby.Size = new System.Drawing.Size(54, 20);
            this.lbcreatedby.TabIndex = 13;
            this.lbcreatedby.Text = "Admin";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(226, 73);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(44, 20);
            this.lbDate.TabIndex = 12;
            this.lbDate.Text = "Date";
            // 
            // tap2
            // 
            this.tap2.Controls.Add(this.cbClass);
            this.tap2.Controls.Add(this.lbcreatedby);
            this.tap2.Controls.Add(this.lbDate);
            this.tap2.Controls.Add(this.lbfees);
            this.tap2.Controls.Add(this.lbD_l_Appid);
            this.tap2.Controls.Add(this.pictureBox5);
            this.tap2.Controls.Add(this.pictureBox4);
            this.tap2.Controls.Add(this.pictureBox3);
            this.tap2.Controls.Add(this.pictureBox2);
            this.tap2.Controls.Add(this.pictureBox1);
            this.tap2.Controls.Add(this.label7);
            this.tap2.Controls.Add(this.label4);
            this.tap2.Controls.Add(this.label3);
            this.tap2.Controls.Add(this.label2);
            this.tap2.Controls.Add(this.label1);
            this.tap2.Location = new System.Drawing.Point(4, 22);
            this.tap2.Name = "tap2";
            this.tap2.Padding = new System.Windows.Forms.Padding(3);
            this.tap2.Size = new System.Drawing.Size(670, 380);
            this.tap2.TabIndex = 1;
            this.tap2.Text = "Application info";
            this.tap2.UseVisualStyleBackColor = true;
            // 
            // lbfees
            // 
            this.lbfees.AutoSize = true;
            this.lbfees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfees.Location = new System.Drawing.Point(226, 177);
            this.lbfees.Name = "lbfees";
            this.lbfees.Size = new System.Drawing.Size(40, 20);
            this.lbfees.TabIndex = 11;
            this.lbfees.Text = "15 $";
            // 
            // lbD_l_Appid
            // 
            this.lbD_l_Appid.AutoSize = true;
            this.lbD_l_Appid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbD_l_Appid.Location = new System.Drawing.Point(226, 26);
            this.lbD_l_Appid.Name = "lbD_l_Appid";
            this.lbD_l_Appid.Size = new System.Drawing.Size(35, 20);
            this.lbD_l_Appid.TabIndex = 10;
            this.lbD_l_Appid.Text = "N/A";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(183, 73);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 24);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(183, 123);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(183, 173);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(183, 223);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(183, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(68, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Created By :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Application Fees :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "License Calss :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Application Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "D.L.Application ID :";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage1.Controls.Add(this.personCardWithFilter1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(670, 380);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Person info";
            // 
            // personCardWithFilter1
            // 
            this.personCardWithFilter1.BackColor = System.Drawing.SystemColors.Window;
            this.personCardWithFilter1.Location = new System.Drawing.Point(3, 2);
            this.personCardWithFilter1.Name = "personCardWithFilter1";
            this.personCardWithFilter1.nationalno = null;
            this.personCardWithFilter1.personId = 0;
            this.personCardWithFilter1.Size = new System.Drawing.Size(665, 404);
            this.personCardWithFilter1.TabIndex = 0;
            this.personCardWithFilter1.OnPersonSelected += new System.Action<int>(this.personCardWithFilter1_OnPersonSelected);
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(623, 656);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(38, 16);
            this.back.TabIndex = 35;
            this.back.Text = "Back";
            // 
            // next
            // 
            this.next.AutoSize = true;
            this.next.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(683, 657);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(34, 16);
            this.next.TabIndex = 33;
            this.next.Text = "Next";
            // 
            // tabPersonInfot
            // 
            this.tabPersonInfot.AccessibleName = "";
            this.tabPersonInfot.Controls.Add(this.tabPage1);
            this.tabPersonInfot.Controls.Add(this.tap2);
            this.tabPersonInfot.Location = new System.Drawing.Point(56, 194);
            this.tabPersonInfot.Name = "tabPersonInfot";
            this.tabPersonInfot.SelectedIndex = 0;
            this.tabPersonInfot.Size = new System.Drawing.Size(678, 406);
            this.tabPersonInfot.TabIndex = 28;
            this.tabPersonInfot.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabPersonInfot_Selecting);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Cornsilk;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Close";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pbSave);
            this.panel1.Controls.Add(this.pbClose);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(306, 616);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 78);
            this.panel1.TabIndex = 30;
            // 
            // pbSave
            // 
            this.pbSave.Location = new System.Drawing.Point(106, 27);
            this.pbSave.Name = "pbSave";
            this.pbSave.Size = new System.Drawing.Size(55, 40);
            this.pbSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSave.TabIndex = 5;
            this.pbSave.TabStop = false;
            this.pbSave.Click += new System.EventHandler(this.pbSave_Click_1);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Cornsilk;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(113, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Save";
            // 
            // lbtitle
            // 
            this.lbtitle.AutoSize = true;
            this.lbtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitle.Location = new System.Drawing.Point(98, 140);
            this.lbtitle.Name = "lbtitle";
            this.lbtitle.Size = new System.Drawing.Size(587, 37);
            this.lbtitle.TabIndex = 36;
            this.lbtitle.Text = " NewLocalDriving License Application";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(321, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(147, 115);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 37;
            this.pictureBox6.TabStop = false;
            // 
            // AddNewLocalDrivingApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(778, 706);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.lbtitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbNext);
            this.Controls.Add(this.pbback);
            this.Controls.Add(this.back);
            this.Controls.Add(this.next);
            this.Controls.Add(this.tabPersonInfot);
            this.Name = "AddNewLocalDrivingApplication";
            this.Text = "AddNewLocalDrivingApplication";
            this.Load += new System.EventHandler(this.Add_local_License_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbback)).EndInit();
            this.tap2.ResumeLayout(false);
            this.tap2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPersonInfot.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbNext;
        private System.Windows.Forms.ImageList buttonsimage;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pbback;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label lbcreatedby;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.TabPage tap2;
        private System.Windows.Forms.Label lbfees;
        private System.Windows.Forms.Label lbD_l_Appid;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private PersonCardWithFilter personCardWithFilter1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label back;
        private System.Windows.Forms.Label next;
        private System.Windows.Forms.TabControl tabPersonInfot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbSave;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbtitle;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}