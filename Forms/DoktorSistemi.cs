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
    public partial class DoktorSistemi : Form
    {
        Randevu1 randevu1 = new Randevu1();
        DoktorKayıt doktor = new DoktorKayıt();

        VeriTabaniBaglanti baglanti = new VeriTabaniBaglanti();

        public DoktorSistemi()
        {
            InitializeComponent();
            comboBox_Brans_Fill();

            comboBox_Brans.SelectedIndex = -1;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = randevu1.Location;

            dataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkGray;
            dataGridView.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.DarkGray;
            dataGridView.DataSource = doktor.getDoktor(0.ToString());
            dataGridView.AutoResizeColumns();

            //this.StartPosition = FormStartPosition.Manual;
            //this.Location = new Point(500, 100);
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

        private void comboBox_Brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView.DataSource = doktor.getDoktor(comboBox_Brans.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonYenile_MouseMove(object sender, MouseEventArgs e)
        {
            buttonYenile.Hide();
            buttonYenile1.Show();
        }

        private void buttonYenile1_MouseLeave(object sender, EventArgs e)
        {
            buttonYenile.Show();
            buttonYenile1.Hide();
        }

        private void buttonYenile1_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = doktor.getDoktor(0.ToString());
            comboBox_Brans.SelectedIndex = -1;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Show();
            pictureBox2.Hide();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            pictureBox2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView.CurrentCell.RowIndex;
            string doktorAd = dataGridView.CurrentRow.Cells[0].Value.ToString();
            string brans = dataGridView.CurrentRow.Cells[1].Value.ToString();

            baglanti.openConnection();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = ("DELETE FROM doktor WHERE doktor_ad= '" + doktorAd + "'");
            command.Connection = baglanti.GetConnection();
            command.ExecuteNonQuery();

            dataGridView.Rows.RemoveAt(rowIndex);
            baglanti.closeConnection();
        }
    }
}
