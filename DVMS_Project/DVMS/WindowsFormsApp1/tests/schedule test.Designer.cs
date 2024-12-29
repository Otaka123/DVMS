namespace WindowsFormsApp1
{
    partial class schedule_test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(schedule_test));
            this.pbtitle = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.titleimage = new System.Windows.Forms.ImageList(this.components);
            this.add_editTest1 = new WindowsFormsApp1.Add_editTest();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbretakefees = new System.Windows.Forms.Label();
            this.lbretakeapppid = new System.Windows.Forms.Label();
            this.lbtotaldees = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbclose = new System.Windows.Forms.PictureBox();
            this.buttons = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbtitle)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbclose)).BeginInit();
            this.SuspendLayout();
            // 
            // pbtitle
            // 
            this.pbtitle.Location = new System.Drawing.Point(237, 12);
            this.pbtitle.Name = "pbtitle";
            this.pbtitle.Size = new System.Drawing.Size(100, 96);
            this.pbtitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbtitle.TabIndex = 0;
            this.pbtitle.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Schedule test";
            // 
            // titleimage
            // 
            this.titleimage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("titleimage.ImageStream")));
            this.titleimage.TransparentColor = System.Drawing.Color.Transparent;
            this.titleimage.Images.SetKeyName(0, "svg.png");
            this.titleimage.Images.SetKeyName(1, "reten.png");
            this.titleimage.Images.SetKeyName(2, "driving-test.png");
            // 
            // add_editTest1
            // 
            this.add_editTest1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_editTest1.BackgroundImage")));
            this.add_editTest1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add_editTest1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.add_editTest1.Location = new System.Drawing.Point(-78, 150);
            this.add_editTest1.Name = "add_editTest1";
            this.add_editTest1.Size = new System.Drawing.Size(682, 468);
            this.add_editTest1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbtotaldees);
            this.groupBox1.Controls.Add(this.lbretakeapppid);
            this.groupBox1.Controls.Add(this.lbretakefees);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 624);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 112);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تفاصيل اعاده الاختبار";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(421, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = ":  رسوم اعاده الاختبار";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(405, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = ":  رقم طلب اعاده الاختبار";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(455, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = ": اجمالي الرسوم";
            // 
            // lbretakefees
            // 
            this.lbretakefees.AutoSize = true;
            this.lbretakefees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbretakefees.Location = new System.Drawing.Point(383, 16);
            this.lbretakefees.Name = "lbretakefees";
            this.lbretakefees.Size = new System.Drawing.Size(30, 16);
            this.lbretakefees.TabIndex = 3;
            this.lbretakefees.Text = "N/A";
            // 
            // lbretakeapppid
            // 
            this.lbretakeapppid.AutoSize = true;
            this.lbretakeapppid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbretakeapppid.Location = new System.Drawing.Point(369, 42);
            this.lbretakeapppid.Name = "lbretakeapppid";
            this.lbretakeapppid.Size = new System.Drawing.Size(30, 16);
            this.lbretakeapppid.TabIndex = 4;
            this.lbretakeapppid.Text = "N/A";
            // 
            // lbtotaldees
            // 
            this.lbtotaldees.AutoSize = true;
            this.lbtotaldees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtotaldees.Location = new System.Drawing.Point(419, 70);
            this.lbtotaldees.Name = "lbtotaldees";
            this.lbtotaldees.Size = new System.Drawing.Size(30, 16);
            this.lbtotaldees.TabIndex = 5;
            this.lbtotaldees.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 796);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "اغلاق";
            // 
            // pbclose
            // 
            this.pbclose.Location = new System.Drawing.Point(251, 739);
            this.pbclose.Name = "pbclose";
            this.pbclose.Size = new System.Drawing.Size(68, 55);
            this.pbclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbclose.TabIndex = 14;
            this.pbclose.TabStop = false;
            this.pbclose.Click += new System.EventHandler(this.pbclose_Click);
            this.pbclose.MouseEnter += new System.EventHandler(this.pbclose_MouseEnter);
            this.pbclose.MouseLeave += new System.EventHandler(this.pbclose_MouseLeave);
            // 
            // buttons
            // 
            this.buttons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("buttons.ImageStream")));
            this.buttons.TransparentColor = System.Drawing.Color.Transparent;
            this.buttons.Images.SetKeyName(0, "chronometer.png");
            this.buttons.Images.SetKeyName(1, "chronometer (1).png");
            this.buttons.Images.SetKeyName(2, "delete (1)00.png");
            this.buttons.Images.SetKeyName(3, "delete11.png");
            // 
            // schedule_test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(574, 811);
            this.Controls.Add(this.add_editTest1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbclose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbtitle);
            this.Name = "schedule_test";
            this.Text = "schedule_test";
            this.Load += new System.EventHandler(this.schedule_test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbtitle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbclose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbtitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList titleimage;
        private Add_editTest add_editTest1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbtotaldees;
        private System.Windows.Forms.Label lbretakeapppid;
        private System.Windows.Forms.Label lbretakefees;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbclose;
        private System.Windows.Forms.ImageList buttons;
    }
}