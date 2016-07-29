using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderBrowseDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FolderBrowserDialog fbd;

        private void button1_Click(object sender, EventArgs e)
        {
            fbd = new FolderBrowserDialog();
            // Miêu tả sự lựa chọn file
            fbd.Description = "Hay chon thu muc";
            // Có cho phép tạo folder mới hay không
            fbd.ShowNewFolderButton = false;
            // đuognừ dẫn đầu tiên bắt đầu bưởi MyConputer
            fbd.RootFolder = Environment.SpecialFolder.MyComputer;
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                // Lấy dường dẫn dán cho txtpath.text
                txtpath.Text = fbd.SelectedPath.ToString();
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}
