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

namespace EFM_ADO_karim_chaouki
{
    public partial class Feulle_Recherche : Form
    {
        public static string cnx = @"Data Source=DESKTOP-SQH9NT6\SQLEXPRESS;Initial Catalog=DB_EFM_ADO;Integrated Security=True";
        public SqlConnection connection = new SqlConnection(cnx);
        public DataTable DT1 = new DataTable();
        public DataTable DT2 = new DataTable();


        public Feulle_Recherche()
        {
            InitializeComponent();
        }

        private void Feulle_Recherche_Load(object sender, EventArgs e)
        {
           
        }

        public void rechercherEtudiant()
        {
            try
            {
                connection.Open();
                string cmd = "select*from Etudiant where CodeEtudiant = "+textBox1.Text+"";
                SqlCommand command = new SqlCommand(cmd, connection);
                SqlDataReader SDR1 = command.ExecuteReader();
                DT1.Load(SDR1);
                dataGridView1.DataSource = DT1;
                SDR1.Close();
                connection.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        public void rechercherExamen()
        {
            try
            {
                connection.Open();
                string cmd = "select*from Examen where CodeEtudiant="+textBox2.Text+"";
                SqlCommand command = new SqlCommand(cmd, connection);
                SqlDataReader SDR2 = command.ExecuteReader();
                DT2.Load(SDR2);
                dataGridView2.DataSource = DT2;
                SDR2.Close();
                connection.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rechercherEtudiant();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rechercherExamen();
        }
    }
}
