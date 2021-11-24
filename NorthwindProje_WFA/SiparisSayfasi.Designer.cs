
namespace NorthwindProje_WFA
{
    partial class SiparisSayfasi
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
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpSiparisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpGondermeTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpUlastirmaTarihi = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbKargoFirmasi = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.nKargoUcret = new System.Windows.Forms.NumericUpDown();
            this.cmbMusteriAdi = new System.Windows.Forms.ComboBox();
            this.cmbCalisanAdi = new System.Windows.Forms.ComboBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nKargoUcret)).BeginInit();
            this.SuspendLayout();
            // 
            // lstUrunler
            // 
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.ItemHeight = 15;
            this.lstUrunler.Location = new System.Drawing.Point(352, 15);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(193, 304);
            this.lstUrunler.TabIndex = 0;
            this.lstUrunler.SelectedIndexChanged += new System.EventHandler(this.lstUrunler_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Müşteri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Calisan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sipariş Tarihi";
            // 
            // dtpSiparisTarihi
            // 
            this.dtpSiparisTarihi.Location = new System.Drawing.Point(103, 70);
            this.dtpSiparisTarihi.Name = "dtpSiparisTarihi";
            this.dtpSiparisTarihi.Size = new System.Drawing.Size(159, 23);
            this.dtpSiparisTarihi.TabIndex = 6;
            // 
            // dtpGondermeTarihi
            // 
            this.dtpGondermeTarihi.Location = new System.Drawing.Point(103, 102);
            this.dtpGondermeTarihi.Name = "dtpGondermeTarihi";
            this.dtpGondermeTarihi.Size = new System.Drawing.Size(159, 23);
            this.dtpGondermeTarihi.TabIndex = 7;
            // 
            // dtpUlastirmaTarihi
            // 
            this.dtpUlastirmaTarihi.Location = new System.Drawing.Point(103, 133);
            this.dtpUlastirmaTarihi.Name = "dtpUlastirmaTarihi";
            this.dtpUlastirmaTarihi.Size = new System.Drawing.Size(159, 23);
            this.dtpUlastirmaTarihi.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Gönderme tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ulaştırma Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Kargo Ücreti";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Kargo Firması";
            // 
            // cmbKargoFirmasi
            // 
            this.cmbKargoFirmasi.FormattingEnabled = true;
            this.cmbKargoFirmasi.Location = new System.Drawing.Point(103, 192);
            this.cmbKargoFirmasi.Name = "cmbKargoFirmasi";
            this.cmbKargoFirmasi.Size = new System.Drawing.Size(159, 23);
            this.cmbKargoFirmasi.TabIndex = 15;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(187, 236);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 56);
            this.btnEkle.TabIndex = 16;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // nKargoUcret
            // 
            this.nKargoUcret.DecimalPlaces = 2;
            this.nKargoUcret.Location = new System.Drawing.Point(102, 164);
            this.nKargoUcret.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nKargoUcret.Name = "nKargoUcret";
            this.nKargoUcret.Size = new System.Drawing.Size(160, 23);
            this.nKargoUcret.TabIndex = 17;
            this.nKargoUcret.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbMusteriAdi
            // 
            this.cmbMusteriAdi.FormattingEnabled = true;
            this.cmbMusteriAdi.Location = new System.Drawing.Point(102, 12);
            this.cmbMusteriAdi.Name = "cmbMusteriAdi";
            this.cmbMusteriAdi.Size = new System.Drawing.Size(159, 23);
            this.cmbMusteriAdi.TabIndex = 18;
            // 
            // cmbCalisanAdi
            // 
            this.cmbCalisanAdi.FormattingEnabled = true;
            this.cmbCalisanAdi.Location = new System.Drawing.Point(103, 41);
            this.cmbCalisanAdi.Name = "cmbCalisanAdi";
            this.cmbCalisanAdi.Size = new System.Drawing.Size(159, 23);
            this.cmbCalisanAdi.TabIndex = 19;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(106, 236);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 56);
            this.btnTemizle.TabIndex = 20;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // SiparisSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 341);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.cmbCalisanAdi);
            this.Controls.Add(this.cmbMusteriAdi);
            this.Controls.Add(this.nKargoUcret);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cmbKargoFirmasi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpUlastirmaTarihi);
            this.Controls.Add(this.dtpGondermeTarihi);
            this.Controls.Add(this.dtpSiparisTarihi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstUrunler);
            this.Name = "SiparisSayfasi";
            this.Text = "SiparisSayfasi";
            this.Load += new System.EventHandler(this.SiparisSayfasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nKargoUcret)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstUrunler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpSiparisTarihi;
        private System.Windows.Forms.DateTimePicker dtpGondermeTarihi;
        private System.Windows.Forms.DateTimePicker dtpUlastirmaTarihi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbKargoFirmasi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.NumericUpDown nKargoUcret;
        private System.Windows.Forms.ComboBox cmbMusteriAdi;
        private System.Windows.Forms.ComboBox cmbCalisanAdi;
        private System.Windows.Forms.Button btnTemizle;
    }
}