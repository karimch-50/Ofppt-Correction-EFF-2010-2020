using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFF2018_TP_V2_1
{
    public partial class Fiche_medicament : Form
    {
        public Fiche_medicament()
        {
            InitializeComponent();
        }

        private void Fiche_medicament_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.ToString() != "")
            {
                CrystalReport1 C1 = new CrystalReport1();
                C1.SetParameterValue("NumMedicament", int.Parse(textBox1.Text));
                C1.SetParameterValue("datePeremptin", dateTimePicker1.Value);
                crystalReportViewer1.ReportSource = C1;
                crystalReportViewer1.Refresh();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
