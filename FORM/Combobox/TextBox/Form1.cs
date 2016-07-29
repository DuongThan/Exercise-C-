using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            //MessageBox.Show("Ban vua di chuyen chuot ra khoi textbox");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt1.Focus();

            txt1.SelectAll();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(txt1.Text.Length >= 10)
            {
                MessageBox.Show("chi nhap dc 10 ki tu");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt1_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Ban vua chuyen con tro sang thu muc khac");
        }

        private void txt1_MouseDown(object sender, MouseEventArgs e)
        {
            //Sự kiện được thực hiện khi bấm chuột lên textbox này
            MessageBox.Show("Banj vua dup chot vao textbox");
        }
    }
}
