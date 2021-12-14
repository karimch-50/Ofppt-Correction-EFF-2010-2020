using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_EFF2018_V1_2
{
    public partial class detail_location : Form
    {
        public detail_location()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            CrystalReport1 C1 = new CrystalReport1();
            crystalReportViewer1.ReportSource = C1;
            crystalReportViewer1.Refresh();
                 
        }
    }
}
