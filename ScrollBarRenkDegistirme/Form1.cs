using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrollBarRenkDegistirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label7.BackColor = Color.Red;
            label8.BackColor = Color.Green;
            label9.BackColor = Color.Blue;

            label10.BackColor = Color.Green;
            label11.BackColor = Color.Red;
            label12.BackColor = Color.Blue;

            hScrollBar1.Value = 0;
            hScrollBar2.Value = 0;
            hScrollBar3.Value = 0;

            vScrollBar1.Value = 0;
            vScrollBar2.Value = 0;
            vScrollBar3.Value = 0;

            label1.Text = 0.ToString();
            label2.Text = 0.ToString();
            label3.Text = 0.ToString();
            label4.Text = 0.ToString();
            label5.Text = 0.ToString();
            label6.Text = 0.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label1.Text = hScrollBar1.Value.ToString();
            textBox1.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            label2.Text = hScrollBar2.Value.ToString();
            textBox1.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            label3.Text = hScrollBar3.Value.ToString();
            textBox1.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
        }


        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label4.Text = vScrollBar1.Value.ToString();
            textBox1.ForeColor = Color.FromArgb(vScrollBar1.Value, vScrollBar2.Value, vScrollBar3.Value);
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            label5.Text = vScrollBar2.Value.ToString();
            textBox1.ForeColor = Color.FromArgb(vScrollBar1.Value, vScrollBar2.Value, vScrollBar3.Value);
        }

        private void vScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            label6.Text = vScrollBar3.Value.ToString();
            textBox1.ForeColor = Color.FromArgb(vScrollBar1.Value, vScrollBar2.Value, vScrollBar3.Value);
        }
    }
}
