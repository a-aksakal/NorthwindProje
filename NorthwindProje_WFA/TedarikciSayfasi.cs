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
    public partial class TedarikciSayfasi : Form
    {
        public TedarikciSayfasi()
        {
            InitializeComponent();
        }

        NorthwindContext _dbContext = new NorthwindContext();
        private void TedarikciSayfasi_Load(object sender, EventArgs e)
        {
            TedarikciListele();
        }

        private void TedarikciListele()
        {
            lstTedarikciler.DataSource = _dbContext.Suppliers.ToList();
            lstTedarikciler.DisplayMember = "CompanyName";
        }

        Supplier _secilitedarikci;
        private void lstTedarikciler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTedarikciler.SelectedItem == null) return;

            _secilitedarikci = (Supplier)lstTedarikciler.SelectedItem;
            txtSirketAdi.Text = _secilitedarikci.CompanyName;
            txtIlgiliKisi.Text = _secilitedarikci.ContactName;
            txtPozisyon.Text = _secilitedarikci.ContactTitle;
            txtAdres.Text = _secilitedarikci.Address;
            txtSehir.Text = _secilitedarikci.City;
            txtBolge.Text = _secilitedarikci.Region;
            txtPosta.Text = _secilitedarikci.PostalCode;
            txtUlke.Text = _secilitedarikci.Country;
            txtTelefon.Text = _secilitedarikci.Phone;
            txtFax.Text = _secilitedarikci.Fax;
            txtWebSite.Text = _secilitedarikci.HomePage;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Supplier _supplier = new Supplier()
            {
                CompanyName = txtSirketAdi.Text,
                ContactName = txtIlgiliKisi.Text,
                ContactTitle = txtPozisyon.Text,
                Address = txtAdres.Text,
                City = txtSehir.Text,
                Region = txtBolge.Text,
                PostalCode = txtPosta.Text,
                Country = txtUlke.Text,
                Phone = txtTelefon.Text,
                Fax = txtFax.Text,
                HomePage = txtWebSite.Text,

            };

            _dbContext.Add(_supplier);
            _dbContext.SaveChanges();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            _secilitedarikci.CompanyName = txtSirketAdi.Text;
            _secilitedarikci.ContactName = txtIlgiliKisi.Text;
            _secilitedarikci.ContactTitle = txtPozisyon.Text;
            _secilitedarikci.Address= txtAdres.Text;
            _secilitedarikci.City= txtSehir.Text;
            _secilitedarikci.Region= txtBolge.Text;
            _secilitedarikci.PostalCode= txtPosta.Text;
            _secilitedarikci.Country= txtUlke.Text;
            _secilitedarikci.Phone= txtTelefon.Text;
            _secilitedarikci.Fax= txtFax.Text;
            _secilitedarikci.HomePage= txtWebSite.Text;

            _dbContext.SaveChanges();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _dbContext.Remove(_secilitedarikci);
            _dbContext.SaveChanges();
        }
    }
}
