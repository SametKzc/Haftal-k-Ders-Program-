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
    public partial class Form1 : Form
    {
        Derslikler derslikler = new Derslikler();
        Dersler dersler = new Dersler();
        OgretimElemanlari Ogretimelemanlari = new OgretimElemanlari();
        DersprogramıOluştur dersprogrami = new DersprogramıOluştur();
        public Form1()
        {
            InitializeComponent();
        }
        

        private void btnDersler_Click(object sender, EventArgs e)
        {
            
            dersler.Show();
            this.Hide();
        }

        private void btnOgretimElemani_Click(object sender, EventArgs e)
        {
            
            Ogretimelemanlari.Show();
            this.Hide();
        }

        private void btnDerslikler_Click(object sender, EventArgs e)
        {
            
            derslikler.Show();
            this.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnOluştur_Click(object sender, EventArgs e)
        {
            dersprogrami.Show();
            this.Hide();

        }
    }
}
