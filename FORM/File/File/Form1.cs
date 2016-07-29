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

namespace File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter write = new StreamWriter(txtFile.Text,true);
            write.WriteLine(txtWrite.Text);
            write.Close();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            StreamReader read = new StreamReader(txtFile.Text);
            txtRead.Text = read.ReadToEnd();
            read.Close();
        }
    }
}
