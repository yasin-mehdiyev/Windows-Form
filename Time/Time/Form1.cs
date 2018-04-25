using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int minute = 0;
        int second = 1;
        int msecond = 1;
        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = "0";
            label5.Text = "0";
            label6.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 60000;
            label4.Text = Convert.ToString(minute);
            minute++;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = 1000;
            if (second==60)
            {
                second = 0;
            }
            label5.Text = Convert.ToString(second);
            second++;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Interval = 10;
            if (msecond==100)
            {
                msecond = 0;
            }
            label6.Text = Convert.ToString(msecond);
            msecond++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = "0";
            label5.Text = "0";
            label6.Text = "0";
            minute = 0;
            second = 1;
            msecond = 1;
        }
    }
}
