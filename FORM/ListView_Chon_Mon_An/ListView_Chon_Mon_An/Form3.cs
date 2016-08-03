using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ListView_Chon_Mon_An
{
    public partial class Form3 : Form
    {
       
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            StreamWriter write = new StreamWriter("a.txt", true);
            write.WriteLine(txtTenMon.Text + "," + txtGia.Text + "," + txtSoLuong.Text);
            write.Close();
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenMon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtGia.Text == "" || txtSoLuong.Text == "" || txtTenMon.Text == "") 
                {
                    MessageBox.Show("Vui long nhap day du thong tin");
                    this.Close();
                    return;
                }
                StreamWriter write = new StreamWriter("a.txt", true);
                write.WriteLine(txtTenMon.Text + "," + txtGia.Text + "," + txtSoLuong.Text);
                write.Close();
                this.Close();
            }
        }

        private void txtGia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtGia.Text == "" || txtSoLuong.Text == "" || txtTenMon.Text == "")
                {
                    MessageBox.Show("Vui long nhap day du thong tin");
                    this.Close();
                    return;
                }
                StreamWriter write = new StreamWriter("a.txt", true);
                write.WriteLine(txtTenMon.Text + "," + txtGia.Text + "," + txtSoLuong.Text);
                write.Close();
                this.Close();
            }
        }

        private void txtSoLuong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtGia.Text == "" || txtSoLuong.Text == "" || txtTenMon.Text == "")
                {
                    MessageBox.Show("Vui long nhap day du thong tin");
                    this.Close();
                    return;
                }
                StreamWriter write = new StreamWriter("a.txt", true);
                write.WriteLine(txtTenMon.Text + "," + txtGia.Text + "," + txtSoLuong.Text);
                write.Close();
                this.Close();
            }
        }
    }
}
