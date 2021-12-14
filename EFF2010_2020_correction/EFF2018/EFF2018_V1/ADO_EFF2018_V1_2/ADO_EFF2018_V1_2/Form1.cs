using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_EFF2018_V1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rechercheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recherche_Voiture R1 = new Recherche_Voiture();
            R1.Show();
            this.Hide();
        }

        private void miseAJourVoitureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mise_Jour_Voiture M1 = new Mise_Jour_Voiture();
            M1.Show();
            this.Hide();
        }

        private void consulterLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulter_location C1 = new Consulter_location();
            C1.Show();
            this.Hide();
        }

        private void detailDuneLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            detail_location D1 = new detail_location();
            D1.Show();
            this.Hide();
        }
    }
}
