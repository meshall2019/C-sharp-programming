using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//the if else are from me :)
        {
            if (textName.Text == "" && textMajor.Text == "" && textGPA.Text == "")
            {
                MessageBox.Show("Please full the Texts");
            }
            else if (textName.Text == "" && textMajor.Text == "")
            {
                MessageBox.Show("Please Enter the Name and the Major");
            }
            else if (textName.Text == "" && textGPA.Text == "")
            {
                MessageBox.Show("Please Enter the Name and the GPA");
            }
            else if (textMajor.Text == "" && textGPA.Text == "")
            {
                MessageBox.Show("Please Enter the Major and the GPA");
            }
            else if (textName.Text == "")
            {
                MessageBox.Show("Please Enter the Name");
            }
            else if (textMajor.Text == "")
            {
                MessageBox.Show("Please Enter the Majer");
            }
            else if (textGPA.Text == "")
            {
                MessageBox.Show("Please Enter the GPA");
            }
            else
            {
                ListViewItem a = new ListViewItem(textName.Text);
                a.SubItems.Add(textMajor.Text);
                a.SubItems.Add(textGPA.Text);
                listView1.Items.Add(a);

      }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            textName.Text = null;
            textMajor.Text = null;
            textGPA.Text = null;
        }

        private void Form1_RightToLeftLayoutChanged(object sender, EventArgs e)
        {

        }

        private void copy_Click(object sender, EventArgs e)
        {


            foreach (ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Add((ListViewItem)item.Clone());
            }

        }
        private void delet_Click(object sender, EventArgs e)
        {
            listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
        }
        
        private void closeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
