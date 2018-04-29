using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29._04._2018
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="" || textBox2.Text=="" || textBox1.Text.Any(char.IsDigit) || textBox2.Text.Any(char.IsLetter))
            {
                label4.Text = "Yanlisliq var";
                label4.ForeColor = Color.Red;
            }
            else
            {
                label4.Text = "";
                dataGridView1.Rows.Add(textBox1.Text, dateTimePicker1.Text, textBox2.Text);
                textBox1.Text = "";
                textBox2.Text = "";
                dateTimePicker1.Value = DateTime.Now;
            }
        }



        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label4.Text = "";
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Rows[i].Cells.Count; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox3.Text))
                        {
                            dataGridView1.Rows[i].Visible = true;
                            break;
                        }
                        else
                        {
                            dataGridView1.Rows[i].Visible = false;
                        }
                    }
                }
            }
        }
    }

