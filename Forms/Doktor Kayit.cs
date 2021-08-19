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
    public partial class Doktor_Kayit : Form
    {
        DoktorKayıt kayit = new DoktorKayıt();

        public static string SetValueForTC = "";
        public static string SetValueForAd = "";
        public static string SetValueForCinsiyet = "";
        public static string SetValueForDogumYeri = "";
        public static string SetValueForDogumYili = "";
        public static string SetValueForAnneAdi = "";
        public static string SetValueForBabaAdi = "";

        VeriTabaniBaglanti baglanti = new VeriTabaniBaglanti();

        public Doktor_Kayit()
        {
            InitializeComponent();
            comboBox_Brans_Fill();
            comboBox_Unvan_Fill();
            groupBox2.Hide();
            groupBox3.Hide();
        }

        private void buttonGeri_Click(object sender, EventArgs e)
        {
            
        }

        private string findBrans(String brans)
        {
            string[] test = new string[39];
            test[1] = "ALGOLOJİ";
            test[2] = "BESLENME VE DİYET";
            test[3] = "BEYİN VE SİNİR CERRAHİSİ";
            test[4] = "ÇOCUK ALERJİSİ";
            test[5] = "ÇOCUK CERRAHİSİ";
            test[6] = "ÇOCUK ENDOKRİNOLOJİSİ";
            test[7] = "	ÇOCUK ENFEKSİYON";
            test[8] = "ÇOCUK GÖĞÜS HASTALIKLARI";
            test[9] = "ÇOCUK HEMATOLOJİSİ";
            test[10] = "ÇOCUK KARDİYOLOJİSİ";
            test[11] = "ÇOCUK METABOLİZMA";
            test[12] = "ÇOCUK NEFROLOJİSİ";
            test[13] = "ÇOCUK NÖROLOJİSİ";
            test[14] = "ÇOCUK PSİKİYATRİSİ";
            test[15] = "ÇOCUK SAĞLIĞI VE HASTALIKLARI";
            test[16] = "ÇOCUK ÜROLOJİSİ";
            test[17] = "DERMATOLOJİ (CİLDİYE)";
            test[18] = "ENDOKRİNOLOJİ VE METABOLİZMA";
            test[19] = "ENFEKSİYON HASTALIKLARI";
            test[20] = "FİZİKSEL TIP VE REHABİLİTASYON";
            test[21] = "GASTROENTEROLOJİ";
            test[22] = "GELENEKSEL VE TAMAMLAYICI TIP(GETAMER)";
            test[23] = "GENEL CERRAHİ";
            test[24] = "GERİATRİ";
            test[25] = "GÖĞÜS CERRAHİSİ";
            test[26] = "GÖĞÜS HASTALIKLARI";
            test[27] = "GÖZ HASTALIKLARI";
            test[28] = "HEMATOLOJİ";
            test[29] = "İÇ HASTALIKLARI";
            test[30] = "KADIN HASTALIKLARI VE DOĞUM";
            test[31] = "KALP VE DAMAR CERRAHİSİ";
            test[32] = "KARDİYOLOJİ";
            test[33] = "KEMİK YOĞUNLUĞU ÖLÇÜMÜ";
            test[34] = "KULAK-BURUN-BOĞAZ HASTALIKLARI";
            test[35] = "NEFROLOJİ";
            test[36] = "NÖROLOJİ";
            test[37] = "ORTOPEDİ VE TRAVMATOLOJİ";
            test[38] = "PLASTİK REKONSTRÜKTİF VE ESTETİK CERRAHİ";

            //MessageBox.Show(test[1], "Kayit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            for (int i = 1; i<38; i++)
            {
                if(test[i] == brans)
                {
                    brans =i.ToString();
                }
            }
            return brans;
            //MessageBox.Show(brans, "Kayit", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBox_Brans_Fill()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("Select `id_brans`,`brans_ad` FROM brans", baglanti.GetConnection());
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            comboBox_Brans.DataSource = dt;
            comboBox_Brans.ValueMember = "id_brans";
            comboBox_Brans.DisplayMember = "brans_ad";
            comboBox_Brans.DropDownHeight = 325;
        }

        private void comboBox_Unvan_Fill()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("Select `id_unvan`,`unvan_ad` FROM unvan", baglanti.GetConnection());
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            comboBox_Unvan.DataSource = dt;
            comboBox_Unvan.ValueMember = "id_unvan";
            comboBox_Unvan.DisplayMember = "unvan_ad";
            comboBox_Unvan.DropDownHeight = 325;
        }

        private void textBoxTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
        }

        private void textBoxCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
        }

        private void textBoxSabit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
        }

        private void textBoxAd_KeyPress(object sender, KeyPressEventArgs e)
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
            pictureBox1.Show();
            pictureBox2.Hide();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Hide();
            pictureBox2.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SetValueForTC = textBoxTC.Text;
            SetValueForAd = textBoxAd.Text;
            SetValueForCinsiyet = comboBoxCinsiyet.Text;
            SetValueForDogumYeri = comboBoxDogumYeri.Text;
            SetValueForDogumYili = dateTimePickerYil.Text;
            SetValueForAnneAdi = textBoxAnaAdi.Text;
            SetValueForBabaAdi = textBoxBabaAdi.Text;

            if (SetValueForTC.Trim().Equals("") || SetValueForAd.Trim().Equals("") || SetValueForCinsiyet.Trim().Equals("") || SetValueForDogumYeri.Trim().Equals("") || SetValueForDogumYili.Trim().Equals("") || SetValueForAnneAdi.Trim().Equals("") || SetValueForBabaAdi.Trim().Equals(""))
            {
                MessageBox.Show("Boş Alan Bırakmayınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                groupBox1.Hide();
                groupBox2.Show();
                groupBox3.Show();
            }
        }

        private void buttonGeri1_MouseLeave(object sender, EventArgs e)
        {
            buttonGeri0.Show();
            buttonGeri1.Hide();
        }

        private void buttonGeri0_MouseMove(object sender, MouseEventArgs e)
        {
            buttonGeri0.Hide();
            buttonGeri1.Show();
        }

        private void buttonGeri1_Click(object sender, EventArgs e)
        {
            groupBox3.Hide();
            groupBox2.Hide();
            groupBox1.Show();
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
            String brans = comboBox_Brans.Text;
            String unvan = comboBox_Unvan.Text;
            brans = findBrans(brans);
            //MessageBox.Show(brans, "Kayit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (eposta == epostaT && !comboBox_Unvan.Text.Trim().Equals("") && !comboBox_Brans.Text.Trim().Equals(""))
            {
                MessageBox.Show("Doktor Kaydı Başarıyla Eklendi.", "Kayit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Boolean hastaEkle = kayit.doktorEkle(SetValueForTC, SetValueForAd, SetValueForCinsiyet, SetValueForDogumYeri, SetValueForDogumYili, SetValueForAnneAdi, SetValueForBabaAdi, cep, sabit, eposta, brans, unvan);
            }
            else
            {
                MessageBox.Show("Hasta Kaydi Başarısız, emailiniz eşleşmiyor", "Kayit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
