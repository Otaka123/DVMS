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
using static WindowsFormsApp1.SearchBar;

namespace WindowsFormsApp1
{
    public partial class MangeUsers : Form
    {
        public MangeUsers()
        {
            InitializeComponent();
        }
        DataTable DataTable=clsUser.GetAllUsers();
        private int Userid;

        //public struct BoolValues
        //{
        //    // خصائص عامة يمكن تعيينها والوصول إليها
        //    public string ColumnName;
        //    public string NullValue;
        //    public string TrueValue;
        //    public string All;

        //    // منشئ struct لتعيين القيم مباشرةً عند الإنشاء
        //    public BoolValues(string columnName, string nullValue, string trueValue, string all)
        //    {
        //        ColumnName = columnName;
        //        NullValue = nullValue;
        //        TrueValue = trueValue;
        //        All = all;
        //    }
        //}
        

        private void MangeUsers_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 230);

            pbAddUser.Image = imagelist.Images[0];
            dgvUsers.DataSource = DataTable;
            //BoolValues boolcolumn = new BoolValues("IsActive","No","Yes","All");

            searchBar.StartSearch(DataTable);
            searchBar.onpic += _search;
            dgvUsers.Columns[2].Width = 120;
            dgvUsers.Columns[3].Width =290;
            dgvUsers.Columns[4].Width = 60;


            lbRowsNum.Text = DataTable.Rows.Count.ToString() + " #ROWS ";
            dgvUsers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsers.DefaultCellStyle.SelectionBackColor = Color.GreenYellow;
            dgvUsers.DefaultCellStyle.SelectionForeColor = Color.Blue;
            dgvUsers.DefaultCellStyle.BackColor = Color.LightGray;

        }
        private void _search(DataTable resulte)
        {

            dgvUsers.DataSource=resulte;
        }

        private void dgvUsers_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                // تحديد الصف وتركه كاختيار وحيد
                dgvUsers.ClearSelection();
                dgvUsers.Rows[e.RowIndex].Selected = true;

                // تحديد الخلية الأولى في الصف المحدد
                dgvUsers.CurrentCell = dgvUsers.Rows[e.RowIndex].Cells[0];
            }
        }

        private void pbAddUser_Click(object sender, EventArgs e)
        {
            AddNewUser addNewUser = new AddNewUser();
            addNewUser.ShowDialog();
        }
        private void close(int prsonid)
        {
            
        }
        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewUser addNewUser = new AddNewUser();
            addNewUser.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _GetCurrentpersonID(ref Userid);
            Changepasswordd changescreen = new Changepasswordd(Userid);
            changescreen.ShowDialog();
        }
        private bool _GetCurrentpersonID(ref int UserId)
        {
            if (dgvUsers.CurrentRow != null)
            {

                object dgvobject = dgvUsers.CurrentRow.Cells[0].Value;

                dgvUsers.CellClick += dgvUsers_CellClick;

                if (dgvobject != null && int.TryParse(dgvobject.ToString(), out int number))
                {

                    UserId = number;
                    return true;




                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        private void refresh()
        {
            DataTable = clsUser.GetAllUsers();
            dgvUsers.DataSource=DataTable;
            dgvUsers.Refresh();
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int userid = 0;
            if (_GetCurrentpersonID(ref userid))
            {
                clsUser user = clsUser.Find(userid);
                if(user.Delete())
                {
                    MessageBox.Show("تم ازاله المستخدم بنجاح");
                    refresh();
                }
                else
                {
                    MessageBox.Show("حصل مشكله اثناء الحذف");

                }
            }
            else
            {
                MessageBox.Show("اتاكد انك واقف علي Data grid view");
            }
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Showditailmenu_Click(object sender, EventArgs e)
        {
            int userid = 0;
            if (_GetCurrentpersonID(ref userid))
            {
                UserInfo usercard = new UserInfo(userid);
                usercard.ShowDialog();


            }
            else
            {
                MessageBox.Show("مشكله هنا");
            }

        }

        private void pbAddUser_MouseEnter(object sender, EventArgs e)
        {
            pbAddUser.Image = imagelist.Images[1];

        }

        private void pbAddUser_MouseLeave(object sender, EventArgs e)
        {
            pbAddUser.Image = imagelist.Images[0];

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
