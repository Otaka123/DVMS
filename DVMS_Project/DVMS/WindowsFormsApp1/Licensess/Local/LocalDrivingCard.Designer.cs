namespace WindowsFormsApp1
{
    partial class LocalDrivingCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalDrivingCard));
            this.pbtitle = new System.Windows.Forms.PictureBox();
            this.lbtitle = new System.Windows.Forms.Label();
            this.titleimage = new System.Windows.Forms.ImageList(this.components);
            this.pbAddappointment = new System.Windows.Forms.PictureBox();
            this.pbclose = new System.Windows.Forms.PictureBox();
            this.buttons = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Taketests = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lbrows = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fullInfoAppCard1 = new WindowsFormsApp1.FullInfoAppCard();
            ((System.ComponentModel.ISupportInitialize)(this.pbtitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddappointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbtitle
            // 
            this.pbtitle.Location = new System.Drawing.Point(446, 12);
            this.pbtitle.Name = "pbtitle";
            this.pbtitle.Size = new System.Drawing.Size(148, 113);
            this.pbtitle.TabIndex = 0;
            this.pbtitle.TabStop = false;
            // 
            // lbtitle
            // 
            this.lbtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitle.Location = new System.Drawing.Point(289, 137);
            this.lbtitle.Name = "lbtitle";
            this.lbtitle.Size = new System.Drawing.Size(501, 37);
            this.lbtitle.TabIndex = 1;
            this.lbtitle.Text = "??????";
            this.lbtitle.Click += new System.EventHandler(this.lbtitle_Click);
            // 
            // titleimage
            // 
            this.titleimage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("titleimage.ImageStream")));
            this.titleimage.TransparentColor = System.Drawing.Color.Transparent;
            this.titleimage.Images.SetKeyName(0, "svg.png");
            this.titleimage.Images.SetKeyName(1, "reten.png");
            this.titleimage.Images.SetKeyName(2, "driving-test.png");
            // 
            // pbAddappointment
            // 
            this.pbAddappointment.Location = new System.Drawing.Point(933, 583);
            this.pbAddappointment.Name = "pbAddappointment";
            this.pbAddappointment.Size = new System.Drawing.Size(68, 72);
            this.pbAddappointment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddappointment.TabIndex = 3;
            this.pbAddappointment.TabStop = false;
            this.pbAddappointment.Click += new System.EventHandler(this.pbAddappointment_Click);
            this.pbAddappointment.MouseEnter += new System.EventHandler(this.pbAddappointment_MouseEnter);
            this.pbAddappointment.MouseLeave += new System.EventHandler(this.pbAddappointment_MouseLeave);
            // 
            // pbclose
            // 
            this.pbclose.Location = new System.Drawing.Point(933, 739);
            this.pbclose.Name = "pbclose";
            this.pbclose.Size = new System.Drawing.Size(68, 55);
            this.pbclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbclose.TabIndex = 4;
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 606);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(821, 173);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Taketests});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 26);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // Taketests
            // 
            this.Taketests.Name = "Taketests";
            this.Taketests.Size = new System.Drawing.Size(120, 22);
            this.Taketests.Text = "Take Test";
            this.Taketests.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 583);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Appointment :";
            // 
            // lbrows
            // 
            this.lbrows.AutoSize = true;
            this.lbrows.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrows.Location = new System.Drawing.Point(17, 792);
            this.lbrows.Name = "lbrows";
            this.lbrows.Size = new System.Drawing.Size(18, 20);
            this.lbrows.TabIndex = 7;
            this.lbrows.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-5, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 10);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(1, 556);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1054, 10);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(1039, 184);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 384);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(2, 185);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 384);
            this.panel4.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(2, 561);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1054, 10);
            this.panel5.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(928, 656);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "حجز موعد اختبار";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(953, 796);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "اغلاق";
            // 
            // fullInfoAppCard1
            // 
            this.fullInfoAppCard1.Location = new System.Drawing.Point(-5, 192);
            this.fullInfoAppCard1.Name = "fullInfoAppCard1";
            this.fullInfoAppCard1.Size = new System.Drawing.Size(1054, 374);
            this.fullInfoAppCard1.TabIndex = 2;
            // 
            // LocalDrivingCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1049, 824);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbclose);
            this.Controls.Add(this.pbAddappointment);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.fullInfoAppCard1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbrows);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbtitle);
            this.Controls.Add(this.pbtitle);
            this.Name = "LocalDrivingCard";
            this.Text = "LocalDrivingCard";
            this.Load += new System.EventHandler(this.LocalDrivingCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbtitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddappointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbtitle;
        private System.Windows.Forms.Label lbtitle;
        private FullInfoAppCard fullInfoAppCard1;
        private System.Windows.Forms.ImageList titleimage;
        private System.Windows.Forms.PictureBox pbAddappointment;
        private System.Windows.Forms.PictureBox pbclose;
        private System.Windows.Forms.ImageList buttons;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbrows;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Taketests;
    }
}