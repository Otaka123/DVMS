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
    public partial class ApplicationCard : UserControl
    {
        public ApplicationCard()
        {
            InitializeComponent();
        }
        public int Appid {  get; set; }
        private clsApplicationCard Appinfo;
        private string nationalno;
        private int personID = 0;
        public void Start(int ApplicationID)
        {
            Appid=ApplicationID;
            /*clsApplicationCard*/ Appinfo= clsApplicationCard.Find(Appid);
            if(Appinfo != null) 
            {
                lbAppid.Text = Appinfo.ApplicationID.ToString();
                lbnationalno.Text = Appinfo.personNo.ToString();
                lbappfees.Text = Convert.ToString(Appinfo.AppFees);
                lbapptype.Text= Convert.ToString(Appinfo.ApplicationType.ToString());
                lbstatsDate.Text=Appinfo.LastStatusDate.ToString();
                lbappdate.Text=Appinfo.ApplicationDate.ToString();
                lbFullname.Text=Appinfo.Applicant.ToString();
                //lbpaidfees.Text = Appinfo.PaidFees.ToString();
                lbUsername.Text=Appinfo.CreatedByUserName;
                lbstatus.Text=Appinfo.status.ToString();


            }
            else
            {
                MessageBox.Show("لم يتم التعرف علي رقم الطلب");
            }

        }
        public void StartInternational(int personId,int applicationtypeID)
        {
            personID = personId;
            if (personID != 0)
            {
                clsPerson person = clsPerson.Find(personId);
                if (person != null)
                {

                    if (applicationtypeID == 6)
                    {
                        clsApllicationTypes app = clsApllicationTypes.Find(applicationtypeID);
                      
                            lbAppid.Text = "????";
                            lbnationalno.Text = person.NationalNo.ToString();
                            lbappfees.Text = Convert.ToString(app.ApplicaionFees);
                            lbapptype.Text = Convert.ToString(app.Applicaiontitle);
                            lbappdate.Text = DateTime.Now.ToString();
                            lbFullname.Text = person.FirstName + " " + person.SecondName + " " + person.ThirdName + " " + person.LastName;
                            lbUsername.Text = ConnectionSetting.UserName;
                            lbstatus.Text = "new";
                        

                    }
                    if (applicationtypeID == 2)
                    {
                        clsApllicationTypes app = clsApllicationTypes.Find(2);

                        lbAppid.Text = "????";
                        lbnationalno.Text = person.NationalNo.ToString();
                        lbappfees.Text = Convert.ToString(app.ApplicaionFees);
                        lbapptype.Text = Convert.ToString(app.Applicaiontitle);
                        lbappdate.Text = DateTime.Now.ToString();
                        lbFullname.Text = person.FirstName + " " + person.SecondName + " " + person.ThirdName + " " + person.LastName;
                        lbUsername.Text = ConnectionSetting.UserName;
                        lbstatus.Text = "new";
                    }
                }
            }
            else
            {
                MessageBox.Show("رقم الشخص لازم ميكونش صفر");
            }
          





        }
      
        private void ApplicationCard_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(Appinfo!=null)
            {
                nationalno = Appinfo.personNo;
                Form1 showpersoninfo=new Form1(nationalno);
                showpersoninfo.ShowDialog();


            }
            if(personID!=0)
            {
                clsPerson person = clsPerson.Find(personID);

                Form1 showpersoninfo = new Form1(person.NationalNo);
                showpersoninfo.ShowDialog();
            }
        }
    }
}
