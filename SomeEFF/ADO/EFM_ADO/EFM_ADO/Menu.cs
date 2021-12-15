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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MAJ_Etudiants M1 = new MAJ_Etudiants();
            M1.Show();
        }

        private void misAJourExamantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MAJ_Examents M2 = new MAJ_Examents();
            M2.Show();
        }

        private void misAJourCoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MAJ_Cours M3 = new MAJ_Cours();
            M3.Show();
        }

        private void feulleDeRecherecheDEtudiantEtExamenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Feulle_Recherche F = new Feulle_Recherche();
            F.Show();
        }

        private void lesNotesParCoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imprimer_PV_Note L1 = new Imprimer_PV_Note();
            L1.Show();
        }

        private void listesDesNoteDetudiantAvecCaMoyenneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List_Note__Etudiant L2 = new List_Note__Etudiant();
            L2.Show();
        }
    }
}
