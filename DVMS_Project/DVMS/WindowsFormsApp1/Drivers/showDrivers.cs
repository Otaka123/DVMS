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
    public partial class showDrivers : Form
    {
        public showDrivers()
        {
            InitializeComponent();
        }

        private void showDrivers_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 230);
            DataTable DataTable= clsLicense.GetAllDrivers();
            dgvUsers.DataSource = DataTable;
            searchBar.StartSearch(DataTable);
            searchBar.onpic += _search;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lbRowsNum.Text = DataTable.Rows.Count.ToString() + " #ROWS ";
            dgvUsers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsers.DefaultCellStyle.SelectionBackColor = Color.GreenYellow;
            dgvUsers.DefaultCellStyle.SelectionForeColor = Color.Blue;
            dgvUsers.DefaultCellStyle.BackColor = Color.LightGray;

        }
        private void _search(DataTable resulte)
        {

            dgvUsers.DataSource = resulte;
        }
    
    }
}
