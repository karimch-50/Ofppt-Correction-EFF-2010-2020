using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFF2019_V1_1_ADO
{
    public partial class MAJ_Asosiation : Form
    {
        public static string cnx = @"Data Source=DESKTOP-AT90UN0\SQLEXPRESS;Initial Catalog=EFF2019_V1_1;Integrated Security=True";
        public SqlConnection connection = new SqlConnection();
        public SqlDataReader SDR;
        public MAJ_Asosiation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string cmd = "insert into Association values("+textBox1.Text+",'"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"',"+textBox6.Text+")";
                SqlCommand command = new SqlCommand(cmd, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Ajout bien fait!!");
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
                string cmd = "select*from Association where Id_Ass="+textBox1.Text+"";
                SqlCommand command = new SqlCommand(cmd, connection);
                SDR = command.ExecuteReader();
                if (SDR.Read())
                {
                    textBox2.Text = SDR[1].ToString();
                    textBox3.Text = SDR[2].ToString();
                    textBox4.Text = SDR[3].ToString();
                    textBox5.Text = SDR[4].ToString();
                    textBox6.Text = SDR[5].ToString();
                }
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
                string cmd = "update Association set Nom_Ass='"+textBox2.Text+"',RaisonSocial='"+textBox3.Text+"',Adresse='"+textBox4.Text+"',Telephone='"+textBox5.Text+"',Id_Ville="+textBox6.Text+" where Id_Ass="+textBox1.Text+"";
                SqlCommand command = new SqlCommand(cmd, connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Modification bient fait!!");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void MAJ_Asosiation_Load(object sender, EventArgs e)
        {

        }
    }
}
