using Microsoft.EntityFrameworkCore;
using NorthwindProje_WFA.Models;
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
    public partial class UrunSayfasi : Form
    {
        public UrunSayfasi()
        {
            InitializeComponent();
        }

        NorthwindContext _dbContext = new NorthwindContext();
        Category _seciliKategori;
        Product _seciliUrun;
        private void CmbKategoriDoldur()
        {
            cmbKategori.DataSource = _dbContext.Categories.Include(x=>x.Products).ToList();
            cmbKategori.DisplayMember = "CategoryName";
            
        }

        private void CmbTedarikciDoldur()
        {
            
            cmbTedarikci.DataSource = _dbContext.Suppliers.Where(x => x.SupplierId == _seciliUrun.SupplierId).ToList();
            cmbTedarikci.DisplayMember = "CompanyName";
        }
        private void UrunSayfasi_Load(object sender, EventArgs e)
        {
            CmbKategoriDoldur();
            lstUrunler.DataSource = null;
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKategori.SelectedIndex < 0) return;
            _seciliKategori = (Category)cmbKategori.SelectedItem;
            lstUrunler.DataSource = _dbContext.Products.Where(x => x.Category.CategoryName == cmbKategori.SelectedItem.ToString()).ToList();
            lstUrunler.DisplayMember = "ProductName";
        }

        private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedIndex <= 0) return;
            _seciliUrun = (Product)lstUrunler.SelectedItem;
            txtUrunAd.Text = _seciliUrun.ProductName;
            nFiyat.Value =(decimal)_seciliUrun.UnitPrice;
            nStok.Value =(short)_seciliUrun.UnitsInStock;
            if (_seciliUrun.Discontinued == true)
                chbVar.Checked = Enabled;
            else { chbVar.Checked = false; }

            CmbTedarikciDoldur();
           
        }

        private void cmbTedarikci_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                Category = (Category)cmbKategori.SelectedItem,
                ProductName = txtUrunAd.Text,
                UnitPrice = nFiyat.Value,
                UnitsInStock = (short)nStok.Value,
                //SupplierId =(int)cmbTedarikci.SelectedItem
            };
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
        }
    }
}
