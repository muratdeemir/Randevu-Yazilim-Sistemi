using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RandevuYazılımSistemi
{
    public partial class Form1 : Form
    {
        public static Form1 Current;

        public static string SetValueForTC = "";
        public static string SetValueForAd = "";
        public static string SetValueForSoyad = "";
        public static string SetValueForCinsiyet = "";
        public static string SetValueForDogumYeri = "";
        public static string SetValueForDogumYili = "";
        public static string SetValueForAnneAdi = "";
        public static string SetValueForBabaAdi = "";

        public Form1()
        {
            Current = this;
            
            InitializeComponent();
            textBoxTC.MaxLength = 11;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void textBoxTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
        }

        private void textBoxAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar);
        }

        private void textBoxSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar);
        }

        private void textBoxAnaAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar);
        }

        private void textBoxBabaAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Hide();
            pictureBox1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SetValueForTC = textBoxTC.Text;
            SetValueForAd = textBoxAd.Text;
            SetValueForSoyad = textBoxSoyad.Text;
            SetValueForCinsiyet = comboBoxCinsiyet.Text;
            SetValueForDogumYeri = comboBoxDogumYeri.Text;
            SetValueForDogumYili = dateTimePickerYil.Text;
            SetValueForAnneAdi = textBoxAnaAdi.Text;
            SetValueForBabaAdi = textBoxBabaAdi.Text;

            if (SetValueForTC.Trim().Equals("") || SetValueForAd.Trim().Equals("") || SetValueForSoyad.Trim().Equals("") || SetValueForCinsiyet.Trim().Equals("") || SetValueForDogumYeri.Trim().Equals("") || SetValueForDogumYili.Trim().Equals("") || SetValueForAnneAdi.Trim().Equals("") || SetValueForBabaAdi.Trim().Equals(""))
            {
                MessageBox.Show("Boş Alan Bırakmayınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                Form3 second_form = new Form3();
                second_form.TopMost = true;
                second_form.Show();
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.Show();
            pictureBox1.Hide();
        }
    }
}
