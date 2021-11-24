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
    public partial class SiparisSayfasi : Form
    {
        public SiparisSayfasi()
        {
            InitializeComponent();
        }

        NorthwindContext _dbContext = new NorthwindContext();
        Order _secilisiparis;
        private void SiparisSayfasi_Load(object sender, EventArgs e)
        {
            ListeyiDoldur();
        }
        private void ListeyiDoldur()
        {
            lstUrunler.DataSource = _dbContext.Orders.Include(x=>x.OrderDetails).ThenInclude(x=>x.Product).ToList();
            lstUrunler.DisplayMember = "OrderId";
        }

        private void CmbKargoFirmaDoldur()
        {
            cmbKargoFirmasi.DataSource = _dbContext.Shippers.Where(x => x.ShipperId == _secilisiparis.ShipVia).Select(x => x.CompanyName).ToList();
            cmbKargoFirmasi.DisplayMember = "CompanyName";
        }

        private void Degerleritemizle()
        {
            foreach (Control item in this.Controls)
            {
                if(item is TextBox txt) { txt.Text =String.Empty; }
                else if(item is DateTimePicker dtp) { dtp.Value = DateTime.UtcNow.ToLocalTime(); }
                else if(item is NumericUpDown n){ n.Value = 0; }
            }
            cmbKargoFirmasi.DataSource=_dbContext.Shippers.ToList();
            cmbKargoFirmasi.DisplayMember = "CompanyName";
            cmbMusteriAdi.DataSource=_dbContext.Customers.ToList();
            cmbMusteriAdi.DisplayMember = "ContactName";
            cmbCalisanAdi.DataSource = _dbContext.Employees.ToList();
            cmbCalisanAdi.DisplayMember = "FirstName";
        }

        private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItem == null) return;
            _secilisiparis = (Order)lstUrunler.SelectedItem;
            cmbMusteriAdi.DataSource = _dbContext.Customers.Where(x=>x.CustomerId== _secilisiparis.CustomerId).Select(x=>x.ContactName).ToList();
            cmbCalisanAdi.DataSource = _dbContext.Employees.Where(x => x.EmployeeId == _secilisiparis.EmployeeId).Select(x => x.FirstName).ToList();
            if(_secilisiparis.OrderDate.HasValue)
            dtpSiparisTarihi.Value = _secilisiparis.OrderDate.Value;
            if (_secilisiparis.ShippedDate.HasValue)
                dtpGondermeTarihi.Value= _secilisiparis.ShippedDate.Value;
            if (_secilisiparis.RequiredDate.HasValue)
                dtpUlastirmaTarihi.Value= _secilisiparis.RequiredDate.Value;
            if (_secilisiparis.Freight.HasValue)
                nKargoUcret.Value= _secilisiparis.Freight.Value;
            CmbKargoFirmaDoldur();

        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            Order orders = new Order()
            {
                EmployeeId = _dbContext.Employees.Where(x => x.FirstName == cmbCalisanAdi.Text).Select(x => x.EmployeeId).FirstOrDefault(),
                CustomerId = _dbContext.Customers.Where(x => x.ContactName == cmbMusteriAdi.Text).Select(x => x.CustomerId).FirstOrDefault(),
                OrderDate = dtpSiparisTarihi.Value,
                ShippedDate = dtpGondermeTarihi.Value,
                RequiredDate = dtpUlastirmaTarihi.Value,
                Freight = nKargoUcret.Value,
                ShipVia = _dbContext.Shippers.Where(x => x.CompanyName == cmbKargoFirmasi.Text).Select(x => x.ShipperId).FirstOrDefault(),

            };
            _dbContext.Add(orders);
            _dbContext.SaveChanges();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Degerleritemizle();
        }
    }
}
