namespace Haftalık_Ders_Programı
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnDersler = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.AnasayfaResim = new System.Windows.Forms.PictureBox();
            this.btnDerslikler = new System.Windows.Forms.Button();
            this.btnOgretimElemani = new System.Windows.Forms.Button();
            this.btnOluştur = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AnasayfaResim)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDersler
            // 
            this.btnDersler.BackColor = System.Drawing.Color.IndianRed;
            this.btnDersler.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDersler.FlatAppearance.BorderSize = 3;
            this.btnDersler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnDersler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDersler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnDersler.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDersler.Location = new System.Drawing.Point(12, 184);
            this.btnDersler.Name = "btnDersler";
            this.btnDersler.Size = new System.Drawing.Size(150, 80);
            this.btnDersler.TabIndex = 4;
            this.btnDersler.Text = "Dersler";
            this.btnDersler.UseVisualStyleBackColor = false;
            this.btnDersler.Click += new System.EventHandler(this.btnDersler_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ımageList2
            // 
            this.ımageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList2.TransparentColor = System.Drawing.Color.Black;
            // 
            // AnasayfaResim
            // 
            this.AnasayfaResim.BackColor = System.Drawing.SystemColors.Control;
            this.AnasayfaResim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AnasayfaResim.Image = ((System.Drawing.Image)(resources.GetObject("AnasayfaResim.Image")));
            this.AnasayfaResim.Location = new System.Drawing.Point(168, 84);
            this.AnasayfaResim.Name = "AnasayfaResim";
            this.AnasayfaResim.Size = new System.Drawing.Size(425, 209);
            this.AnasayfaResim.TabIndex = 5;
            this.AnasayfaResim.TabStop = false;
            // 
            // btnDerslikler
            // 
            this.btnDerslikler.BackColor = System.Drawing.Color.IndianRed;
            this.btnDerslikler.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDerslikler.FlatAppearance.BorderSize = 3;
            this.btnDerslikler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnDerslikler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDerslikler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnDerslikler.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDerslikler.Location = new System.Drawing.Point(12, 98);
            this.btnDerslikler.Name = "btnDerslikler";
            this.btnDerslikler.Size = new System.Drawing.Size(150, 80);
            this.btnDerslikler.TabIndex = 6;
            this.btnDerslikler.Text = "Derslerlikler";
            this.btnDerslikler.UseVisualStyleBackColor = false;
            this.btnDerslikler.Click += new System.EventHandler(this.btnDerslikler_Click);
            // 
            // btnOgretimElemani
            // 
            this.btnOgretimElemani.BackColor = System.Drawing.Color.IndianRed;
            this.btnOgretimElemani.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOgretimElemani.FlatAppearance.BorderSize = 3;
            this.btnOgretimElemani.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnOgretimElemani.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnOgretimElemani.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnOgretimElemani.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOgretimElemani.Location = new System.Drawing.Point(12, 12);
            this.btnOgretimElemani.Name = "btnOgretimElemani";
            this.btnOgretimElemani.Size = new System.Drawing.Size(150, 80);
            this.btnOgretimElemani.TabIndex = 7;
            this.btnOgretimElemani.Text = "Öğretim Elemanları";
            this.btnOgretimElemani.UseVisualStyleBackColor = false;
            this.btnOgretimElemani.Click += new System.EventHandler(this.btnOgretimElemani_Click);
            // 
            // btnOluştur
            // 
            this.btnOluştur.BackColor = System.Drawing.Color.Green;
            this.btnOluştur.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOluştur.FlatAppearance.BorderSize = 3;
            this.btnOluştur.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnOluştur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnOluştur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnOluştur.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOluştur.Location = new System.Drawing.Point(12, 270);
            this.btnOluştur.Name = "btnOluştur";
            this.btnOluştur.Size = new System.Drawing.Size(150, 80);
            this.btnOluştur.TabIndex = 8;
            this.btnOluştur.Text = "Haftalık Ders Programı Oluştur";
            this.btnOluştur.UseVisualStyleBackColor = false;
            this.btnOluştur.Click += new System.EventHandler(this.btnOluştur_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(613, 380);
            this.Controls.Add(this.btnOluştur);
            this.Controls.Add(this.btnOgretimElemani);
            this.Controls.Add(this.btnDerslikler);
            this.Controls.Add(this.AnasayfaResim);
            this.Controls.Add(this.btnDersler);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AnasayfaResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDersler;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.PictureBox AnasayfaResim;
        private System.Windows.Forms.Button btnDerslikler;
        private System.Windows.Forms.Button btnOgretimElemani;
        private System.Windows.Forms.Button btnOluştur;
    }
}

