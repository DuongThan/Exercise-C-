using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int i = 1;
        private int j = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblRun.Location = new Point(lblRun.Location.X + i, lblRun.Location.Y);
            lblTime.Text = "Time : " + j;
            if(lblRun.Location.X > 350 || lblRun.Location.X <=0)
            {
                i = -i;
            }
            j++;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer.Interval = 1;
        }
    }
}
