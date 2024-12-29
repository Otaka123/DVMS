using Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.util
{
    public class Utilty
    {
        public static void Form_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridView dgv = sender as DataGridView;

                //if (dgv != null)
                //{
                //    //object value = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                //}
            }
        }
        public static void selectallrow(object sender, DataGridViewCellMouseEventArgs e, DataGridView controlname)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                // تحديد الصف وتركه كاختيار وحيد
                controlname.ClearSelection();
                controlname.Rows[e.RowIndex].Selected = true;

                // تحديد الخلية الأولى في الصف المحدد
                controlname.CurrentCell = controlname.Rows[e.RowIndex].Cells[0];
            }
        }
        public static void FormatDataGridVeiw(Control labal,DataTable Datasorce,DataGridView controlname)
        {

            labal.Text = Datasorce.Rows.Count.ToString() + " #ROWS ";
            controlname.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            controlname.DefaultCellStyle.SelectionBackColor = Color.GreenYellow;
            controlname.DefaultCellStyle.SelectionForeColor = Color.Blue;
            controlname.DefaultCellStyle.BackColor = Color.LightGray;
            controlname.DataSource = Datasorce;
        }
        public static bool Getfirstcellvalue(ref int Id, object sender, DataGridView controlname)
        {

            if (controlname.CurrentRow != null)
            {

                object dgvobject = controlname.CurrentRow.Cells[0].Value;

                controlname.CellClick += Form_CellClick;


                if (dgvobject != null && int.TryParse(dgvobject.ToString(), out int number))
                {

                    Id = number;
                    return true;




                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
