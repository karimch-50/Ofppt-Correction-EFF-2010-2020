using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EFF2014
{
    public partial class QUESTION1 : Form
    {
        public QUESTION1()
        {
            InitializeComponent();
        }
        ADO d = new ADO();
        public void remplissageLycee()
        {
            d.Connecter();
            d.cmd.CommandText = "select IDLYCEE,NOM_LYCEE from LYCEE";
            d.cmd.Connection = d.con;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            combolycee.DataSource = d.dt;
            combolycee.DisplayMember = "NOM_LYCEE";
            combolycee.ValueMember = "IDLYCEE";
            d.dr.Close();
            d.Deonnecter();
        }

        private void QUESTION1_Load(object sender, EventArgs e)
        {
            d.Connecter();
            d.dap = new SqlDataAdapter("select * from PROFESSEUR", d.con);
            d.dap.Fill(d.ds, "prof");
            remplissageLycee();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            d.ligne = d.ds.Tables["prof"].NewRow();
            d.ligne[0] = txtid.Text;
            d.ligne[1] = txtnom.Text;
            d.ligne[2] = txtprenom.Text;
            d.ligne[3] = dateTimePicker1.Value;
            d.ligne[4] = txtemail.Text;
            d.ligne[5] = txtpass.Text;
            d.ligne[6] = dateTimePicker2.Value;
            d.ligne[7] = comboetat.Text;
            if (txtenfant.Enabled == true)
            {
                d.ligne[8] = txtenfant.Text;
            }


            d.ligne[9] = combolycee.SelectedValue;
            for (int i = 0; i <= d.ds.Tables["prof"].Rows.Count - 1; i++)
            {
                if (txtid.Text == d.ds.Tables["prof"].Rows[i][0].ToString())
                {
                    MessageBox.Show("Ce Identifiant existe déja ");
                    return;
                }

            }
            d.ds.Tables["prof"].Rows.Add(d.ligne);
            MessageBox.Show("ajouter avec succes");
            d.cb = new SqlCommandBuilder(d.dap);
            d.dap.Update(d.ds, "prof");




        }

        private void comboetat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboetat.SelectedItem == "Célibataire")
            {
                txtenfant.Enabled = false;

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool tr = false;
            for (int i = 0; i <= d.ds.Tables["prof"].Rows.Count - 1; i++)
            {
                if (txtid.Text == d.ds.Tables["prof"].Rows[i][0].ToString())
                {
                    tr = true;
                    d.ds.Tables["prof"].Rows[i].Delete();
                    MessageBox.Show("supprimer avec succes");
                    d.cb = new SqlCommandBuilder(d.dap);
                    d.dap.Update(d.ds, "prof");
                    break;
                }
                if (tr == false)
                    MessageBox.Show(" ce identifiant n'existe pas ");


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool tr = false;
            for (int i = 0; i <= d.ds.Tables["prof"].Rows.Count - 1; i++)
            {
                if (txtid.Text == d.ds.Tables["prof"].Rows[i][0].ToString())
                {
                    tr = true;
                    d.ds.Tables["prof"].Rows[i][1] = txtnom.Text;
                    d.ds.Tables["prof"].Rows[i][2] = txtprenom.Text;
                    d.ds.Tables["prof"].Rows[i][3] = dateTimePicker1.Value;
                    d.ds.Tables["prof"].Rows[i][4] = txtemail.Text;
                    d.ds.Tables["prof"].Rows[i][5] = txtpass.Text;
                    d.ds.Tables["prof"].Rows[i][6] = dateTimePicker2.Value;
                    d.ds.Tables["prof"].Rows[i][7] = comboetat.Text;
                    if (txtenfant.Enabled == true)
                    {
                        d.ds.Tables["prof"].Rows[i][8] = txtenfant.Text;
                    }
                    d.ds.Tables["prof"].Rows[i][9] = combolycee.SelectedValue;

                    MessageBox.Show("modifier avec succes");
                    d.cb = new SqlCommandBuilder(d.dap);
                    d.dap.Update(d.ds, "prof");
                    break;
                }
                if (tr == false)
                    MessageBox.Show(" ce identifiant n'existe pas ");
            }
        }
    }
}
