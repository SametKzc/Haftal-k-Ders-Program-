using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Haftalık_Ders_Programı
{
    public partial class Derslikler : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=haftalık_ders_programı;Uid=root;Pwd='';");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        

        void VeriYenile()
        {
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("SELECT *FROM derslikler", conn);
            adapter.Fill(dt);
            dgwderslik.DataSource = dt;
            conn.Close();
            dgwderslik.RowHeadersVisible = false;
        }
        public Derslikler()
        {
            InitializeComponent();
        }

        private void btn_Derslikler_geri_Click(object sender, EventArgs e)
        {
            Form1 anasayfa = new Form1();
            anasayfa.Show();
            this.Close();
        }
         int arama()
        {
            MySqlCommand cmd2 = new MySqlCommand("SELECT * FROM derslikler WHERE derslik_kodu = '" + txtderslikkod.Text + "'",conn);
            conn.Open();
            MySqlDataReader rd = cmd2.ExecuteReader();
            if (rd.HasRows)
            {
                conn.Close();
                rd.Close();
                return 1;  
            }
            else
            {
                conn.Close();
                rd.Close();
                return 0;
            }
        }
        private void btnEkleOgretimElemani_Click(object sender, EventArgs e)
        {
            //string sql = "INSERT INTO derslikler(derslik_kodu,derslik_türü,derslik_kontenjanı)" + "VALUES(@DerslikKod,@derslikturu,@kontenjan)";
            //cmd = new MySqlCommand(sql, conn);
            //cmd.Parameters.AddWithValue("@DerslikKod", txtderslikkod.Text);
            //cmd.Parameters.AddWithValue("@derslikturu", cbxDerslikTuru.Text);
            //cmd.Parameters.AddWithValue("@kontenjan", txtkontenjan.Text);
            //if ((txtderslikkod.Text != null) && (txtkontenjan.Text != null) && (cbxDerslikTuru.Text != null))
            //{

            //    MessageBox.Show("Boş Alanlar Mevcut");
            //}
            //else
            //{
            //    if ((cbxDerslikTuru.Text == "TEORİK") || (cbxDerslikTuru.Text == "UYGULAMALI"))
            //    {
            //        if (arama() == 1)
            //        {
            //            MessageBox.Show("Kayıt Mevcut");
            //        }
            //        else
            //        {
            //            if (!Regex.IsMatch(txtkontenjan.Text, "^[0-9]*$"))
            //            {
            //                MessageBox.Show("Hatalı Giriş \n Lütfen Kontenjan Bilgisini Düzeltin!");
            //            }

            //            else if (arama() == 1)
            //            {
            //                MessageBox.Show("Bu Derslik Bulunuyor");
            //            }
            //            else
            //            {
            //                conn.Open();
            //                cmd.ExecuteNonQuery();
            //                conn.Close();
            //                MessageBox.Show("Kayıt Eklendi");
            //                VeriYenile();
            //            }
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Hatalı Giriş \n Derslik Türünü teorik veya uygulama olarak girin");
            //    }
            //}
            if (string.IsNullOrEmpty(txtderslikkod.Text) || string.IsNullOrEmpty(txtkontenjan.Text) || string.IsNullOrEmpty(cbxDerslikTuru.Text) )
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
            }

            else if ((cbxDerslikTuru.Text == "teorik") || (cbxDerslikTuru.Text == "Teorik") || (cbxDerslikTuru.Text == "Uygulamalı") || (cbxDerslikTuru.Text == "uygulamalı") || (cbxDerslikTuru.Text == "TEORİK") || (cbxDerslikTuru.Text == "UYGULAMALI"))
            {
                if (string.IsNullOrWhiteSpace(txtkontenjan.Text) || !Regex.IsMatch(txtkontenjan.Text.Trim(), "^[0-9]*$"))
                {
                    MessageBox.Show("Hatalı Giriş \n Lütfen Kontenjan Bilgisini Düzeltin!");
                }
                else if (arama() == 1)
                {
                    MessageBox.Show("Bu Derslik Bulunuyor");
                }
                else
                {
                    string sql = "INSERT INTO derslikler(derslik_kodu,derslik_türü,derslik_kontenjanı)" + "VALUES(@DerslikKod,@derslikturu,@kontenjan)";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@DerslikKod", txtderslikkod.Text);
                    cmd.Parameters.AddWithValue("@derslikturu", cbxDerslikTuru.Text);
                    cmd.Parameters.AddWithValue("@kontenjan", txtkontenjan.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Kayıt Eklendi");
                    VeriYenile();
                }
            }
            else
            {
                MessageBox.Show("Hatalı Giriş \n Derslik Türünü teorik veya uygulama olarak girin");
            }



        }
        private void cbxlist()
        {
            cbxDerslikTuru.Items.Add("TEORİK");
            cbxDerslikTuru.Items.Add("UYGULAMALI");
            
        }

        private void Derslikler_Load(object sender, EventArgs e)
        {
            VeriYenile();
            cbxlist();
        }

        private void dgwderslik_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtderslikkod.Text= dgwderslik.CurrentRow.Cells[0].Value.ToString();
            cbxDerslikTuru.Text = dgwderslik.CurrentRow.Cells[1].Value.ToString();
            txtkontenjan.Text = dgwderslik.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnOgretimElemaniSilme_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM derslikler WHERE derslik_kodu=@derslikkod AND derslik_türü=@dersliktur";
            cmd=new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@derslikkod", txtderslikkod.Text);
            cmd.Parameters.AddWithValue("@dersliktur", cbxDerslikTuru.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kayıt Silindi");
            VeriYenile();

        }
    }
}
