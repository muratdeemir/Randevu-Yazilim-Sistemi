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
    public partial class Form3 : Form
    {
        HastaKayit kayit = new HastaKayit();

        public static Form3 Current;

        public static string SetValueForTC = Form1.SetValueForTC;
        public static string SetValueForAd = Form1.SetValueForAd;
        public static string SetValueForSoyad = Form1.SetValueForSoyad;
        public static string SetValueForCinsiyet = Form1.SetValueForCinsiyet;
        public static string SetValueForDogumYeri = Form1.SetValueForDogumYeri;
        public static string SetValueForDogumYili = Form1.SetValueForDogumYili;
        public static string SetValueForAnneAdi = Form1.SetValueForAnneAdi;
        public static string SetValueForBabaAdi = Form1.SetValueForBabaAdi;

        public Form3()
        {
            Current = this;

            InitializeComponent();
        }

        

        private void textBoxCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
        }

        private void textBoxSabit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
        }

        private void buttonKayıt0_MouseMove(object sender, MouseEventArgs e)
        {
            buttonKayıt0.Hide();
            buttonKayıt1.Show();
        }

        private void buttonKayıt1_MouseLeave(object sender, EventArgs e)
        {
            buttonKayıt0.Show();
            buttonKayıt1.Hide();
        }

        private void buttonKayıt1_Click(object sender, EventArgs e)
        {
            String cep = textBoxCep.Text;
            String sabit = textBoxSabit.Text;
            String eposta = textBoxEmail.Text;
            String epostaT = textBoxEmailTekrar.Text;




            if (eposta == epostaT)
            {
                MessageBox.Show("Hasta Kaydı Başarıyla Eklendi.", "Kayit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Boolean hastaEkle = kayit.hastaEkle(SetValueForTC, SetValueForAd, SetValueForSoyad, SetValueForCinsiyet, SetValueForDogumYeri, SetValueForDogumYili, SetValueForAnneAdi, SetValueForBabaAdi, cep, sabit, eposta);
            }
            else
            {
                MessageBox.Show("Hasta Kaydi Başarısız, emailiniz eşleşmiyor", "Kayit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGeri0_MouseMove(object sender, MouseEventArgs e)
        {
            buttonGeri0.Hide();
            buttonGeri1.Show();
        }

        private void buttonGeri1_MouseLeave(object sender, EventArgs e)
        {
            buttonGeri0.Show();
            buttonGeri1.Hide();
        }

        private void buttonGeri1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            //Form1 first_form = new Form1();
            //first_form.Show();

            this.Hide();

            Form1.Current.Show();
        }
    }
}
