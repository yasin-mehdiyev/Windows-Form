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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double D_benzin95 = 0, D_benzin97 = 0, D_dizel = 0, D_eurodizel = 0, D_lpg = 0;
        double E_benzin95 = 0, E_benzin97 = 0, E_dizel = 0, E_eurodizel = 0, E_lpg = 0;
        double F_benzin95 = 0, F_benzin97 = 0, F_dizel = 0, F_eurodizel = 0, F_lpg = 0;
        double S_benzin95 = 0, S_benzin97 = 0, S_dizel = 0, S_eurodizel = 0, S_lpg = 0;
        string[] depo_məlumatları;
        string[] qiymət_məlumatları;

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Benzin(95)")
            {
                numericUpDown1.Enabled = true;
                numericUpDown2.Enabled = false;
                numericUpDown3.Enabled = false;
                numericUpDown4.Enabled = false;
                numericUpDown5.Enabled = false;
            }
            else if (comboBox1.Text == "Benzin(97)")
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = true;
                numericUpDown3.Enabled = false;
                numericUpDown4.Enabled = false;
                numericUpDown5.Enabled = false;
            }
            else if (comboBox1.Text == "Dizel")
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
                numericUpDown3.Enabled = true;
                numericUpDown4.Enabled = false;
                numericUpDown5.Enabled = false;
            }
            else if (comboBox1.Text == "EuroDizel")
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
                numericUpDown3.Enabled = false;
                numericUpDown4.Enabled = true;
                numericUpDown5.Enabled = false;
            }
            else if (comboBox1.Text == "Lpg")
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
                numericUpDown3.Enabled = false;
                numericUpDown4.Enabled = false;
                numericUpDown5.Enabled = true;
            }
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;
            label25.Text = "0.00";
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.Text = "Yanacaqdoldurma Məntəqəsi";
            progressBar1.Maximum = 1000;
            progressBar2.Maximum = 1000;
            progressBar3.Maximum = 1000;
            progressBar4.Maximum = 1000;
            progressBar5.Maximum = 1000;

            depo_txt_oxu();
            depo_txt_yazdir();
            qiymət_txt_oxu();
            qiymət_txt_yazdır();
            progress_bar_update();
            numeric_up_down_change();

            string[] yanacaq_tipləri = { "Benzin(95)", "Benzin(97)", "Dizel", "Eurodizel", "Lpg" };
            comboBox1.Items.AddRange(yanacaq_tipləri);

            numericUpDown1.Enabled = false;
            numericUpDown2.Enabled = false;
            numericUpDown3.Enabled = false;
            numericUpDown4.Enabled = false;
            numericUpDown5.Enabled = false;

            numericUpDown1.DecimalPlaces = 2;
            numericUpDown2.DecimalPlaces = 2;
            numericUpDown3.DecimalPlaces = 2;
            numericUpDown4.DecimalPlaces = 2;
            numericUpDown5.DecimalPlaces = 2;

            numericUpDown1.Increment = 0.1M;
            numericUpDown2.Increment = 0.1M;
            numericUpDown3.Increment = 0.1M;
            numericUpDown4.Increment = 0.1M;
            numericUpDown5.Increment = 0.1M;

            numericUpDown1.ReadOnly = true;
            numericUpDown2.ReadOnly = true;
            numericUpDown3.ReadOnly = true;
            numericUpDown4.ReadOnly = true;
            numericUpDown5.ReadOnly = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                E_benzin95 = Convert.ToInt16(textBox1.Text);
                if (1000 <= D_benzin95 + E_benzin95 || E_benzin95 <= 0)
                {
                    textBox1.Text = "Yanliş Giriş";
                }
                else
                {
                    depo_məlumatları[0] = Convert.ToString(D_benzin95 + E_benzin95);
                    textBox1.Text = "";
                }

            }
            catch (Exception)
            {
                textBox1.Text = "Yanliş Giriş";
            }
            try
            {
                E_benzin97 = Convert.ToInt16(textBox2.Text);
                if (1000 <= D_benzin97 + E_benzin97 || E_benzin97 <= 0)
                {
                    textBox2.Text = "Yanliş Giriş";
                }
                else
                {
                    depo_məlumatları[1] = Convert.ToString(D_benzin97 + E_benzin97);
                    textBox2.Text = "";
                }

            }
            catch (Exception)
            {
                textBox2.Text = "Yanliş Giriş";
            }
            try
            {
                E_dizel = Convert.ToInt16(textBox3.Text);
                if (1000 <= D_dizel + E_dizel || E_dizel <= 0)
                {
                    textBox3.Text = "Yanliş Giriş";
                }
                else
                {
                    depo_məlumatları[2] = Convert.ToString(D_dizel + E_dizel);
                    textBox3.Text = "";
                }

            }
            catch (Exception)
            {
                textBox3.Text = "Yanliş Giriş";
            }
            try
            {
                E_eurodizel = Convert.ToInt16(textBox3.Text);
                if (1000 <= D_eurodizel + E_eurodizel || E_eurodizel <= 0)
                {
                    textBox4.Text = "Yanliş Giriş";
                }
                else
                {
                    depo_məlumatları[3] = Convert.ToString(D_eurodizel + E_eurodizel);
                    textBox4.Text = "";
                }

            }
            catch (Exception)
            {
                textBox4.Text = "Yanliş Giriş";
            }
            try
            {
                E_lpg = Convert.ToInt16(textBox3.Text);
                if (1000 <= D_lpg + E_lpg || E_lpg <= 0)
                {
                    textBox5.Text = "Yanliş Giriş";
                }
                else
                {
                    depo_məlumatları[4] = Convert.ToString(D_lpg + E_lpg);
                    textBox5.Text = "";
                }

            }
            catch (Exception)
            {
                textBox5.Text = "Yanliş Giriş";
            }

            System.IO.File.WriteAllLines(Application.StartupPath + "\\depo.txt", depo_məlumatları);
            depo_txt_oxu();
            depo_txt_yazdir();
            progress_bar_update();
            numeric_up_down_change();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            S_benzin95 = double.Parse(numericUpDown1.Value.ToString());
            S_benzin97 = double.Parse(numericUpDown2.Value.ToString());
            S_dizel = double.Parse(numericUpDown3.Value.ToString());
            S_eurodizel = double.Parse(numericUpDown4.Value.ToString());
            S_lpg = double.Parse(numericUpDown5.Value.ToString());

            if (numericUpDown1.Enabled == true)
            {
                D_benzin95 -= S_benzin95;
                label25.Text = (F_benzin95 * S_benzin95).ToString();
            }
            else if (numericUpDown2.Enabled == true)
            {
                D_benzin97 -= S_benzin97;
                label25.Text = (F_benzin97 * S_benzin97).ToString();
            }
            else if (numericUpDown3.Enabled == true)
            {
                D_dizel -= S_dizel;
                label25.Text = (F_dizel * S_dizel).ToString();
            }
            else if (numericUpDown4.Enabled == true)
            {
                D_eurodizel -= S_eurodizel;
                label25.Text = (F_eurodizel * S_eurodizel).ToString();
            }
            else if (numericUpDown5.Enabled == true)
            {
                D_lpg -= S_lpg;
                label25.Text = (F_lpg * S_lpg).ToString();
            }

            depo_məlumatları[0] = D_benzin95.ToString();
            depo_məlumatları[1] = D_benzin97.ToString();
            depo_məlumatları[2] = D_dizel.ToString();
            depo_məlumatları[3] = D_eurodizel.ToString();
            depo_məlumatları[4] = D_lpg.ToString();
            System.IO.File.WriteAllLines(Application.StartupPath + "\\depo.txt", depo_məlumatları);
            depo_txt_oxu();
            depo_txt_yazdir();
            progress_bar_update();
            numeric_up_down_change();

            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {      
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                F_benzin95 = F_benzin95 + ((F_benzin95 * (Convert.ToDouble(textBox6.Text))) / 100);
                qiymət_məlumatları[0] = F_benzin95.ToString();
            }
            catch (Exception)
            {
                textBox6.Text = "Yanliş Giriş";
            }
            try
            {
                F_benzin97 = F_benzin97 + ((F_benzin97 * (Convert.ToDouble(textBox7.Text))) / 100);
                qiymət_məlumatları[1] = F_benzin97.ToString();
            }
            catch (Exception)
            {
                textBox7.Text = "Yanliş Giriş";
            }
            try
            {
                F_dizel = F_dizel + ((F_dizel * (Convert.ToDouble(textBox8.Text))) / 100);
                qiymət_məlumatları[2] = F_dizel.ToString();
            }
            catch (Exception)
            {
                textBox8.Text = "Yanliş Giriş";
            }
            try
            {
                F_eurodizel = F_eurodizel + ((F_eurodizel * (Convert.ToDouble(textBox9.Text))) / 100);
                qiymət_məlumatları[3] = F_eurodizel.ToString();
            }
            catch (Exception)
            {
                textBox9.Text = "Yanliş Giriş";
            }
            try
            {
                F_lpg = F_lpg + ((F_lpg * (Convert.ToDouble(textBox10.Text))) / 100);
                qiymət_məlumatları[4] = F_lpg.ToString();
            }
            catch (Exception)
            {
                textBox10.Text = "Yanliş Giriş";
            }
            System.IO.File.WriteAllLines(Application.StartupPath + "\\qiymət.txt", qiymət_məlumatları);
            qiymət_txt_oxu();
            qiymət_txt_yazdır();
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {     
        }
        private void depo_txt_oxu()
        {
            depo_məlumatları = System.IO.File.ReadAllLines(Application.StartupPath + "\\depo.txt");
            D_benzin95 = Convert.ToDouble(depo_məlumatları[0]);
            D_benzin97 = Convert.ToDouble(depo_məlumatları[1]);
            D_dizel = Convert.ToDouble(depo_məlumatları[2]);
            D_eurodizel = Convert.ToDouble(depo_məlumatları[3]);
            D_lpg = Convert.ToDouble(depo_məlumatları[4]);
        }
        private void depo_txt_yazdir()
        {
            label2.Text = D_benzin95.ToString();
            label4.Text = D_benzin97.ToString();
            label6.Text = D_dizel.ToString();
            label8.Text = D_eurodizel.ToString();
            label10.Text = D_lpg.ToString();
        }
        private void qiymət_txt_oxu()
        {
            qiymət_məlumatları = System.IO.File.ReadAllLines(Application.StartupPath + "\\qiymət.txt");
            F_benzin95 = Convert.ToDouble(qiymət_məlumatları[0]);
            F_benzin97 = Convert.ToDouble(qiymət_məlumatları[1]);
            F_dizel = Convert.ToDouble(qiymət_məlumatları[2]);
            F_eurodizel = Convert.ToDouble(qiymət_məlumatları[3]);
            F_lpg = Convert.ToDouble(qiymət_məlumatları[4]);
        }
        private void qiymət_txt_yazdır()
        {
            label19.Text = F_benzin95.ToString("N");
            label17.Text = F_benzin97.ToString("N");
            label15.Text = F_dizel.ToString("N");
            label13.Text = F_eurodizel.ToString("N");
            label11.Text = F_lpg.ToString("N");
        }
        private void progress_bar_update()
        {
            progressBar1.Value = Convert.ToInt16(D_benzin95);
            progressBar2.Value = Convert.ToInt16(D_benzin97);
            progressBar3.Value = Convert.ToInt16(D_dizel);
            progressBar4.Value = Convert.ToInt16(D_eurodizel);
            progressBar5.Value = Convert.ToInt16(D_lpg);
        }
        private void numeric_up_down_change()
        {
            numericUpDown1.Maximum = decimal.Parse(D_benzin95.ToString());
            numericUpDown2.Maximum = decimal.Parse(D_benzin97.ToString());
            numericUpDown3.Maximum = decimal.Parse(D_dizel.ToString());
            numericUpDown4.Maximum = decimal.Parse(D_eurodizel.ToString());
            numericUpDown5.Maximum = decimal.Parse(D_lpg.ToString());
        }
        private void Form1_Load(object sender, EventArgs e)
        {       
        }
    }
}
