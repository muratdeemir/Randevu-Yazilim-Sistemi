using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace RandevuYazılımSistemi
{
    class YoneticiEkle
    {
        VeriTabaniBaglanti baglanti = new VeriTabaniBaglanti();

        public bool Ekle(String tc, String ad, String soyad, String cepTel, String password)
        {
            MySqlCommand command = new MySqlCommand();
            String insertQuery = "INSERT INTO `resepsiyonist`(`ad`, `password`, `soyAd`, `tc`, `telefon`) VALUES (@ad,@pass,@soyAd,@tc,@telefon)";
            command.CommandText = insertQuery;
            command.Connection = baglanti.GetConnection();

            //@tc,@pass,@ad,@soyad,@telefon,
            command.Parameters.Add("@tc", MySqlDbType.VarChar).Value = tc;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;
            command.Parameters.Add("@ad", MySqlDbType.VarChar).Value = ad;
            command.Parameters.Add("@soyAd", MySqlDbType.VarChar).Value = soyad;
            command.Parameters.Add("@telefon", MySqlDbType.VarChar).Value = cepTel;

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
    }
}
