
namespace NorthwindProje_WFA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kategoriMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunSayfasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparisSayfasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategoriMenuToolStripMenuItem,
            this.urunSayfasiToolStripMenuItem,
            this.siparisSayfasiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(607, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kategoriMenuToolStripMenuItem
            // 
            this.kategoriMenuToolStripMenuItem.Name = "kategoriMenuToolStripMenuItem";
            this.kategoriMenuToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.kategoriMenuToolStripMenuItem.Text = "Kategori Menu";
            this.kategoriMenuToolStripMenuItem.Click += new System.EventHandler(this.kategoriMenuToolStripMenuItem_Click);
            // 
            // urunSayfasiToolStripMenuItem
            // 
            this.urunSayfasiToolStripMenuItem.Name = "urunSayfasiToolStripMenuItem";
            this.urunSayfasiToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.urunSayfasiToolStripMenuItem.Text = "Urun Sayfasi";
            this.urunSayfasiToolStripMenuItem.Click += new System.EventHandler(this.urunSayfasiToolStripMenuItem_Click);
            // 
            // siparisSayfasiToolStripMenuItem
            // 
            this.siparisSayfasiToolStripMenuItem.Name = "siparisSayfasiToolStripMenuItem";
            this.siparisSayfasiToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.siparisSayfasiToolStripMenuItem.Text = "Siparis Sayfasi";
            this.siparisSayfasiToolStripMenuItem.Click += new System.EventHandler(this.siparisSayfasiToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 331);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kategoriMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunSayfasiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparisSayfasiToolStripMenuItem;
    }
}

