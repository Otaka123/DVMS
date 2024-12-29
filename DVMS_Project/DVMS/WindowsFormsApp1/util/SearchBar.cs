using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class SearchBar : UserControl
    {
        public delegate void databackhandler( DataTable result);
        public databackhandler onpic;
       
        public SearchBar()
        {
            InitializeComponent();
        }
        public DataTable dataTable;
        public DataTable Searchresult;
        public string NationalNo {  get; set; }
        public void defultValue(int defultvalue)
        {

           cbBy.Enabled = false;
           cbBy.SelectedIndex = defultvalue;
            

        }
        
        public void StartSearch(DataTable Data)
        {
            dataTable = Data;
            if (cbBy.Enabled == true)
            {
                FillComboBoxElemnts();
                cbBy.SelectedItem = "None";
            }

        }

            public void FillComboBoxElemnts()
        {
           
            cbBy.Items.Add("None");
            //cbbool.Items.Add("All");
            foreach (DataColumn column in dataTable.Columns)
            {
                cbBy.Items.Add(column.ColumnName);
               
            }
            //foreach (DataRow row in dataTable.Rows)
            //{
            //    cbbool.Items.Add(dataTable.Rows

            //}


        }
        private void _search(string by, string text)
        {
            
            //   إنشاء DataTable جديد لتخزين نتائج البحث وتعبئه الcombobox
            DataTable dt = new DataTable();
            foreach (DataColumn column in dataTable.Columns)
            {
                dt.Columns.Add(column.ColumnName, column.DataType);
            }

            // التحقق من نوع العمود (إذا كان String أو Integer)
            string filterExpression;
            if (dataTable.Columns[by].DataType == typeof(string))
            {
                // البحث باستخدام "LIKE" إذا كان نوع العمود String
                filterExpression = by + " LIKE '%" + text + "%'";

            }
            else
            {
                // البحث باستخدام "=" إذا كان نوع العمود Integer
                filterExpression = by + " = " + text;
            }

            // تنفيذ البحث وتخزين النتائج
            DataRow[] results = dataTable.Select(filterExpression);
            foreach (DataRow row in results)
            {
                dt.ImportRow(row);
            }

            // تخزين النتائج في DataTable النهائي
            Searchresult = dt;
            
        }

        private DataTable GetAllintcolumn()
        {   DataTable dt = new DataTable();
            foreach (DataColumn column in dataTable.Columns)
            {
                if(column.DataType == typeof(int))
                {
                    dt.Columns.Add(column.ColumnName, column.DataType);

                }
            }
            return dt;
        }
        private void SearchGenric()
        {
            if (tbtext.Text != "" && cbBy.Text != "None")
            {
                foreach (DataColumn column in dataTable.Columns)
                {

                    if (column.ColumnName == cbBy.Text)
                    {
                        _search(cbBy.Text, tbtext.Text);

                        //if (tbtext.Visible == true)
                        //{
                        //}
                        //if (cbbool.Visible == true&& cbbool.Text!="All")
                        //{
                            
                        //    _search(cbBy.Text, cbbool.Text);

                        //}

                    }
                }
            }
            else
            { Searchresult= dataTable;
            }
        }
        private void cbBy_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbBy.Text!="None" )
            {
                tbtext.Visible=true;
               
            }
          

        }
        private void GetNationalNo()
        {
          
           foreach (DataRow row in Searchresult.Rows)
            {
                NationalNo = row[1].ToString();
            }
        }
        private void tbtext_TextChanged(object sender, EventArgs e)
        {    SearchGenric();
            //onpic?.Invoke(Searchresult); لو عايز تلغي الزرار شغل دي
        }
      
        private void pbSearchbtn_Click(object sender, EventArgs e)
        {
            
            if (cbBy.Text == "None")
            {
                tbtext.Visible = false;
                onpic?.Invoke(dataTable);

            }
            SearchGenric();
            onpic?.Invoke(Searchresult);
          
            

        }
        private void pbSearchbtn_MouseEnter(object sender, EventArgs e)
        {pbSearchbtn.Image= btnimage.Images[1];
        }
        private void pbSearchbtn_MouseLeave(object sender, EventArgs e)
        { pbSearchbtn.Image = btnimage.Images[0];
        }
        private void SearchBar_Load(object sender, EventArgs e)
        {pbSearchbtn.Image = btnimage.Images[0];
        }
        private void tbtext_KeyPress(object sender, KeyPressEventArgs e)
        {
            foreach(DataColumn d in GetAllintcolumn().Columns)
            {
                if (cbBy.SelectedItem?.ToString() == d.ColumnName)
                {
                    if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    {
                        e.Handled = true; // منع الإدخال
                    }
                }
            }            
        }
        private void cbBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbtext.Text = string.Empty;
            if (cbBy.Text == "None")
            {

                tbtext.Visible = false;
                //onpic?.Invoke(dataTable);

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
