using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace WindowsFormsApp1
{
    public partial class Manage_LocalDrivinglicenseApp : Form
    {
        public Manage_LocalDrivinglicenseApp()
        {
            InitializeComponent();
        }
        public DataTable Application;
        public int ApplicationID { get; set; }
        public int testtype = 0;
        public int testpassed = 0;
        private void Manage_LocalDrivinglicenseApp_Load(object sender, EventArgs e)
        {
            this.Location = new Point(300, 230);

            Application = clsApplications.GetlocalApplication();
            searchBar1.StartSearch(clsApplications.GetlocalApplication());
            searchBar1.onpic = _search;
            lbRowsNum.Text = Application.Rows.Count.ToString() + " #ROWS ";
            dgvApp.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvApp.DefaultCellStyle.SelectionBackColor = Color.GreenYellow;
            dgvApp.DefaultCellStyle.SelectionForeColor = Color.Blue;
            dgvApp.DefaultCellStyle.BackColor = Color.LightGray;
            dgvApp.DataSource = Application;
            dgvApp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvApp.Columns[0].Width = 100;
            dgvApp.Columns[1].Width = 300;
            dgvApp.Columns[2].Width = 100;
            dgvApp.Columns[3].Width = 300;
            pbAddApp.Image = imageList1.Images[0];

        }
        private void _refrsh()
        {
            Application = clsApplications.GetlocalApplication();
            dgvApp.DataSource = Application;
            lbRowsNum.Text = Application.Rows.Count.ToString() + " #ROWS ";

        }

        private void _search(DataTable dt)
        {
            Application = dt;
            dgvApp.DataSource = Application;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AddNewLocalDrivingApplication ff = new AddNewLocalDrivingApplication();
            ff.apphndler += _refrsh;
            ff.ShowDialog();
        }

        private void sechToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private bool _GetCurrentpersonID(ref int UserId)
        {
            if (dgvApp.CurrentRow != null)
            {

                object dgvobject = dgvApp.CurrentRow.Cells[0].Value;

                dgvApp.CellClick += dgvApp_CellClick;

                if (dgvobject != null && int.TryParse(dgvobject.ToString(), out int number))
                {

                    UserId = number;
                    return true;




                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        private void dgvApp_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                // تحديد الصف وتركه كاختيار وحيد
                dgvApp.ClearSelection();
                dgvApp.Rows[e.RowIndex].Selected = true;

                // تحديد الخلية الأولى في الصف المحدد
                dgvApp.CurrentCell = dgvApp.Rows[e.RowIndex].Cells[0];
            }
        }

        private void dgvApp_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private int getpassd(object testp)
        {
            if (testp != null && int.TryParse(testp.ToString(), out int num))

                    { return num; }
            return -1;
        }   
        private void controltest(int passedtests)
        {
            if (passedtests == 0)
            {
                testtype = 1;
                sechdule.Enabled = true;

                VisionTest.Enabled = true;
                WrittenTest.Enabled = false;
                DrivingTest.Enabled = false;
                issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
                showLicenseToolStripMenuItem.Enabled=false;

            }
            else if (passedtests == 1)
            {
                testtype = 2;
                sechdule.Enabled = true;

                VisionTest.Enabled = false;
                WrittenTest.Enabled = true;
                DrivingTest.Enabled = false;
                issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
                showLicenseToolStripMenuItem.Enabled=false;

            }
            else if(passedtests == 2)
            {
                testtype = 3;
                sechdule.Enabled = true;

                VisionTest.Enabled = false;
                WrittenTest.Enabled = false;
                DrivingTest.Enabled = true;
                issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
                showLicenseToolStripMenuItem.Enabled=false;

            }
            else  if (passedtests == 3) 
            {
                sechdule.Enabled = false;
                issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = true;
                showLicenseToolStripMenuItem.Enabled=false;
            }

        }
        private void _Conrtol()
        {
            if (dgvApp.CurrentRow != null)
            {
                object dgvobject = dgvApp.CurrentRow.Cells[6].Value;
                if(dgvobject.ToString()=="New")
                {
                    cmCancle.Enabled = true;
                }
                else
                {
                    cmCancle.Enabled= false;
                }
                if(dgvobject.ToString()== "Completed")
                {
                    editApplicationToolStripMenuItem.Enabled=false;
                    deleteApplicationToolStripMenuItem.Enabled = false;
                    cmCancle.Enabled=false;
                    sechdule.Enabled=false;
                    issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled= false;
                }
               object testp = dgvApp.CurrentRow.Cells[5].Value;
                if(getpassd(testp) !=-1)
                {
                    controltest(getpassd(testp));
                }


            }
            else
            {
                MessageBox.Show("اتاكد انك واقف علي بيانات الطلب");
            } 

        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            _Conrtol();
        }

        private void pbAddApp_MouseEnter(object sender, EventArgs e)
        {
            pbAddApp.Image = imageList1.Images[1];

        }

        private void pbAddApp_MouseLeave(object sender, EventArgs e)
        {
            pbAddApp.Image = imageList1.Images[0];

        }

        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int localApplication = 0;
           if( _GetCurrentpersonID(ref localApplication))
            {
                ApplicationID = clsApplicationCard.GerApplicationID(localApplication);
                Applicationshowinfo info = new Applicationshowinfo(ApplicationID);
                info.ShowDialog();
            }
           else
            {
                MessageBox.Show("اتاكد انك واقف علي بيانات الطلب");
            }
           
        }

        private void cancleApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int localApplication = 0;

            if (_GetCurrentpersonID(ref localApplication))
            {
                ApplicationID = clsApplicationCard.GerApplicationID(localApplication);
               clsApplications.updatestatApplication(ApplicationID,2);
                _refrsh();


            }
            else
            {
                MessageBox.Show("اتاكد انك واقف علي بيانات الطلب");
            }

        }

        private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int localApplication = 0;

            if (_GetCurrentpersonID(ref localApplication))
            {

                AddNewLocalDrivingApplication Update=new AddNewLocalDrivingApplication(localApplication);
                Update.apphndler += _refrsh;
                Update.ShowDialog();


            }
            else
            {
                MessageBox.Show("اتاكد انك واقف علي بيانات الطلب");
            }
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int localApplication = 0;

            ApplicationID = clsApplicationCard.GerApplicationID(localApplication);

           if( clsApplications.delete(ApplicationID))
            {
                MessageBox.Show("تم المسح بنجاح");
            }
           else
            {
                MessageBox.Show("لم يتم المسح هذا الطلب مربوط مع طلبات اخري");
            }

        }

        private void dgvApp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void _testAppointment()
        {
            int localid = 0;
            if (_GetCurrentpersonID(ref localid))
            {
                LocalDrivingCard localdriving = new LocalDrivingCard(localid, testtype);
                localdriving.ShowDialog();
                _refrsh();
            }
            if (testpassed == 3)
            {
                ApplicationID = clsApplicationCard.GerApplicationID(localid);

                clsApplications.updatestatApplication(ApplicationID, 3);
            }
        }

        private void VisionTest_Click(object sender, EventArgs e)
        {
            _testAppointment();
        }

        private void WrittenTest_Click(object sender, EventArgs e)
        {
            _testAppointment();
        }

        private void DrivingTest_Click(object sender, EventArgs e)
        {
            _testAppointment();
        }

        private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int localid = 0;
            if (_GetCurrentpersonID(ref localid))
            {

                issue_Driving_License_firstTime newlicense = new issue_Driving_License_firstTime(localid);
                newlicense.apphndler += _unlockshowlicense;
                newlicense.ShowDialog();
                _refrsh();
            }
        }
        private void _unlockshowlicense()
        {
            showLicenseToolStripMenuItem.Enabled=true;
        }
        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int localid = 0;
            if (_GetCurrentpersonID(ref localid))
            {
                ApplicationID = clsApplicationCard.GerApplicationID(localid);

                showLicense newlicense = new showLicense(ApplicationID);
                newlicense.ShowDialog();
            }
            
        }
    }
}
