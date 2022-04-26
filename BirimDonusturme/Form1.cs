using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirimDonusturme
{
    public partial class Form1 : Form
    {
        private const string metre = "metre";
        private const string inch = "inch";
        private const string foot = "foot";
        private const string yard = "yard";
        private const string karamili = "kara mili";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.uzunluk1_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.uzunluk2_combobox.DropDownStyle = ComboBoxStyle.DropDownList;

            uzunluk1_combobox.SelectedIndex = 0;
            uzunluk2_combobox.SelectedIndex = 0;


            this.guc1_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.guc2_combobox.DropDownStyle = ComboBoxStyle.DropDownList;

            guc1_combobox.SelectedIndex = 0;
            guc2_combobox.SelectedIndex = 0;


            this.basinc1_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.basinc2_combobox.DropDownStyle = ComboBoxStyle.DropDownList;

            basinc1_combobox.SelectedIndex = 0;
            basinc2_combobox.SelectedIndex = 0;
        }

        private bool IsContainsLetter(string text)
        {
            foreach (var karakter in text)
            {
                if (char.IsLetter(karakter))
                {
                    return true;
                }
            }
            return false;

        }

        private void uzunluguhesapla()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = 0.ToString();
            }
            else
            {
                double ilkuzunlugunmetrekarsiligi = 0;

                if (IsContainsLetter(textBox1.Text))
                {
                    MessageBox.Show("Çevirmek İçin Sayı Değer Giriniz.");
                }
                else
                {
                    double ilksayi = double.Parse(textBox1.Text);

                    if (uzunluk1_combobox.SelectedItem == metre)
                    {
                        ilkuzunlugunmetrekarsiligi = ilksayi * 1;
                    }
                    else if (uzunluk1_combobox.SelectedItem == inch)
                    {
                        ilkuzunlugunmetrekarsiligi = ilksayi * 0.0254;
                    }
                    else if (uzunluk1_combobox.SelectedItem == foot)
                    {
                        ilkuzunlugunmetrekarsiligi = ilksayi * 0.3048;
                    }
                    else if (uzunluk1_combobox.SelectedItem == yard)
                    {
                        ilkuzunlugunmetrekarsiligi = ilksayi * 0.9144;
                    }
                    else if (uzunluk1_combobox.SelectedItem == karamili)
                    {
                        ilkuzunlugunmetrekarsiligi = ilksayi * 1609.3472187;
                    }

                    double sonuc = 0;

                    if (uzunluk2_combobox.SelectedItem == metre)
                    {
                        sonuc = ilkuzunlugunmetrekarsiligi * 1;
                        textBox2.Text = sonuc.ToString();
                    }
                    else if (uzunluk2_combobox.SelectedItem == inch)
                    {
                        sonuc = ilkuzunlugunmetrekarsiligi * 39.37007874;
                        textBox2.Text = sonuc.ToString();
                    }
                    else if (uzunluk2_combobox.SelectedItem == foot)
                    {
                        sonuc = ilkuzunlugunmetrekarsiligi * 3.280839895;
                        textBox2.Text = sonuc.ToString();
                    }
                    else if (uzunluk2_combobox.SelectedItem == yard)
                    {
                        sonuc = ilkuzunlugunmetrekarsiligi * 1.0936132983;
                        textBox2.Text = sonuc.ToString();
                    }
                    else if (uzunluk2_combobox.SelectedItem == karamili)
                    {
                        sonuc = ilkuzunlugunmetrekarsiligi * 0.0006213699;
                        textBox2.Text = sonuc.ToString();
                    }


                    if (sonuc - (int)(sonuc + 0.001) < 0.00005)
                    {
                        int yenisonuc = (int)(sonuc + 0.001);

                        textBox2.Text = yenisonuc.ToString();
                    }
                }

               
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uzunluk1_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = uzunluk1_combobox.SelectedItem.ToString();

            uzunluguhesapla();
        }

        private void uzunluk2_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = uzunluk2_combobox.SelectedItem.ToString();
            
            uzunluguhesapla();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            uzunluguhesapla();
        }




        private const string kgf = "kgf. m/s";
        private const string kw = "Kw";
        private const string kcal = "Kcal/s";
        private const string PS = "PS";


        private void guchesapla()
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                textBox4.Text = 0.ToString();
            }
            else
            {
                double ilkgucunkgfkarsiligi = 0;

                if (IsContainsLetter(textBox4.Text))
                {
                    MessageBox.Show("Çevirmek İçin Sayı Değer Giriniz.");
                }
                else
                {
                    double ilksayi = double.Parse(textBox4.Text);

                    if (guc1_combobox.SelectedItem == kgf)
                    {
                        ilkgucunkgfkarsiligi = ilksayi * 1;
                    }
                    else if (guc1_combobox.SelectedItem == kw)
                    {
                        ilkgucunkgfkarsiligi = ilksayi * 102.0408;
                    }
                    else if (guc1_combobox.SelectedItem == kcal)
                    {
                        ilkgucunkgfkarsiligi = ilksayi * 427.3504;
                    }
                    else if (guc1_combobox.SelectedItem == PS)
                    {
                        ilkgucunkgfkarsiligi = ilksayi * 75.18796;
                    }

                    double sonuc = 0;

                    if (guc2_combobox.SelectedItem == kgf)
                    {
                        sonuc = ilkgucunkgfkarsiligi * 1;
                        textBox3.Text = sonuc.ToString();
                    }
                    else if (guc2_combobox.SelectedItem == kw)
                    {
                        sonuc = ilkgucunkgfkarsiligi * 0.0098;
                        textBox3.Text = sonuc.ToString();
                    }
                    else if (guc2_combobox.SelectedItem == kcal)
                    {
                        sonuc = ilkgucunkgfkarsiligi * 0.00234;
                        textBox3.Text = sonuc.ToString();
                    }
                    else if (guc2_combobox.SelectedItem == PS)
                    {
                        sonuc = ilkgucunkgfkarsiligi * 0.0133;
                        textBox3.Text = sonuc.ToString();
                    }


                    if (sonuc - (int)(sonuc + 0.001) < 0.00005)
                    {
                        int yenisonuc = (int)(sonuc + 0.001);

                        textBox3.Text = yenisonuc.ToString();
                    }
                }
               
            }
        }

        private void guc1_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Text = guc1_combobox.Text;

            guchesapla();
        }

        private void guc2_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = guc2_combobox.Text;

            guchesapla();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            guchesapla();
        }




        private const string atm = "atm";
        private const string psi = "psi";
        private const string bar = "bar";


        private void basinchesapla()
        {
            if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                textBox6.Text = 0.ToString();
            }
            else
            {
                double ilkbasincinatmkarsiligi = 0;

                if (IsContainsLetter(textBox6.Text))
                {
                    MessageBox.Show("Çevirmek İçin Sayı Değer Giriniz.");
                }

                else
                {
                    double ilksayi = double.Parse(textBox6.Text);


                    if (basinc1_combobox.SelectedItem == atm)
                    {
                        ilkbasincinatmkarsiligi = ilksayi * 1;
                    }
                    else if (basinc1_combobox.SelectedItem == psi)
                    {
                        ilkbasincinatmkarsiligi = ilksayi * 0.06825;
                    }
                    else if (basinc1_combobox.SelectedItem == bar)
                    {
                        ilkbasincinatmkarsiligi = ilksayi * 0.99;
                    }

                    double sonuc = 0;

                    if (basinc2_combobox.SelectedItem == atm)
                    {
                        sonuc = ilkbasincinatmkarsiligi * 1;
                        textBox5.Text = sonuc.ToString();
                    }
                    else if (basinc2_combobox.SelectedItem == psi)
                    {
                        sonuc = ilkbasincinatmkarsiligi * 14.65;
                        textBox5.Text = sonuc.ToString();
                    }
                    else if (basinc2_combobox.SelectedItem == bar)
                    {
                        sonuc = ilkbasincinatmkarsiligi * 1.01;
                        textBox5.Text = sonuc.ToString();
                    }


                    if (sonuc - (int)(sonuc + 0.001) < 0.00005)
                    {
                        int yenisonuc = (int)(sonuc + 0.001);

                        textBox5.Text = yenisonuc.ToString();
                    }
                }
                
            }
        }

        private void basinc1_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            label6.Text = basinc1_combobox.Text;

            basinchesapla();
        }

        private void basinc2_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            label5.Text = basinc2_combobox.Text;

            basinchesapla();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            basinchesapla();
        }
    }
}
