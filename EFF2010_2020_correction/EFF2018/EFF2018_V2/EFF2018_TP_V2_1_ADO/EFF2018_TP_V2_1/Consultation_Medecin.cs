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

namespace EFF2018_TP_V2_1
{
    public partial class Consultation_Medecin : Form
    {
        public static string Num_Medcin;
        public static string cnx = @"Data Source=DESKTOP-AT90UN0\SQLEXPRESS;Initial Catalog=EFF2018_TP_V2_1;Integrated Security=True";
        public SqlConnection connection = new SqlConnection(cnx);
        //public SqlDataAdapter SDA ;
        public SqlDataReader SDR;
        public SqlDataReader SDR1;
        public DataTable DT = new DataTable();
        //public DataSet DS = new DataSet();

        public Consultation_Medecin()
        {
            InitializeComponent();
        }

        public void fill_combobox()
        {
            try
            {
                connection.Open();
                string cmd = "select specialite from Medecin";
                SqlCommand command = new SqlCommand(cmd,connection);
                SDR=command.ExecuteReader();
                while (SDR.Read())
                {
                    comboBox1.Items.Add(SDR[0]);
                }
                connection.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        public void fill_dgv()
        {
            try
            {
                connection.Open();
                string cmd = "exec P1 "+ comboBox1.SelectedItem.ToString()+ "";
                SqlCommand command1 = new SqlCommand(cmd, connection);
                SDR1 =command1.ExecuteReader();
                DT.Load(SDR1);
                dataGridView1.DataSource = DT;
                connection.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Consultation_Medecin_Load(object sender, EventArgs e)
        {
            fill_combobox();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewButtonCell b = new DataGridViewButtonCell();
            //int rowIndex = MainTable.Rows.Add(b);
            //MainTable.Rows[rowIndex].Cells[0].Value = "name";
            this.Hide();
            info_Medcein I = new info_Medcein();
            I.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fill_dgv();
            Num_Medcin = dataGridView1.Rows[0].Cells[1].Value.ToString();
        }
    }
}
