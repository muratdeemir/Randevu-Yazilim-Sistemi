using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace RandevuYazılımSistemi
{

    class DoktorKayıt
    {
        VeriTabaniBaglanti baglanti = new VeriTabaniBaglanti();

        public bool doktorEkle(String tc, String ad, String cinsiyet, String dogumYeri, String dogumYili, String anneAdi, String babaAdi, String cepTelefonu, String sabitTelefon, String eposta, String brans, String unvan)
        {
            MySqlCommand command = new MySqlCommand();
            String insertQuery = "INSERT INTO `doktor`(`tc`, `doktor_ad`, `fk_brans`, `fk_unvan`, `baba_Adi`, `anne_Adi`, `cinsiyet`, `dogumTarihi`, `dogumYeri`, `cepTelefonu`, `email`) VALUES (@tc,@ad,@brans,@unvan,@babaadi,@anneadi,@cinsiyet,@d_tarihi,@d_yeri,@cep_tel,@e_posta)";
            command.CommandText = insertQuery;
            command.Connection = baglanti.GetConnection();

            //@tc,@ad,@brans,@unvan,@babaadi,@anneadi,@cinsiyet,@d_tarihi,@d_yeri,@cep_tel,@e_posta
            command.Parameters.Add("@tc", MySqlDbType.VarChar).Value = tc;
            command.Parameters.Add("@ad", MySqlDbType.VarChar).Value = ad;
            command.Parameters.Add("@brans", MySqlDbType.VarChar).Value = brans;
            command.Parameters.Add("@unvan", MySqlDbType.VarChar).Value = unvan;
            command.Parameters.Add("@babaadi", MySqlDbType.VarChar).Value = babaAdi;
            command.Parameters.Add("@anneadi", MySqlDbType.VarChar).Value = anneAdi;
            command.Parameters.Add("@cinsiyet", MySqlDbType.VarChar).Value = cinsiyet;
            command.Parameters.Add("@d_tarihi", MySqlDbType.VarChar).Value = dogumYili;
            command.Parameters.Add("@d_yeri", MySqlDbType.VarChar).Value = dogumYeri;
            command.Parameters.Add("@cep_tel", MySqlDbType.VarChar).Value = cepTelefonu;
            command.Parameters.Add("@sabit_tel", MySqlDbType.VarChar).Value = sabitTelefon;
            command.Parameters.Add("@e_posta", MySqlDbType.VarChar).Value = eposta;

            baglanti.openConnection();

            if (command.ExecuteNonQuery() == 1)
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

        
        public DataTable getDoktor(String brans)
        {
            if(brans==0.ToString())
            {
                MySqlCommand command = new MySqlCommand("SELECT `doktor_ad` AS Doktor, brans_ad AS Branş FROM doktor INNER JOIN brans ON doktor.fk_brans=brans.id_brans", baglanti.GetConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();

                adapter.SelectCommand = command;
                adapter.Fill(table);

                return table;
            }
            else
            {
                MySqlCommand command = new MySqlCommand("SELECT `doktor_ad` AS Doktor, brans_ad AS Branş FROM doktor INNER JOIN brans ON doktor.fk_brans=brans.id_brans WHERE `brans_ad` like '%" + brans + "'", baglanti.GetConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();

                adapter.SelectCommand = command;
                adapter.Fill(table);

                return table;
            }
        }
    }
}
