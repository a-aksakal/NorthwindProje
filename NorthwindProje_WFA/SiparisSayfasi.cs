using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        
        private void SiparisSayfasi_Load(object sender, EventArgs e)
        {
           
        }
    }
}
