using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EFF2014
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void gestionDesProfesseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QUESTION1 q1 = new QUESTION1();
            q1.Show();
        }

        private void MENU_Load(object sender, EventArgs e)
        {

        }
    }
}
