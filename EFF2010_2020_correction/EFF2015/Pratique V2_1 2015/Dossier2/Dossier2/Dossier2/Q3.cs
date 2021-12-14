using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dossier2
{
    public partial class Q3 : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=.;Initial Catalog=EFF_PRATIQUE_2015_V2_1;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        public Q3()
        {
            InitializeComponent();
        }

        private void cmbAbonnement_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SELECT Abonne.nomAb FROM Abonnement,Abonne,Consommation WHERE Abonne.idAbonne=Abonnement.idAbonne and Consommation.idAbonnement=Abonnement.idAbonnement and Abonnement.idAbonnement="+cmbAbonnement.Text+" and Consommation.periode='"+dateTimePicker1.Text+"'", Con);
            Con.Open();
            string nom;
            dr=cmd.ExecuteReader();
            while (dr.Read())
            {
                lblNom.Text = dr["nomAb"].ToString();
            }
            dr.Close();
            Con.Close();
        }

        private void Q3_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select idAbonnement from Abonnement", Con);
            da.Fill(ds, "tblAbonnement");
            cmbAbonnement.DataSource = ds.Tables["tblAbonnement"];
            cmbAbonnement.DisplayMember = "idAbonnement";
        }
    }
}
