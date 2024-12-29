using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Licensess.Detain
{
    public partial class ManageDetain : Form
    {
        public ManageDetain()
        {
            InitializeComponent();
        }
        private DataTable _Tableinfo;
        private int _DetainID = 0;
        private int _LicenseID = 0;
        private int _personID = 0;
        private void ManageDetain_Load(object sender, EventArgs e)
        {
            this.Location = new Point(300, 230);

            _Tableinfo = clsdetain.GetallDetain();
            searchBar1.StartSearch(_Tableinfo);
            searchBar1.onpic = _search;
            lbRowsNum.Text = _Tableinfo.Rows.Count.ToString() + " #ROWS ";
            dgvApp.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvApp.DefaultCellStyle.SelectionBackColor = Color.GreenYellow;
            dgvApp.DefaultCellStyle.SelectionForeColor = Color.Blue;
            dgvApp.DefaultCellStyle.BackColor = Color.LightGray;
            dgvApp.DataSource = _Tableinfo;
            dgvApp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pbAddApp.Image = imageList1.Images[0];
            pbrelease.Image = imageList1.Images[2];
        }
        private void _search(DataTable dt)
        {
            dgvApp.DataSource=dt;
        }

        private void _refresh()
        {
            dgvApp.DataSource= clsdetain.GetallDetain();
        }
        private void pbAddApp_MouseLeave(object sender, EventArgs e)
        {
            pbAddApp.Image = imageList1.Images[0];

        }

        private void pbAddApp_MouseEnter(object sender, EventArgs e)
        {
            pbAddApp.Image = imageList1.Images[1];

        }
        private bool _GetCurrentpersonID(ref int UserId ,int colnum)
        {
            if (dgvApp.CurrentRow != null)
            {

                object dgvobject = dgvApp.CurrentRow.Cells[colnum].Value;

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

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (!clsLicense.IsDetain(_LicenseID))
            {
                releaseLicenseToolStripMenuItem.Enabled = false;
            }
        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if( _GetCurrentpersonID(ref _LicenseID,1))
            {
                
                showLicense showLicense = new showLicense(clsLicense.Find(_LicenseID).ApplictionID);
                showLicense.ShowDialog();
            }
        }

        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_GetCurrentpersonID(ref _DetainID,0))
            {
                _personID = clsdetain.GetPersonID(_DetainID);
                Form1 form1 = new Form1(_personID);
                form1.ShowDialog();
            }

        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pbrelease.Image = imageList1.Images[2];

        }

        private void pbrelease_MouseEnter(object sender, EventArgs e)
        {
            pbrelease.Image = imageList1.Images[3];

        }

        private void pbAddApp_Click(object sender, EventArgs e)
        {
            Detain_License detain_License = new Detain_License();
            detain_License.ShowDialog();
        }

        private void licensesHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_GetCurrentpersonID(ref _DetainID, 0))
            {
                _personID = clsdetain.GetPersonID(_DetainID);

                LicenseHistory licenseHistory = new LicenseHistory(_personID);
                licenseHistory.ShowDialog();
            }
        }

        private void pbrelease_Click(object sender, EventArgs e)
        {
            ReleaseLicense release = new ReleaseLicense();
            release.ShowDialog();
        }

        private void releaseLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_GetCurrentpersonID(ref _LicenseID, 1))
            
                if(clsLicense.IsDetain(_LicenseID))
                {
                    ReleaseLicense release = new ReleaseLicense();
                    release.fillinfo(_LicenseID);
                }
               

            }
               
        }
    }
        
     

    
