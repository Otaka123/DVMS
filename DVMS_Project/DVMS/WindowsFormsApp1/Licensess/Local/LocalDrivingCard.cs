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
    public partial class LocalDrivingCard : Form
    {
        public LocalDrivingCard()
        {
            InitializeComponent();
        }
       
        private int localID = 0;
        //private int Appid = 0;
        private int testtypeid= 0;
        public LocalDrivingCard(int G_localId,int G_testtypeid)
        {
            InitializeComponent();
            localID = G_localId;
            testtypeid = G_testtypeid;
        }
        private void _refrsh()
        {
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.GreenYellow;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Blue;
            dataGridView1.DefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = clsTestAppointment.GetAlltestAppointments(localID, testtypeid);
            lbrows.Text = dataGridView1.RowCount.ToString() + " #Rows";

        }
        private void LocalDrivingCard_Load(object sender, EventArgs e)
        {
            _refrsh();
            pbAddappointment.Image=buttons.Images[0];
            if(localID!=0)
            {
                fullInfoAppCard1.start(localID);
                pbclose.Image = buttons.Images[2];
            }
            if(testtypeid==1)
            {
                pbtitle.Image = titleimage.Images[0];
                lbtitle.Text = "Vision Test Appointments";
                
            }
            else if (testtypeid == 2)
            {
                pbtitle.Image = titleimage.Images[1];
                lbtitle.Text = "Written Test Appointments";
            }
            else if(testtypeid == 3)
            {
                pbtitle.Image = titleimage.Images[2];
                lbtitle.Text = "Driving Test Appointments";
            }
            
        }

        private void lbtitle_Click(object sender, EventArgs e)
        {

        }

        private void pbAddappointment_MouseLeave(object sender, EventArgs e)
        {
            pbAddappointment.Image = buttons.Images[0];

        }

        private void pbAddappointment_MouseEnter(object sender, EventArgs e)
        {
            pbAddappointment.Image = buttons.Images[1];

        }

        private void pbAddappointment_Click(object sender, EventArgs e)
        { if(!clsTestAppointment.IsSucced(localID, testtypeid))
            {
                if (clsTestAppointment.HaveAntherAppointment(localID, testtypeid))
                {
                    MessageBox.Show("عندك معاد تاني مفتوح لنفس الاختبار ");
                }
                else
                {
                    schedule_test scheduleTest=new schedule_test(localID, testtypeid);
                    scheduleTest.ShowDialog();
                    _refrsh();
                }
            }
            else
            {
                MessageBox.Show("انت نجحت في كل الاختبارات مش محتاج تحجز معاد امتحان :)");
            }
        }

        private void pbclose_MouseLeave(object sender, EventArgs e)
        {
            pbclose.Image = buttons.Images[2];

        }

        private void pbclose_MouseEnter(object sender, EventArgs e)
        {
            pbclose.Image = buttons.Images[3];

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pbclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            bool isTrue = Convert.ToBoolean(dataGridView1.CurrentRow.Cells["IsLocked"].Value);
            if(isTrue)
            {
                Taketests.Enabled = false;
            }
            else
            {
                Taketests.Enabled = true;

            }
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
           object appointid= dataGridView1.CurrentRow.Cells[0].Value;
            if (appointid != null && int.TryParse(appointid.ToString(), out int num))
             {
                TakeTest test = new TakeTest(num, localID);
                test.ShowDialog();
                fullInfoAppCard1.start(localID);
                _refrsh();
            }
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                // تحديد الصف وتركه كاختيار وحيد
                dataGridView1.ClearSelection();
                dataGridView1.Rows[e.RowIndex].Selected = true;

                // تحديد الخلية الأولى في الصف المحدد
                dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[0];
            }
        }
    }
}
