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
    public partial class Changepasswordd : Form
    { private int userid;
        public Changepasswordd()
        {
            InitializeComponent();
        }
        public Changepasswordd(int USerID)
        {
            InitializeComponent();
            userid=USerID;
        }

        private void Changepassword_Load(object sender, EventArgs e)
        {
            changePassword1.Start(userid);
        }

        private void changePassword1_Load(object sender, EventArgs e)
        {

        }

        private void changePassword1_Oncloseclicked()
        {
            this.Close();
        }
    }
}
