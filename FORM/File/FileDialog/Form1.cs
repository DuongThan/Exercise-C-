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

namespace FileDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OpenFileDialog open;
        SaveFileDialog save;

        private void btnOpen_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.Filter = "|*.txt";
            if(open.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = open.FileName;
                StreamReader read = new StreamReader(txtPath.Text);
                txtContaint.Text = read.ReadToEnd();
                read.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPath.Text == "") return;
            StreamWriter write = new StreamWriter(txtPath.Text.Trim());
            write.WriteLine(txtContaint.Text);
            write.Close();
            MessageBox.Show("Save success");
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            save = new SaveFileDialog();
            save.Filter = "|*.txt";
            save.RestoreDirectory = true;
            if(save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(save.FileName);
                write.WriteLine(txtContaint.Text);
                write.Close();
            }
        }
    }
}
