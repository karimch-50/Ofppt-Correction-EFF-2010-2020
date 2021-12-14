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

namespace EFF2012_V7_ADO
{
    public partial class Liste_Entretien : Form
    {
        public static string cnx = @"Data Source=DESKTOP-AT90UN0\SQLEXPRESS;Initial Catalog=EFF2012_V7;Integrated Security=True";
        public SqlConnection connection = new SqlConnection(cnx);
        public SqlDataReader SDR;
        public DataTable DT = new DataTable();
        public DataRow DR;

        public Liste_Entretien()
        {
            InitializeComponent();
        }

        private void Liste_Entretien_Load(object sender, EventArgs e)
        {
            fillCmbo();
        }

        public void fillCmbo()
        {
            try
            {
                connection.Open();
                string cmd = "select immat from Vehicule";
                SqlCommand command = new SqlCommand(cmd, connection);
                SDR = command.ExecuteReader();
                while (SDR.Read())
                {
                    comboBox1.Items.Add(SDR[0].ToString());
                }
                connection.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        public void fillDGV()
        {
            try
            {
                DT.Clear();
                connection.Open();
                string cmd = "select E1.nomEntretien,E2.dateEbtretien, E1.kilometrage from Entretien E1,EntrVehicule E2 where E1.idEntretien=E2.idEntretien and E2.immat='"+comboBox1.Text+"'";
                SqlCommand command = new SqlCommand(cmd, connection);
                SDR = command.ExecuteReader();
                DT.Load(SDR);
                dataGridView1.DataSource = DT;
                connection.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillDGV();
        }
    }
}
