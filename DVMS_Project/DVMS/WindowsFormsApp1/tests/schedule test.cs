using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class schedule_test : Form
    {

        public schedule_test()
        {
            InitializeComponent();
        }
        private int localid = 0;
        private int testtypeid=0;
        public schedule_test(int G_LocalID, int G_testtypeId)
        {
            localid=G_LocalID;
            testtypeid=G_testtypeId;
            InitializeComponent();

        }

        private void pbclose_MouseLeave(object sender, EventArgs e)
        {
            pbclose.Image = buttons.Images[2];

        }

        private void pbclose_MouseEnter(object sender, EventArgs e)
        {
            pbclose.Image = buttons.Images[3];

        }
        private void fillretakeinfo()
        {
            lbretakefees.Text = "5";
            lbtotaldees.Text= (clsTestType.Find(testtypeid).ApplicaionFees+5).ToString();
        }
        private void schedule_test_Load(object sender, EventArgs e)
        {
            add_editTest1.Start(localid,testtypeid);
            pbclose.Image= buttons.Images[2];
            if (testtypeid == 1)
            {
                pbtitle.Image = titleimage.Images[0];

            }
            else if (testtypeid == 2)
            {
                pbtitle.Image = titleimage.Images[1];
            }
            else if (testtypeid == 3)
            {
                pbtitle.Image = titleimage.Images[2];
            }

            if (clsTestAppointment.GetTrialNum(localid, testtypeid)!=0)
            {
                groupBox1.Enabled = true;
                fillretakeinfo();
            }
            else
            {
                groupBox1.Enabled = false;

            }
            add_editTest1.TestAppointment += _retake;
        }
        private void _retake(int appointmentid)
        {
        }

        private void pbclose_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
