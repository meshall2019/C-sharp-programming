using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Calculater : Form
    {
        public Calculater()
        {
            InitializeComponent();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            String a = textBox1.Text = null;
            String b = textBox2.Text = null;
            String c = textBox3.Text = null;
        }
    }
}
