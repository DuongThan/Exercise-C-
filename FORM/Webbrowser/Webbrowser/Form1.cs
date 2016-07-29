using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Webbrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tsbStart_Click(object sender, EventArgs e)
        {
            wbWeb.Navigate(txtLink.Text);
        }

        private void txtLink_Click(object sender, EventArgs e)
        {

        }

        private void txtLink_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                wbWeb.Navigate(txtLink.Text);
            }
            if (e.Control && e.KeyCode == Keys.R)
            {
                wbWeb.Refresh();
            }
            if (e.Control && e.KeyCode == Keys.H)
            {
                wbWeb.GoHome();
            }
            if (e.Control && e.KeyCode == Keys.B)
            {
                wbWeb.GoBack();
            }
        }

        private void tsbStop_Click(object sender, EventArgs e)
        {
            wbWeb.Stop();
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            wbWeb.Refresh();
        }

        private void tsbHome_Click(object sender, EventArgs e)
        {
            wbWeb.GoHome();
        }

        private void tsbNext_Click(object sender, EventArgs e)
        {
            wbWeb.GoForward();
        }

        private void tsbGoBack_Click(object sender, EventArgs e)
        {
            wbWeb.GoBack();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtLink_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tstpToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
