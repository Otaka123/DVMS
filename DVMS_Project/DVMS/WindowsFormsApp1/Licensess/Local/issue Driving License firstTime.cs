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
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
    public partial class issue_Driving_License_firstTime : Form
    {
        public delegate void applicationadded();
        public applicationadded apphndler;
        private int LOCALID = 0;
        public issue_Driving_License_firstTime(int G_localid)
        {
            LOCALID = G_localid;
            InitializeComponent();
            
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pbissuelicense.Image=imageList1.Images[0];
        }

        private void issue_Driving_License_firstTime_Load(object sender, EventArgs e)
        {
            pbissuelicense.Image = imageList1.Images[0];
            pbclose.Image = imageList1.Images[2];
            fullInfoAppCard1.start(LOCALID);
        }

        private void pbclose_MouseLeave(object sender, EventArgs e)
        {
            pbclose.Image = imageList1.Images[2];

        }

        private void pbclose_MouseEnter(object sender, EventArgs e)
        {
            pbclose.Image = imageList1.Images[3];

        }

        private void pbissuelicense_MouseEnter(object sender, EventArgs e)
        {
            pbissuelicense.Image = imageList1.Images[1];

        }
        private void lockscreen()
        {
            fullInfoAppCard1.Enabled = false;
            tbNote.Enabled = false;
            pbissuelicense.Enabled = false;

        }
        private void pbissuelicense_Click(object sender, EventArgs e)
        {
            clsLicense Newlicense = new clsLicense();

            int AppId = clsApplicationCard.GerApplicationID(LOCALID);
            if (AppId != 0)
            {
                
                clsApplicationCard sad = clsApplicationCard.Find(AppId);
                clsLicenseclass classinfo = clsLicenseclass.Findbylocalid(LOCALID);
                Newlicense.personiD = clsPerson.Find(sad.personNo).PersonID;
                Newlicense.ApplictionID = AppId;
                Newlicense.LicenseClass = classinfo.LicenseClassID;
                Newlicense.IssueDate = DateTime.Now;
                Newlicense.ExpirationDate = DateTime.Now.AddYears(classinfo.DefaultValidityLength);
                Newlicense.Notes = tbNote.Text;
                Newlicense.PaidFees = classinfo.ClassFees;
                Newlicense.IsActive = true;
                Newlicense.IssueReason = Convert.ToByte(sad.ApplicationType);
                Newlicense.CreatedByUserID = clsUser.GetUserIdByUserName(ConnectionSetting.UserName);
            }

            if(Newlicense._AddNewLicense())
            {
                MessageBox.Show($" {Newlicense.LicensesID.ToString()} = تم اصدار الرخصه بنجاح رقم الرخصه ");
                apphndler?.Invoke();
                lockscreen();
            }
            else
            {
                MessageBox.Show("حصل مشكله اثناء اصدار الرخصه");
            }


        }

        private void pbclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
