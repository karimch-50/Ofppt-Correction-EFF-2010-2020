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
    public partial class Consulter_location : Form
    {

        public static string con = @"Data Source=DESKTOP-SQH9NT6\SQLEXPRESS;Initial Catalog=ADO_EFF2018_V1_2;Integrated Security=True";
        public SqlConnection connection = new SqlConnection(con);
        DataTable DT = new DataTable();
        DataTable DT2 = new DataTable();
        public Consulter_location()
        {
            InitializeComponent();
        }

        private void Consulter_location_Load(object sender, EventArgs e)
        {
            Affiche_nomConducteur_combobox();
        }

        public void Affiche_nomConducteur_combobox()
        {
            connection.Open();
            string cmd = "select nomConducteur from Conducteur";
            SqlCommand command = new SqlCommand(cmd, connection);
            SqlDataReader SDR = command.ExecuteReader();
            while (SDR.Read())
            {
                comboBox1.Items.Add(SDR[0]);
            }
            SDR.Close();
            connection.Close();
        }

        public void Affiche_dgv1()
        {
            connection.Open();
            string cmd = "select * from Locationn where noPermis = (select noPermis from Conducteur where nomConducteur='"+comboBox1.SelectedItem+"')";
            SqlCommand command = new SqlCommand(cmd, connection);
            SqlDataReader SDR = command.ExecuteReader();
            DT.Load(SDR);
            dataGridView1.DataSource = DT;
            SDR.Close();
            connection.Close(); 
        }

        public void Affiche_dgv2()
        {
            connection.Open();
            string cmd = "select V.*,D.* from Voiture V,Dommage D,Locationn L where V.matricule=L.matricule and L.idLoc=D.idLoc and L.noPermis='" + dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString() + "'";
            SqlCommand command = new SqlCommand(cmd, connection);
            SqlDataReader SDR2 = command.ExecuteReader();
            //SqlDataAdapter SDA = new SqlDataAdapter(cmd, connection);
            MessageBox.Show("select V.*,D.* from Voiture V,Dommage D,Locationn L where V.matricule=L.matricule and L.idLoc=D.idLoc and L.noPermis='"+ dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()+"'");
            //SDA.Fill(DT2);
            DT2.Load(SDR2);
            dataGridView2.DataSource = DT2;
            SDR2.Close();
            connection.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex >-1)
            {
                Affiche_dgv1();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                Affiche_dgv2();
        }
    }
}
