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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void misAJourAutocaresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MAJ_AutoCares M1 = new MAJ_AutoCares();
            M1.Show();
        }

        private void saisieCalendrierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Saisie_Calendrier S1 = new Saisie_Calendrier();
            S1.Show();
        }

        private void listVoyageAssurerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List_Voyage_Assurer L1 = new List_Voyage_Assurer();
            L1.Show();
        }

        private void imprimerCalendrierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imprimer_Calendrier I = new Imprimer_Calendrier();
            I.Show();
        }

        private void totalKilometreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Total_Kilometre t1 = new Total_Kilometre();
            t1.Show();
        }
    }
}
