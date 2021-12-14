using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_EFF2011_TP_V01
{
    public partial class Total_Kilometre : Form
    {
        public Total_Kilometre()
        {
            InitializeComponent();
        }

        private void Total_Kilometre_Load(object sender, EventArgs e)
        {
            CrystalReport2 C2 = new CrystalReport2();
            crystalReportViewer1.ReportSource = C2;
            crystalReportViewer1.Refresh();
        }
    }
}
