using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progress_Bar_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 25;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 50;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 75;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 100;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            MessageBox.Show("Progress Bar tamamen doldu");
        }
    }
}
