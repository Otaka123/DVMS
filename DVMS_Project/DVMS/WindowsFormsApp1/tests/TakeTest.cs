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
    public partial class TakeTest : Form
    {
        public TakeTest()
        {
            InitializeComponent();
        }
        private int testAppointmentid = 0;
        private int LocalID = 0;

        public TakeTest(int TestAppointmentID,int Localid)
        {
            InitializeComponent();
            testAppointmentid = TestAppointmentID;
            LocalID = Localid;
        }


        private void TakeTest_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[0];

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            clsTakeTest testresult = new clsTakeTest();
            if(rbfail.Checked)
            {
                testresult.TestResult=false;

            }
            else
            {
                testresult.TestResult=true;

            }
            testresult.TestAppointmentID = testAppointmentid;
            testresult.Notes=textBox1.Text;
            testresult.CreatedByUserID= clsUser.GetUserIdByUserName(ConnectionSetting.UserName);
            if(testresult._AddNewTaketest(LocalID))
            {
                MessageBox.Show("تم تسجيل نتيجة الامتحان بنجاح");
                rbfail.Enabled = false;
                rbpass.Enabled = false;
                pictureBox1.Enabled = false;
                textBox1 .Enabled = false;

            }
            else
            {
                MessageBox.Show("حصل مشكله اثناء تسجيل نتيجة الامتحان ");


            }



        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[0];

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[1];

        }
    }
}
