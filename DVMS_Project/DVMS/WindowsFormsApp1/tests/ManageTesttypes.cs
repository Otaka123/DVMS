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
    public partial class ManageTesttypes : Form
    {
        public ManageTesttypes()
        {
            InitializeComponent();
        }
        private DataTable Application = clsTestType.GettAllTestTypes();
        //private clsTestType App;
        private int AppID = 0;

        private void ManageTesttypes_Load(object sender, EventArgs e)
        {
            lbRowsNum.Text = Application.Rows.Count.ToString() + " #ROWS ";
            dgvApp.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvApp.DefaultCellStyle.SelectionBackColor = Color.GreenYellow;
            dgvApp.DefaultCellStyle.SelectionForeColor = Color.Blue;
            dgvApp.DefaultCellStyle.BackColor = Color.LightGray;
            dgvApp.DataSource = Application;
            dgvApp.Columns[0].Width = 80;
            dgvApp.Columns[1].Width = 100;
            dgvApp.Columns[2].Width = 250;
            pbclose.Image = imageList2.Images[0];
        }

        private void pbclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbclose_MouseEnter(object sender, EventArgs e)
        {
            pbclose.Image = imageList2.Images[1];

        }

        private void pbclose_MouseLeave(object sender, EventArgs e)
        {
            pbclose.Image = imageList2.Images[0];

        }
        private bool _GetCurrentpersonID(ref int UserId)
        {
            if (dgvApp.CurrentRow != null)
            {

                object dgvobject = dgvApp.CurrentRow.Cells[0].Value;

                dgvApp.CellClick += dgvApp_CellClick;

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

        private void dgvApp_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                // تحديد الصف وتركه كاختيار وحيد
                dgvApp.ClearSelection();
                dgvApp.Rows[e.RowIndex].Selected = true;

                // تحديد الخلية الأولى في الصف المحدد
                dgvApp.CurrentCell = dgvApp.Rows[e.RowIndex].Cells[0];
            }
        }

        private void dgvApp_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void _refresh()
        {
            dgvApp.DataSource = clsTestType.GettAllTestTypes();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _GetCurrentpersonID(ref AppID);
            if (AppID != 0)
            {
                Edittesttype editApp = new Edittesttype(AppID);
                editApp.das += _refresh;
                editApp.ShowDialog();
            }
        }
    }
}
