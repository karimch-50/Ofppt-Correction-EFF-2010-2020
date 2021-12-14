using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dossier2
{
    public partial class Q7 : Form
    {
        public Q7()
        {
            InitializeComponent();
        }

        private void Q7_Load(object sender, EventArgs e)
        {
            CrystalReport2 cr = new CrystalReport2();
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();
        }
    }
}
