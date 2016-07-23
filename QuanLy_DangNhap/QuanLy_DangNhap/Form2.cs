using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace QuanLy_DangNhap
{
    public partial class Form2 : Form
    {
        Connection con = new Connection();
        string tk,name,sex,sdt,mail;
        bool them = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void LoadData()
        {
            dgvTK.DataSource = con.GetData("Select TaiKhoan,Hoten,GioiTinh,SDT,Email from Login");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string s = "delete from Login where TaiKhoan = '" + txtTaiKhoan.Text + "'";
            con.ExecuteSQL(s);
            LoadData();
        }

        public void Setnull()
        {
            txtTaiKhoan.Text = "";
            txtGioiTinh.Text = "";
            txtmail.Text = "";
            txtSDT.Text = "";
            txtTen.Text = "";
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            Setnull();
            btnThem.Enabled = true;
        }

        private void dgvTK_MouseEnter(object sender, EventArgs e)
        {

        }

        private void dgvTK_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = con.GetData(" select TaiKhoan,HoTen,GioiTinh,SDT,Email from Login where TaiKhoan = '" + txtsearch.Text + "'");
            if (dt.Rows.Count == 0)
            {
                this.lbstatus.Text = "Khong tim thay du lieu";
                this.lbstatus.ForeColor = Color.Red;
                return;
            }
            dgvTK.DataSource = dt;
            this.lbstatus.Text = "";
       
        }

        private void gdvTK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex; //dgvTK.CurrentRow.Index;
            txtTaiKhoan.Text = dgvTK[0, row].Value.ToString();
            txtTen.Text = dgvTK[1, row].Value.ToString();
            txtGioiTinh.Text = dgvTK[2, row].Value.ToString();
            txtSDT.Text = dgvTK[3, row].Value.ToString();
            txtmail.Text = dgvTK[4, row].Value.ToString();

            btnThem.Enabled = false;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            tk = txtTaiKhoan.Text;
            name = txtTen.Text;
            sdt = txtSDT.Text;
            sex = txtGioiTinh.Text;
            mail = txtmail.Text;

            string s = "insert into Login (TaiKhoan,HoTen,GioiTinh,SDT,Email) values ('"+tk+"','"+name+"','"+sex+"','"+sdt+"','"+mail+"')";
            con.ExecuteSQL(s);
            LoadData();
            btnThem.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            tk = txtTaiKhoan.Text;
            name = txtTen.Text;
            sdt = txtSDT.Text;
            sex = txtGioiTinh.Text;
            mail = txtmail.Text;

            string s = "update Login set HoTen = '"+name+"',GioiTinh='"+sex+"',SDT='"+sdt+"',Email='"+mail+"' where TaiKhoan = '"+tk+"' ";
            con.ExecuteSQL(s);
            LoadData();
        }
    }
}
