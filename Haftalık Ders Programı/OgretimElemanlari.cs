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

namespace Haftalık_Ders_Programı
{
    
    public partial class OgretimElemanlari : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=haftalık_ders_programı;Uid=root;Pwd='';");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;

        
        void VeriYenile()
        {
            dt = new DataTable();
            con.Open();
            adapter = new MySqlDataAdapter("SELECT *FROM ogretimuyeleri", con);
            adapter.Fill(dt);
            dgwOgretimElemanlari.DataSource = dt;
            con.Close();
            dgwOgretimElemanlari.RowHeadersVisible = false;
        }
        public OgretimElemanlari()
        {
            InitializeComponent();
        }

        private void cbxOgretimElemanlari_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void cbxlist()
        {

            cbxbrans.Items.Add("Bilgisayar Bilimleri");
            cbxbrans.Items.Add("Bilgisayar Donanımı");
            cbxbrans.Items.Add("Bilgisayar Yazılımı");
            cbxbrans.Items.Add("Bilgisayar Bilimleri ve Mühendisliği");
            cbxbrans.Items.Add("Çevre Bilimleri ve Mühendisliği");
            cbxbrans.Items.Add("Elektrik-Elektronik Mühendisliği");
            cbxbrans.Items.Add("Matematik");
            cbxbrans.Items.Add("Fizik");
            cbxbrans.Items.Add("Maden Mühendisliği");
            cbxbrans.Items.Add("Yönetim ve Stratej");
            cbxbrans.Items.Add("Yeni Türk Edebiyatı");
            cbxbrans.Items.Add("Yabancı Dil Eğitimi");
            cbxbrans.Items.Add("Elektronik-Haberleşme Mühendisliği");
            cbxbrans.Items.Add("Malzeme ve Metalurji Mühendisliği");

            cbxUnvan.Items.Add("DOKTOR ÖĞRETİM");
            cbxUnvan.Items.Add("ARAŞTIRMA GÖREVLİSİ");
            cbxUnvan.Items.Add("ÖĞRETİM GÖREVLİSİ");
            cbxUnvan.Items.Add("DOÇENT DR");
            cbxUnvan.Items.Add("PROFESÖR DR");
        }
        private void btn_OgretimElemanlari_geri_Click(object sender, EventArgs e)
        {
            Form1 anasayfa = new Form1();
            anasayfa.Show();
            this.Close();
        }

        public void OgretimElemanlari_Load(object sender, EventArgs e)
        {
      
            VeriYenile();
            cbxlist();

        }
        public void btnEkleOgretimElemani_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO ogretimuyeleri(Ad,Soyad,Unvan,Brans)" +
               "VALUES(@Ad,@SoyAd,@Unvan,@Brans)";
            cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Ad",txtAd.Text);
            cmd.Parameters.AddWithValue("@SoyAd",txtsoyad.Text);
            cmd.Parameters.AddWithValue("@Unvan",cbxUnvan.Text);
            cmd.Parameters.AddWithValue("@Brans",cbxbrans.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            VeriYenile();
            MessageBox.Show("Kayıt Eklendi");

        }
        private void dgwOgretimElemanlari_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtAd.Text = dgwOgretimElemanlari.CurrentRow.Cells[0].Value.ToString();
            txtsoyad.Text= dgwOgretimElemanlari.CurrentRow.Cells[1].Value.ToString();
            cbxbrans.Text = dgwOgretimElemanlari.CurrentRow.Cells[2].Value.ToString();
            cbxUnvan.Text = dgwOgretimElemanlari.CurrentRow.Cells[3].Value.ToString();

        }

        private void btnOgretimElemaniSilme_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM ogretimuyeleri WHERE Ad=@Ad AND Soyad=@soyad AND Unvan=@Unvan AND Brans=@Brans";
            cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@ad",txtAd.Text);
            cmd.Parameters.AddWithValue("@soyad", txtsoyad.Text);
            cmd.Parameters.AddWithValue("@Unvan", cbxUnvan.Text);
            cmd.Parameters.AddWithValue("@Brans", cbxbrans.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Kayıt Silindi");
        }
    }
}
