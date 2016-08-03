using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Load1()
        {
            TreeNode root = new TreeNode();
            root.Text = "Root 1";
            root.Nodes.Add(new TreeNode() { Text = "tree 1" });
            root.Nodes[0].Nodes.Add(new TreeNode() { Text = "tree 1.1" } );
            treeView1.Nodes.Add(root);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Load1();
        }
    }
}
