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
using WindowsFormsApp1.Licensess;
using WindowsFormsApp1.Licensess.Detain;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }
        private int _UserId;
        //private string _UserName;
        //private int _Password;
        private void _MensuPicturesDefult()
        {
            pbpeople.Image = systemimage.Images[0];
            pbApplication.Image = systemimage.Images[2];
            pbDrivers.Image = systemimage.Images[4];
            pbUser.Image = systemimage.Images[6];
            pbAcountSeittnngs.Image = systemimage.Images[8];
              
        }
        private void _MenuPicturesEnter()
        {
            pbpeople.Image = systemimage.Images[1];
            pbApplication.Image = systemimage.Images[3];
            pbDrivers.Image = systemimage.Images[5];
            pbUser.Image = systemimage.Images[7];
            pbAcountSeittnngs.Image = systemimage.Images[9];
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            _MensuPicturesDefult();
            _UserId = clsUser.GetUserIdByUserName(ConnectionSetting.UserName);
        }


        private void pbApplication_MouseEnter(object sender, EventArgs e)
        {
            pbApplication.Image = systemimage.Images[3];
        }

        private void pbAcountSeittnngs_MouseEnter(object sender, EventArgs e)
        {
            pbAcountSeittnngs.Image = systemimage.Images[9];

        }

        private void pbUser_MouseEnter(object sender, EventArgs e)
        {
            pbUser.Image = systemimage.Images[7];

        }

        private void pbpeople_MouseEnter(object sender, EventArgs e)
        {
            pbpeople.Image = systemimage.Images[1];

        }

        private void pbDrivers_MouseEnter(object sender, EventArgs e)
        {
            pbDrivers.Image = systemimage.Images[5];

        }

        private void pbApplication_MouseLeave(object sender, EventArgs e)
        {
            _MensuPicturesDefult();

        }

        private void pbDrivers_MouseLeave(object sender, EventArgs e)
        {
            _MensuPicturesDefult();
        }

        private void pbpeople_MouseLeave(object sender, EventArgs e)
        {
            _MensuPicturesDefult();
        }

        private void pbUser_MouseLeave(object sender, EventArgs e)
        {
            _MensuPicturesDefult();


        }

        private void pbAcountSeittnngs_MouseLeave(object sender, EventArgs e)
        {
            _MensuPicturesDefult();
        }

        private void cmsAccountlogout_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }

        private void cmsAccountcurrentUserInfo_Click(object sender, EventArgs e)
        {
            UserInfo usercard = new UserInfo(_UserId);
            usercard.ShowDialog();
        }

        private void cmsAcountchangePassword_Click(object sender, EventArgs e)
        {
            Changepasswordd changepassword = new Changepasswordd(_UserId);
            changepassword.ShowDialog();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationTypes applicationTypes = new ApplicationTypes();
            applicationTypes.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageTesttypes manageTesttypes = new ManageTesttypes();
            manageTesttypes.ShowDialog();
        }

       
        private void pbApplication_Click(object sender, EventArgs e)
        {
            var location = new Point(pbApplication.Left, pbApplication.Bottom);

            // عرض القائمة السياقية عند الموقع المحدد
            cmsApplications.Show(this, location);
        }

        private void pbAcountSeittnngs_Click(object sender, EventArgs e)
        {
            var location = new Point(pbAcountSeittnngs.Left, pbAcountSeittnngs.Bottom);
            cmsAccountSettings.Show(pbAcountSeittnngs, location);
        }

        private void pbpeople_Click(object sender, EventArgs e)
        {
            peopleMangement people = new peopleMangement();
            people.ShowDialog();
        }

        private void replacementForLostOrDamageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReplaceDamaged_lost replace = new ReplaceDamaged_lost();
            replace.ShowDialog();
        }

        private void newDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewLocalDrivingApplication addnew = new AddNewLocalDrivingApplication();
            addnew.ShowDialog();
        }

        private void localDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manage_LocalDrivinglicenseApp mangeform=new Manage_LocalDrivinglicenseApp();
            mangeform.ShowDialog();
        }

        private void pbUser_Click(object sender, EventArgs e)
        {
            MangeUsers user= new MangeUsers();
            user.ShowDialog();
        }

        private void pbDrivers_Click(object sender, EventArgs e)
        {
            showDrivers drivers = new showDrivers();
            drivers.ShowDialog();
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            issueInternational international = new issueInternational();
            international.ShowDialog();
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenewDrivingLicense renew = new RenewDrivingLicense();
            renew.ShowDialog();
        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void cmsApplications_Opening(object sender, CancelEventArgs e)
        {

        }

        private void detainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Detain_License detain_License = new Detain_License();
            detain_License.ShowDialog();
        }

        private void manageDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageDetain manage_License = new ManageDetain();   
            manage_License.ShowDialog();
        }

        private void releaseLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReleaseLicense release = new ReleaseLicense();
            release.ShowDialog();
        }
    }
}
