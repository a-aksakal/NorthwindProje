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
    public partial class SiparisDetay : Form
    {
        public SiparisDetay()
        {
            InitializeComponent();
        }

        NorthwindContext _dbContext = new NorthwindContext();
        private void SiparisDetay_Load(object sender, EventArgs e)
        {
            SiparisListele();
        }

        private void SiparisListele()
        {
            lstSiparisler.DataSource = _dbContext.Orders.Include(o => o.OrderDetails).ThenInclude(od=>od.Product).ToList();
            lstSiparisler.DisplayMember = "OrderID";
        }

        Order _seciliSiparis;
        Product _seciliUrunDetay;
        private void lstSiparisler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSiparisler.SelectedItem == null) return;

            _seciliSiparis= (Order)lstSiparisler.SelectedItem;
            if (chkYeniKayit.Checked != Enabled)
            {
                cmbUrunler.DataSource = _seciliSiparis.OrderDetails.Select(od => od.Product).ToList();
                cmbUrunler.DisplayMember = "ProductName";
            }
            else 
            { 
                cmbUrunler.DataSource = _dbContext.Products.ToList();
                cmbUrunler.DisplayMember = "ProductName";
            }

        }

        private void cmbUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            _seciliUrunDetay = (Product)cmbUrunler.SelectedItem;

            if (chkYeniKayit.Checked == Enabled) return;

            nBirimFiyat.Value = _seciliSiparis.OrderDetails.Where(od => od.ProductId == _seciliUrunDetay.ProductId).Select(od => od.UnitPrice).FirstOrDefault();
            nStok.Value = _seciliSiparis.OrderDetails.Where(od=>od.ProductId==_seciliUrunDetay.ProductId).Select(od=>od.Quantity).FirstOrDefault();
            nIndirim.Value = (decimal) _seciliSiparis.OrderDetails.Where(od => od.ProductId == _seciliUrunDetay.ProductId).Select(od => od.Discount).FirstOrDefault();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            OrderDetail orderDetail = new OrderDetail()
            {
                OrderId = _seciliSiparis.OrderId,
                ProductId = _seciliUrunDetay.ProductId,
                UnitPrice = nBirimFiyat.Value,
                Quantity = (short)nStok.Value,
                Discount = (float)nIndirim.Value,

            };
            var _kalanstok = _seciliUrunDetay.UnitsInStock - Convert.ToInt16(nStok.Value);
            _seciliUrunDetay.UnitsInStock = (short) _kalanstok;
            _dbContext.Add(orderDetail);
            _dbContext.Update(_seciliUrunDetay);
            _dbContext.SaveChanges();
        }

        private void nStok_ValueChanged(object sender, EventArgs e)
        {
            if (chkYeniKayit.Checked==Enabled && nStok.Value > _seciliUrunDetay.UnitsInStock)
            {
                nStok.Value =(decimal) _seciliUrunDetay.UnitsInStock;
            }
        }
    }
}
