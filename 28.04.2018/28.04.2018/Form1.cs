using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28._04._2018
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

        private void label2_Click(object sender, EventArgs e)
        {         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

            if (textBox1.Text.Any(char.IsLower))
            {
                label3.ForeColor = Color.Silver;
            }
            else
            {
                label3.ForeColor = Color.Black;
            }

            if (textBox1.Text.Any(char.IsUpper))
            {
                label4.ForeColor = Color.Silver;
            }
            else
            {
                label4.ForeColor = Color.Black;
            }


            if (textBox1.Text.Any(char.IsNumber))
            {
                label5.ForeColor = Color.Silver;
            }
            else
            {
                label5.ForeColor = Color.Black;
            }


            if (textBox1.Text.Any(char.IsPunctuation))
            {
                label6.ForeColor = Color.Silver;
            }
            else
            {
                label6.ForeColor = Color.Black;
            }


            if (textBox1.Text.Length >= 8)
            {
                label7.ForeColor = Color.Silver;
            }
            else
            {
                label7.ForeColor = Color.Black;
            }
            if (label3.ForeColor == Color.Silver && label4.ForeColor == Color.Silver && label5.ForeColor == Color.Silver && label6.ForeColor == Color.Silver && label7.ForeColor == Color.Silver)
            {
                button1.Visible = true;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                button1.Text = "Siz butun variantlari doldurmusunuz";
            }
            else
            {
                button1.Visible = false;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            if (label2.Text == "Show")
            {
                label2.Text = "Hide";
                textBox1.UseSystemPasswordChar = true;
            }
            else
            {
                label2.Text = "Show";
                textBox1.UseSystemPasswordChar = false;
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            button1.Visible = false;
        }
    }
}
