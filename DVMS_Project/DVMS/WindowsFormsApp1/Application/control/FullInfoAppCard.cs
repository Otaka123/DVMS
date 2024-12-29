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
    public partial class FullInfoAppCard : UserControl
    {
        public FullInfoAppCard()
        {
            InitializeComponent();
        }
        private int localID = 0;
        private int Appid = 0;
        public void start (int localid)
        {
            localID = localid;
            localAppplicationcard1.strart(localID);
            Appid = clsApplicationCard.GerApplicationID(localID);
            applicationCard1.Start(Appid);
        }
        private void FullInfoAppCard_Load(object sender, EventArgs e)
        {
           
        }
    }
}
