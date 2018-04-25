using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combo_Box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] marka = { "Audi", "Mersedes", "Toyota", "Suzuki" };
            comboBox1.Items.AddRange(marka);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text=="Audi")
            {
                comboBox2.Items.Clear();
                string[] model1 = { "A1", "A2", "A3"};
                comboBox2.Items.AddRange(model1);
            }
            else if (comboBox1.Text == "Mersedes")
            {
                comboBox2.Items.Clear();
                string[] model2 = { "B170", "B180", "B190" };
                comboBox2.Items.AddRange(model2);
            }
            else if (comboBox1.Text == "Toyota")
            {
                comboBox2.Items.Clear();
                string[] model3 = { "Carolla", "Camry", "Prado" };
                comboBox2.Items.AddRange(model3);
            }
            else if (comboBox1.Text == "Suzuki")
            {
                comboBox2.Items.Clear();
                string[] model4 = { "Alto", "Baleno", "Liana" };
                comboBox2.Items.AddRange(model4);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text=="A1")
            {
                comboBox3.Items.Clear();
                string[] version1 = { "1.3", "1.5" };
                comboBox3.Items.AddRange(version1);
            }
            else if (comboBox2.Text == "A2")
            {
                comboBox3.Items.Clear();
                string[] version2 = { "1.5", "1.7","1.9" };
                comboBox3.Items.AddRange(version2);
            }
            else if (comboBox2.Text == "A3")
            {
                comboBox3.Items.Clear();
                string[] version3 = { "1.5", "1.7", "1.9","2.0" };
                comboBox3.Items.AddRange(version3);
            }
            if (comboBox2.Text== "B170")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add(1.4);
            }
            else if (comboBox2.Text == "B180")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add(1.5);
                comboBox3.Items.Add(1.8);
            }
            else if (comboBox2.Text == "B190")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add(1.3);
            }
            if (comboBox2.Text== "Carolla")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add(2.4);
                comboBox3.Items.Add(2.7);
            }
            else if (comboBox2.Text == "Camry")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add(1.6);
            }
            else if (comboBox2.Text == "Prado")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add(1.2);
                comboBox3.Items.Add(1.6);
            }
            if (comboBox2.Text == "Alto")
            {
                comboBox3.Items.Clear();
                string[] version4 = { "2.5", "1.7", "2.9" };
                comboBox3.Items.AddRange(version4);
            }
            else if (comboBox2.Text == "Baleno")
            {
                comboBox3.Items.Clear();
                string[] version5 = { "3.2", "1.9", "2.2" };
                comboBox3.Items.AddRange(version5);
            }
            else if (comboBox2.Text == "Liana")
            {
                comboBox3.Items.Clear();
                string[] version6 = { "2.0", "2.3", "2.4" };
                comboBox3.Items.AddRange(version6);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Marka - " + comboBox1.Text + " | Model - " + comboBox2.Text + " | Versiya - " + comboBox3.Text);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove("Marka - " + comboBox1.Text + " | Model - " + comboBox2.Text + " | Versiya - " + comboBox3.Text);
        }
    }
}
