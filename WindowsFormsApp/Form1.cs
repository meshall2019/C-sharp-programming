using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            int addf = Int16.Parse(textBox1.Text);
            int adds=Int16.Parse(textBox2.Text);
            double add = addf + adds;

            string a = add.ToString();
            textBox3.Text = a;
        }

        private void Sub_Click(object sender, EventArgs e)
        {

            int subf = Int16.Parse(textBox1.Text);
            int subs = Int16.Parse(textBox2.Text);
            double sub = subf - subs;

            String s = sub.ToString();
            textBox3.Text = s;

        }

        private void Mult_Click(object sender, EventArgs e)
        {

            int multf = Int16.Parse(textBox1.Text);
            int mults = Int16.Parse(textBox2.Text);
            double mult = multf * mults;
            string m = mult.ToString();

            textBox3.Text = m;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            String a = textBox1.Text = null;
            String b = textBox2.Text = null;
            String c = textBox3.Text = null;
        }
    }
}
