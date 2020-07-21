using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate
{
    public partial class Form1 : Form
    {
        bool sum_buttun;
        bool sub_buttun;
        bool mult_buttun;
        bool div_buttun;
        public Form1()
        {
            InitializeComponent();
        }
        public void sum_Click (object sender, EventArgs e)
        {
            sum_buttun = true;
        }
        public void button2_Click(object sender, EventArgs e)
        {
            sub_buttun = true;
        }

        public void button3_Click(object sender, EventArgs e)
        {
            mult_buttun = true;
        }

        public void div_Click(object sender, EventArgs e)
        {
            div_buttun = true;
        }
        public void Result_but_Click(object sender, EventArgs e)
        {

            if (sum_buttun == true)
            {
                Double Num1 = Convert.ToDouble(FirstNum.Text);
                Double Num2 = Convert.ToDouble(SecondNum.Text);

                double Result_sum = Num1 + Num2;

                Result.Text = Result_sum.ToString();
                sum_buttun = false;
            }
            else if (sub_buttun == true)
            {

                Double Num1 = Convert.ToDouble(FirstNum.Text);
                Double Num2 = Convert.ToDouble(SecondNum.Text);

                double Result_sub = Num1 - Num2;

                Result.Text = Result_sub.ToString();

                sub_buttun = false;
            }
            else if (mult_buttun == true)
            {

                Double Num1 = Convert.ToDouble(FirstNum.Text);
                Double Num2 = Convert.ToDouble(SecondNum.Text);

                double Result_mult = Num1 * Num2;
                Result.Text = Result_mult.ToString();

                mult_buttun = false;
            }

            else if (div_buttun = true)
            {
                Double Num1 = Convert.ToDouble(FirstNum.Text);
                Double Num2 = Convert.ToDouble(SecondNum.Text);

                double Result_div = Num1 / Num2;
                Result.Text = Result_div.ToString();

                div_buttun = false;

            }

        }
       
        private void Remove_Click(object sender, EventArgs e)
        {
            FirstNum.Text = null;
            SecondNum.Text = null;
            Result.Text = null;
        }
    }
}


