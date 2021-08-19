using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandevuYazılımSistemi
{
    public partial class Randevu1 : Form
    {
        RandevuKayıt randevu = new RandevuKayıt();
        VeriTabaniBaglanti baglanti = new VeriTabaniBaglanti();

        public static string dok;
        public static string hour;
        
        //Randevu2 randevu2 = new Randevu2();

        public static string SetValueForTC = "";
        public static string SetValueForBrans = "";
        public static string SetValueForDoktor = "";
        public static string SetValueForHour = "";
        public static int SetValueForHourInt = 0;
        public static int next;

        public Randevu1()
        {
            InitializeComponent();
            textBox_TC.MaxLength = 11;

            comboBox_Brans_Fill();
            comboBox_Doktor_Fill();       

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(185,85);
            
            FormConnector randevu2_bind = new FormConnector(this);
            
            //randevu2_bind.ConnectForm(randevu2);

            
        }
        

        private void comboBox_Brans_Fill()
        {
            VeriTabaniBaglanti baglanti = new VeriTabaniBaglanti();
            MySqlDataAdapter adapter = new MySqlDataAdapter("Select `id_brans`,`brans_ad` FROM brans", baglanti.GetConnection());
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            comboBox_Brans.DataSource = dt;
            comboBox_Brans.ValueMember = "id_brans";
            comboBox_Brans.DisplayMember = "brans_ad";
            comboBox_Brans.DropDownHeight = 325;
        }
        private void comboBox_Doktor_Fill()
        {
            int val;
            Int32.TryParse(comboBox_Brans.SelectedValue.ToString(), out val);

            VeriTabaniBaglanti baglanti = new VeriTabaniBaglanti();
            MySqlDataAdapter adapter = new MySqlDataAdapter("Select `fk_brans`,`doktor_ad` FROM doktor WHERE `fk_brans` ="+val, baglanti.GetConnection());
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            comboBox_Doktor.DataSource = dt;
            comboBox_Doktor.ValueMember = "fk_brans";
            comboBox_Doktor.DisplayMember = "doktor_ad";
        }

        private void comboBox_Brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(comboBox_Brans.SelectedValue.ToString(), out val);
            
            VeriTabaniBaglanti baglanti = new VeriTabaniBaglanti();
            MySqlDataAdapter adapter = new MySqlDataAdapter("Select `fk_brans`,`doktor_ad` FROM doktor WHERE `fk_brans` =" + val, baglanti.GetConnection());
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            comboBox_Doktor.DataSource = dt;
            comboBox_Doktor.ValueMember = "fk_brans";
            comboBox_Doktor.DisplayMember = "doktor_ad";
        }
        private void comboBox_Doktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int p;

            for( p = 9; p < 17; p++)
            {
                baglanti.openConnection();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = ("SELECT * FROM randevu WHERE randevu_saat=@randevu_saat and fk_doktor=@fk_doktor");
                command.Parameters.AddWithValue("@randevu_saat", p);
                command.Parameters.AddWithValue("@fk_doktor", comboBox_Doktor.Text);
                command.Connection = baglanti.GetConnection();
                MySqlDataReader dataReader = command.ExecuteReader();
                
                switch(p)
                {

                    case 9:
                        if (dataReader.HasRows)
                        {
                            pictureBox9.Visible = false;
                            pictureBox9_D.Visible = true;
                        }
                        else
                        {
                            pictureBox9.Visible = true;
                            pictureBox9_D.Visible = false;
                        }
                        break;
                    case 10:
                        if (dataReader.HasRows)
                        {
                            pictureBox10.Visible = false;
                            pictureBox10_D.Visible = true;
                        }
                        else
                        {
                            pictureBox10.Visible = true;
                            pictureBox10_D.Visible = false;
                        }
                        break;
                    case 11:
                        if (dataReader.HasRows)
                        {
                            pictureBox11.Visible = false;
                            pictureBox11_D.Visible = true;
                        }
                        else
                        {
                            pictureBox11.Visible = true;
                            pictureBox11_D.Visible = false;
                        }
                        break;
                    case 12:
                        if (dataReader.HasRows)
                        {
                            pictureBox12.Visible = false;
                            pictureBox12_D.Visible = true;
                        }
                        else
                        {
                            pictureBox12.Visible = true;
                            pictureBox12_D.Visible = false;
                        }
                        break;
                    case 13:
                        if (dataReader.HasRows)
                        {
                            pictureBox13.Visible = false;
                            pictureBox13_D.Visible = true;
                        }
                        else
                        {
                            pictureBox13.Visible = true;
                            pictureBox13_D.Visible = false;
                        }
                        break;
                    case 14:
                        if (dataReader.HasRows)
                        {
                            pictureBox14.Visible = false;
                            pictureBox14_D.Visible = true;
                        }
                        else
                        {
                            pictureBox14.Visible = true;
                            pictureBox14_D.Visible = false;
                        }
                        break;
                    case 15:
                        if (dataReader.HasRows)
                        {
                            pictureBox15.Visible = false;
                            pictureBox15_D.Visible = true;
                        }
                        else
                        {
                            pictureBox15.Visible = true;
                            pictureBox15_D.Visible = false;
                        }
                        break;
                    case 16:
                        if (dataReader.HasRows)
                        {
                            pictureBox16.Visible = false;
                            pictureBox16_D.Visible = true;
                        }
                        else
                        {
                            pictureBox16.Visible = true;
                            pictureBox16_D.Visible = false;
                        }
                        break;

                }
                baglanti.closeConnection();

            }
        }


        //@@@@@@@@@@@ SAAT SEÇİMİ

        private void pictureBox9_MouseClick(object sender, MouseEventArgs e)
        {          
            pictureBox10.BorderStyle = BorderStyle.None;
            pictureBox11.BorderStyle = BorderStyle.None;
            pictureBox12.BorderStyle = BorderStyle.None;
            pictureBox13.BorderStyle = BorderStyle.None;
            pictureBox14.BorderStyle = BorderStyle.None;
            pictureBox15.BorderStyle = BorderStyle.None;
            pictureBox16.BorderStyle = BorderStyle.None;

            pictureBox9.BorderStyle = BorderStyle.Fixed3D;
            SetValueForTC = textBox_TC.Text;
            SetValueForBrans = comboBox_Brans.Text;
            SetValueForDoktor = comboBox_Doktor.Text;
            SetValueForHour = "09:00";
            SetValueForHourInt = 9;
        }

        private void pictureBox10_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox9.BorderStyle = BorderStyle.None;
            pictureBox11.BorderStyle = BorderStyle.None;
            pictureBox12.BorderStyle = BorderStyle.None;
            pictureBox13.BorderStyle = BorderStyle.None;
            pictureBox14.BorderStyle = BorderStyle.None;
            pictureBox15.BorderStyle = BorderStyle.None;
            pictureBox16.BorderStyle = BorderStyle.None;

            pictureBox10.BorderStyle = BorderStyle.Fixed3D;
            SetValueForTC = textBox_TC.Text;
            SetValueForBrans = comboBox_Brans.Text;
            SetValueForDoktor = comboBox_Doktor.Text;
            SetValueForHour = "10:00";
            SetValueForHourInt = 10;
        }

        private void pictureBox11_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox9.BorderStyle = BorderStyle.None;
            pictureBox10.BorderStyle = BorderStyle.None;
            pictureBox12.BorderStyle = BorderStyle.None;
            pictureBox13.BorderStyle = BorderStyle.None;
            pictureBox14.BorderStyle = BorderStyle.None;
            pictureBox15.BorderStyle = BorderStyle.None;
            pictureBox16.BorderStyle = BorderStyle.None;

            pictureBox11.BorderStyle = BorderStyle.Fixed3D;
            SetValueForTC = textBox_TC.Text;
            SetValueForBrans = comboBox_Brans.Text;
            SetValueForDoktor = comboBox_Doktor.Text;
            SetValueForHour = "11:00";
            SetValueForHourInt = 11;
        }

        private void pictureBox12_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox9.BorderStyle = BorderStyle.None;
            pictureBox10.BorderStyle = BorderStyle.None;
            pictureBox11.BorderStyle = BorderStyle.None;
            pictureBox13.BorderStyle = BorderStyle.None;
            pictureBox14.BorderStyle = BorderStyle.None;
            pictureBox15.BorderStyle = BorderStyle.None;
            pictureBox16.BorderStyle = BorderStyle.None;

            pictureBox12.BorderStyle = BorderStyle.Fixed3D;
            SetValueForTC = textBox_TC.Text;
            SetValueForBrans = comboBox_Brans.Text;
            SetValueForDoktor = comboBox_Doktor.Text;
            SetValueForHour = "12:00";
            SetValueForHourInt = 12;
        }

        private void pictureBox13_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox9.BorderStyle = BorderStyle.None;
            pictureBox10.BorderStyle = BorderStyle.None;
            pictureBox11.BorderStyle = BorderStyle.None;
            pictureBox12.BorderStyle = BorderStyle.None;
            pictureBox14.BorderStyle = BorderStyle.None;
            pictureBox15.BorderStyle = BorderStyle.None;
            pictureBox16.BorderStyle = BorderStyle.None;

            pictureBox13.BorderStyle = BorderStyle.Fixed3D;
            SetValueForTC = textBox_TC.Text;
            SetValueForBrans = comboBox_Brans.Text;
            SetValueForDoktor = comboBox_Doktor.Text;
            SetValueForHour = "13:00";
            SetValueForHourInt = 13;
        }

        private void pictureBox14_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox9.BorderStyle = BorderStyle.None;
            pictureBox10.BorderStyle = BorderStyle.None;
            pictureBox11.BorderStyle = BorderStyle.None;
            pictureBox12.BorderStyle = BorderStyle.None;
            pictureBox13.BorderStyle = BorderStyle.None;
            pictureBox15.BorderStyle = BorderStyle.None;
            pictureBox16.BorderStyle = BorderStyle.None;

            pictureBox14.BorderStyle = BorderStyle.Fixed3D;
            SetValueForTC = textBox_TC.Text;
            SetValueForBrans = comboBox_Brans.Text;
            SetValueForDoktor = comboBox_Doktor.Text;
            SetValueForHour = "14:00";
            SetValueForHourInt = 14;
        }

        private void pictureBox15_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox9.BorderStyle = BorderStyle.None;
            pictureBox10.BorderStyle = BorderStyle.None;
            pictureBox11.BorderStyle = BorderStyle.None;
            pictureBox12.BorderStyle = BorderStyle.None;
            pictureBox13.BorderStyle = BorderStyle.None;
            pictureBox14.BorderStyle = BorderStyle.None;
            pictureBox16.BorderStyle = BorderStyle.None;

            pictureBox15.BorderStyle = BorderStyle.Fixed3D;
            SetValueForTC = textBox_TC.Text;
            SetValueForBrans = comboBox_Brans.Text;
            SetValueForDoktor = comboBox_Doktor.Text;
            SetValueForHour = "15:00";
            SetValueForHourInt = 15;
        }

        private void pictureBox16_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox9.BorderStyle = BorderStyle.None;
            pictureBox10.BorderStyle = BorderStyle.None;
            pictureBox11.BorderStyle = BorderStyle.None;
            pictureBox12.BorderStyle = BorderStyle.None;
            pictureBox13.BorderStyle = BorderStyle.None;
            pictureBox14.BorderStyle = BorderStyle.None;
            pictureBox15.BorderStyle = BorderStyle.None;

            pictureBox16.BorderStyle = BorderStyle.Fixed3D;
            SetValueForTC = textBox_TC.Text;
            SetValueForBrans = comboBox_Brans.Text;
            SetValueForDoktor = comboBox_Doktor.Text;
            SetValueForHour = "16:00";
            SetValueForHourInt = 16;
        }

        private void textBox_TC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
        }

        private void textBox_TC_TextChanged(object sender, EventArgs e)
        {
            VeriTabaniBaglanti baglanti = new VeriTabaniBaglanti();
            Object returnValue;

            MySqlCommand command = new MySqlCommand();
            //String query = "SELECT * FROM `hastalar` WHERE `tc`=@tc";

            command.CommandText = "SELECT * FROM `hastalar` WHERE `tc`=@tc";
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@tc", textBox_TC.Text);
            command.Connection = baglanti.GetConnection();


            baglanti.openConnection();

            returnValue = command.ExecuteScalar();
            baglanti.closeConnection();

            if (Convert.ToInt64(returnValue) > 0)
            {
                pictureBoxTick.Visible = true;
                pictureBoxCross.Visible = false;
                next = 1;
            }
            else
            {
                pictureBoxCross.Visible = true;
                pictureBoxTick.Visible = false;
                next = 0;
            }
            baglanti.closeConnection();
        }

        private void buttonIleri_MouseMove(object sender, MouseEventArgs e)
        {
            buttonIleri.Hide();
            buttonIleri2.Show();
        }

        private void buttonIleri2_MouseLeave(object sender, EventArgs e)
        {
            buttonIleri.Show();
            buttonIleri2.Hide();
        }

        private void buttonIleri2_Click(object sender, EventArgs e)
        {
            if (next == 1 && SetValueForHourInt > 1)
            {
                RandevuEkle randevu = new RandevuEkle();
                randevu.TopMost = true;
                randevu.ShowDialog();
                SetValueForHour = 0.ToString();

                textBox_TC.Clear();
                pictureBox9.BorderStyle = BorderStyle.None;
                pictureBox10.BorderStyle = BorderStyle.None;
                pictureBox11.BorderStyle = BorderStyle.None;
                pictureBox12.BorderStyle = BorderStyle.None;
                pictureBox13.BorderStyle = BorderStyle.None;
                pictureBox14.BorderStyle = BorderStyle.None;
                pictureBox15.BorderStyle = BorderStyle.None;
                pictureBox16.BorderStyle = BorderStyle.None;
            }
            else
            {
                MessageBox.Show("Eksik Bilgi", "Randevu İstenemedi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //@@@@@@@@@
    }
}
