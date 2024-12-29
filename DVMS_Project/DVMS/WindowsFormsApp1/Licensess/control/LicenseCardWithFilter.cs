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
    public partial class LicenseCardWithFilter : UserControl
    {
        public event Action<int,int> OnLicenseSelected;
        protected virtual void Personselected(int LicenseId,int AppplicationID)
        {
            Action<int, int> Handler = OnLicenseSelected;
            if (Handler != null)
            {
                Handler(LicenseId, AppplicationID);
            }
        }
        public LicenseCardWithFilter()
        {
            InitializeComponent();
        }
        private int LicenseId = 0;
        private int Appid = 0;
        private bool _search(string text)
        {
           DataTable data= clsLicense.GetAllLicense();
            bool found = false;
            //   إنشاء DataTable جديد لتخزين نتائج البحث وتعبئه الcombobox
            DataTable dt = new DataTable();
            foreach (DataColumn column in data.Columns)
            {
                dt.Columns.Add(column.ColumnName, column.DataType);
            }

            // التحقق من نوع العمود (إذا كان String أو Integer)
           


            // تنفيذ البحث وتخزين النتائج
            DataRow[] results = data.Select("LicenseID = "+ text);
            foreach (DataRow row in results)
            {
                found = true;
                LicenseId =Convert.ToInt32( row["LicenseID"]);
            }

            // تخزين النتائج في DataTable النهائي

            return found;
        }
        private void licenseCard1_Load(object sender, EventArgs e)
        {
            pbSearchbtn.Image = btnimage.Images[0];
        }

 
        private void pbSearchbtn_MouseLeave(object sender, EventArgs e)
        {
            pbSearchbtn.Image = btnimage.Images[0];

        }

        private void pbSearchbtn_MouseEnter(object sender, EventArgs e)
        {
            pbSearchbtn.Image = btnimage.Images[1];

        }
        public void fillinfo(int licenseID)
        {
            clsLicense mylicense = clsLicense.Find(LicenseId);
            Appid = mylicense.ApplictionID;
            if (Appid != 0)
            {
                Personselected(LicenseId, Appid);
                licenseCard1.Start(Appid);


            }
        }
        private void pbSearchbtn_Click(object sender, EventArgs e)
        {
            if(_search(tbtext.Text))
            {
                clsLicense mylicense= clsLicense.Find(LicenseId);
                Appid = mylicense.ApplictionID;
                if(Appid != 0)
                {
                    Personselected(LicenseId, Appid);
                    licenseCard1.Start(Appid);


                }
            }
            else
            {
                MessageBox.Show($"غير موجوده {tbtext.Text} الرخصه رقم ");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LicenseCardWithFilter_Load(object sender, EventArgs e)
        {
            cbBy.SelectedIndex = 0;
            cbBy.Enabled = false;
        }

        private void tbtext_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pbSearchbtn_Click(sender, e); // استدعاء حدث النقر على PictureBox                                              // استدعاء النقر على الزر عند الضغط على Enter
                e.Handled = true; // منع الإجراء الافتراضي
                e.SuppressKeyPress = true;
            }
        }
    }
}
