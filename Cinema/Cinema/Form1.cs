using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Button> sendbtn = new List<Button>();
        private void all_btn_click(object sender,EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackColor == Color.White)
            {
                btn.BackColor = Color.FromArgb(0, 172, 236);
                btn.FlatAppearance.BorderColor = Color.FromArgb(0, 172, 236);
                btn.ForeColor = Color.White;
                sendbtn.Add(btn);

            }
            else if (btn.BackColor == Color.FromArgb(0, 172, 236)) 
            {
                btn.BackColor = Color.White;
                btn.FlatAppearance.BorderColor = Color.White;
                btn.ForeColor = Color.White;
                sendbtn.Remove(btn);
            }
            else
            {
                DialogResult r = MessageBox.Show("Əminsiniz mi?", "Bilet Qaytarma", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    btn.BackColor = Color.White;
                    btn.FlatAppearance.BorderColor = Color.White;
                    btn.ForeColor = Color.Black;
                }
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            foreach (Button btn in sendbtn)
            {
                btn.BackColor = Color.Black;
                btn.FlatAppearance.BorderColor = Color.Black;
                btn.ForeColor = Color.LightGray;
            }
            sendbtn.Clear();
        }
    }
}
