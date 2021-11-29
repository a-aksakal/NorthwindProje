namespace NorthwindProje_WFA
{
    partial class SiparisDetay
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
            this.lstSiparisler = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUrunler = new System.Windows.Forms.ComboBox();
            this.nBirimFiyat = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nStok = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nIndirim = new System.Windows.Forms.NumericUpDown();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.chkYeniKayit = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nBirimFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIndirim)).BeginInit();
            this.SuspendLayout();
            // 
            // lstSiparisler
            // 
            this.lstSiparisler.FormattingEnabled = true;
            this.lstSiparisler.ItemHeight = 15;
            this.lstSiparisler.Location = new System.Drawing.Point(396, 25);
            this.lstSiparisler.Name = "lstSiparisler";
            this.lstSiparisler.Size = new System.Drawing.Size(186, 349);
            this.lstSiparisler.TabIndex = 0;
            this.lstSiparisler.SelectedIndexChanged += new System.EventHandler(this.lstSiparisler_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Adı";
            // 
            // cmbUrunler
            // 
            this.cmbUrunler.FormattingEnabled = true;
            this.cmbUrunler.Location = new System.Drawing.Point(95, 41);
            this.cmbUrunler.Name = "cmbUrunler";
            this.cmbUrunler.Size = new System.Drawing.Size(178, 23);
            this.cmbUrunler.TabIndex = 2;
            this.cmbUrunler.SelectedIndexChanged += new System.EventHandler(this.cmbUrunler_SelectedIndexChanged);
            // 
            // nBirimFiyat
            // 
            this.nBirimFiyat.DecimalPlaces = 2;
            this.nBirimFiyat.Location = new System.Drawing.Point(95, 70);
            this.nBirimFiyat.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nBirimFiyat.Name = "nBirimFiyat";
            this.nBirimFiyat.Size = new System.Drawing.Size(117, 23);
            this.nBirimFiyat.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Birim Fiyatı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stok";
            // 
            // nStok
            // 
            this.nStok.DecimalPlaces = 2;
            this.nStok.Location = new System.Drawing.Point(95, 99);
            this.nStok.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nStok.Name = "nStok";
            this.nStok.Size = new System.Drawing.Size(117, 23);
            this.nStok.TabIndex = 5;
            this.nStok.ValueChanged += new System.EventHandler(this.nStok_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "İskonto";
            // 
            // nIndirim
            // 
            this.nIndirim.DecimalPlaces = 2;
            this.nIndirim.Location = new System.Drawing.Point(95, 128);
            this.nIndirim.Name = "nIndirim";
            this.nIndirim.Size = new System.Drawing.Size(117, 23);
            this.nIndirim.TabIndex = 7;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(43, 185);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 49);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(124, 185);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 49);
            this.btnGuncelle.TabIndex = 10;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(205, 185);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 49);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // chkYeniKayit
            // 
            this.chkYeniKayit.AutoSize = true;
            this.chkYeniKayit.Location = new System.Drawing.Point(95, 160);
            this.chkYeniKayit.Name = "chkYeniKayit";
            this.chkYeniKayit.Size = new System.Drawing.Size(77, 19);
            this.chkYeniKayit.TabIndex = 14;
            this.chkYeniKayit.Text = "Yeni Kayıt";
            this.chkYeniKayit.UseVisualStyleBackColor = true;
            // 
            // SiparisDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 405);
            this.Controls.Add(this.chkYeniKayit);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nIndirim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nStok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nBirimFiyat);
            this.Controls.Add(this.cmbUrunler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstSiparisler);
            this.Name = "SiparisDetay";
            this.Text = "SiparisDetay";
            this.Load += new System.EventHandler(this.SiparisDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nBirimFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIndirim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSiparisler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUrunler;
        private System.Windows.Forms.NumericUpDown nBirimFiyat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nStok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nIndirim;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.CheckBox chkYeniKayit;
    }
}