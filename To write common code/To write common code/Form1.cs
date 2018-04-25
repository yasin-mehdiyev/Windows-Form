﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_write_common_code
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double startprice = Convert.ToDouble(textBox2.Text);
                double count = Convert.ToDouble(textBox3.Text);
                double kdv = 0;
                double finallyprice = startprice * count;
                if (radioButton1.Checked==true)
                {
                    kdv = finallyprice * 0.25;
                }
                else if (radioButton2.Checked==true)
                {
                    kdv = finallyprice * 0.18;
                }
                else if (radioButton3.Checked==true)
                {
                    kdv = finallyprice * 0.08;
                }
                finallyprice += kdv;
                if (checkBox1.Checked==true)
                {
                    finallyprice -= finallyprice * 0.1;
                }
                textBox4.Text = Convert.ToString(kdv);
                textBox5.Text = Convert.ToString(finallyprice);
            }
            catch (Exception)
            {
                textBox4.Text = "0";
                textBox5.Text = "0";
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = "0";
            textBox3.Text = "1";
            radioButton1.Checked = true;
            textBox4.Enabled = false;
            textBox5.Enabled = false;

        }
    }
}
