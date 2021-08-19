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
    public partial class RandevuEkle : Form
    {
        VeriTabaniBaglanti baglanti = new VeriTabaniBaglanti();
        RandevuKayıt randevuAl = new RandevuKayıt();

        public static string SetValueForTc = Randevu1.SetValueForTC;
        public static string SetValueForBrans = Randevu1.SetValueForBrans;
        public static string SetValueForDoktor = Randevu1.SetValueForDoktor;
        public static string SetValueForHour = Randevu1.SetValueForHour;
        public static int SetValueForHourInt = Randevu1.SetValueForHourInt;

        
        public RandevuEkle()
        {
            InitializeComponent();
            
            labelOnay.Text = Randevu1.SetValueForBrans.ToUpper() + " BÖLÜMÜNDEN " + Randevu1.SetValueForDoktor.ToUpper() + " DOKTORUNDAN ";
            labelOnay2.Text = "SAAT:" + Randevu1.SetValueForHour.ToString().ToUpper() + ".00 İÇİN RANDEVU ALMAK ÜZERESİNİZ";
            labelOnay.AutoSize = false;
            labelOnay.TextAlign = ContentAlignment.MiddleCenter;
            labelOnay.Dock = DockStyle.None;
            labelOnay.Left = 10;
            labelOnay.Width = this.Width - 10;

            labelOnay2.AutoSize = false;
            labelOnay2.TextAlign = ContentAlignment.MiddleCenter;
            labelOnay2.Dock = DockStyle.None;
            labelOnay2.Left = 10;
            labelOnay2.Width = this.Width - 10;

        }

        private void pictureBox_Kapat_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void pictureBox_Kapat_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_Kapat.BorderStyle = BorderStyle.None;
        }

        private void buttonRandevu_Click(object sender, EventArgs e)
        {
            int p = SetValueForHourInt;

            baglanti.openConnection();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = ("SELECT * FROM randevu WHERE randevu_saat=@randevu_saat and tc=@tc");
            command.Parameters.AddWithValue("@randevu_saat", p.ToString());
            command.Parameters.AddWithValue("@tc", SetValueForTc);
            command.Connection = baglanti.GetConnection();
            MySqlDataReader dataReader = command.ExecuteReader();

            switch (p)
            {

                case 9:
                    if (dataReader.HasRows)
                    {
                        MessageBox.Show("BU SAATTE RANDEVU ALAMAZSINIZ", "BU SAATTE RANDEVUNUZ ZATEN VAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Boolean randevu = randevuAl.randevuEkle(SetValueForTc, SetValueForBrans, SetValueForDoktor, SetValueForHour);
                        MessageBox.Show("Randevu Alındı", "Randevu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case 10:
                    if (dataReader.HasRows)
                    {
                        MessageBox.Show("BU SAATTE RANDEVU ALAMAZSINIZ", "BU SAATTE RANDEVUNUZ ZATEN VAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Boolean randevu = randevuAl.randevuEkle(SetValueForTc, SetValueForBrans, SetValueForDoktor, SetValueForHour);
                        MessageBox.Show("Randevu Alındı", "Randevu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case 11:
                    if (dataReader.HasRows)
                    {
                        MessageBox.Show("BU SAATTE RANDEVU ALAMAZSINIZ", "BU SAATTE RANDEVUNUZ ZATEN VAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Boolean randevu = randevuAl.randevuEkle(SetValueForTc, SetValueForBrans, SetValueForDoktor, SetValueForHour);
                        MessageBox.Show("Randevu Alındı", "Randevu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case 12:
                    if (dataReader.HasRows)
                    {
                        MessageBox.Show("BU SAATTE RANDEVU ALAMAZSINIZ", "BU SAATTE RANDEVUNUZ ZATEN VAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Boolean randevu = randevuAl.randevuEkle(SetValueForTc, SetValueForBrans, SetValueForDoktor, SetValueForHour);
                        MessageBox.Show("Randevu Alındı", "Randevu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case 13:
                    if (dataReader.HasRows)
                    {
                        MessageBox.Show("BU SAATTE RANDEVU ALAMAZSINIZ", "BU SAATTE RANDEVUNUZ ZATEN VAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Boolean randevu = randevuAl.randevuEkle(SetValueForTc, SetValueForBrans, SetValueForDoktor, SetValueForHour);
                        MessageBox.Show("Randevu Alındı", "Randevu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case 14:
                    if (dataReader.HasRows)
                    {
                        MessageBox.Show("BU SAATTE RANDEVU ALAMAZSINIZ", "BU SAATTE RANDEVUNUZ ZATEN VAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Boolean randevu = randevuAl.randevuEkle(SetValueForTc, SetValueForBrans, SetValueForDoktor, SetValueForHour);
                        MessageBox.Show("Randevu Alındı", "Randevu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case 15:
                    if (dataReader.HasRows)
                    {
                    MessageBox.Show("BU SAATTE RANDEVU ALAMAZSINIZ", "BU SAATTE RANDEVUNUZ ZATEN VAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Boolean randevu = randevuAl.randevuEkle(SetValueForTc, SetValueForBrans, SetValueForDoktor, SetValueForHour);
                        MessageBox.Show("Randevu Alındı", "Randevu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case 16:
                    if (dataReader.HasRows)
                    {
                        MessageBox.Show("BU SAATTE RANDEVU ALAMAZSINIZ", "BU SAATTE RANDEVUNUZ ZATEN VAR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        Boolean randevu = randevuAl.randevuEkle(SetValueForTc, SetValueForBrans, SetValueForDoktor, SetValueForHour);
                        MessageBox.Show("Randevu Alındı", "Randevu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;

            }
            baglanti.closeConnection();

            this.Close();
        }

        private void pictureBox_Kapat_MouseMove(object sender, MouseEventArgs e)
        {

            pictureBox_Kapat.BorderStyle = BorderStyle.Fixed3D;
        }
    }
}
