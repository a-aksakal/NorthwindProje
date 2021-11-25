using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindProje_WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kategoriMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KategoriMenu kategoriMenu = new KategoriMenu();
            kategoriMenu.MdiParent = this;
            kategoriMenu.Dock = DockStyle.Fill;
            kategoriMenu.Show();
        }

        private void urunSayfasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunSayfasi urunSayfasi = new UrunSayfasi();
            urunSayfasi.MdiParent = this;
            urunSayfasi.Dock = DockStyle.Fill;
            urunSayfasi.Show();
        }

        private void siparisSayfasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparisSayfasi siparisSayfasi = new SiparisSayfasi();
            siparisSayfasi.MdiParent = this;
            siparisSayfasi.Dock = DockStyle.Fill;
            siparisSayfasi.Show();
        }

        private void çalışanSayfasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalisanlarMenu calisanlarMenu = new CalisanlarMenu();
            calisanlarMenu.MdiParent = this;
            calisanlarMenu.Dock = DockStyle.Fill;
            calisanlarMenu.Show();
        }
    }
}
