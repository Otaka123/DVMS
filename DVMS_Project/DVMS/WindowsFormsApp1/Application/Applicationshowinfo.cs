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
    public partial class Applicationshowinfo : Form
    {
        public Applicationshowinfo()
        {
            InitializeComponent();
        }
        private int appid;
        //private string nationalno;
        public Applicationshowinfo(int ApplicationId)
        {
            InitializeComponent();
            appid = ApplicationId;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void Applicationshowinfo_Load(object sender, EventArgs e)
        {
            this.Location = new Point(580, 300);

            applicationCard1.Start(appid);
        }
    }
}
