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
    public partial class MAJ_Examents : Form
    {
        public static string cnx = @"Data Source=DESKTOP-SQH9NT6\SQLEXPRESS;Initial Catalog=DB_EFM_ADO;Integrated Security=True";
        public SqlConnection connection = new SqlConnection(cnx);

        public MAJ_Examents()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string cmd = "insert into Examen values(" + textBox1.Text + "," + textBox2.Text + ",'" + dateTimePicker1.Value + "'," + textBox3.Text + ")";
                SqlCommand command = new SqlCommand(cmd, connection);
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
                string cmd = "update Examen set NumCours=" + textBox2.Text + ",Datee='" + dateTimePicker1.Value + "',Note=" + textBox3.Text + " where CodeEtudiant=" + textBox1.Text + "";
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
                string cmd = "delete from Examen where CodeEtudiant=" + textBox1.Text + " ";
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

        private void MAJ_Examents_Load(object sender, EventArgs e)
        {

        }
    }
}
