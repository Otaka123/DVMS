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
    public partial class AddNewLocalDrivingApplication : Form
    {
        public delegate void applicationadded();
        public applicationadded apphndler;
        public AddNewLocalDrivingApplication()
        {
            InitializeComponent();
        }
        private int localid = 0;
        public AddNewLocalDrivingApplication(int LocalApplicationId)
        {
            InitializeComponent();
            localid = LocalApplicationId;
        }

        public int personId { get; set; }
        public clsApplications App = new clsApplications();
        private clsUpdateApp updateApp;


        private void personCardWithFilter1_OnPersonSelected(int obj)
        {
            personId = obj;
            MessageBox.Show(personId.ToString());
            tap2.Enabled = true;
            pbNext.Enabled = true;
            pbNext.Visible = true;
            next.Visible = true;
            pbSave.Enabled = true;
        }

        private void Add_local_License_Load(object sender, EventArgs e)
        {
            DataTable dt = clsApplications.GetLicenseClasses();
            foreach (DataRow dr in dt.Rows)
            {
                cbClass.Items.Add(dr[0].ToString());
            }

            if (localid == 0)
            {
                pbNext.Image = buttonsimage.Images[0];
                tabPersonInfot.SelectedTab = tabPage1;
                tap2.Enabled = false;
                pbback.Image = buttonsimage.Images[6];
                pbback.Enabled = true;
                pbback.Visible = false;
                pbNext.Enabled = false;
                pbNext.Visible = false;
                next.Visible = false;
                pbSave.Enabled = false;
                back.Visible = false;


            }
            else
            {
                tabPersonInfot.SelectedTab = tap2;
                tap2.Enabled = true;
                tabPage1.Enabled = false;
                 
                updateApp = clsUpdateApp.GetUpdate(localid);
                lbtitle.Text = " Update LocalDriving License Application";
                lbD_l_Appid.Text=localid.ToString();
                 lbcreatedby.Text= updateApp.username;
                lbDate.Text= updateApp.Date.ToString();
                pbback.Visible = false;
                pbNext.Visible = false;
                back.Visible = false;
                next.Visible=false;
                cbClass.SelectedItem = updateApp.classname;

                clsApplicationCard info = clsApplicationCard.Find(clsApplicationCard.GerApplicationID(localid));
               if(info != null)
                {
                    personId = clsPerson.Find( info.personNo).PersonID;
                }


            }
            pbSave.Image = buttonsimage.Images[4];
            pbClose.Image = buttonsimage.Images[2];
           


        }
        private void FillTap2()
        {   if(localid == 0)
            {
                lbDate.Text = DateTime.Now.ToString();
                lbD_l_Appid.Text = App.ApplicationID.ToString();
            }


        }
        private void pbNext_Click(object sender, EventArgs e)
        {
            tabPersonInfot.SelectedTab = tap2;
            pbNext.Visible = false;
            next.Visible = false;
            pbback.Visible = true;
            back.Visible = true;

        }

        private void pbback_Click(object sender, EventArgs e)
        {
            tabPersonInfot.SelectedTab = tabPage1;
            pbback.Visible = false;
            back.Visible = false;
            pbNext.Visible = true;
            next.Visible = true;
        }

        private void pbback_MouseEnter(object sender, EventArgs e)
        {
            pbback.Image = buttonsimage.Images[7];

        }

        private void pbback_MouseLeave(object sender, EventArgs e)
        {
            pbback.Image = buttonsimage.Images[6];

        }

     

        private void pbSave_MouseEnter(object sender, EventArgs e)
        {
            pbSave.Image = buttonsimage.Images[5];
        }

        private void pbSave_MouseLeave(object sender, EventArgs e)
        {
            pbSave.Image = buttonsimage.Images[4];

        }

        private void pbClose_MouseEnter(object sender, EventArgs e)
        {
            pbClose.Image = buttonsimage.Images[3];

        }

        private void pbClose_MouseLeave(object sender, EventArgs e)
        {
            pbClose.Image = buttonsimage.Images[2];

        }

      

        private void pbSave_Click_1(object sender, EventArgs e)
        {
            if(localid == 0)
            {
                int classid = clsApplications.GetClassId(cbClass.Text);
                if (clsApplications.IsExist(personId, classid))
                {
                    MessageBox.Show("فيه طلب مفتوح او انك طلعت الرخص دي قبل كدا ");

                }
                else
                {
                    App.ApplicantPersonID = personId;
                    App.ApplicationStatus = 1;
                    App.ApplicationDate = DateTime.Now;
                    App.ApplicationTypeID = 1;
                    App.ClassTypeid = classid;
                    App.CreatedByUserID = clsUser.GetUserIdByUserName(ConnectionSetting.UserName);
                    App.LastStatusDate = DateTime.Now;
                    App.PaidFees = 15;
                    if (App.Save())
                    {
                        MessageBox.Show("تم بنجاح");
                        FillTap2();
                        apphndler?.Invoke();
                    }
                    else
                    {
                        MessageBox.Show("حصل مشكله اثناء الاضافه");
                    }


                }
            }
            else
            {
                int classid = clsApplications.GetClassId(cbClass.Text);

                if (clsApplications.IsExist(personId, classid))
                {
                    MessageBox.Show("فيه طلب مفتوح او انك طلعت الرخص دي قبل كدا ");

                }
                else
                {
                    if (clsApplications.UpdateClass(localid, classid))
                    {
                        MessageBox.Show("تم بنجاح");
                        FillTap2();
                        apphndler?.Invoke();

                    }
                    else
                    {
                        MessageBox.Show("حصل مشكله اثناء الاضافه");
                    }
                }
               
            }

        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbNext_MouseEnter(object sender, EventArgs e)
        {
            pbNext.Image=buttonsimage.Images[1];
        }

        private void pbNext_MouseLeave(object sender, EventArgs e)
        {
            pbNext.Image = buttonsimage.Images[0];

        }

        private void tabPersonInfot_Selecting(object sender, TabControlCancelEventArgs e)
        {
            tabPersonInfot.SelectedTab = tap2;
            if (localid != 0)
            {
                if (tabPersonInfot.SelectedTab == tabPage1)
                {
                    // منع التنقل عن طريق تعيين e.Cancel إلى true
                    e.Cancel = true;
                }
            }
           
        }
    }
}
