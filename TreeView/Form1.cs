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

        private void AddNodes_Click(object sender, EventArgs e)
        {
            treeView.Nodes.Add("Laptop");
            treeView.Nodes.Add("Smart phones");
            treeView.Nodes.Add("Printers");


        }

        private void AddCildNodes_Click(object sender, EventArgs e)
        {
            treeView.Nodes[0].Nodes.Add("Dell");
            treeView.Nodes[0].Nodes.Add("Toshiba");
            treeView.Nodes[0].Nodes.Add("Acer");

            treeView.Nodes[1].Nodes.Add("iPhone");
            treeView.Nodes[1].Nodes.Add("Samsung");
            treeView.Nodes[1].Nodes.Add("LG");

            treeView.Nodes[2].Nodes.Add("Canon ");
            treeView.Nodes[2].Nodes.Add("Epson");
        }

        private void RemoveNode_Click(object sender, EventArgs e)
        {
            treeView.SelectedNode.Remove();


        }

        private void DeletTree_Click(object sender, EventArgs e)
        {
            treeView.Nodes.Clear();
        }
    }
}
