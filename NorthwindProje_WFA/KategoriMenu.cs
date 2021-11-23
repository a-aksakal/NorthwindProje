using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using NorthwindProje_WFA.Models;

namespace NorthwindProje_WFA
{
    public partial class KategoriMenu : Form
    {
        public KategoriMenu()
        {
            InitializeComponent();
        }

        NorthwindContext _dbContext = new NorthwindContext();
        Category _seciliKategori;
        private void KategoriMenu_Load(object sender, EventArgs e)
        {
            ListeyiDoldur();
        }

        private void ListeyiDoldur()
        {
            lstKategoriler.DataSource = null;
            lstKategoriler.DataSource = _dbContext.Categories.ToList();
            lstKategoriler.DisplayMember = "CategoryName";
        }

        private void lstKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKategoriler.SelectedIndex < 0) return;
            _seciliKategori = (Category)lstKategoriler.SelectedItem;
            txtKategoriAdi.Text = _seciliKategori.CategoryName;
            txtAciklama.Text = _seciliKategori.Description;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Category category = new Category() 
            { CategoryName = txtKategoriAdi.Text, 
                Description = txtAciklama.Text 
            };
            _dbContext.Categories.Add(category);
            _dbContext.SaveChanges();
            ListeyiDoldur();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            _seciliKategori.CategoryName = txtKategoriAdi.Text;
            _seciliKategori.Description = txtAciklama.Text;
            _dbContext.SaveChanges();
            ListeyiDoldur();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _dbContext.Remove(_seciliKategori);
            _dbContext.SaveChanges();
            ListeyiDoldur();
        }

        private void txtKategoriAra_TextChanged(object sender, EventArgs e)
        {
            var txt = txtKategoriAra.Text.ToLower();
            var sonuc = _dbContext.Categories.Where(x => x.CategoryName.ToLower().Contains(txt)).ToList();
            lstKategoriler.DataSource = sonuc;
        }
    }
}
