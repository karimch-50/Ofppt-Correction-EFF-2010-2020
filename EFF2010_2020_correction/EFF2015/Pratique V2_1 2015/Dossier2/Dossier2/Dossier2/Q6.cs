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
    public partial class Q6 : Form
    {
        public Q6()
        {
            InitializeComponent();
        }

        private void Q6_Load(object sender, EventArgs e)
        {
            CrystalReport1 cr = new CrystalReport1();
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();
        }
    }
}
