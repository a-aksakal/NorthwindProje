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
    public partial class CalisanlarMenu : Form
    {
        public CalisanlarMenu()
        {
            InitializeComponent();
        }

        NorthwindContext _dbContext = new NorthwindContext();
        private void ListeyiDoldur()
        {
            lstCalisanlar.DataSource = _dbContext.Employees.ToList();
            lstCalisanlar.DisplayMember = "FirstName";
        }

        Models.Region _seciliBolge;
        private void CalisanlarMenu_Load(object sender, EventArgs e)
        {
            ListeyiDoldur();
            CmbBolgeDoldur();
        }
        
        private void CmbBolgeDoldur()
        {

            cmbBolge.DataSource = _dbContext.Regions.ToList();
            cmbBolge.DisplayMember = "RegionDescription";

        }

        private void cmbBolge_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBolge.SelectedItem == null) return;
            _seciliBolge = (Models.Region)cmbBolge.SelectedItem;
            cmbIl.DataSource = _dbContext.Territories.Where(x => x.RegionId == _seciliBolge.RegionId).Select(x => x.TerritoryDescription).ToList();
        }

        Employee _seciliCalisan;
        private void lstCalisanlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCalisanlar.SelectedItem == null) return;

            _seciliCalisan = (Employee)lstCalisanlar.SelectedItem;
            txtAd.Text = _seciliCalisan.FirstName;
            txtSoyad.Text = _seciliCalisan.LastName;
            dtpDogum.Value = _seciliCalisan.BirthDate.Value;
            txtUnvan.Text = _seciliCalisan.TitleOfCourtesy;
            txtPozisyon.Text = _seciliCalisan.Title;
            cmbIl.Text = _dbContext.EmployeeTerritories.Where(et=>et.EmployeeId==_seciliCalisan.EmployeeId).Join(_dbContext.Territories, et => et.TerritoryId, t => t.TerritoryId, (et, t) => new {t.TerritoryDescription}).Select(t=>t.TerritoryDescription).FirstOrDefault();
            cmbBolge.Text = _dbContext.Territories.Where(t=>t.TerritoryDescription==cmbIl.Text).Join(_dbContext.Regions, t => t.RegionId, r=>r.RegionId, (t, r) => new {r.RegionDescription}).Select(r=>r.RegionDescription).FirstOrDefault();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee()
            {
                FirstName = txtAd.Text,
                LastName = txtSoyad.Text,
                BirthDate = dtpDogum.Value,
                TitleOfCourtesy = txtUnvan.Text,
                Title = txtPozisyon.Text,
                Region = cmbBolge.Text,

            };
            _dbContext.Add(employee);
            _dbContext.SaveChanges();
        }
    }
}
