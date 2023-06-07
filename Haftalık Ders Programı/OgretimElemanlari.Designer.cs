namespace Haftalık_Ders_Programı
{
    partial class OgretimElemanlari
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_OgretimElemanlari_geri = new System.Windows.Forms.Button();
            this.cbxbrans = new System.Windows.Forms.ComboBox();
            this.lblad = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblbrans = new System.Windows.Forms.Label();
            this.btnEkleOgretimElemani = new System.Windows.Forms.Button();
            this.btnOgretimElemaniSilme = new System.Windows.Forms.Button();
            this.dgwOgretimElemanlari = new System.Windows.Forms.DataGridView();
            this.lblUnvan = new System.Windows.Forms.Label();
            this.cbxUnvan = new System.Windows.Forms.ComboBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.lblsoyad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOgretimElemanlari)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_OgretimElemanlari_geri
            // 
            this.btn_OgretimElemanlari_geri.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_OgretimElemanlari_geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btn_OgretimElemanlari_geri.Location = new System.Drawing.Point(12, 12);
            this.btn_OgretimElemanlari_geri.Name = "btn_OgretimElemanlari_geri";
            this.btn_OgretimElemanlari_geri.Size = new System.Drawing.Size(100, 49);
            this.btn_OgretimElemanlari_geri.TabIndex = 0;
            this.btn_OgretimElemanlari_geri.Text = "Geri";
            this.btn_OgretimElemanlari_geri.UseVisualStyleBackColor = false;
            this.btn_OgretimElemanlari_geri.Click += new System.EventHandler(this.btn_OgretimElemanlari_geri_Click);
            // 
            // cbxbrans
            // 
            this.cbxbrans.FormattingEnabled = true;
            this.cbxbrans.Location = new System.Drawing.Point(98, 178);
            this.cbxbrans.Name = "cbxbrans";
            this.cbxbrans.Size = new System.Drawing.Size(181, 21);
            this.cbxbrans.TabIndex = 1;
            this.cbxbrans.SelectedIndexChanged += new System.EventHandler(this.cbxOgretimElemanlari_SelectedIndexChanged);
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblad.Location = new System.Drawing.Point(52, 129);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(37, 17);
            this.lblad.TabIndex = 2;
            this.lblad.Text = "Ad  :";
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.Color.White;
            this.txtAd.Location = new System.Drawing.Point(98, 126);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(181, 20);
            this.txtAd.TabIndex = 3;
            // 
            // lblbrans
            // 
            this.lblbrans.AutoSize = true;
            this.lblbrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblbrans.Location = new System.Drawing.Point(33, 178);
            this.lblbrans.Name = "lblbrans";
            this.lblbrans.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblbrans.Size = new System.Drawing.Size(56, 17);
            this.lblbrans.TabIndex = 4;
            this.lblbrans.Text = "Branşı :";
            this.lblbrans.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnEkleOgretimElemani
            // 
            this.btnEkleOgretimElemani.BackColor = System.Drawing.Color.LightGreen;
            this.btnEkleOgretimElemani.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnEkleOgretimElemani.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnEkleOgretimElemani.Location = new System.Drawing.Point(72, 255);
            this.btnEkleOgretimElemani.Name = "btnEkleOgretimElemani";
            this.btnEkleOgretimElemani.Size = new System.Drawing.Size(85, 52);
            this.btnEkleOgretimElemani.TabIndex = 6;
            this.btnEkleOgretimElemani.Text = "Ekle";
            this.btnEkleOgretimElemani.UseVisualStyleBackColor = false;
            this.btnEkleOgretimElemani.Click += new System.EventHandler(this.btnEkleOgretimElemani_Click);
            // 
            // btnOgretimElemaniSilme
            // 
            this.btnOgretimElemaniSilme.BackColor = System.Drawing.Color.OrangeRed;
            this.btnOgretimElemaniSilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnOgretimElemaniSilme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnOgretimElemaniSilme.Location = new System.Drawing.Point(163, 255);
            this.btnOgretimElemaniSilme.Name = "btnOgretimElemaniSilme";
            this.btnOgretimElemaniSilme.Size = new System.Drawing.Size(85, 52);
            this.btnOgretimElemaniSilme.TabIndex = 7;
            this.btnOgretimElemaniSilme.Text = "Sil";
            this.btnOgretimElemaniSilme.UseVisualStyleBackColor = false;
            this.btnOgretimElemaniSilme.Click += new System.EventHandler(this.btnOgretimElemaniSilme_Click);
            // 
            // dgwOgretimElemanlari
            // 
            this.dgwOgretimElemanlari.AllowUserToAddRows = false;
            this.dgwOgretimElemanlari.AllowUserToDeleteRows = false;
            this.dgwOgretimElemanlari.AllowUserToResizeRows = false;
            this.dgwOgretimElemanlari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwOgretimElemanlari.BackgroundColor = System.Drawing.Color.White;
            this.dgwOgretimElemanlari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOgretimElemanlari.Location = new System.Drawing.Point(305, 45);
            this.dgwOgretimElemanlari.Name = "dgwOgretimElemanlari";
            this.dgwOgretimElemanlari.ReadOnly = true;
            this.dgwOgretimElemanlari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwOgretimElemanlari.Size = new System.Drawing.Size(491, 294);
            this.dgwOgretimElemanlari.TabIndex = 8;
            this.dgwOgretimElemanlari.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwOgretimElemanlari_CellEnter);
            // 
            // lblUnvan
            // 
            this.lblUnvan.AutoSize = true;
            this.lblUnvan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblUnvan.Location = new System.Drawing.Point(32, 205);
            this.lblUnvan.Name = "lblUnvan";
            this.lblUnvan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUnvan.Size = new System.Drawing.Size(57, 17);
            this.lblUnvan.TabIndex = 10;
            this.lblUnvan.Text = "Ünvan :";
            // 
            // cbxUnvan
            // 
            this.cbxUnvan.FormattingEnabled = true;
            this.cbxUnvan.Location = new System.Drawing.Point(98, 205);
            this.cbxUnvan.Name = "cbxUnvan";
            this.cbxUnvan.Size = new System.Drawing.Size(181, 21);
            this.cbxUnvan.TabIndex = 9;
            // 
            // txtsoyad
            // 
            this.txtsoyad.BackColor = System.Drawing.Color.White;
            this.txtsoyad.Location = new System.Drawing.Point(98, 152);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(181, 20);
            this.txtsoyad.TabIndex = 11;
            // 
            // lblsoyad
            // 
            this.lblsoyad.AutoSize = true;
            this.lblsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblsoyad.Location = new System.Drawing.Point(33, 151);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(56, 17);
            this.lblsoyad.TabIndex = 12;
            this.lblsoyad.Text = "Soyad :";
            // 
            // OgretimElemanlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(808, 401);
            this.Controls.Add(this.lblsoyad);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.lblUnvan);
            this.Controls.Add(this.cbxUnvan);
            this.Controls.Add(this.dgwOgretimElemanlari);
            this.Controls.Add(this.btnOgretimElemaniSilme);
            this.Controls.Add(this.btnEkleOgretimElemani);
            this.Controls.Add(this.lblbrans);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblad);
            this.Controls.Add(this.cbxbrans);
            this.Controls.Add(this.btn_OgretimElemanlari_geri);
            this.Name = "OgretimElemanlari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OgretimElemanlari";
            this.Load += new System.EventHandler(this.OgretimElemanlari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwOgretimElemanlari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OgretimElemanlari_geri;
        private System.Windows.Forms.ComboBox cbxbrans;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblbrans;
        private System.Windows.Forms.Button btnEkleOgretimElemani;
        private System.Windows.Forms.Button btnOgretimElemaniSilme;
        public System.Windows.Forms.DataGridView dgwOgretimElemanlari;
        private System.Windows.Forms.Label lblUnvan;
        private System.Windows.Forms.ComboBox cbxUnvan;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label lblsoyad;
    }
}