using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.cinsiyet_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            cinsiyet_combobox.SelectedIndex = 0;
        }


        private void hesapla_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(boy_textbox.Text))
            {
                MessageBox.Show("Boy Boş Bırakılamaz !");
            }
            else if (string.IsNullOrWhiteSpace(dogumyili_textbox.Text))
            {
                MessageBox.Show("Doğum Yılı Boş Bırakılamaz !");
            }
            else if (string.IsNullOrWhiteSpace(kilo_textbox.Text))
            {
                MessageBox.Show("Kilo Boş Bırakılamaz !");
            }
            else
            {
                float k = 0;
                if (cinsiyet_combobox.SelectedIndex == 0)
                {
                    k = 0.9f;
                }
                else if (cinsiyet_combobox.SelectedIndex == 1)
                {
                    k = 0.8f;
                }

                int boy = int.Parse(boy_textbox.Text);
                int yas = (DateTime.Now.Year - int.Parse(dogumyili_textbox.Text));
                int kilo = int.Parse(kilo_textbox.Text);

                int idealkilo = (int)((boy - 100 + yas / 10) * k);

                idealkilo_textbox.Text = idealkilo.ToString();

                if (kilo > idealkilo)
                {
                    bilgi_label.Text = "İdeal Kilodan Daha Fazla Kilonuz Var. Zayıflamalısınız.";
                }
                else if (kilo < idealkilo)
                {
                    bilgi_label.Text = "İdeal Kilodan Daha Az Kilonuz Var. Kilo Almalısınız.";
                }
                else
                {
                    bilgi_label.Text = "Bravo! İdeal Kilodasınız.";
                }
            }

        }

        private void son_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
