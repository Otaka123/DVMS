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
using WindowsFormsApp1.util;

namespace WindowsFormsApp1
{
    public partial class ApplicationTypes : Form
    {
      
        public ApplicationTypes()
        {
            InitializeComponent();
        }
        private DataTable Application = clsApllicationTypes.GettAllApplicationTypes();
        private int AppID=0;
        private void ApplicationTypes_Load(object sender, EventArgs e)
        {

            this.Location = new Point(580, 300);
            Utilty.FormatDataGridVeiw(lbRowsNum, Application, dgvApp);
            dgvApp.Columns[1].Width = 300;
            dgvApp.Columns[2].Width = 120;
            pbclose.Image = imageList2.Images[0];
            dgvApp.CellClick += Utilty.Form_CellClick;
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
      
        private void dgvApp_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
           
           Utilty.selectallrow(sender, e,dgvApp);
        }

        private void dgvApp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }
        private void _refresh()
        {
            dgvApp.DataSource = clsApllicationTypes.GettAllApplicationTypes();
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilty.Getfirstcellvalue(ref AppID, sender,dgvApp);
            if (AppID != 0)
            {
                EditApp editApp = new EditApp(AppID);
                editApp.das += _refresh;
                editApp.ShowDialog();
            }
        }
    }
}
