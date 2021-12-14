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
    public partial class Mise_Jour_Voiture : Form
    {
        public static string con = @"Data Source=DESKTOP-SQH9NT6\SQLEXPRESS;Initial Catalog=ADO_EFF2018_V1_2;Integrated Security=True";
        public SqlConnection connection = new SqlConnection(con);
        DataTable DT = new DataTable();
        public Mise_Jour_Voiture()
        {
            InitializeComponent();
        }

        private void Mise_Jour_Voiture_Load(object sender, EventArgs e)
        {
            Id_mark_combobox();
            affichage_data();
        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string cmd = "insert into Voiture values("+textBox1.Text+",'"+textBox2.Text+"',"+textBox3.Text+","+comboBox1.SelectedItem+")";
                SqlCommand command = new SqlCommand(cmd,connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Ajout bient fait");
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string cmd = "delete from Voiture where matricule =" + textBox1.Text + "";
                SqlCommand command = new SqlCommand(cmd, connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Supprition bient fait");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string cmd = "update Voiture set modele = '" + textBox2.Text + "' and prixLocation = " + textBox3.Text + " and idMarq = " + comboBox1.SelectedItem + " where matricule =" + textBox1.Text + "";
                SqlCommand command = new SqlCommand(cmd, connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Modification bient fait");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        public void Id_mark_combobox()
        {
            connection.Open();
            string cmd = "select idMarq from Voiture";
            SqlCommand command = new SqlCommand(cmd,connection);
            SqlDataReader SDR = command.ExecuteReader();
            while(SDR.Read())
            {
                comboBox1.Items.Add(SDR[0]);
            }
            SDR.Close();
            connection.Close();
        }

        public void affichage_data()
        {
            connection.Open();
            string cmd = "select*from Voiture";
            SqlCommand command = new SqlCommand(cmd,connection);
            SqlDataReader SDR = command.ExecuteReader();
            DT.Load(SDR);
            connection.Close();
        }

        public int position;
        public void Navigation()
        {
            textBox1.Text = DT.Rows[position][0].ToString();
            textBox2.Text = DT.Rows[position][1].ToString();
            textBox3.Text = DT.Rows[position][2].ToString();
            comboBox1.Text = DT.Rows[position][3].ToString();
        }

        private void btn_Premier_Click(object sender, EventArgs e)
        {
            position = 0;
            Navigation();
        }

        private void btn_Dernier_Click(object sender, EventArgs e)
        {
            position = DT.Rows.Count-1;
            Navigation();
        }

        private void btn_precedant_Click(object sender, EventArgs e)
        {
            try
            {
                position -= 1;
                Navigation();
            }
            catch
            {
                MessageBox.Show("Premier Element !!");
            }
        }

        private void btn_suivant_Click(object sender, EventArgs e)
        {
            try
            {
                position += 1;
                Navigation();
            }
            catch
            {
                MessageBox.Show("Dernier Element !!");
            }
        }
    }
}
