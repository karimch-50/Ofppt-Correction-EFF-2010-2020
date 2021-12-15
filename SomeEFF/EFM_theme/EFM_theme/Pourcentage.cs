using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFM_theme
{
    public partial class Pourcentage : Form
    {
        public Pourcentage()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            CrystalReport3 cr = new CrystalReport3();
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();

        }
    }
}
