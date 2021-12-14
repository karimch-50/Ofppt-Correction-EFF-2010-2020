using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFF2012_V7_ADO
{
    public partial class Imprimer_Vehicule_Regrouper_Marque : Form
    {
        public Imprimer_Vehicule_Regrouper_Marque()
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
