using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace RandevuYazılımSistemi
{
    class HastaKayit
    {
        VeriTabaniBaglanti baglanti = new VeriTabaniBaglanti();

        public bool hastaEkle(String tc, String ad, String soyad, String cinsiyet, String dogumYeri, String dogumYili, String anneAdi, String babaAdi, String cepTelefonu, String sabitTelefon, String eposta)
        {
            MySqlCommand command = new MySqlCommand();
            String insertQuery = "INSERT INTO `hastalar`(`tc`, `ad`, `soyad`, `cinsiyet`, `dogum_yeri`, `dogum_yili`, `anne_adi`, `baba_adi`, `cep_telefonu`, `sabit_telefon`, `e_posta`) VALUES (@tc,@ad,@soyad,@cinsiyet,@d_yeri,@d_yili,@anneadi,@babaadi,@cep_tel,@sabit_tel,@e_posta)";
            command.CommandText = insertQuery;
            command.Connection = baglanti.GetConnection();

            //@tc,@pass,@ad,@soyad,@cinsiyet,@d_yeri,@d_yili,@anneadi,@babaadi,@cep_tel,@sabit_tel,@e_posta
            command.Parameters.Add("@tc", MySqlDbType.VarChar).Value = tc;
            command.Parameters.Add("@ad", MySqlDbType.VarChar).Value = ad;
            command.Parameters.Add("@soyad", MySqlDbType.VarChar).Value = soyad;
            command.Parameters.Add("@cinsiyet", MySqlDbType.VarChar).Value = cinsiyet;
            command.Parameters.Add("@d_yeri", MySqlDbType.VarChar).Value = dogumYeri;
            command.Parameters.Add("@d_yili", MySqlDbType.VarChar).Value = dogumYili;
            command.Parameters.Add("@anneadi", MySqlDbType.VarChar).Value = anneAdi;
            command.Parameters.Add("@babaadi", MySqlDbType.VarChar).Value = babaAdi;
            command.Parameters.Add("@cep_tel", MySqlDbType.VarChar).Value = cepTelefonu;
            command.Parameters.Add("@sabit_tel", MySqlDbType.VarChar).Value = sabitTelefon;
            command.Parameters.Add("@e_posta", MySqlDbType.VarChar).Value = eposta;

            baglanti.openConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                baglanti.closeConnection();

                return true;
            }
            else
            {
                baglanti.closeConnection();

                return false;
            }

        }
        // hasta listesi 
        public DataTable getHasta(String hasta)
        {
            if(hasta==(-1).ToString())
            {
                MySqlCommand command = new MySqlCommand("SELECT `tc` AS Tc, CONCAT (`ad`, ' ', `soyad`) AS İsim, `cinsiyet` AS Cinsiyet, `dogum_yeri` AS 'Doğduğu Yeri', `dogum_yili` AS YIL, `anne_adi` AS 'Anne Adı', `baba_adi` AS 'Baba Adı', `cep_telefonu` AS 'Cep Telefonu', `e_posta` AS 'E-Posta' FROM `hastalar` ", baglanti.GetConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();

                adapter.SelectCommand = command;
                adapter.Fill(table);

                return table;
            }
            else
            {
                MySqlCommand command = new MySqlCommand("SELECT `tc` AS Tc, CONCAT (`ad`, ' ', `soyad`) AS İsim, `cinsiyet` AS Cinsiyet, `dogum_yeri` AS 'Doğduğu Yeri', `dogum_yili` AS YIL, `anne_adi` AS 'Anne Adı', `baba_adi` AS 'Baba Adı', `cep_telefonu` AS 'Cep Telefonu', `e_posta` AS 'E-Posta' FROM `hastalar` WHERE `tc` like '" + hasta + "%'", baglanti.GetConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();

                adapter.SelectCommand = command;
                adapter.Fill(table);

                return table;
            }
        }
            
    }
}
