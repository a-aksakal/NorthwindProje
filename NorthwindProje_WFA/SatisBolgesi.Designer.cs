namespace NorthwindProje_WFA
{
    partial class SatisBolgesi
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
            this.lstCalisanlar = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCalisanAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBolge = new System.Windows.Forms.ComboBox();
            this.cmbIl = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.chkYeniKayit = new System.Windows.Forms.CheckBox();
            this.chkKayitGetir = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lstCalisanlar
            // 
            this.lstCalisanlar.FormattingEnabled = true;
            this.lstCalisanlar.ItemHeight = 15;
            this.lstCalisanlar.Location = new System.Drawing.Point(351, 24);
            this.lstCalisanlar.Name = "lstCalisanlar";
            this.lstCalisanlar.Size = new System.Drawing.Size(172, 364);
            this.lstCalisanlar.TabIndex = 0;
            this.lstCalisanlar.SelectedIndexChanged += new System.EventHandler(this.lstCalisanlar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Çalışan Adı";
            // 
            // txtCalisanAdi
            // 
            this.txtCalisanAdi.Location = new System.Drawing.Point(114, 41);
            this.txtCalisanAdi.Name = "txtCalisanAdi";
            this.txtCalisanAdi.Size = new System.Drawing.Size(157, 23);
            this.txtCalisanAdi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bölge";
            // 
            // cmbBolge
            // 
            this.cmbBolge.FormattingEnabled = true;
            this.cmbBolge.Location = new System.Drawing.Point(114, 76);
            this.cmbBolge.Name = "cmbBolge";
            this.cmbBolge.Size = new System.Drawing.Size(157, 23);
            this.cmbBolge.TabIndex = 4;
            this.cmbBolge.SelectedIndexChanged += new System.EventHandler(this.cmbBolge_SelectedIndexChanged);
            // 
            // cmbIl
            // 
            this.cmbIl.FormattingEnabled = true;
            this.cmbIl.Location = new System.Drawing.Point(114, 105);
            this.cmbIl.Name = "cmbIl";
            this.cmbIl.Size = new System.Drawing.Size(157, 23);
            this.cmbIl.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "İl";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(196, 134);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 45);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // chkYeniKayit
            // 
            this.chkYeniKayit.AutoSize = true;
            this.chkYeniKayit.Location = new System.Drawing.Point(95, 135);
            this.chkYeniKayit.Name = "chkYeniKayit";
            this.chkYeniKayit.Size = new System.Drawing.Size(77, 19);
            this.chkYeniKayit.TabIndex = 8;
            this.chkYeniKayit.Text = "Yeni Kayıt";
            this.chkYeniKayit.UseVisualStyleBackColor = true;
            this.chkYeniKayit.CheckedChanged += new System.EventHandler(this.chkYeniKayit_CheckedChanged);
            // 
            // chkKayitGetir
            // 
            this.chkKayitGetir.AutoSize = true;
            this.chkKayitGetir.Location = new System.Drawing.Point(95, 160);
            this.chkKayitGetir.Name = "chkKayitGetir";
            this.chkKayitGetir.Size = new System.Drawing.Size(80, 19);
            this.chkKayitGetir.TabIndex = 9;
            this.chkKayitGetir.Text = "Kayıt Getir";
            this.chkKayitGetir.UseVisualStyleBackColor = true;
            this.chkKayitGetir.CheckedChanged += new System.EventHandler(this.chkKayitGetir_CheckedChanged);
            // 
            // SatisBolgesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 408);
            this.Controls.Add(this.chkKayitGetir);
            this.Controls.Add(this.chkYeniKayit);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cmbIl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbBolge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCalisanAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCalisanlar);
            this.Name = "SatisBolgesi";
            this.Text = "SatisBolgesi";
            this.Load += new System.EventHandler(this.SatisBolgesi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCalisanlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCalisanAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBolge;
        private System.Windows.Forms.ComboBox cmbIl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.CheckBox chkYeniKayit;
        private System.Windows.Forms.CheckBox chkKayitGetir;
    }
}