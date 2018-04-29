using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioBox_CheckBox_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string card_no="", name_surname="",human="", study="", language="", science="";

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            language = "";
            science = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItems);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            card_no = textBox1.Text;
            name_surname = textBox2.Text;
            if (radioButton1.Checked)
            {
                human = radioButton1.Text;
            }
            else
            {
                human = radioButton2.Text;
            }
            if (radioButton3.Checked)
            {
                study = radioButton1.Text;
            }
            else if (radioButton4.Checked)
            {
                study = radioButton2.Text;
            }
            if (checkBox1.Checked)
            {
                language = language + "," + checkBox1.Text;
            }
            if (checkBox2.Checked)
            {
                language = language + "," + checkBox2.Text;
            }
            if (checkBox3.Checked)
            {
                language = language + "," + checkBox3.Text;
            }
            if (checkBox4.Checked)
            {
                language = language + "," + checkBox4.Text;
            }
            if (checkBox5.Checked)
            {
                language = language + "," + checkBox5.Text;
            }
            if (checkBox6.Checked)
            {
                language = language + "," + checkBox6.Text;
            }

            language = language.Substring(1);

            if (checkBox7.Checked)
            {
                science = science + "," + checkBox7.Text;
            }
            if (checkBox8.Checked)
            {
                science = science + "," + checkBox8.Text;
            }
            if (checkBox9.Checked)
            {
                science = science + "," + checkBox9.Text;
            }
            if (checkBox10.Checked)
            {
                science = science + "," + checkBox10.Text;
            }
            if (checkBox11.Checked)
            {
                science = science + "," + checkBox11.Text;
            }
            if (checkBox12.Checked)
            {
                science = science + "," + checkBox12.Text;
            }
            science = science.Substring(1);

            listBox1.Items.Add("Card No : " + card_no + " | " + "Ad-Soyad : " + name_surname + " | " + " Cinsiyyetiniz : " + human + " | " + "Bildiyi Diller : " + language + " | " + "Sahesi : " + science);

        }
    }
}
