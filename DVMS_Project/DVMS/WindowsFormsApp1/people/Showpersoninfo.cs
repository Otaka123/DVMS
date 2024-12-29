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
    public partial class Form1 : Form
    {
        private int personID = 0;
        private string Nationalno;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(int personid)
        {
            personID=personid;
            InitializeComponent();
        }
        public Form1(string nationalno)
        {
            Nationalno = nationalno;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(580, 300);
            if (string.IsNullOrEmpty(Nationalno)&& personID!=0)
            {
                personCard1.loadinfo(personID);

            }
            else if (!string.IsNullOrEmpty(Nationalno) && personID == 0)
            {
                personCard1.loadinfo(Nationalno);
            }
            else
            {
                MessageBox.Show("اتاكد انك تبعت المعلومات عن طريق Constractor");
            }
        }
    }
}
