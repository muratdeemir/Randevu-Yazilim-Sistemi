using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace RandevuYazılımSistemi
{
    class RandevuKayıt
    {
        VeriTabaniBaglanti baglanti = new VeriTabaniBaglanti();

        public bool randevuEkle(String tc, String brans, String doktor, String saat)
        {
            MySqlCommand command = new MySqlCommand();
            String insertQuery = "INSERT INTO `randevu`(`tc`, `fk_doktor`, `brans`, `randevu_saat`) VALUES (@tc,@fk_doktor,@brans,@randevu_saat)";
            command.CommandText = insertQuery;
            command.Connection = baglanti.GetConnection();

            //@tc,@fk_doktor,@brans,@randevu_saat
            command.Parameters.Add("@tc", MySqlDbType.VarChar).Value = tc;
            command.Parameters.Add("@fk_doktor", MySqlDbType.VarChar).Value = doktor;
            command.Parameters.Add("@brans", MySqlDbType.VarChar).Value = brans;
            command.Parameters.Add("@randevu_saat", MySqlDbType.VarChar).Value = saat;

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
        
        public DataTable getRandevu(String doktor)
        {
            if(doktor==0.ToString())
            {
                MySqlCommand command = new MySqlCommand("SELECT hastalar.ad AS Hasta, `brans` AS Branş,`fk_doktor` AS Doktor, `randevu_saat` AS Saat FROM `randevu` INNER JOIN hastalar ON randevu.tc=hastalar.tc ", baglanti.GetConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();

                adapter.SelectCommand = command;
                adapter.Fill(table);

                return table;
            }
            else
            {
                MySqlCommand command = new MySqlCommand("SELECT hastalar.ad AS Hasta, `brans` AS Branş,`fk_doktor` AS Doktor, `randevu_saat` AS Saat FROM `randevu` INNER JOIN hastalar ON randevu.tc=hastalar.tc WHERE `fk_doktor` like '%" + doktor + "'", baglanti.GetConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();

                adapter.SelectCommand = command;
                adapter.Fill(table);

                return table;
            }
        }
    }
}
