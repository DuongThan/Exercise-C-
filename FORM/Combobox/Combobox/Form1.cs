using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private DataTable dt;
        private void cbbIndex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbbIndex.SelectedText = "Chọn lớp";
        }

        private void LoadData()
        {
            dt = new DataTable();
            dt.Columns.Add("Ma");
            dt.Columns.Add("Lop");
            dt.Rows.Add("1", "Lop 1");
            dt.Rows.Add("2", "Lop 2");
            dt.Rows.Add("3", "Lop 3");
            dt.Rows.Add("4", "Lop 4");
            dt.Rows.Add("5", "Lop 5");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
            cbbData.DataSource = dt;
            cbbData.DisplayMember = "Lop";
            cbbData.ValueMember = "Ma";
            // tự động thêm dữ liệu vào một danh sách 2 dòng nay phải đi cùng nhau
            cbbData.AutoCompleteSource = AutoCompleteSource.ListItems;
            // xem chế độ là gì suggest append..
            cbbData.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void cbbData_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(cbbData.SelectedIndex == 2)
            //{
            //    MessageBox.Show("Da chon lop 3");
            //}
        }

        private void cbbData_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbData.Text == "") return;
                MessageBox.Show("Da chon lop  : "+ cbbData.SelectedValue);
            
        }

        private void cbbData_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void cbbData_Enter(object sender, EventArgs e)
        {
        }

        private void cbbData_Leave(object sender, EventArgs e)
        {
        }

        private void cbbData_MouseLeave(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            MessageBox.Show("Di chuyen con tro ra khoi man hinh");
        }
    }
}
