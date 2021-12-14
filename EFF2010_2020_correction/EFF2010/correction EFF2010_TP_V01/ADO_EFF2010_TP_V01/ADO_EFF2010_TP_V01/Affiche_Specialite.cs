using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_EFF2010_TP_V01
{
    public partial class Affiche_Specialite : Form
    {
        public Affiche_Specialite()
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
