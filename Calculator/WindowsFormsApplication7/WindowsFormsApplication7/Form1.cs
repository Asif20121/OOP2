using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        private string fnum;
        private string snum;
        private string opt;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            string num = textBox1.Text;
            textBox1.Text = num + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string num = textBox1.Text;
            textBox1.Text = num + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string num = textBox1.Text;
            textBox1.Text = num + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            string num = textBox1.Text;
            textBox1.Text = num + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            string num = textBox1.Text;
            textBox1.Text = num + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            string num = textBox1.Text;
            textBox1.Text = num + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            string num = textBox1.Text;
            textBox1.Text = num + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            string num = textBox1.Text;
            textBox1.Text = num + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            string num = textBox1.Text;
            textBox1.Text = num + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            string num = textBox1.Text;
            textBox1.Text = num + "9";
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            textBox2.Text = "/";
            label1.Text = textBox1.Text;
            textBox1.Text = " ";
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            textBox2.Text = "*";
            label1.Text = textBox1.Text;
            textBox1.Text = " ";
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            textBox2.Text = "-";
            label1.Text = textBox1.Text;
            textBox1.Text = " ";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            textBox2.Text = "+";
            label1.Text = textBox1.Text;
            textBox1.Text = " ";
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            fnum = textBox1.Text;
            snum = label1.Text;
            opt = textBox2.Text;

            int a=Convert.ToInt32(fnum);
            int b = Convert.ToInt32(snum);
            int result;
            switch (opt)
            {
                case "+":
                    result = a+b;
                    textBox2.Text = result+" ";
                    label1.Text = "";
                    textBox1.Text = "";
                    break;
                case "-":
                    result = a-b;
                    textBox2.Text = result+"";
                    label1.Text = "";
                    textBox1.Text = "";
                    break;
                case "*":
                    result = a*b;
                    textBox2.Text = result+"";
                    label1.Text = "";
                    textBox1.Text = "";
                    break;
                case "/":
                    result = a/b;
                    textBox2.Text = result+"";
                    label1.Text = "";
                    textBox1.Text = "";
                    break;
                default:
                    MessageBox.Show ("invalid operator");
                    break;
            }
        }
    }
}
