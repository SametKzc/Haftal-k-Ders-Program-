namespace Haftalık_Ders_Programı
{
    partial class Derslikler
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
            this.btnOgretimElemaniSilme = new System.Windows.Forms.Button();
            this.btnEkleOgretimElemani = new System.Windows.Forms.Button();
            this.lblDerslikturu = new System.Windows.Forms.Label();
            this.cbxDerslikTuru = new System.Windows.Forms.ComboBox();
            this.btn_Derslikler_geri = new System.Windows.Forms.Button();
            this.dgwderslik = new System.Windows.Forms.DataGridView();
            this.lblderslikkodu = new System.Windows.Forms.Label();
            this.txtderslikkod = new System.Windows.Forms.TextBox();
            this.txtkontenjan = new System.Windows.Forms.TextBox();
            this.lblkontenjan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwderslik)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOgretimElemaniSilme
            // 
            this.btnOgretimElemaniSilme.BackColor = System.Drawing.Color.OrangeRed;
            this.btnOgretimElemaniSilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnOgretimElemaniSilme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnOgretimElemaniSilme.Location = new System.Drawing.Point(149, 238);
            this.btnOgretimElemaniSilme.Name = "btnOgretimElemaniSilme";
            this.btnOgretimElemaniSilme.Size = new System.Drawing.Size(85, 52);
            this.btnOgretimElemaniSilme.TabIndex = 15;
            this.btnOgretimElemaniSilme.Text = "Sil";
            this.btnOgretimElemaniSilme.UseVisualStyleBackColor = false;
            this.btnOgretimElemaniSilme.Click += new System.EventHandler(this.btnOgretimElemaniSilme_Click);
            // 
            // btnEkleOgretimElemani
            // 
            this.btnEkleOgretimElemani.BackColor = System.Drawing.Color.LightGreen;
            this.btnEkleOgretimElemani.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnEkleOgretimElemani.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnEkleOgretimElemani.Location = new System.Drawing.Point(31, 238);
            this.btnEkleOgretimElemani.Name = "btnEkleOgretimElemani";
            this.btnEkleOgretimElemani.Size = new System.Drawing.Size(85, 52);
            this.btnEkleOgretimElemani.TabIndex = 14;
            this.btnEkleOgretimElemani.Text = "Ekle";
            this.btnEkleOgretimElemani.UseVisualStyleBackColor = false;
            this.btnEkleOgretimElemani.Click += new System.EventHandler(this.btnEkleOgretimElemani_Click);
            // 
            // lblDerslikturu
            // 
            this.lblDerslikturu.AutoSize = true;
            this.lblDerslikturu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblDerslikturu.Location = new System.Drawing.Point(22, 155);
            this.lblDerslikturu.Name = "lblDerslikturu";
            this.lblDerslikturu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDerslikturu.Size = new System.Drawing.Size(97, 17);
            this.lblDerslikturu.TabIndex = 12;
            this.lblDerslikturu.Text = "Derslik Türü : ";
            this.lblDerslikturu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbxDerslikTuru
            // 
            this.cbxDerslikTuru.FormattingEnabled = true;
            this.cbxDerslikTuru.Location = new System.Drawing.Point(125, 155);
            this.cbxDerslikTuru.Name = "cbxDerslikTuru";
            this.cbxDerslikTuru.Size = new System.Drawing.Size(109, 21);
            this.cbxDerslikTuru.TabIndex = 9;
            // 
            // btn_Derslikler_geri
            // 
            this.btn_Derslikler_geri.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Derslikler_geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btn_Derslikler_geri.Location = new System.Drawing.Point(10, 9);
            this.btn_Derslikler_geri.Name = "btn_Derslikler_geri";
            this.btn_Derslikler_geri.Size = new System.Drawing.Size(100, 49);
            this.btn_Derslikler_geri.TabIndex = 8;
            this.btn_Derslikler_geri.Text = "Geri";
            this.btn_Derslikler_geri.UseVisualStyleBackColor = false;
            this.btn_Derslikler_geri.Click += new System.EventHandler(this.btn_Derslikler_geri_Click);
            // 
            // dgwderslik
            // 
            this.dgwderslik.AllowUserToAddRows = false;
            this.dgwderslik.AllowUserToDeleteRows = false;
            this.dgwderslik.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwderslik.BackgroundColor = System.Drawing.Color.White;
            this.dgwderslik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwderslik.Location = new System.Drawing.Point(277, 29);
            this.dgwderslik.Name = "dgwderslik";
            this.dgwderslik.ReadOnly = true;
            this.dgwderslik.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwderslik.Size = new System.Drawing.Size(413, 309);
            this.dgwderslik.TabIndex = 16;
            this.dgwderslik.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwderslik_CellEnter);
            // 
            // lblderslikkodu
            // 
            this.lblderslikkodu.AutoSize = true;
            this.lblderslikkodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblderslikkodu.Location = new System.Drawing.Point(20, 114);
            this.lblderslikkodu.Name = "lblderslikkodu";
            this.lblderslikkodu.Size = new System.Drawing.Size(96, 17);
            this.lblderslikkodu.TabIndex = 17;
            this.lblderslikkodu.Text = "Derslik Kodu :";
            // 
            // txtderslikkod
            // 
            this.txtderslikkod.BackColor = System.Drawing.Color.White;
            this.txtderslikkod.Location = new System.Drawing.Point(125, 114);
            this.txtderslikkod.Name = "txtderslikkod";
            this.txtderslikkod.Size = new System.Drawing.Size(109, 20);
            this.txtderslikkod.TabIndex = 18;
            // 
            // txtkontenjan
            // 
            this.txtkontenjan.BackColor = System.Drawing.Color.White;
            this.txtkontenjan.Location = new System.Drawing.Point(125, 194);
            this.txtkontenjan.Name = "txtkontenjan";
            this.txtkontenjan.Size = new System.Drawing.Size(109, 20);
            this.txtkontenjan.TabIndex = 20;
            // 
            // lblkontenjan
            // 
            this.lblkontenjan.AutoSize = true;
            this.lblkontenjan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblkontenjan.Location = new System.Drawing.Point(33, 194);
            this.lblkontenjan.Name = "lblkontenjan";
            this.lblkontenjan.Size = new System.Drawing.Size(72, 17);
            this.lblkontenjan.TabIndex = 19;
            this.lblkontenjan.Text = "Kontenjan";
            // 
            // Derslikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 364);
            this.Controls.Add(this.txtkontenjan);
            this.Controls.Add(this.lblkontenjan);
            this.Controls.Add(this.txtderslikkod);
            this.Controls.Add(this.lblderslikkodu);
            this.Controls.Add(this.dgwderslik);
            this.Controls.Add(this.btnOgretimElemaniSilme);
            this.Controls.Add(this.btnEkleOgretimElemani);
            this.Controls.Add(this.lblDerslikturu);
            this.Controls.Add(this.cbxDerslikTuru);
            this.Controls.Add(this.btn_Derslikler_geri);
            this.Name = "Derslikler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Derslikler";
            this.Load += new System.EventHandler(this.Derslikler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwderslik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOgretimElemaniSilme;
        private System.Windows.Forms.Button btnEkleOgretimElemani;
        private System.Windows.Forms.Label lblDerslikturu;
        private System.Windows.Forms.ComboBox cbxDerslikTuru;
        private System.Windows.Forms.Button btn_Derslikler_geri;
        public System.Windows.Forms.DataGridView dgwderslik;
        private System.Windows.Forms.Label lblderslikkodu;
        private System.Windows.Forms.TextBox txtderslikkod;
        private System.Windows.Forms.TextBox txtkontenjan;
        private System.Windows.Forms.Label lblkontenjan;
    }
}