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
    public partial class IlSayfasi : Form
    {
        public IlSayfasi()
        {
            InitializeComponent();
        }

        NorthwindContext _dbContext=new NorthwindContext();
        private void IlSayfasi_Load(object sender, EventArgs e)
        {
            CmbBolgeDoldur();
        }
        private void IllerListele()
        {
            lstIller.DataSource = _dbContext.Territories.Include(t=>t.Region).Where(t=>t.Region.RegionDescription==cmbBolge.Text).ToList();
            lstIller.DisplayMember = "TerritoryDescription";
        }

        private void CmbBolgeDoldur()
        {
            cmbBolge.DataSource = _dbContext.Regions.ToList();
            cmbBolge.DisplayMember = "RegionDescription";
        }

        Territory _seciliIl;
        private void lstIller_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstIller.SelectedItem == null) return;

            _seciliIl = lstIller.SelectedItem as Territory;
            txtIlid.Text = _seciliIl.TerritoryId;
            txtIlAdi.Text = _seciliIl.TerritoryDescription;
            cmbBolge.Text = _seciliIl.Region.RegionDescription;

        }

        private void cmbBolge_SelectedIndexChanged(object sender, EventArgs e)
        {
            IllerListele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Territory territory = new Territory()
            {
                RegionId = _dbContext.Regions.Where(r => r.RegionDescription == cmbBolge.Text).Select(r => r.RegionId).FirstOrDefault(),
                TerritoryDescription = txtIlAdi.Text,
                TerritoryId = txtIlid.Text
            };
            _dbContext.Add(territory);
            _dbContext.SaveChanges();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            _seciliIl.TerritoryId = txtIlid.Text;
            _seciliIl.TerritoryDescription = txtIlAdi.Text;
            _dbContext.SaveChanges();
        }
    }
}
