using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02._05._2018
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        Form1 frm1 = new Form1();

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text)
            && !string.IsNullOrEmpty(textBox3.Text))
            {
                label5.Text = "";
                dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text);
                MessageBox.Show("Siz Qeydiyyatdan ugurla kecdiniz");
            }
            else
            {
                label5.Text = "Yanlışlıq var";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==textBox4.Text && textBox2.Text==textBox5.Text)
            {
                this.Hide();
                frm1.Show();
            }
            else
            {
                MessageBox.Show("Yanlisliq var");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
        }
    }
}
