using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maytinh_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            PTtext.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            PTtext.Text += "1";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            PTtext.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            PTtext.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PTtext.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PTtext.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PTtext.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PTtext.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PTtext.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PTtext.Text += "9";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            PTtext.Text += "%";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PTtext.Text += " / ";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            PTtext.Text += " * ";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            PTtext.Text += " - ";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (PTtext.Text.Split(' ').Length >= 3)
            {
                Tinh(PTtext.Text.Split(' '));
                PTtext.Text = KQtext.Text + " + ";
            }
            else
            {
                PTtext.Text += " + ";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string[] s = PTtext.Text.Split(' ');
            if (s.Length <= 1)
            {
                return;
            }
            Tinh(s);
        }

        private void Tinh(string[] s)
        {
            double num1 = double.Parse(s[0]);
            double num2 = double.Parse(s[2]);
            double kq = 0;
            if (s[1] == "+")
            {
                kq = num1 + num2;
            }
            else if (s[1] == "-")
            {
                kq = num1 - num2;
            }

            KQtext.Text = kq.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            PTtext.Text = "";
            KQtext.Text = "";
        }
    }
}
