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
    public partial class UserInfo : Form
    {
        public int userID;
        public UserInfo()
        {
            InitializeComponent();
        }
        public UserInfo(int G_UserId)
        {
            InitializeComponent();
            userID = G_UserId;
        }

        private void UserInfo_Load(object sender, EventArgs e)
        {
            this.Location = new Point(580, 300);

            userCard1.userIID=this.userID;
            userCard1.LoadUserInfo();
        }
    }
}
