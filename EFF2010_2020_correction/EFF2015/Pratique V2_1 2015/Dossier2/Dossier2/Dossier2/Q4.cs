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
    public partial class Q4 : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=.;Initial Catalog=EFF_PRATIQUE_2015_V2_1;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        public Q4()
        {
            InitializeComponent();
        }

        private void Q4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select SUM(C.qte) from Consommation C,Abonnement A where C.idAbonnement=A.idAbonnement and A.idAbonnement="+cmbAbonnement.Text+" and C.periode like '"+textBox1.Text+"%'", Con);

            Con.Open();
            int a;
            a=(int)cmd.ExecuteScalar();
            txtMontant.Text = a.ToString();
            Con.Close();
        }
    }
}
