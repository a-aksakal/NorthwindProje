namespace NorthwindProje_WFA
{
    partial class IlSayfasi
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
            this.lstIller = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIlid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBolge = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtIlAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstIller
            // 
            this.lstIller.FormattingEnabled = true;
            this.lstIller.ItemHeight = 15;
            this.lstIller.Location = new System.Drawing.Point(329, 12);
            this.lstIller.Name = "lstIller";
            this.lstIller.Size = new System.Drawing.Size(185, 364);
            this.lstIller.TabIndex = 0;
            this.lstIller.SelectedIndexChanged += new System.EventHandler(this.lstIller_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "İl ID";
            // 
            // txtIlid
            // 
            this.txtIlid.Location = new System.Drawing.Point(90, 40);
            this.txtIlid.Name = "txtIlid";
            this.txtIlid.Size = new System.Drawing.Size(129, 23);
            this.txtIlid.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bölge Adı";
            // 
            // cmbBolge
            // 
            this.cmbBolge.FormattingEnabled = true;
            this.cmbBolge.Location = new System.Drawing.Point(90, 99);
            this.cmbBolge.Name = "cmbBolge";
            this.cmbBolge.Size = new System.Drawing.Size(129, 23);
            this.cmbBolge.TabIndex = 4;
            this.cmbBolge.SelectedIndexChanged += new System.EventHandler(this.cmbBolge_SelectedIndexChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(144, 128);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 42);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtIlAdi
            // 
            this.txtIlAdi.Location = new System.Drawing.Point(90, 70);
            this.txtIlAdi.Name = "txtIlAdi";
            this.txtIlAdi.Size = new System.Drawing.Size(129, 23);
            this.txtIlAdi.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "İl Adı";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(144, 176);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 42);
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // IlSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 386);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtIlAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cmbBolge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIlid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstIller);
            this.Name = "IlSayfasi";
            this.Text = "IlSayfasi";
            this.Load += new System.EventHandler(this.IlSayfasi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstIller;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIlid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBolge;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtIlAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuncelle;
    }
}