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
    public partial class localAppplicationcard : UserControl
    {
        public localAppplicationcard()
        {
            InitializeComponent();
        }
        private int localid = 0;
        public void strart (int LocalID)
        {
            localid=LocalID;
            if (localid != 0) 
            {
                lblocalId.Text = localid.ToString();
                lbclassname.Text = clsUpdateApp.Getclassname(localid);
                lbpassedtest.Text = clsUpdateApp.Getpassedtests(localid).ToString() + " / 3";
            }
        }

        private void localAppplicationcard_Load(object sender, EventArgs e)
        {

        }
    }
}
