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

namespace ADO_EFF2018_V1_2
{
    public partial class Recherche_Voiture : Form
    {
        public static string con = @"Data Source=DESKTOP-SQH9NT6\SQLEXPRESS;Initial Catalog=ADO_EFF2018_V1_2;Integrated Security=True";
        public SqlConnection connection = new SqlConnection(con);
        DataTable DT = new DataTable();

        public Recherche_Voiture()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string cmd = "select V.* from Voiture V,Dommage D,Locationn L where V.matricule=L.matricule and L.idLoc=D.idLoc and D.descriptionn = '"+textBox1.Text+"'";
                SqlCommand command = new SqlCommand(cmd,connection);
                SqlDataReader SDR = command.ExecuteReader();
                DT.Load(SDR);
                dataGridView1.DataSource = DT;
                SDR.Close();
                connection.Close();
                MessageBox.Show("recherche bien fait !!");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string cmd = "select * from Voiture where idMarq= "+textBox3.Text+"";
                SqlCommand command = new SqlCommand(cmd, connection);
                SqlDataReader SDR = command.ExecuteReader();
                DT.Load(SDR);
                dataGridView1.DataSource = DT;
                SDR.Close();
                connection.Close();
                MessageBox.Show("recherche bien fait !!");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string cmd = "select * from Voiture where prixLocation = '" + textBox2.Text + "'";
                SqlCommand command = new SqlCommand(cmd, connection);
                SqlDataReader SDR = command.ExecuteReader();
                DT.Load(SDR);
                dataGridView1.DataSource = DT;
                SDR.Close();
                connection.Close();
                MessageBox.Show("recherche bien fait !!");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Recherche_Voiture_Load(object sender, EventArgs e)
        {

        }
    }
}
