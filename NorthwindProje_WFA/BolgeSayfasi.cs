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
    public partial class BolgeSayfasi : Form
    {
        public BolgeSayfasi()
        {
            InitializeComponent();
        }

        NorthwindContext _dbContext = new NorthwindContext();
        private void BolgeSayfasi_Load(object sender, EventArgs e)
        {
            BolgeDoldur();
        }

        private void BolgeDoldur()
        {
            lstBolge.DataSource = _dbContext.Regions.ToList();
            lstBolge.DisplayMember = "RegionDescription";
        }

        Models.Region _seciliBolge;
        private void lstBolge_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBolge.SelectedItem == null) return;

            _seciliBolge= lstBolge.SelectedItem as Models.Region;
            txtBolgeAdi.Text = _seciliBolge.RegionDescription;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Models.Region region = new Models.Region()
            {
                RegionDescription = txtBolgeAdi.Text,

            };

            _dbContext.Add(region);
            _dbContext.SaveChanges();
            BolgeDoldur();

        }
    }
}
