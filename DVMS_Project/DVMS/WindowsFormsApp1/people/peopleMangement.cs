using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
    public partial class peopleMangement : Form
    {
        public peopleMangement()
        {
            InitializeComponent();
        }
        public DataTable dataTable = clsPerson.GetAllpersons();

        private void _search(DataTable result)
        {
            dgvpeople.DataSource = result;
        }
        private void _LoadDataPerson()
       {
            this.Location = new Point(350, 230);
            dgvpeople.DataSource = dataTable;
            searchBar.StartSearch(dataTable);
            searchBar.onpic += _search;
           

            lbRowsNum.Text = clsPerson.GetAllpersons().Rows.Count.ToString()+" #ROWS ";   
            //dgvpeople.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvpeople.DefaultCellStyle.SelectionBackColor = Color.GreenYellow;
            dgvpeople.DefaultCellStyle.SelectionForeColor = Color.Blue;
            dgvpeople.DefaultCellStyle.BackColor = Color.LightGray;

        }
        private void peopleMangement_Load(object sender, EventArgs e)
        {
            _LoadDataPerson();
        }

        private void pbAddNewperson_MouseEnter(object sender, EventArgs e)
        {
            pbAddNewperson.Image = Properties.Resources.add_friendenter;
        }

        private void pbAddNewperson_MouseLeave(object sender, EventArgs e)
        {
            pbAddNewperson.Image = Properties.Resources.add_friend;

        }

       
       

        private void pbAddNewperson_Click(object sender, EventArgs e)
        {
            AddNewPerson addNewPerson = new AddNewPerson();
            addNewPerson.ShowDialog();
        }

       
        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewPerson addNewPerson = new AddNewPerson();
            addNewPerson.ShowDialog();
            _refresh();

        }
        private bool _GetCurrentpersonID(ref int personId2fill)
        {
            if (dgvpeople.CurrentRow != null)
            {

                object dgvobject = dgvpeople.CurrentRow.Cells[0].Value;

                dgvpeople.CellClick += dgvpeople_CellClick;

                if (dgvobject != null && int.TryParse(dgvobject.ToString(), out int number))
                {
                    
                    personId2fill = number;
                    return true;
                    



                }
               else
                {
                    return false;
                }
            }
            return false;
        }
        private void das()
        {
            int personId = -1;



                if(_GetCurrentpersonID(ref personId))
                {
                        AddNewPerson addNewPerson = new AddNewPerson(personId);
                      addNewPerson.ShowDialog();
                }
                else
                {
                    MessageBox.Show("حصل مشكله");

                }



       

        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            das();
            _refresh();

        }

        private void dgvpeople_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            //{
            //    // إلغاء تحديد الصفوف الأخرى
            //    foreach (DataGridViewRow row in dgvpeople.Rows)
            //    {
            //        row.Selected = false; // إلغاء تحديد الصفوف
            //    }

            //    // تحديد الصف الحالي
            //    dgvpeople.Rows[e.RowIndex].Selected = true; // تحديد الصف
            //}

        }
       
        private void pbpeoplemanage_Click(object sender, EventArgs e)
        {
        } 
        private void dgvpeople_CellContextMenuStripChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Showditailmenu_Click(object sender, EventArgs e)
        {
            int personid = -1;
            _GetCurrentpersonID(ref personid);
            Form1 form1 = new Form1(personid);
            form1.ShowDialog();
        }

        private void dgvpeople_MouseDown(object sender, MouseEventArgs e)
        {

        }
        private void _refresh()
        {
            dataTable = clsPerson.GetAllpersons();
            dgvpeople.DataSource= dataTable;
            dgvpeople.Refresh();
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int personid = -1;
            _GetCurrentpersonID(ref personid);
            if (clsPerson.Delete(personid))
            {
                MessageBox.Show("تم مسح الشخص بنجاح","تمام",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                _refresh();
            }
            else
            {
                MessageBox.Show("لم يتم المسح ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }
        }

        private void dgvpeople_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                // تحديد الصف وتركه كاختيار وحيد
                dgvpeople.ClearSelection();
                dgvpeople.Rows[e.RowIndex].Selected = true;

                // تحديد الخلية الأولى في الصف المحدد
                dgvpeople.CurrentCell = dgvpeople.Rows[e.RowIndex].Cells[0];
            }
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("الميزه دي هتكون موجوده التحديث الي جي", "معلومه", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("الميزه دي هتكون موجوده التحديث الي جي", "معلومه", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
