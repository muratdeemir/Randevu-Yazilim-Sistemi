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
    
    public partial class Form2 : Form
    {   
        
        public static Form2 Current;

        public Form2()
        {
            Current = this;
            InitializeComponent();
            textBoxTC.MaxLength = 11;
            buttonEnter.Hide();
            buttonKayıt1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VeriTabaniBaglanti baglanti = new VeriTabaniBaglanti();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            String query = "SELECT * FROM `resepsiyonist` WHERE `tc`=@tc AND `password`=@pass";

            command.CommandText = query;
            command.Connection = baglanti.GetConnection();

            command.Parameters.Add("@tc", MySqlDbType.VarChar).Value = textBoxTC.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxPassword.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            //zaten kayıtlıysa
            if (table.Rows.Count > 0) 
            {
                //formu açar
                CentralForm central_form = new CentralForm();
                central_form.Show();
                this.Hide();
            }
            else
            {
                if(textBoxTC.Text.Trim().Equals(""))
                {
                    MessageBox.Show("TC Kimlik Numaranızı Giriniz", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(textBoxPassword.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Şifrenizi Giriniz", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("TC Kimlik Numaranız veya Parolanızı Hatalı Girdiniz", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            VeriTabaniBaglanti baglanti = new VeriTabaniBaglanti();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            String query = "SELECT * FROM `resepsiyonist` WHERE `tc`=@tc AND `password`=@pass";

            command.CommandText = query;
            command.Connection = baglanti.GetConnection();

            command.Parameters.Add("@tc", MySqlDbType.VarChar).Value = textBoxTC.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxPassword.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            //zaten kayıtlıysa
            if (table.Rows.Count > 0)
            {
                //formu açar
                CentralForm central_form = new CentralForm();
                central_form.Show();
                this.Hide();
            }
            else
            {
                if (textBoxTC.Text.Trim().Equals(""))
                {
                    MessageBox.Show("TC Kimlik Numaranızı Giriniz", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textBoxPassword.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Şifrenizi Giriniz", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("TC Kimlik Numaranız veya Parolanızı Hatalı Girdiniz", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonEnterHover_MouseMove(object sender, MouseEventArgs e)
        {
            buttonEnter.Show();
            buttonEnterHover.Hide();
        }

        private void buttonEnter_MouseLeave(object sender, EventArgs e)
        {
            buttonEnter.Hide();
            buttonEnterHover.Show();
        }

        private void buttonKayıt0_MouseMove(object sender, MouseEventArgs e)
        {
            buttonKayıt0.Hide();
            buttonKayıt1.Show();
        }

        private void buttonKayıt1_Click(object sender, EventArgs e)
        {
            YoneticiKayit Kayit = new YoneticiKayit();
            Kayit.Show();
            //this.Hide();
        }

        private void buttonKayıt1_MouseLeave(object sender, EventArgs e)
        {
            buttonKayıt0.Show();
            buttonKayıt1.Hide();
        }

        private void textBoxTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
        }
    }
}
