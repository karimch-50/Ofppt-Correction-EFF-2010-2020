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
    public partial class ETAT1 : Form
    {
        public ETAT1()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            Etat cr = new Etat();
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrystalReport2rpt cr2 = new CrystalReport2rpt();
            cr2.SetParameterValue("des",textBox1.Text);
            crystalReportViewer1.ReportSource = cr2;
            crystalReportViewer1.Refresh();
        }
    }
}
