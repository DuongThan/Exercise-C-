using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            MessageBox.Show("SAD");
        }

        private bool them = true;
        private QuanLy quanly = new QuanLy();

        private void LoadData()
        {
            SinhVien sv = new SinhVien();
            dgvDssv.Rows.Clear();
            for (int i = 0; i < quanly.List_SinhVien.Count(); i++)
            {
                sv = quanly.List_SinhVien[i];
                dgvDssv.Rows.Add("" + sv.MaSV + " ", "" + sv.HoTen + " ", "" + sv.Khoa + " ", "" + sv.Lop + " ", "" + sv.GioiTinh + " ", "" + sv.NgaySinh + " ", "" + sv.Email + " ", "" + sv.DiaChi + " ", "" + sv.SoDT + " ", "" + sv.DiemTB + " ", "" + sv.ThanhTich + " ", "" + sv.GhiChu + " ");
            }
        }

        public void SetNull()
        {
            txtma1.Text = "";
            txthoten1.Text = "";
            txtma2.Text = "";
            txthoten2.Text = "";
            cmbKhoa.Text = "";
            cmbLop.Text = "";
            radnam.Checked = true;
            radnam1.Checked = true;
            datpDate.Text = "";
            txtmail2.Text = "";
            txtdiachi2.Text = "";
            txtthanhtich.Text = "";
            txtdiemtb2.Text = "";
            txtdiemtb1.Text = "";
            txtghichu2.Text = "";
            txtsdt2.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
        private int dich = 10;
        private int minleft, maxright;
        private void button3_Click(object sender, EventArgs e)
        {
            grb2.Left = grb1.Left + grb1.Width + dich;
            grb2.Top = grb1.Top;
            TimerNext.Interval = 5;
            minleft = grb1.Left;
            grb2.Show();
            TimerNext.Start();
        }

        private void TimerNext_Tick(object sender, EventArgs e)
        {

        }

        private void TimerPre_Tick(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            picb.BackgroundImage = null;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                picb2.BackgroundImage = Image.FromFile(opnfd.FileName);
                picb2.BackgroundImageLayout = ImageLayout.Center;
            }
            picb.BackgroundImage = picb2.BackgroundImage;
            picb.BackgroundImageLayout = ImageLayout.Center;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            them = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            grb2.Left = grb1.Left;
            grb1.Hide();
            grb2.Show();
        }

        public void SetN()
        {
            btnThemMoi.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SinhVien sv;
            if (them)
            {
                sv = new SinhVien();
                sv.MaSV = txtma2.Text;
                sv.HoTen = txthoten2.Text;
                sv.Khoa = cmbKhoasv.Text;
                sv.Lop = cmbLop.Text;
                if (radnam.Checked == true)
                {
                    sv.GioiTinh = "Nam";
                }
                else sv.GioiTinh = "Nu";
                sv.NgaySinh = DateTime.Parse(datpDate.Text);
                sv.Email = txtmail2.Text;
                sv.DiaChi = txtdiachi2.Text;
                sv.ThanhTich = txtthanhtich.Text;
                sv.DiemTB = float.Parse(txtdiemtb2.Text);
                sv.SoDT = int.Parse(txtsdt2.Text);
                sv.GhiChu = txtghichu2.Text;

                quanly.Add(sv);
            }
            else
            {
                sv = new SinhVien();
                sv.MaSV = txtma2.Text;
                sv.HoTen = txthoten2.Text;
                sv.Khoa = cmbKhoa.Text;
                sv.Lop = cmbLop.Text;
                if (radnam.Checked == true)
                {
                    sv.GioiTinh = "Nam";
                }
                else sv.GioiTinh = "Nu";
                sv.NgaySinh = DateTime.Parse(datpDate.Text);
                sv.Email = txtmail2.Text;
                sv.DiaChi = txtdiachi2.Text;
                sv.ThanhTich = txtthanhtich.Text;
                sv.DiemTB = float.Parse(txtdiemtb2.Text);
                sv.GhiChu = txtghichu2.Text;
                sv.SoDT = int.Parse(txtsdt2.Text);

                quanly.List_SinhVien[quanly.Search(txtma2.Text)] = sv;
            }
            SetNull();
            LoadData();
            SetN();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            quanly.Remove(quanly.List_SinhVien[quanly.Search(txtma2.Text)]);
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnThemMoi.Enabled = false;
            them = false;
            btnLuu.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetN();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            maxright = grb1.Left + grb1.Width + dich;
            grb1.Show();
            TimerPre.Interval = 5;
            TimerPre.Start();
        }
    }
}
