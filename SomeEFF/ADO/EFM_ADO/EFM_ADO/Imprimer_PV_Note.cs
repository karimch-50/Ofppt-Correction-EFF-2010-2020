using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFM_ADO_karim_chaouki
{
    public partial class Imprimer_PV_Note : Form
    {
        public Imprimer_PV_Note()
        {
            InitializeComponent();
        }

        private void Imprimer_PV_Note_Load(object sender, EventArgs e)
        {
            CrystalReport1 C1 = new CrystalReport1();
            crystalReportViewer1.ReportSource = C1;
            crystalReportViewer1.Refresh();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
