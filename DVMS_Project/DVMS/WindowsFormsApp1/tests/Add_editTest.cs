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
    public partial class Add_editTest : UserControl
    {
        public delegate void TestAppointmentHandler(int testAppointmentId);
        public event TestAppointmentHandler TestAppointment;
        public Add_editTest()
        {
            InitializeComponent();
        }
        private int LocalID = 0;
        private int Testtype = 0;
        private int ApplicationId = 0;


        public void Start(int G_LocalID,int G_testtypeId)
        {
            LocalID=G_LocalID;
            Testtype=G_testtypeId;
            ApplicationId = clsApplicationCard.GerApplicationID(LocalID);
            if (LocalID != 0)
            {
                lbdlApp.Text = LocalID.ToString();
                lbclass.Text = clsUpdateApp.Getclassname(LocalID);
                lbtrials.Text = clsTestAppointment.GetTrialNum(LocalID, Testtype).ToString();
                lbfees.Text = clsTestType.Find(Testtype).ApplicaionFees.ToString();
                lbfullname.Text = clsApplicationCard.Find(ApplicationId).Applicant;
            }

        }
        private void Add_editTest_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[0];

        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image=imageList1.Images[0];
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[1];

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(LocalID != 0)
            {
                clsTestAppointment testAppointment = new clsTestAppointment();
                testAppointment.TestTypeID = Testtype;
                testAppointment.LocalDrivingLicenseApplicationID = LocalID;
                testAppointment.AppointmentDate = dateTimePicker1.Value;
                testAppointment.PaidFees = clsTestType.Find(Testtype).ApplicaionFees;
                testAppointment.CreatedByUserID = clsUser.GetUserIdByUserName(ConnectionSetting.UserName);
                testAppointment.IsLocked = false;
                if(testAppointment.Save())
                {
                    MessageBox.Show("تم حجز موعد للامتحان بنجاح");
                    TestAppointment?.Invoke(testAppointment.AppointmentId);
                    dateTimePicker1.Enabled = false;
                    pictureBox1.Enabled = false;
                }
                else
                {
                    MessageBox.Show("حصل مشكله اثناء الحجز");


                }
            }
           
        }
    }
}
