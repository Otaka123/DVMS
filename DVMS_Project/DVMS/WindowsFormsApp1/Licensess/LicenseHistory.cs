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
    public partial class LicenseHistory : Form
    {
        public LicenseHistory()
        {
            InitializeComponent();
        }
        public LicenseHistory(int G_personID)
        {
            personId = G_personID;
            InitializeComponent();
        }
        //public LicenseHistory(string G_Nationalno)
        //{
        //    Nationalno = G_Nationalno;
        //    InitializeComponent();
        //}
        private int personId =0;
        private string Nationalno = "";
        private int DriverId = 0;
        private void LicenseHistory_Load(object sender, EventArgs e)
        {
            if (personId != 0)
            {
                personCard1.loadinfo(personId);
                DriverId = clsLicense.GetDriverID(personId);
                dgvlocal.DataSource= clsLicense.GetLocallicnse(DriverId);
                dgvinternational.DataSource= clsLicense.GetinternationalLicense(DriverId);
                lbinterows.Text=dgvinternational.Rows.Count.ToString() + " #ROWS ";
                lblocalrows.Text=dgvlocal.Rows.Count.ToString() + " #ROWS ";

            }
            //if (Nationalno !="")
            //{
            //    personCard1.loadinfo(Nationalno);
            //    dgvlocal.DataSource= 
            //}
        }
    }
}
