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

namespace Haftalık_Ders_Programı
{
    public partial class DersprogramıOluştur : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=haftalık_ders_programı;Uid=root;Pwd='';");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        public DersprogramıOluştur()
        {
            InitializeComponent();
        }
        void VeriYenile()
        {
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("SELECT *FROM dersprogramı", conn);
            adapter.Fill(dt);
            cbxders.DataSource = dt;
            conn.Close();
        }
        void derscek()
        {

                MySqlCommand komut = new MySqlCommand("SELECT * FROM dersler WHERE yarıyıl = @Yarıyıl", conn);
                komut.Parameters.AddWithValue("@Yarıyıl", cbxsınıf.Text);
                MySqlDataReader dr;
                conn.Open();
                dr = komut.ExecuteReader();
                cbxders.Items.Clear(); // Daha önceki dersleri temizle

                while (dr.Read())
                {
                    cbxders.Items.Add("( " + dr["ders_kodu"] + " ) " + dr["ders_adı"] + " ( " + dr["ders_türü"] + ")");
                }
                conn.Close();
        }
        void elemanscek()
        {
            MySqlCommand komut = new MySqlCommand("SELECT * FROM ogretimuyeleri", conn);
            MySqlDataReader dr;
            conn.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cbxeleman.Items.Add(dr["Ad"] + " " + dr["Soyad"]);
            }
            conn.Close();
        }
        void derslikcek()
        {
            MySqlCommand komut = new MySqlCommand("SELECT * FROM derslikler", conn);

            MySqlDataReader dr;
            conn.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                
                cbxderslik.Items.Add(dr["derslik_kodu"] + " " + dr["derslik_türü"]);
            }
            conn.Close();
        }
        void comboboxvericek()
        {
                cbxgun.Items.Add("PAZARTESİ");
                cbxgun.Items.Add("SALI");
                cbxgun.Items.Add("ÇARŞAMBA");
                cbxgun.Items.Add("PERŞEMBE");
                cbxgun.Items.Add("CUMA");
                cbxsaat.Items.Add("17.30-18.20");
                cbxsaat.Items.Add("18.25-19.15");
                cbxsaat.Items.Add("19.20-20.10");
                cbxsaat.Items.Add("20.15-21.05");
                cbxsaat.Items.Add("21.10-22.00");
                cbxsaat.Items.Add("22.05-22.55");
                cbxsaat.Items.Add("23.00-23.50");
                cbxsaat.Items.Add("23.55-00.45");
                cbxsaat.Items.Add("00.50-01.40");
                cbxsınıf.Items.Add("1. Yarıyıl");
                cbxsınıf.Items.Add("2. Yarıyıl");
                cbxsınıf.Items.Add("3. Yarıyıl");
                cbxsınıf.Items.Add("4. Yarıyıl");
                cbxsınıf.Items.Add("5. Yarıyıl");
                cbxsınıf.Items.Add("6. Yarıyıl");
                cbxsınıf.Items.Add("7. Yarıyıl");
                cbxsınıf.Items.Add("8. Yarıyıl");
                cbxogrenimturu.Items.Add("1.Öğretim");
                cbxogrenimturu.Items.Add("2.Öğretim");
        }
        void VerileriCek()
        {
            conn.Open();

            string sql = "SELECT * FROM dersprogramı  WHERE Gün = @gun ORDER BY Saat ASC";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            // cbxgun.SelectedItem değerini kontrol et
            if (cbxgun.SelectedItem != null)
            {
                cmd.Parameters.AddWithValue("@gun", cbxgun.SelectedItem.ToString());
            }
            else
            {
                cmd.Parameters.AddWithValue("@gun", DBNull.Value);
            }

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            Dgwsonuc.Columns.Clear();

            // Pazartesi sütunu ekle
            Dgwsonuc.Columns.Add("Pazartesi", "Pazartesi");

            foreach (DataRow row in dt.Rows)
            {
                Dgwsonuc.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                // Verileri pazartesi sütununun altına ekle
                Dgwsonuc.Rows.Add( row["Saat"]+"\n"+ row["Ders"]+" \n "+row["OgretimElemani"]+" \n " + row["Derslik"]);
            }

            conn.Close();
        }

        private void DersprogramıOluştur_Load(object sender, EventArgs e)
        {

            comboboxvericek();
            derslikcek();
            elemanscek();
            
        }

        private void Dgwsonuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            string sql ="INSERT INTO dersprogramı(Ders,Derslik,OgretimElemani,Gün,Saat,Sınıf,OgretimTuru)"+
                "VALUES(@ders,@derslik,@ogretimelemani,@gun,@saat,@sınıf,@ogretimturu)";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ders", cbxders.Text);
            cmd.Parameters.AddWithValue("@derslik", cbxderslik.Text);
            cmd.Parameters.AddWithValue("@ogretimelemani",cbxeleman.Text);
            cmd.Parameters.AddWithValue("@gun", cbxgun.Text);
            cmd.Parameters.AddWithValue("@saat", cbxsaat.Text);
            cmd.Parameters.AddWithValue("@sınıf", cbxsınıf.Text);
            cmd.Parameters.AddWithValue("@ogretimturu", cbxogrenimturu.Text);

            if ((cbxders.Text != null) && (cbxderslik.Text != null) && (cbxeleman.Text != null) && (cbxgun.Text != null) && (cbxogrenimturu.Text != null) && (cbxsaat.Text != null) && (cbxsınıf != null))
            {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Kayıt Eklendi");

            }
            else
                MessageBox.Show("Boş alan mevcut!!");


            VerileriCek();









            
        }

        private void cbxsınıf_SelectedIndexChanged(object sender, EventArgs e)
        {

            derscek();
        }

    }
}
