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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void listeDEntretienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Liste_Entretien L1 = new Liste_Entretien();
            L1.Show();
        }

        private void listeDEtretienEnRetardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Liste_Entretien_Retard L2 = new Liste_Entretien_Retard();
            L2.Show();
        }

        private void mToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MAJ_Vehicules M1 = new MAJ_Vehicules();
            M1.Show();
        }

        private void impimerLaListDesVehiculeDiuneMarqueDonneeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imprimer_Vehicule_MArque_Donnee I1 = new Imprimer_Vehicule_MArque_Donnee();
            I1.Show();
        }

        private void imrimerLaListDesVehiculeRegreperParLaMarqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imprimer_Vehicule_Regrouper_Marque I2 = new Imprimer_Vehicule_Regrouper_Marque();
            I2.Show();
        }
    }
}
