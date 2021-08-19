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
    public partial class HastaSistemi : Form
    {
        Randevu1 randevu1 = new Randevu1();
        HastaKayit hasta = new HastaKayit();

        VeriTabaniBaglanti baglanti = new VeriTabaniBaglanti();

        public HastaSistemi()
        {
            InitializeComponent();
            textBoxTC.MaxLength = 11;

            this.StartPosition = FormStartPosition.Manual;
            this.Location = randevu1.Location;

            dataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkGray;
            dataGridView.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.DarkGray;
            dataGridView.DataSource = hasta.getHasta((-1).ToString());
            dataGridView.AutoResizeColumns();

            //this.StartPosition = FormStartPosition.Manual;
            //this.Location = new Point(500, 100);
        }

        private void textBoxTC_TextChanged(object sender, EventArgs e)
        {
            dataGridView.DataSource = hasta.getHasta(textBoxTC.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = hasta.getHasta((-1).ToString());
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
            dataGridView.DataSource = hasta.getHasta((-1).ToString());
            textBoxTC.Text = "";
        }

        private void textBoxTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
        }

        private void buttonHastaSil0_MouseMove(object sender, MouseEventArgs e)
        {
            buttonHastaSil0.Hide();
            buttonHastaSil1.Show();
        }

        private void buttonHastaSil1_MouseLeave(object sender, EventArgs e)
        {
            buttonHastaSil0.Show();
            buttonHastaSil1.Hide();
        }

        private void buttonHastaSil1_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView.CurrentCell.RowIndex;
            string tc = dataGridView.CurrentRow.Cells[0].Value.ToString();

            baglanti.openConnection();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = ("DELETE FROM hastalar WHERE tc= '" + tc + "'");
            command.Connection = baglanti.GetConnection();
            command.ExecuteNonQuery();

            dataGridView.Rows.RemoveAt(rowIndex);
            baglanti.closeConnection();
        }
    }
}
