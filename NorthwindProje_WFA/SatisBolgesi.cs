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
    public partial class SatisBolgesi : Form
    {
        public SatisBolgesi()
        {
            InitializeComponent();
        }

        NorthwindContext _dbContext = new NorthwindContext();
        private void SatisBolgesi_Load(object sender, EventArgs e)
        {
            CalisanDoldur();
            BolgeDoldur();
        }

        private void CalisanDoldur()
        {
            lstCalisanlar.DataSource= _dbContext.Employees.ToList();
            lstCalisanlar.DisplayMember = "FirstName";
            
        }

        private void BolgeDoldur()
        {
            cmbBolge.DataSource = _dbContext.Regions.ToList();
            cmbBolge.DisplayMember = "RegionDescription";
        }

        private void DegerTemizle()
        {
            foreach(Control c in this.Controls)
            {
                if (c is TextBox txt) { txt.Text = string.Empty; }
                else if (c is ComboBox cmb) { cmb.DataSource = null; }
            }
            BolgeDoldur();
        }


        Employee _seciliCalisan;
        private void lstCalisanlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCalisanlar.SelectedItem == null) return;

            _seciliCalisan=(Employee)lstCalisanlar.SelectedItem;
            txtCalisanAdi.Text = _seciliCalisan.FirstName;
            cmbIl.DataSource = _dbContext.EmployeeTerritories.Where(et => et.EmployeeId == _seciliCalisan.EmployeeId).Join(_dbContext.Territories, et => et.TerritoryId, t => t.TerritoryId, (et, t) => new { t.TerritoryDescription , t.TerritoryId}).Select(t => t.TerritoryDescription).ToList();
            cmbIl.DisplayMember = "TerritoryDescription";
            cmbBolge.Text = _dbContext.Territories.Where(t => t.TerritoryDescription == cmbIl.Text).Join(_dbContext.Regions, t => t.RegionId, r => r.RegionId, (t, r) => new { r.RegionDescription}).Select(t => t.RegionDescription).FirstOrDefault();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            EmployeeTerritory employeeTerritory = new EmployeeTerritory()
            {
                EmployeeId = _dbContext.Employees.Where(e => e.FirstName == txtCalisanAdi.Text).Select(e => e.EmployeeId).First(),
                TerritoryId = _dbContext.Territories.Where(t => t.TerritoryDescription == cmbIl.Text).Select(t => t.TerritoryId).First(),
            };
            if (_dbContext.EmployeeTerritories.Where(et => et.EmployeeId == employeeTerritory.EmployeeId).Select(et => et.TerritoryId).FirstOrDefault() == _dbContext.Territories.Where(t=>t.TerritoryId==employeeTerritory.TerritoryId).Select(t=>t.TerritoryId).FirstOrDefault()) { MessageBox.Show("Bu il zaten tanımlı.","HATA!",MessageBoxButtons.OK,MessageBoxIcon.Error); }
            _dbContext.Add(employeeTerritory);
            _dbContext.SaveChanges();
        }

        Models.Region _seciliBolge;
        private void cmbBolge_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chkYeniKayit.Checked != Enabled) return;
            if (cmbBolge.SelectedItem == null) return;
            _seciliBolge=cmbBolge.SelectedItem as Models.Region;
            cmbIl.DataSource = _dbContext.Territories.Where(t=>t.RegionId==_seciliBolge.RegionId).Select(t=>t.TerritoryDescription).ToList();
            cmbIl.DisplayMember = "TerritoryDescription";
        }

        private void chkYeniKayit_CheckedChanged(object sender, EventArgs e)
        {
            DegerTemizle();
            btnEkle.Enabled = true;
        }

        private void chkKayitGetir_CheckedChanged(object sender, EventArgs e)
        {
            btnEkle.Enabled = false;
        }
    }
}
