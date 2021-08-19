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
    public partial class CentralForm : Form
    {
        Randevu1 randevu1 = new Randevu1();
        Randevu2 randevuListesi = new Randevu2();
        HastaSistemi hastaListesi = new HastaSistemi();
        DoktorSistemi doktorListesi = new DoktorSistemi();
        
        public static CentralForm Current;
        public CentralForm()
        {
            FormConnector randevu1_bind = new FormConnector(this);
            FormConnector randevuListesi_bind = new FormConnector(this);
            FormConnector hastaListesi_bind = new FormConnector(this);
            FormConnector doktorListesi_bind = new FormConnector(this);

            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            randevu1.TopMost = true;
            randevuListesi.TopMost = true;
            hastaListesi.TopMost = true;
            doktorListesi.TopMost = true;

            randevu1.Show();
            randevu1_bind.ConnectForm(randevu1);
            randevuListesi_bind.ConnectForm(randevuListesi);
            hastaListesi_bind.ConnectForm(hastaListesi);
            doktorListesi_bind.ConnectForm(doktorListesi);
            
            //randevu1.Show();
        }

        
        private void CentralForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            randevu1.Close();
            randevuListesi.Close();
            hastaListesi.Close();
            doktorListesi.Close();
            System.Windows.Forms.Application.Exit();
        }

        private void buttonRandevu_Click(object sender, EventArgs e)
        {
            //FormConnector randevu1_bind = new FormConnector(this);

            randevu1.Show();
            randevuListesi.Hide();
            hastaListesi.Hide();
            doktorListesi.Hide();
            //randevu1_bind.ConnectForm(randevu1);

        }

        private void buttonRandevuListesi_Click(object sender, EventArgs e)
        {
            randevuListesi.Show();
            randevu1.Hide();
            hastaListesi.Hide();
            doktorListesi.Hide();
        }

        private void buttonHastaSistemi_MouseClick(object sender, MouseEventArgs e)
        {
            hastaListesi.Show();
            randevu1.Hide();
            randevuListesi.Hide();
            doktorListesi.Hide();
        }

        private void buttonDoktorSistemi_Click(object sender, EventArgs e)
        {
            doktorListesi.Show();
            randevu1.Hide();
            randevuListesi.Hide();
            hastaListesi.Hide();
        }

        private void buttonYeniHasta_Click(object sender, EventArgs e)
        {
            //FormConnector form1_bind = new FormConnector(this);
            Form1 hastaEkle = new Form1();

            hastaEkle.TopMost = true;
            //hastaEkle.Location = randevu1.Location;
            hastaEkle.Show();
        }

        private void buttonYeniDoktor_Click(object sender, EventArgs e)
        {
            Doktor_Kayit doktorKayitForm = new Doktor_Kayit();

            doktorKayitForm.TopMost = true;
            doktorKayitForm.Show();
        }

        private void buttonDoktorKaydet_MouseMove(object sender, MouseEventArgs e)
        {
            buttonDoktorKaydet.Hide();
            buttonDoktorKaydet1.Show();
        }

        private void buttonDoktorKaydet1_MouseLeave(object sender, EventArgs e)
        {
            buttonDoktorKaydet.Show();
            buttonDoktorKaydet1.Hide();
        }

        private void buttonDoktorKaydet1_Click(object sender, EventArgs e)
        {
            Doktor_Kayit doktorKayitForm = new Doktor_Kayit();

            doktorKayitForm.TopMost = true;
            doktorKayitForm.Show();
        }


        private void buttonHastaKaydet1_MouseLeave(object sender, EventArgs e)
        {
            buttonHastaKaydet.Show();
            buttonHastaKaydet1.Hide();
        }

        private void buttonHastaKaydet_MouseMove(object sender, MouseEventArgs e)
        {
            buttonHastaKaydet.Hide();
            buttonHastaKaydet1.Show();
        }

        private void buttonHastaKaydet1_Click(object sender, EventArgs e)
        {
            Form1 hasta_Kaydet = new Form1();

            hasta_Kaydet.TopMost = true;
            hasta_Kaydet.Show();
        }

        private void button_RandevuListesi1_MouseLeave(object sender, EventArgs e)
        {
            button_RandevuListesi.Show();
            button_RandevuListesi1.Hide();
        }

        private void button_RandevuListesi_MouseMove(object sender, MouseEventArgs e)
        {
            button_RandevuListesi.Hide();
            button_RandevuListesi1.Show();
        }

        private void button_RandevuListesi1_Click(object sender, EventArgs e)
        {
            randevuListesi.Show();
            randevu1.Hide();
            hastaListesi.Hide();
            doktorListesi.Hide();
        }

        private void buttonDoktorListesi_MouseMove(object sender, MouseEventArgs e)
        {
            buttonDoktorListesi.Hide();
            buttonDoktorListesi1.Show();
        }

        private void buttonDoktorListesi1_MouseLeave(object sender, EventArgs e)
        {
            buttonDoktorListesi.Show();
            buttonDoktorListesi1.Hide();
        }

        private void buttonDoktorListesi1_Click(object sender, EventArgs e)
        {
            doktorListesi.Show();
            randevu1.Hide();
            randevuListesi.Hide();
            hastaListesi.Hide();
        }

        private void buttonHastaListesi_MouseMove(object sender, MouseEventArgs e)
        {
            buttonHastaListesi.Hide();
            buttonHastaListesi1.Show();
        }

        private void buttonHastaListesi1_MouseLeave(object sender, EventArgs e)
        {
            buttonHastaListesi.Show();
            buttonHastaListesi1.Hide();
        }

        private void buttonHastaListesi1_Click(object sender, EventArgs e)
        {
            hastaListesi.Show();
            randevu1.Hide();
            randevuListesi.Hide();
            doktorListesi.Hide();
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.Hide();
            pictureBox1.Show();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Show();
            pictureBox1.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            randevu1.Show();
            randevuListesi.Hide();
            hastaListesi.Hide();
            doktorListesi.Hide();
        }
    }
}
