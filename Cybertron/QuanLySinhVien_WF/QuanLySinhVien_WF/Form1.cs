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
            InitializeComponent();
        }
        
        private bool them = true;
        private QuanLy quanly = new QuanLy();
        ConnectData con = new ConnectData();

        private void LoadData()
        {
            //SinhVien sv = new SinhVien();
            //dgvDssv.Rows.Clear();
            //for (int i = 0; i < quanly.List_SinhVien.Count(); i++)
            //{
            //    sv = quanly.List_SinhVien[i];
            //    dgvDssv.Rows.Add("" + sv.MaSV + " ", "" + sv.HoTen + " ", "" + sv.Khoa + " ", "" + sv.Lop + " ", "" + sv.GioiTinh + " ", "" + sv.NgaySinh + " ", "" + sv.Email + " ", "" + sv.DiaChi + " ", "" + sv.SoDT + " ", "" + sv.DiemTB + " ", "" + sv.ThanhTich + " ", "" + sv.GhiChu + " ");
            //}
            DataTable dt = con.GetTable("select * from SinhVien");
            dgvDssv.DataSource = dt;
        }

        public void SetNull()
        {
            txtma1.Text = "";
            txtma2.Text = "";
            txthoten1.Text = "";
            txthoten2.Text = "";
            cmbKhoa.Text = "";
            cmbKhoasv.Text = "";
            comblop1.Text = "";
            combLop2.Text = "";
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
            LoadData();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
        private int dich = 10;
        private int minleft,maxright;
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
            grb2.Left -= dich;
            if (grb2.Left <= minleft)
            {
                grb2.Left = minleft;
                TimerNext.Stop();
            }
        }

        private void TimerPre_Tick(object sender, EventArgs e)
        {
            grb2.Left += dich;
            if(grb2.Left>=maxright)
            {
                grb2.Left = maxright;
                grb2.Hide();
                TimerPre.Stop();
            }

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
            grb2.Top = grb1.Top;
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
                sv.Lop = combLop2.Text;
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

                // quanly.Add(sv);
                quanly.ThemMoi(sv);
            }
            else
            {
                sv = new SinhVien();
                sv.MaSV = txtma2.Text;
                sv.HoTen = txthoten2.Text;
                sv.Khoa = cmbKhoasv.Text;
                sv.Lop = combLop2.Text;
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

                //quanly.List_SinhVien[quanly.Search(txtma2.Text)] = sv;
                quanly.Sua(sv);
            }
            SetNull();
            LoadData();
            SetN();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //quanly.Remove(quanly.List_SinhVien[quanly.Search(txtma2.Text)]);
            quanly.Delete(txtma2.Text);
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

        private void opnfd_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void dgvDssv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txtma1.Text = dgvDssv.Rows[row].Cells[0].Value.ToString();
            txtma2.Text = dgvDssv.Rows[row].Cells[0].Value.ToString();

            txthoten1.Text = dgvDssv.Rows[row].Cells[1].Value.ToString();
            txthoten2.Text = dgvDssv.Rows[row].Cells[1].Value.ToString();

            cmkhoa1.Text = dgvDssv.Rows[row].Cells[2].Value.ToString();
            cmbKhoasv.Text = dgvDssv.Rows[row].Cells[2].Value.ToString();

            comblop1.Text = dgvDssv.Rows[row].Cells[3].Value.ToString();
            combLop2.Text = dgvDssv.Rows[row].Cells[3].Value.ToString();

            txtdiemtb1.Text = dgvDssv.Rows[row].Cells[11].Value.ToString();
            txtdiemtb2.Text = dgvDssv.Rows[row].Cells[11].Value.ToString();

            if (dgvDssv.Rows[row].Cells[4].Value.ToString() == "Nam")
            {
                radnam.Checked = true;
                radnam1.Checked = true;
            }
            else
            {
                radnu.Checked = true;
                radnu1.Checked = true;
            }

            datpDate.Text = dgvDssv.Rows[row].Cells[9].Value.ToString();
            txtmail2.Text = dgvDssv.Rows[row].Cells[5].Value.ToString();
            txtdiachi2.Text = dgvDssv.Rows[row].Cells[6].Value.ToString();
            txtsdt2.Text = dgvDssv.Rows[row].Cells[10].Value.ToString();
            txtthanhtich.Text = dgvDssv.Rows[row].Cells[8].Value.ToString();
            txtghichu2.Text = dgvDssv.Rows[row].Cells[7].Value.ToString();

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
