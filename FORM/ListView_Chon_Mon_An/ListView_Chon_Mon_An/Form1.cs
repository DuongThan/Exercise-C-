using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView_Chon_Mon_An
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DangNhap()
        {
            if (txtID.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Vui long nhap day du ID,Password");
                return;
            }
            if (txtID.Text == "admin" && txtPassword.Text == "123")
            {
                OpenForm2(0);
            }
            else
            {
                MessageBox.Show("Tai khoan hoac mat khau khong dung");
            }
        }
        private void OpenForm2(int user)
        {
            Form2 f2 = new Form2(user);
            f2.FormClosed += F2_FormClosed;
            f2.StartPosition = FormStartPosition.CenterScreen;
            //this.Hide();
            f2.Show();
            this.Hide();
        }

        private void F2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

       

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                DangNhap();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                DangNhap();
            }
        }

        private void btnguest_Click(object sender, EventArgs e)
        {
            OpenForm2(1);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
