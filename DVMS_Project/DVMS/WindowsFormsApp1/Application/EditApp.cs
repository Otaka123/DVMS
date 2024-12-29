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
    public partial class EditApp : Form
    {
        public delegate void databackhandler();
        public databackhandler das;
      
        private int ID;
        private clsApllicationTypes App;
        public EditApp()
        {
            InitializeComponent();
        }
        public EditApp(int Appid)
        {
            InitializeComponent();
            ID = Appid;
        }

        private void EditApp_Load(object sender, EventArgs e)
        {
            this.Location = new Point(670, 300);

            pbclose.Image = imageList1.Images[2];
            pbSave.Image = imageList1.Images[0];
            App= clsApllicationTypes.Find(ID);
            if(App != null)
            {
                lbID.Text=App.ApplicaionID.ToString();
                tbtitle.Text=App.Applicaiontitle.ToString();
                tbfees.Text =App.ApplicaionFees.ToString();
            }
        }

        private void pbclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbtitle.Text) && !string.IsNullOrEmpty(tbfees.Text))
            {
                App.Applicaiontitle = tbtitle.Text;
                App.ApplicaionFees=Convert.ToDecimal( tbfees.Text);
                if(App.Save())
                {
                    MessageBox.Show("تم الحفظ بنجاح");
                    das?.Invoke();
                }
                else
                {
                    MessageBox.Show("حصل مشكله اثناء الحفظ");
                }
            }
            else
            {
                MessageBox.Show("اتاكد انك مليت كل الحقول قبل الحفظ");

            }
        }

        private void pbSave_MouseLeave(object sender, EventArgs e)
        {

            pbSave.Image = imageList1.Images[0];
        }

        private void pbSave_MouseEnter(object sender, EventArgs e)
        {
            pbSave.Image = imageList1.Images[1];

        }

        private void pbclose_MouseLeave(object sender, EventArgs e)
        {
            pbclose.Image = imageList1.Images[2];   
        }

        private void pbclose_MouseEnter(object sender, EventArgs e)
        {
            pbclose.Image = imageList1.Images[3];

        }
    }
}
