using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandevuYazılımSistemi
{
    public partial class YoneticiKayit : Form
    {
        YoneticiEkle yeniYonetici = new YoneticiEkle();

        public static string SetValueForTC = "";
        public static string SetValueForAd = "";
        public static string SetValueForSoyad = "";
        public static string SetValueForCepTel = "";
        //public static string

        public YoneticiKayit()
        {
            InitializeComponent();
            textBoxTC.MaxLength = 11;
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

        private void textBoxCepTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Hide();
            pictureBox2.Show();
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Show();
            pictureBox2.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (textBoxPass.Text == textBoxPass2.Text)
            {
                if (textBoxPass.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Kayıt Başarısız, şifrenizi giriniz", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(textBoxPass != textBoxPass2)
                {
                    MessageBox.Show("Kayıt Başarısız, şifreniz uyuşmuyor", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Yeni Kullanıcı Başarıyla Eklendi.", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Boolean yoneticiEkle = yeniYonetici.Ekle(textBoxTC.Text, textBoxAd.Text, textBoxSoyad.Text, textBoxCepTel.Text, textBoxPass.Text);
                }
            }
        }
    }
}
