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
    public partial class List_Note__Etudiant : Form
    {
        public List_Note__Etudiant()
        {
            InitializeComponent();
        }

        private void List_Note__Etudiant_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CrystalReport2 C2 = new CrystalReport2();
            C2.SetParameterValue("CodeEtudiant",textBox1.Text);
            crystalReportViewer1.ReportSource = C2;
            crystalReportViewer1.Refresh();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
