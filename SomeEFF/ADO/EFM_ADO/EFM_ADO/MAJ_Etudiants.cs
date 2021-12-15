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

    
    public partial class MAJ_Etudiants : Form
    {
        public static string cnx = @"Data Source=DESKTOP-SQH9NT6\SQLEXPRESS;Initial Catalog=DB_EFM_ADO;Integrated Security=True";

        public SqlConnection connection = new SqlConnection(cnx);
        public DataTable DT = new DataTable();
        public MAJ_Etudiants()
        {
            InitializeComponent();
        }

        private void MAJ_Etudiants_Load(object sender, EventArgs e)
        {
            Fill_datatable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string cmd = "insert into Etudiant values(" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Value + "')";
                SqlCommand command = new SqlCommand(cmd,connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Ajout bien fait !!");
                connection.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string cmd = "update Etudiant set Nom='"+textBox2.Text+"',Prenom='"+textBox3.Text+"',Date_naiss='"+dateTimePicker1.Value+"' where CodeEtudiant="+textBox1.Text+"";
                SqlCommand command = new SqlCommand(cmd, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Modification bien fait !!");
                connection.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string cmd = "delete from Etudiant where CodeEtudiant=" + textBox1.Text + " ";
                SqlCommand command = new SqlCommand(cmd, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Supprition bien fait !!");
                connection.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        public void Fill_datatable()
        {
            connection.Open();
            string cmd = "select*from Etudiant";
            SqlCommand command = new SqlCommand(cmd,connection);
            SqlDataReader SDR = command.ExecuteReader();
            DT.Load(SDR);
            connection.Close();
        }

        public int pos;
        public void Navigation()
        {
            textBox1.Text = DT.Rows[pos][0].ToString();
            textBox2.Text = DT.Rows[pos][1].ToString();
            textBox3.Text = DT.Rows[pos][2].ToString();
            dateTimePicker1.Text = DT.Rows[pos][3].ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pos = 0;
            Navigation();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                pos -= 1;
                Navigation();
            }
            catch
            {
                MessageBox.Show("Premier Element !!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                pos += 1;
                Navigation();
            }
            catch
            {
                MessageBox.Show("Dernier Element !!");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pos = DT.Rows.Count-1;
            Navigation();
        }
    }
}
