using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int delta = 10,min,max;
        private void button1_Click(object sender, EventArgs e)
        {
            grb2.Left = grb1.Left + grb1.Width + delta;
            grb2.Top = grb1.Top;
            Timer1.Interval = 20;
            min = grb1.Left;
            grb2.Show();
            Timer1.Start();
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            grb1.Left += delta;
            grb2.Left += delta;
            if(grb1.Left >= max)
            {
                grb1.Left = max;
                grb2.Hide();
                Timer2.Stop();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            max = grb2.Left;
            Timer2.Interval = 20;
            grb1.Show();
            Timer2.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            grb1.Left -= delta;
            grb2.Left -= delta;
            if(grb2.Left <= min)
            {
                grb2.Left = min;
                grb1.Hide();
                Timer1.Stop();
            }
        }
    }
}
