using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dossier2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void q1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
                MessageBox.Show("La fenetre " + this.MdiChildren[0].Name + " est ouvert !!");
            else
            {
                Q2_a_b q2 = new Q2_a_b();
                q2.MdiParent = this;
                q2.Show();
            }
        }

        private void q3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
                MessageBox.Show("La fenetre " + this.MdiChildren[0].Name + " est ouvert !!");
            else
            {
                Q3 q3 = new Q3();
                q3.MdiParent = this;
                q3.Show();
            }
        }

        private void q4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
                MessageBox.Show("La fenetre " + this.MdiChildren[0].Name + " est ouvert !!");
            else
            {
                Q4 q4 = new Q4();
                q4.MdiParent = this;
                q4.Show();
            }
        }

        private void q6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
                MessageBox.Show("La fenetre " + this.MdiChildren[0].Name + " est ouvert !!");
            else
            {
                Q6 q6 = new Q6();
                q6.MdiParent = this;
                q6.Show();
            }
        }

        private void q7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
                MessageBox.Show("La fenetre " + this.MdiChildren[0].Name + " est ouvert !!");
            else
            {
                Q7 q7 = new Q7();
                q7.MdiParent = this;
                q7.Show();
            }
        }
    }
}
