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
    public partial class Q2_a_b : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=.;Initial Catalog=EFF_PRATIQUE_2015_V2_1;Integrated Security=True");
       SqlCommand cmd;
       SqlDataReader dr;
       SqlDataAdapter da;
       DataSet ds = new DataSet();
       BindingSource bs = new BindingSource();
        public Q2_a_b()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into Abonnement values("+textBox1.Text+",'"+textBox2.Text+"',"+cmbUsage.Text+","+cmbAbonne.Text+")",Con);
            Con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Bien Ajouter");
            textBox1.Text = textBox2.Text = "";
            Con.Close();
        }

        private void Q2_a_b_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select idUsage from Usage", Con);
            da.Fill(ds, "tblUsage");
            cmbUsage.DataSource = ds.Tables["tblUsage"];
            cmbUsage.DisplayMember = "idUsage";

            da = new SqlDataAdapter("select idAbonne from Abonne", Con);
            da.Fill(ds, "tblAbonne");
            cmbUsage.DataSource = ds.Tables["tblAbonne"];
            cmbUsage.DisplayMember = "idAbonne";

            da = new SqlDataAdapter("select *from Abonnement", Con);
            da.Fill(ds, "tblAbonnement");
            bs.DataSource = ds.Tables["tblAbonnement"];
            textBox1.DataBindings.Add(new Binding("text", bs, "idAbonnement"));
            textBox2.DataBindings.Add(new Binding("text", bs, "dateAb"));
            cmbUsage.DataBindings.Add(new Binding("text", bs, "idUsage"));
            cmbAbonne.DataBindings.Add(new Binding("text", bs, "idAbonne"));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("delete Abonnement where idAbonnement="+textBox1.Text, Con);
            Con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Bien Supprimer");
            Con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("update Abonnement set dateAb='" + textBox2.Text + "' where idAbonnement="+textBox1.Text, Con);
            Con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Bien Modifier");
            Con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
        }
    }
}
