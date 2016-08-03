using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Add()
        {
            liv.Columns.Add(new ColumnHeader() { Text = "Info" });
            liv.Columns.Add(new ColumnHeader() { Text = "Info1" });
            liv.Columns.Add(new ColumnHeader() { Text = "Info2" });
            liv.Columns.Add(new ColumnHeader() { Text = "Info3" });
            ListViewItem item = new ListViewItem();
            item.Text = "Download";
            item.ImageIndex = 1;
            liv.Items.Add(new ListViewItem() { Text = "Desktop" });
            liv.Items.Add(item);
            ListViewItem.ListViewSubItem sub = new ListViewItem.ListViewSubItem();
            sub.Text = DateTime.Now.ToString();
            liv.Items[0].SubItems.Add(sub);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            liv.Items.Add(new ListViewItem() { Text = "1" });
            liv.Items.Add(new ListViewItem() { Text = "2" });
            liv.Items.Add(new ListViewItem() { Text = "3" });
            liv.Items.Add(new ListViewItem() { Text = "4" });
            liv.Items.Add(new ListViewItem() { Text = "5" });
            liv.Items.Add(new ListViewItem() { Text = "6" });
            liv.Items.Add(new ListViewItem() { Text = "7" });
            liv.Items.Add(new ListViewItem() { Text = "8" });
            Add();
            var itema = liv.Items[8];
            liv.Items.Remove(itema);
            liv.Items.Insert(5, itema);
        }

        private void btnlarge_Click(object sender, EventArgs e)
        {
            liv.View = View.LargeIcon;
        }

        private void btnsmall_Click(object sender, EventArgs e)
        {
            liv.View = View.SmallIcon;
        }

        private void btnlist_Click(object sender, EventArgs e)
        {
            liv.View = View.List;
        }

        private void btndetail_Click(object sender, EventArgs e)
        {
            liv.View = View.Details;
        }

        private void liv_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (liv.SelectedItems.Count > 0)
            //    MessageBox.Show(liv.SelectedIndices[0].ToString());
        }

        private void liv_MouseClick(object sender, MouseEventArgs e)
        {
            //if(liv.SelectedItems.Count>0)
            //MessageBox.Show("Press " + liv.SelectedIndices[0].ToString());
            //if (liv.SelectedItems.Count > 0)
            //    MessageBox.Show(liv.CheckBoxes.ToString());
        }

        private void liv_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void liv_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (liv.SelectedItems.Count > 0)
                MessageBox.Show(liv.CheckBoxes.ToString());

            //if (liv.CheckedItems[0].Checked == false)
            //{
            //    MessageBox.Show("khong chon");
            //}
            if (liv.CheckedItems[0].Checked == true)
            {
                MessageBox.Show("Da chon");
            }
        }
    }
}
