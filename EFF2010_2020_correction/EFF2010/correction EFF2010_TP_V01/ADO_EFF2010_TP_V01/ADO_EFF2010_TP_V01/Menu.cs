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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void mAJTableHopitaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hopital H1 = new Hopital();
            H1.Show();
        }

        private void mAJTabeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Medecin M1 = new Medecin();
            M1.Show();
        }

        private void mAJTablePatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Patient P1 = new Patient();
            P1.Show();
        }

        private void mAJTableSejourneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sejournee S1 = new Sejournee();
            S1.Show();
        }

        private void saisaisTableSoignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Soigne S2 = new Soigne();
            S2.Show();
        }

        private void feuilleDeRechercherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fuille_echerche F = new Fuille_echerche();
            F.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void afficheSpecialiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Affiche_Specialite A1 = new Affiche_Specialite();
            A1.Show();
        }
    }
}
