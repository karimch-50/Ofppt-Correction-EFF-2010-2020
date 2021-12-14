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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void consultationMedecinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Consultation_Medecin C1 = new Consultation_Medecin();
            C1.Show();
        }

        private void ficheMedecamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fiche_medicament F1 = new Fiche_medicament();
            F1.Show();
        }

        private void listeMedicamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            List_Medicament L1 = new List_Medicament();
            L1.Show();
        }

        private void misAJoursMedicamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MAJ_Medicament M1 = new MAJ_Medicament();
            M1.Show();
        }

        private void infoMedecinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            info_Medcein I1 = new info_Medcein();
            I1.Show();
        }
    }
}
