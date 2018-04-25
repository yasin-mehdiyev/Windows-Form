using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progress_Bar_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum = 11;//11 hisseye boluruk progress barimizi
            textBox1.MaxLength = 11;  //inputa maksimum 11 herf daxil etmek olar 11ci herfde progress bar dolacaqdir
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           progressBar1.Value=textBox1.Text.Length;
            if (textBox1.Text.Length==11)
            {
                MessageBox.Show("Progress-Bar dolmusdur.Herf daxil etmek huququnuz yoxdur");
                textBox1.Text = "";//Dolduqdan sonra resetleyir
            }
        }
    }
}
