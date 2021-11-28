namespace NorthwindProje_WFA
{
    partial class BolgeSayfasi
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
            this.lstBolge = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBolgeAdi = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBolge
            // 
            this.lstBolge.FormattingEnabled = true;
            this.lstBolge.ItemHeight = 15;
            this.lstBolge.Location = new System.Drawing.Point(346, 21);
            this.lstBolge.Name = "lstBolge";
            this.lstBolge.Size = new System.Drawing.Size(182, 364);
            this.lstBolge.TabIndex = 0;
            this.lstBolge.SelectedIndexChanged += new System.EventHandler(this.lstBolge_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bölge Adı";
            // 
            // txtBolgeAdi
            // 
            this.txtBolgeAdi.Location = new System.Drawing.Point(111, 45);
            this.txtBolgeAdi.Name = "txtBolgeAdi";
            this.txtBolgeAdi.Size = new System.Drawing.Size(141, 23);
            this.txtBolgeAdi.TabIndex = 2;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(185, 74);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(67, 38);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // BolgeSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 394);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtBolgeAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBolge);
            this.Name = "BolgeSayfasi";
            this.Text = "BolgeSayfasi";
            this.Load += new System.EventHandler(this.BolgeSayfasi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBolge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBolgeAdi;
        private System.Windows.Forms.Button btnEkle;
    }
}