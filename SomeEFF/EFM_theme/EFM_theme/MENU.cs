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
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void mAJTHEMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Theme theme = new Theme();
            theme.Show();
        }

        private void afficherCommentaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AfficherCommentaire a = new AfficherCommentaire();
            a.Show();
        }

        private void afficherToutesLesIdeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ETAT1 et = new ETAT1();
            et.Show();
        }

        private void pourcentageSecteursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pourcentage p = new Pourcentage();
            p.Show();
        }

        private void MENU_Load(object sender, EventArgs e)
        {

        }
    }
}
