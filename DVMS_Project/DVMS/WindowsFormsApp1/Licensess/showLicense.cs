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
    public partial class showLicense : Form
    {   private int ApplicationID = 0;
        public showLicense(int G_ApplicationId)
        {
            ApplicationID = G_ApplicationId;
            InitializeComponent();
        }

        public showLicense()
        {
            
        }
        private void showLicense_Load(object sender, EventArgs e)
        {
            this.Location = new Point(580, 300);
           
            licenseCard1.Start(ApplicationID);
        }
        //public void start(int licenseid)
        //{
        //    if (ApplicationID == 0)
        //    {
        //        licenseCard1.StartwithLicneseID(licenseid);
        //    }
        //}
    }
}
