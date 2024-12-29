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
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    public partial class AddNewUser : Form
    {
        public AddNewUser()
        {
            InitializeComponent();
        }
        private void edit_AddUser1_Load(object sender, EventArgs e)
        {
            edit_AddUser1.PersonIDHandler += _close;
        }
        private void _close(int num)
        {
            this.Close();
        }
    }
 }   
