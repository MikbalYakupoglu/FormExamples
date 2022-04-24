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

namespace ResmiTatilGunleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private const string yilbasi = "Yılbaşı";
        private const string egemenlik = "Ulusal Egemenlik ve Çocuk Bayramı";
        private const string emek = "Emek ve Dayanışma Günü";
        private const string ramazan = "Ramazan Bayramı";
        private const string genclik = "Atatürk'ü Anma, Gençlik ve Spor Bayramı";
        private const string kurban = "Kurban Bayramı";
        private const string demokrasi = "Demokrasi Bayramı";
        private const string zafer = "Zafer Bayramı";
        private const string cumhuriyet = "Cumhuriyet Bayramı";

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == yilbasi)
            {
                monthCalendar1.SelectionStart = new DateTime(2022, 01, 01);
                monthCalendar1.SelectionEnd = new DateTime(2022, 01, 01);
            }
            else if (comboBox1.SelectedItem == egemenlik)
            {
                monthCalendar1.SelectionStart = new DateTime(2022, 04, 23);
                monthCalendar1.SelectionEnd = new DateTime(2022, 04, 23);
            }
            else if (comboBox1.SelectedItem == emek)
            {
                monthCalendar1.SelectionStart = new DateTime(2022, 05, 01);
                monthCalendar1.SelectionEnd = new DateTime(2022, 05, 01);
            }
            else if (comboBox1.SelectedItem == ramazan)
            {
                monthCalendar1.SelectionStart = new DateTime(2022, 05, 02);
                monthCalendar1.SelectionEnd = new DateTime(2022, 05, 04);
            }
            else if (comboBox1.SelectedItem == genclik)
            {
                monthCalendar1.SelectionStart = new DateTime(2022, 05, 19);
                monthCalendar1.SelectionEnd = new DateTime(2022, 05, 19);
            }
            else if (comboBox1.SelectedItem == kurban)
            {
                monthCalendar1.SelectionStart = new DateTime(2022, 07, 09);
                monthCalendar1.SelectionEnd = new DateTime(2022, 07, 12);
            }
            else if (comboBox1.SelectedItem == demokrasi)
            {
                monthCalendar1.SelectionStart = new DateTime(2022, 07, 15);
                monthCalendar1.SelectionEnd = new DateTime(2022, 07, 15);
            }
            else if (comboBox1.SelectedItem == zafer)
            {
                monthCalendar1.SelectionStart = new DateTime(2022, 08, 30);
                monthCalendar1.SelectionEnd = new DateTime(2022, 08, 30);
            }
            else if (comboBox1.SelectedItem == cumhuriyet)
            {
                monthCalendar1.SelectionStart = new DateTime(2022, 10, 29);
                monthCalendar1.SelectionEnd = new DateTime(2022, 10, 29);
            }
        }

        private string TarihleriYazdir()
        {
            return monthCalendar1.SelectionRange.Start.Day + "." +
                   monthCalendar1.SelectionRange.Start.Month + "." +
                   monthCalendar1.SelectionRange.Start.Year +
                   " - " +
                   monthCalendar1.SelectionRange.End.Day + "." +
                   monthCalendar1.SelectionRange.End.Month + "." +
                   monthCalendar1.SelectionRange.End.Year +
                   "  " + comboBox1.Text;
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains(TarihleriYazdir()))
            {

            }
            else
            {
              listBox1.Items.Add(TarihleriYazdir());
            }

        }

        private void cikar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
