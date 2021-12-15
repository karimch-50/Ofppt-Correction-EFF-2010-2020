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
    public partial class MAJ_Cours : Form
    {
        public static string cnx = @"Data Source=DESKTOP-SQH9NT6\SQLEXPRESS;Initial Catalog=DB_EFM_ADO;Integrated Security=True";
        public SqlConnection connection = new SqlConnection(cnx);

        public MAJ_Cours()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string cmd = "insert into Cours values(" + textBox1.Text + "," + textBox2.Text + "," + textBox3.Text + ",'" + textBox4.Text + "'," + textBox5.Text + ")";
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

        private void MAJ_Cours_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string cmd = "update Cours set NumSalle=" + textBox2.Text + ",MatriculeProfesseur=" + textBox3.Text + ",Titre='" + textBox4.Text + "',Coef ="+textBox5.Text+" where NumCours=" + textBox1.Text + "";
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
                string cmd = "delete from Cours where NumCours=" + textBox1.Text + " ";
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

    }
}
