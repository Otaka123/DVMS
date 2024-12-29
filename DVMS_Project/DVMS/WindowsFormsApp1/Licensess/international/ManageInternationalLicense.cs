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
    public partial class ManageInternationalLicense : Form
    {
        public ManageInternationalLicense()
        {
            InitializeComponent();
        }
        private DataTable sourceadta;
        private void ManageInternationalLicense_Load(object sender, EventArgs e)
        {
            this.Location = new Point(300, 230);
            sourceadta = clsLicense.GetAllinternationalLicense();
            searchBar1.StartSearch(clsLicense.GetAllinternationalLicense());
            searchBar1.onpic = _search;
            lbRowsNum.Text = sourceadta.Rows.Count.ToString() + " #ROWS ";
            dgvApp.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvApp.DefaultCellStyle.SelectionBackColor = Color.GreenYellow;
            dgvApp.DefaultCellStyle.SelectionForeColor = Color.Blue;
            dgvApp.DefaultCellStyle.BackColor = Color.LightGray;
            dgvApp.DataSource = sourceadta;
            dgvApp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pbAddApp.Image = imageList1.Images[0];
        }
        private void _refrsh()
        {
           
            dgvApp.DataSource = clsApplications.GetlocalApplication();
            lbRowsNum.Text = dgvApp.Rows.Count.ToString() + " #ROWS ";

        }
        private void _search(DataTable dt)
        {
            sourceadta = dt;
            dgvApp.DataSource = sourceadta;
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

        private void pbAddApp_MouseLeave(object sender, EventArgs e)
        {
            pbAddApp.Image = imageList1.Images[0];

        }

        private void pbAddApp_MouseEnter(object sender, EventArgs e)
        {
            pbAddApp.Image = imageList1.Images[1];

        }

        private void pbAddApp_Click(object sender, EventArgs e)
        {
            issueInternational newtap = new issueInternational();
            newtap.ShowDialog();
        }
    }
}
