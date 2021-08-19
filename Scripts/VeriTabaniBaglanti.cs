using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace RandevuYazılımSistemi
{
    class VeriTabaniBaglanti
    {
        private MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=randevusistemi");
        /*
         
         private MySqlConnection connection = new MySqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=" +
     System.IO.Path.GetDirectoryName(AppContext.BaseDirectory) +
     "\\database.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");*/

        public MySqlConnection GetConnection() 
        {
            return connection;
        }
    
        // bağlantıyı kurma fonksiyonu
        public void openConnection() 
        {
            if(connection.State == System.Data.ConnectionState.Closed) 
            {
                connection.Open();
            }
        }

        //bağlantıyı kesme fonksiyonu
        public void closeConnection() 
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
