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
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
    public partial class PersonCardWithFilter : UserControl
    {
        public event Action<int> OnPersonSelected;
        public enum mode { normal=1, user=2 };
        private mode _mode=mode.normal;
        protected virtual void Personselected(int personId)
        {
            Action <int> Handler=OnPersonSelected;
            if(Handler != null)
            {
                Handler(personId);
            }
        }
        public PersonCardWithFilter()
        {
            InitializeComponent();
        }
        
        public DataTable data = clsPerson.GetAllpersons();
        public int personId { get; set; }
        public string nationalno {  get; set; }
        private void PersonCardWithFilter_Load(object sender, EventArgs e)
         {
            pbaddUser.Image = imageList1.Images[0];
            pbSearchbtn.Image = btnimage.Images[0];
            cbBy.Text = "NationalNo";


        }
        public void Mode(int on1off0)
        {
            if (on1off0 == 1)
            {
                _mode = mode.user;
            }
        }
        private bool _search(string by, string text)
        {
            bool found = false;
            //   إنشاء DataTable جديد لتخزين نتائج البحث وتعبئه الcombobox
            DataTable dt = new DataTable();
            foreach (DataColumn column in data.Columns)
            {
                dt.Columns.Add(column.ColumnName, column.DataType);
            }

                string filterExpression;
            if(int.TryParse(text,out int no))
            {
                filterExpression = by + " = " + no.ToString();

            }
            else
            {
                filterExpression = by + " LIKE '%" + text + "%'";

            }


            // تنفيذ البحث وتخزين النتائج
            DataRow[] results = data.Select(filterExpression);
            foreach (DataRow row in results)
            {
                found = true;
                nationalno = row["NationalNo"].ToString();
                personId = (int)row["PersonID"];
            }

            // تخزين النتائج في DataTable النهائي
           
            return found;
        }
     
        private void pbaddUser_Click(object sender, EventArgs e)
         {
             AddNewPerson addNewPerson = new AddNewPerson();
             addNewPerson.ShowDialog();
            
         }

         private void personCard_Load(object sender, EventArgs e)
         {

         }

        private void pbaddUser_MouseEnter(object sender, EventArgs e)
        {
            pbaddUser.Image = imageList1.Images[1];

        }

        private void pbaddUser_MouseLeave(object sender, EventArgs e)
        {
            pbaddUser.Image = imageList1.Images[0];

        }

        private void pbSearchbtn_MouseEnter(object sender, EventArgs e)
        {
            pbSearchbtn.Image = btnimage.Images[0];
        }

        private void pbSearchbtn_MouseLeave(object sender, EventArgs e)
        {
            pbSearchbtn.Image = btnimage.Images[1];

        }
       
        private void pbSearchbtn_Click(object sender, EventArgs e)
        {
            if (tbtext.Text != "")
            {
                if (_search(cbBy.Text, tbtext.Text))
                {
                    if (_mode == mode.user)
                    {
                        if(clsUser.ISExist(personId))
                        {
                            MessageBox.Show("الرقم القومي دا مربوط مع حساب تاني راجع الادمن");
                        }
                        else
                        {
                            Personselected(this.personId);

                            personCard.loadinfo(nationalno);

                        }
                    }
                    else
                    {
                        Personselected(this.personId);

                        personCard.loadinfo(nationalno);
                    }
                    
                       
                        
                    
                    

                }
                else
                {
                    MessageBox.Show("الرقم القومي دا مش متسجل علي السيستم");
                }
            }
            else
            {
                MessageBox.Show("اتاكد انك كاتب الرقم القومي");

            }



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
