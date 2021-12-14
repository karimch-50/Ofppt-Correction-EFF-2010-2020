using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Certificat
{
    public partial class List_Certificat : Form
    {
        SqlConnection cnx;
        SqlCommand cmd;
        SqlDataReader cr;
        DataTable dt;
        public List_Certificat()
        {
            InitializeComponent();
        }

        private void List_Certificat_Load(object sender, EventArgs e)
        {
            cnx = new SqlConnection("data source = HaithamJelfaoui;database=EFF2017;integrated security = true;");
            cmd = new SqlCommand("select * from Activite", cnx);
            dt = new DataTable();
            cnx.Open();
            dt.Load(cmd.ExecuteReader());
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "nom_activite";
            comboBox1.ValueMember = "num_activite";
            
            cnx.Close();
            cmd = new SqlCommand("select * from Innovation", cnx);
            dt = new DataTable();
            cnx.Open();
            dt.Load(cmd.ExecuteReader());
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "descriptif";
            comboBox2.ValueMember = "num_Innovation";
            comboBox2.SelectedIndex = -1;
            cnx.Close();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            try
            {
                cnx.Close();
                cmd = new SqlCommand("select * from Innovation where num_activite = " + comboBox1.SelectedValue + "; ", cnx);
                dt = new DataTable();
                cnx.Open();
                cr = cmd.ExecuteReader();
                dt.Load(cr);
                comboBox2.DataSource = dt;
                comboBox2.DisplayMember = "descriptif";
                comboBox2.ValueMember = "num_innovation";
                cnx.Close();
            }
            catch
            {
                
            }
            
        }

   

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("select c.*,a.*,s.* from Societe s inner join Auteur a on s.num_societe = a.num_societe inner join Certificat c on a.num_auteur=c.num_auteur inner join Innovation i on c.num_innovation=i.num_innovation where i.num_innovation = " + comboBox2.SelectedValue + " order by c.num_certificat desc; ", cnx);
                dt = new DataTable();
                cnx.Open();
                cr = cmd.ExecuteReader();
                dt.Load(cr);
                dataGridView1.DataSource = dt;

                cnx.Close();
            }
            catch
            {

            }
        }
    }
}
