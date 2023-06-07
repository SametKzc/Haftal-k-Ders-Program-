namespace Haftalık_Ders_Programı
{
    partial class Dersler
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
            this.components = new System.ComponentModel.Container();
            this.btnDersSil = new System.Windows.Forms.Button();
            this.btnDersEkle = new System.Windows.Forms.Button();
            this.lblDersAdi = new System.Windows.Forms.Label();
            this.lblDerstur = new System.Windows.Forms.Label();
            this.lblDersSaat = new System.Windows.Forms.Label();
            this.lblDersKontenjan = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtDersAdi = new System.Windows.Forms.TextBox();
            this.txtDersSaat = new System.Windows.Forms.TextBox();
            this.cbxDersTur = new System.Windows.Forms.ComboBox();
            this.txtKontenjan = new System.Windows.Forms.TextBox();
            this.btnGeriDersler = new System.Windows.Forms.Button();
            this.txtderskodu = new System.Windows.Forms.TextBox();
            this.lblderskodu = new System.Windows.Forms.Label();
            this.dgwdersler = new System.Windows.Forms.DataGridView();
            this.lblDersyarıyıl = new System.Windows.Forms.Label();
            this.cbxdersyarıyıl = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwdersler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDersSil
            // 
            this.btnDersSil.BackColor = System.Drawing.Color.Red;
            this.btnDersSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnDersSil.ForeColor = System.Drawing.Color.White;
            this.btnDersSil.Location = new System.Drawing.Point(500, 321);
            this.btnDersSil.Name = "btnDersSil";
            this.btnDersSil.Size = new System.Drawing.Size(86, 46);
            this.btnDersSil.TabIndex = 0;
            this.btnDersSil.Text = "Sil";
            this.btnDersSil.UseVisualStyleBackColor = false;
            this.btnDersSil.Click += new System.EventHandler(this.btnDersSil_Click);
            // 
            // btnDersEkle
            // 
            this.btnDersEkle.BackColor = System.Drawing.Color.Lime;
            this.btnDersEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnDersEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDersEkle.Location = new System.Drawing.Point(143, 321);
            this.btnDersEkle.Name = "btnDersEkle";
            this.btnDersEkle.Size = new System.Drawing.Size(88, 46);
            this.btnDersEkle.TabIndex = 1;
            this.btnDersEkle.Text = "Ekle";
            this.btnDersEkle.UseVisualStyleBackColor = false;
            this.btnDersEkle.Click += new System.EventHandler(this.btnDersEkle_Click);
            // 
            // lblDersAdi
            // 
            this.lblDersAdi.AutoSize = true;
            this.lblDersAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblDersAdi.Location = new System.Drawing.Point(41, 113);
            this.lblDersAdi.Name = "lblDersAdi";
            this.lblDersAdi.Size = new System.Drawing.Size(70, 17);
            this.lblDersAdi.TabIndex = 2;
            this.lblDersAdi.Text = "Ders Adı :";
            // 
            // lblDerstur
            // 
            this.lblDerstur.AutoSize = true;
            this.lblDerstur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblDerstur.Location = new System.Drawing.Point(31, 192);
            this.lblDerstur.Name = "lblDerstur";
            this.lblDerstur.Size = new System.Drawing.Size(80, 17);
            this.lblDerstur.TabIndex = 3;
            this.lblDerstur.Text = "Ders Türü :";
            // 
            // lblDersSaat
            // 
            this.lblDersSaat.AutoSize = true;
            this.lblDersSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblDersSaat.Location = new System.Drawing.Point(29, 152);
            this.lblDersSaat.Name = "lblDersSaat";
            this.lblDersSaat.Size = new System.Drawing.Size(82, 17);
            this.lblDersSaat.TabIndex = 4;
            this.lblDersSaat.Text = "Ders Saati :";
            // 
            // lblDersKontenjan
            // 
            this.lblDersKontenjan.AutoSize = true;
            this.lblDersKontenjan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblDersKontenjan.Location = new System.Drawing.Point(31, 230);
            this.lblDersKontenjan.Name = "lblDersKontenjan";
            this.lblDersKontenjan.Size = new System.Drawing.Size(80, 17);
            this.lblDersKontenjan.TabIndex = 5;
            this.lblDersKontenjan.Text = "Kontenjan :";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtDersAdi
            // 
            this.txtDersAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtDersAdi.Location = new System.Drawing.Point(143, 113);
            this.txtDersAdi.Name = "txtDersAdi";
            this.txtDersAdi.Size = new System.Drawing.Size(164, 23);
            this.txtDersAdi.TabIndex = 7;
            this.txtDersAdi.TextChanged += new System.EventHandler(this.txtDersAdi_TextChanged);
            // 
            // txtDersSaat
            // 
            this.txtDersSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtDersSaat.Location = new System.Drawing.Point(143, 152);
            this.txtDersSaat.Name = "txtDersSaat";
            this.txtDersSaat.Size = new System.Drawing.Size(164, 23);
            this.txtDersSaat.TabIndex = 8;
            // 
            // cbxDersTur
            // 
            this.cbxDersTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cbxDersTur.FormattingEnabled = true;
            this.cbxDersTur.Location = new System.Drawing.Point(143, 192);
            this.cbxDersTur.Name = "cbxDersTur";
            this.cbxDersTur.Size = new System.Drawing.Size(164, 25);
            this.cbxDersTur.TabIndex = 9;
            // 
            // txtKontenjan
            // 
            this.txtKontenjan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtKontenjan.Location = new System.Drawing.Point(143, 230);
            this.txtKontenjan.Name = "txtKontenjan";
            this.txtKontenjan.Size = new System.Drawing.Size(164, 23);
            this.txtKontenjan.TabIndex = 10;
            // 
            // btnGeriDersler
            // 
            this.btnGeriDersler.BackColor = System.Drawing.Color.Aqua;
            this.btnGeriDersler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnGeriDersler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnGeriDersler.Location = new System.Drawing.Point(12, 12);
            this.btnGeriDersler.Name = "btnGeriDersler";
            this.btnGeriDersler.Size = new System.Drawing.Size(88, 46);
            this.btnGeriDersler.TabIndex = 12;
            this.btnGeriDersler.Text = "Geri";
            this.btnGeriDersler.UseVisualStyleBackColor = false;
            this.btnGeriDersler.Click += new System.EventHandler(this.btnGeriDersler_Click);
            // 
            // txtderskodu
            // 
            this.txtderskodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtderskodu.Location = new System.Drawing.Point(143, 75);
            this.txtderskodu.Name = "txtderskodu";
            this.txtderskodu.Size = new System.Drawing.Size(164, 23);
            this.txtderskodu.TabIndex = 14;
            // 
            // lblderskodu
            // 
            this.lblderskodu.AutoSize = true;
            this.lblderskodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblderskodu.Location = new System.Drawing.Point(30, 78);
            this.lblderskodu.Name = "lblderskodu";
            this.lblderskodu.Size = new System.Drawing.Size(81, 17);
            this.lblderskodu.TabIndex = 13;
            this.lblderskodu.Text = "Ders kodu :";
            // 
            // dgwdersler
            // 
            this.dgwdersler.AllowUserToAddRows = false;
            this.dgwdersler.AllowUserToDeleteRows = false;
            this.dgwdersler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwdersler.BackgroundColor = System.Drawing.Color.White;
            this.dgwdersler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwdersler.Location = new System.Drawing.Point(331, 32);
            this.dgwdersler.Name = "dgwdersler";
            this.dgwdersler.ReadOnly = true;
            this.dgwdersler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwdersler.Size = new System.Drawing.Size(405, 283);
            this.dgwdersler.TabIndex = 15;
            this.dgwdersler.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwdersler_CellEnter);
            // 
            // lblDersyarıyıl
            // 
            this.lblDersyarıyıl.AutoSize = true;
            this.lblDersyarıyıl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblDersyarıyıl.Location = new System.Drawing.Point(31, 274);
            this.lblDersyarıyıl.Name = "lblDersyarıyıl";
            this.lblDersyarıyıl.Size = new System.Drawing.Size(91, 17);
            this.lblDersyarıyıl.TabIndex = 16;
            this.lblDersyarıyıl.Text = "Ders Yarıyılı :";
            // 
            // cbxdersyarıyıl
            // 
            this.cbxdersyarıyıl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cbxdersyarıyıl.FormattingEnabled = true;
            this.cbxdersyarıyıl.Location = new System.Drawing.Point(143, 271);
            this.cbxdersyarıyıl.Name = "cbxdersyarıyıl";
            this.cbxdersyarıyıl.Size = new System.Drawing.Size(164, 25);
            this.cbxdersyarıyıl.TabIndex = 17;
            this.cbxdersyarıyıl.SelectedIndexChanged += new System.EventHandler(this.cbxdersyarıyıl_SelectedIndexChanged);
            // 
            // Dersler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 401);
            this.Controls.Add(this.cbxdersyarıyıl);
            this.Controls.Add(this.lblDersyarıyıl);
            this.Controls.Add(this.dgwdersler);
            this.Controls.Add(this.txtderskodu);
            this.Controls.Add(this.lblderskodu);
            this.Controls.Add(this.btnGeriDersler);
            this.Controls.Add(this.txtKontenjan);
            this.Controls.Add(this.cbxDersTur);
            this.Controls.Add(this.txtDersSaat);
            this.Controls.Add(this.txtDersAdi);
            this.Controls.Add(this.lblDersKontenjan);
            this.Controls.Add(this.lblDersSaat);
            this.Controls.Add(this.lblDerstur);
            this.Controls.Add(this.lblDersAdi);
            this.Controls.Add(this.btnDersEkle);
            this.Controls.Add(this.btnDersSil);
            this.Name = "Dersler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dersler";
            this.Load += new System.EventHandler(this.Dersler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwdersler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDersSil;
        private System.Windows.Forms.Button btnDersEkle;
        private System.Windows.Forms.Label lblDersAdi;
        private System.Windows.Forms.Label lblDerstur;
        private System.Windows.Forms.Label lblDersSaat;
        private System.Windows.Forms.Label lblDersKontenjan;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtDersAdi;
        private System.Windows.Forms.TextBox txtDersSaat;
        private System.Windows.Forms.ComboBox cbxDersTur;
        private System.Windows.Forms.TextBox txtKontenjan;
        private System.Windows.Forms.Button btnGeriDersler;
        private System.Windows.Forms.TextBox txtderskodu;
        private System.Windows.Forms.Label lblderskodu;
        private System.Windows.Forms.DataGridView dgwdersler;
        private System.Windows.Forms.Label lblDersyarıyıl;
        private System.Windows.Forms.ComboBox cbxdersyarıyıl;
    }
}