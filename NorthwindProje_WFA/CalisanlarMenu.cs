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

        
        private void CalisanlarMenu_Load(object sender, EventArgs e)
        {
            ListeyiDoldur();
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
            dtpIseGiris.Value = _seciliCalisan.HireDate.Value;

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
                HireDate = dtpIseGiris.Value

            };
            _dbContext.Add(employee);
            _dbContext.SaveChanges();
        }
    }
}
