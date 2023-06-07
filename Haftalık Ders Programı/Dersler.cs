using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Haftalık_Ders_Programı
{
    public partial class Dersler : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=haftalık_ders_programı;Uid=root;Pwd='';");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        Derslikler derslikler = new Derslikler();
        void VeriYenile()
        {
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("SELECT *FROM dersler", conn);
            adapter.Fill(dt);
            dgwdersler.DataSource = dt;
            conn.Close();
            dgwdersler.RowHeadersVisible = false;
        }
        public Dersler()
        {
            InitializeComponent();
        }

        private void txtDersAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGeriDersler_Click(object sender, EventArgs e)
        {
            Form1 anasayfa = new Form1();
            anasayfa.Show();
            this.Close();
        }

        private void Dersler_Load(object sender, EventArgs e)
        {
            VeriYenile();
            cbxlist();
        }
        private void cbxlist()
        {
            cbxDersTur.Items.Add("teorik");
            cbxDersTur.Items.Add("uygulamalı");
            cbxdersyarıyıl.Items.Add("1. Yarıyıl");
            cbxdersyarıyıl.Items.Add("2. Yarıyıl");
            cbxdersyarıyıl.Items.Add("3. Yarıyıl");
            cbxdersyarıyıl.Items.Add("4. Yarıyıl");
            cbxdersyarıyıl.Items.Add("5. Yarıyıl");
            cbxdersyarıyıl.Items.Add("6. Yarıyıl");
            cbxdersyarıyıl.Items.Add("7. Yarıyıl");
            cbxdersyarıyıl.Items.Add("8. Yarıyıl");
        }
        int arama()
        {
            MySqlCommand cmd2 = new MySqlCommand("SELECT ders_kodu  FROM dersler WHERE ders_kodu='" + txtderskodu.Text + "'", conn);
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
        private void dgwdersler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtderskodu.Text = dgwdersler.CurrentRow.Cells[0].Value.ToString();
            txtDersAdi.Text = dgwdersler.CurrentRow.Cells[1].Value.ToString();
            txtDersSaat.Text = dgwdersler.CurrentRow.Cells[3].Value.ToString();
            cbxDersTur.Text = dgwdersler.CurrentRow.Cells[2].Value.ToString();
            txtKontenjan.Text= dgwdersler.CurrentRow.Cells[4].Value.ToString();
        }
        private void btnDersEkle_Click(object sender, EventArgs e)
        {
           

            //    if ((txtDersAdi.Text != null) && (txtderskodu.Text != null) && (txtDersSaat.Text != null) &&(cbxDersTur.Text != null) && (txtKontenjan.Text != null)&&(cbxdersyarıyıl.Text !=null))
            //    {
            //        if (arama() == 1)
            //        {
            //            MessageBox.Show("Kayıt mevcut");
            //        }
            //        else
            //        {
            //            if ((cbxDersTur.Text == "teorik") || (cbxDersTur.Text == "Teorik") || (cbxDersTur.Text == "Uygulamalı") || (cbxDersTur.Text == "uygulamalı"))
            //            {

            //                conn.Open();
            //                cmd.ExecuteNonQuery();
            //                conn.Close();
            //                MessageBox.Show("Kayıt Eklendi");
            //                VeriYenile();
            //            }

            //            else
            //            {
            //                MessageBox.Show("Hatalı Giriş \n Ders Türünü teorik veya uygulama olarak girin!");
            //            }
            //        }
            //    }
            //    else
            //        MessageBox.Show("Boş alan mevcut!!");


            if (string.IsNullOrEmpty(txtderskodu.Text) ||  string.IsNullOrEmpty(txtDersSaat.Text) || string.IsNullOrEmpty(txtKontenjan.Text) || string.IsNullOrEmpty(txtDersAdi.Text) || string.IsNullOrEmpty(cbxDersTur.Text) || string.IsNullOrEmpty(cbxdersyarıyıl.Text))
             {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
             }

             else if ((cbxDersTur.Text == "teorik") || (cbxDersTur.Text == "Teorik") || (cbxDersTur.Text == "Uygulamalı") || (cbxDersTur.Text == "uygulamalı"))
              {
                if (string.IsNullOrWhiteSpace(txtKontenjan.Text) || !Regex.IsMatch(txtKontenjan.Text.Trim(), "^[0-9]*$"))
                {
                    MessageBox.Show("Hatalı Giriş \n Lütfen Kontenjan Bilgisini Düzeltin!");
                }

                else if (string.IsNullOrWhiteSpace(txtDersSaat.Text) || !Regex.IsMatch(txtDersSaat.Text.Trim(), "^[0-9]*$"))
                {
                    MessageBox.Show("Hatalı Giriş \n Lütfen Saat Bilgisini Düzeltin!");
                }
                else if (arama() == 1)
                {
                    MessageBox.Show("Bu Derslik Bulunuyor");
                }
                else
                {
                    string sql = "INSERT INTO dersler(ders_kodu,ders_adı,ders_türü,ders_saati,ders_kontenjanı,yarıyıl)" +
                     "VALUES(@DersKodu,@DersAdi,@DersTuru,@DersSaati,@Derskontenjani,@Yarıyıl)";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@DersSaati", Int32.Parse(txtDersSaat.Text));
                    cmd.Parameters.AddWithValue("@Derskontenjani", Int32.Parse(txtKontenjan.Text));
                    cmd.Parameters.AddWithValue("@DersKodu", txtderskodu.Text);
                    cmd.Parameters.AddWithValue("@DersAdi", txtDersAdi.Text);
                    cmd.Parameters.AddWithValue("@DersTuru", cbxDersTur.Text);
                    cmd.Parameters.AddWithValue("@Yarıyıl", cbxdersyarıyıl.Text);
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

        private void btnDersSil_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM dersler WHERE ders_kodu=@DersKodu";
            cmd=new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@DersKodu",txtderskodu.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kayıt Silindi!!");
            VeriYenile();
        }
        private void cbxdersyarıyıl_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter="yarıyıl Like '"+cbxdersyarıyıl.Text+"%'";
            dgwdersler.DataSource=dv;

        }
    }
}
