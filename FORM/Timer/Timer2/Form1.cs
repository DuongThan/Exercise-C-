using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }
        private int delta = 10, min;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            grb1.Left -= delta;
            grb2.Left -= delta;
            if (grb2.Left <= min)
            {
                grb2.Left = min;
                grb1.Hide();
                Timer.Stop();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            grb2.Left = grb1.Left + grb1.Width + delta;
            grb2.Top = grb1.Top;
            // thiết lập thời gian chạy , trượt
            Timer.Interval = 10;
            grb2.Show();
            min = grb1.Left;
            // timer bắt đầu
            Timer.Start(); // <=> timer.Enable = true;
        }
    }
}
