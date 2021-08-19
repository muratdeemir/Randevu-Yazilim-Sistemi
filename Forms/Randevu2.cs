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
    public partial class Randevu2 : Form
    {
        Randevu1 randevu1 = new Randevu1();
        RandevuKayıt randevu = new RandevuKayıt();
        
        VeriTabaniBaglanti baglanti = new VeriTabaniBaglanti();

        public Randevu2()
        {
            InitializeComponent();
            comboBox_Doktor_Fill();

            comboBox_Doktor.SelectedIndex = -1;

            this.StartPosition = FormStartPosition.Manual;
            this.Location = randevu1.Location;

            dataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkGray;
            dataGridView.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.DarkGray;
            dataGridView.DataSource = randevu.getRandevu(0.ToString());
            dataGridView.AutoResizeColumns();

            //this.StartPosition = FormStartPosition.Manual;
            //this.Location = new Point(500, 100);
        }

        private void comboBox_Doktor_Fill()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("Select `fk_brans`,`doktor_ad` FROM doktor", baglanti.GetConnection());
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            comboBox_Doktor.DataSource = dt;
            comboBox_Doktor.ValueMember = "fk_brans";
            comboBox_Doktor.DisplayMember = "doktor_ad";
            foreach (DataGridViewColumn col in dataGridView.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void comboBox_Doktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView.DataSource = randevu.getRandevu(comboBox_Doktor.Text);
            foreach (DataGridViewColumn col in dataGridView.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
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
            dataGridView.DataSource = randevu.getRandevu(0.ToString());
            comboBox_Doktor.SelectedIndex = -1;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Hide();
            pictureBox1.Show();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.Show();
            pictureBox1.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView.CurrentCell.RowIndex;
            string bransAd = dataGridView.CurrentRow.Cells[1].Value.ToString();
            string saat = dataGridView.CurrentRow.Cells[3].Value.ToString();

            baglanti.openConnection();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = ("DELETE FROM randevu WHERE ( brans= '" + bransAd + "' && randevu_saat = '" + saat + "' )");
            command.Connection = baglanti.GetConnection();
            command.ExecuteNonQuery();

            dataGridView.Rows.RemoveAt(rowIndex);
            baglanti.closeConnection();
        }
    }
}
