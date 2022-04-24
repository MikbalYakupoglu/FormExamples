using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisListesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kitaplistesi_checkbox.CheckOnClick = true;
        }

        private void siparislistesi_button_Click(object sender, EventArgs e)
        {
            foreach (var checkedbook in kitaplistesi_checkbox.CheckedItems)
            {
                for (int i = 0; i < siparislistesi_listbox.Items.Count; i++)
                {
                    if (checkedbook == siparislistesi_listbox.Items[i])
                    {
                        break;
                    }
                    else if (i == siparislistesi_listbox.Items.Count-1)
                    {
                        siparislistesi_listbox.Items.Add(checkedbook);
                    }
                }

            }
        }

        private void son_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void siparislistesi_listbox_DoubleClick(object sender, EventArgs e)
        {
            siparislistesi_listbox.Items.Remove(siparislistesi_listbox.SelectedItem);
        }
    }
}
