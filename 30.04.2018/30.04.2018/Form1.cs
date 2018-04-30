using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30._04._2018
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double first_result, second_result, third_result, average;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            if (textBox1.Text!="" && textBox2.Text!="" && textBox3.Text!="" && textBox4.Text!="")
            {
                if (textBox1.Text.Any(char.IsLetter))
                {
                    frm2.label2.Text = textBox1.Text;
                }
                else
                {
                    label5.Text = "Login Sistemini duzgun sekilde doldurun";
                }
                if (textBox2.Text.Any(char.IsDigit) && textBox3.Text.Any(char.IsDigit) && textBox4.Text.Any(char.IsDigit))
                {
                    first_result = Convert.ToDouble(textBox2.Text);
                    second_result = Convert.ToDouble(textBox3.Text);
                    third_result = Convert.ToDouble(textBox4.Text);
                    average = ((first_result + second_result + third_result) / 3);
                    frm2.label4.Text = average.ToString();
                    if (average >= 0 && average <= 100)
                    {
                        if (average <= 50)
                        {
                            frm2.label6.Text = "Imtahandan Kesildiniz";
                        }
                        else if (average > 50 && average <= 60)
                        {
                            frm2.label6.Text = "Ortalamaniz QenaetBexsdir";
                        }
                        else if (average > 60 && average <= 70)
                        {
                            frm2.label6.Text = "Ortalamaniz Kafidir";
                        }
                        else if (average > 70 && average <= 80)
                        {
                            frm2.label6.Text = "Ortalamaniz Yaxsidir";
                        }
                        else if (average > 80 && average <= 90)
                        {
                            frm2.label6.Text = "Ortalamaniz Cox Yaxsidir";
                        }
                        else
                        {
                            frm2.label6.Text = "Ortalamaniz Eladir";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Duzgun sekilde imtahan ballarinizi daxil edin");
                    }

                    this.Hide();
                    frm2.Show();
                    
                }
                else
                {
                    label5.Text = "Login Sistemini duzgun sekilde doldurun";
                }
                
            }
            else
            {
                label5.Text = "Login Sistemini bos qoymayin";
            }
           

        }
    }
}
