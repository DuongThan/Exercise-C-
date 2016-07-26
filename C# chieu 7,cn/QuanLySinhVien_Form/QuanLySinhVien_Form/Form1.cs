using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien_Form
{
    public partial class Form1 : Form
    {
        private List<SinhVien> list_SinhVien = new List<SinhVien>();
        private SinhVien sv;
        bool themmoi = true;

        public Form1()
        {
            InitializeComponent();
        }

        public void SetNull()
        {
            txtMaSV.Text = "";
            txtLop.Text = "";
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
        }

        public void AnTextbox()
        {
            txtDiaChi.Enabled = false;
            txtHoTen.Enabled = false;
            txtLop.Enabled = false;
            txtMaSV.Enabled = false;
            txtSDT.Enabled = false;
        }

        public void HienTexbox()
        {
            txtDiaChi.Enabled = true;
            txtHoTen.Enabled = true;
            txtLop.Enabled = true;
            txtMaSV.Enabled = true;
            txtSDT.Enabled = true;
        }

        public void LoadData()
        {
            AnTextbox();
            dgvDssv.Rows.Clear();
            foreach(SinhVien temp in list_SinhVien)
            {
                dgvDssv.Rows.Add(temp.MaSinhVien, temp.HoTen, temp.Lop,temp.GioiTinh, temp.NgaySinh.ToShortDateString(), temp.SoDienThoai, temp.DiaChi);
            }
            SetNull();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private bool CheckNull()
        {
            if (txtMaSV.Text == "" || txtLop.Text == "" || txtHoTen.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "" || (rbNam.Checked == false && rbNu.Checked == false))
            {
                return true;
            }
            return false;
        }

        private void LuuThemMoi()
        {
            if (CheckNull())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            foreach (SinhVien sv in list_SinhVien)
            {
                if (txtMaSV.Text == sv.MaSinhVien)
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại, Bạn vui lòng nhập mã số khác");
                    return;
                }
            }
            sv = new SinhVien();
            sv.MaSinhVien = txtMaSV.Text;
            sv.HoTen = txtHoTen.Text;
            sv.Lop = txtLop.Text;
            sv.DiaChi = txtDiaChi.Text;
            int sdt;
            if(!int.TryParse(txtSDT.Text,out sdt))
            {
                MessageBox.Show("Số điện thoại không đúng kiểu dữ liệu");
                return;
            }
            sv.SoDienThoai = sdt;
            sv.NgaySinh = DateTime.Parse(dtpNgaySInh.Text);
            if (rbNam.Checked) sv.GioiTinh = true;
            else sv.GioiTinh = false;
            list_SinhVien.Add(sv);
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            SetNull();
            themmoi = true;
            HienTexbox();
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void dgvDssv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HienTexbox();
            btnLuu.Enabled = false;
            btnThemMoi.Enabled = true;
            int row = e.RowIndex;
            txtMaSV.Text = dgvDssv.Rows[row].Cells[0].Value.ToString();
            txtHoTen.Text = dgvDssv.Rows[row].Cells[1].Value.ToString();
            txtLop.Text = dgvDssv.Rows[row].Cells[2].Value.ToString();
            if (dgvDssv.Rows[row].Cells[2].Value.ToString() == "true") rbNam.Checked = true;
            else rbNu.Checked = true;
           dtpNgaySInh.Text = dgvDssv.Rows[row].Cells[4].Value.ToString();
            txtSDT.Text = dgvDssv.Rows[row].Cells[5].Value.ToString();
            txtDiaChi.Text = dgvDssv.Rows[row].Cells[6].Value.ToString();
            txtMaSV.Enabled = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            HienTexbox();
            txtMaSV.Enabled = true;
            btnThemMoi.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            SetNull();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            HienTexbox();
            btnLuu.Enabled = true;
            if (CheckNull() || dgvDssv.Rows.Count == 1) return;
            txtMaSV.Enabled = false;
            themmoi = false;
            btnThemMoi.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void LuuSua()
        {
            if (CheckNull())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            foreach(SinhVien sv in list_SinhVien)
            {
                if(txtMaSV.Text == sv.MaSinhVien)
                {
                    sv.HoTen = txtHoTen.Text;
                    sv.Lop = txtLop.Text;
                    sv.DiaChi = txtDiaChi.Text;
                    sv.SoDienThoai = int.Parse(txtSDT.Text);
                    sv.NgaySinh = DateTime.Parse(dtpNgaySInh.Text);
                    if (rbNam.Checked) sv.GioiTinh = true;
                    else sv.GioiTinh = false;
                }
            }


        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            HienTexbox();
            btnLamMoi.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            if (themmoi == true)
                LuuThemMoi();

            else LuuSua();
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            HienTexbox();
            foreach (SinhVien sv in list_SinhVien)
            {
                if (txtMaSV.Text == sv.MaSinhVien)
                {
                    list_SinhVien.Remove(sv);
                    MessageBox.Show("Đã xóa thành công");
                    break;
                }
            }
            LoadData();
        }
    }
}
