﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ListView_Chon_Mon_An
{
    public partial class Form2 : Form
    {
        private int user_;
        private List<ListViewItem> list_ListViewItem;
        private List<ListViewItem> list_ListMonChon;
        public Form2(int user)
        {
            InitializeComponent();
            user_ = user;
            list_ListViewItem = new List<ListViewItem>();
            list_ListMonChon = new List<ListViewItem>();
        }

        public void LoadBT()
        {
            if(user_==1)
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnGoiMon.Enabled = true;
                btnTinhTien.Enabled = false;
                btnThoat.Enabled = true;
                btnDangXuat.Enabled = true;
            }
        }

        private void AddColum()
        {
            livdsmon.Columns.Add(new ColumnHeader() { Text = "Tên Món ăn " });
            livdsmon.Columns.Add(new ColumnHeader() { Text = "Giá " });
            livdsmon.Columns.Add(new ColumnHeader() { Text = "Số lượng cọn lại " });


            livMonduocchon.Columns.Add(new ColumnHeader() { Text = "Tên Món ăn " });
            livMonduocchon.Columns.Add(new ColumnHeader() { Text = "Giá " });
            livMonduocchon.Columns.Add(new ColumnHeader() { Text = "Số lượng " });
            livMonduocchon.Columns.Add(new ColumnHeader() { Text = "Tổng tiền" });
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            livdsmon.View = View.Details;
            livMonduocchon.View = View.Details;
            livdsmon.GridLines = true;
            livMonduocchon.GridLines = true;
            livdsmon.FullRowSelect = true;
            livMonduocchon.FullRowSelect = true;
            LoadBT();
            AddColum();
            LoadMonAn();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.FormClosed += F3_FormClosed;
            f3.StartPosition = FormStartPosition.CenterScreen;
            f3.Show();
            this.Hide();
        }

        private void OpenFile()
        {
            list_ListViewItem.Clear();
            ListViewItem item;
            StreamReader read = new StreamReader("a.txt");
            string tenMonAn = null;
            int soLuong = 0;
            float gia = 0;
            string monAn = null;
            while (!read.EndOfStream)
            {
                item = new ListViewItem();
                monAn = read.ReadLine();
                string[] s = monAn.Split(',');
                tenMonAn = s[0];
                soLuong = int.Parse(s[1]);
                gia = float.Parse(s[2]);
                item.Text = tenMonAn;
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = gia.ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = soLuong.ToString() });
                //livdsmon.Items.Add(item);
                list_ListViewItem.Add(item);
            }
            read.Close();
        }

        public void LoadMonAn()
        {
            livdsmon.Items.Clear();
            OpenFile();
            foreach (var temp in list_ListViewItem)
            {
                livdsmon.Items.Add(temp);
            }
        }

        public void LoadMonChon()
        {
            livMonduocchon.Items.Clear();
            foreach(var item in list_ListMonChon)
            {
                ListViewItem it = new ListViewItem();
                it.Text = item.SubItems[0].Text;
                it.SubItems.Add(item.SubItems[1]);
                it.SubItems.Add(item.SubItems[2]);
                it.SubItems.Add(new ListViewItem.ListViewSubItem() { Text =( int.Parse(item.SubItems[1].Text) * float.Parse(item.SubItems[1].Text)).ToString() });
                livMonduocchon.Items.Add(it);
            }
        }

        private void F3_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            LoadMonAn();
            LoadMonChon();
        }

        private void livdsmon_DoubleClick(object sender, EventArgs e)
        {
            if (livdsmon.Items.Count > 0)
            {
                try
                {
                    //MessageBox.Show(livdsmon.SelectedIndices[0].ToString());
                    //MessageBox.Show(livdsmon.SelectedItems[0].SubItems[2].Text.ToString());
                    list_ListMonChon.Add(list_ListViewItem[livdsmon.SelectedIndices[0]]);
                }
                catch { }
            }
            LoadMonChon();
        }
    }
}
