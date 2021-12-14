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
    public partial class info_Medcein : Form
    {
        public static string cnx = @"Data Source=DESKTOP-AT90UN0\SQLEXPRESS;Initial Catalog=EFF2018_TP_V2_1;Integrated Security=True";
        public SqlConnection connection = new SqlConnection(cnx);
        public SqlDataReader SDR;
        public SqlDataReader SDR2;
        public DataTable DT = new DataTable();

        public info_Medcein()
        {
            InitializeComponent();
        }

        string Num1 = Consultation_Medecin.Num_Medcin;

        private void info_Medcein_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string cmd = "select*from Medecin where NumMedecin=" + Convert.ToInt32(Num1) + "";
                SqlCommand command = new SqlCommand(cmd, connection);
                SDR = command.ExecuteReader();
                SDR.Read();
                label1.Text = SDR[0].ToString();
                label2.Text = SDR[1].ToString();
                label3.Text = SDR[2].ToString();
                label4.Text = SDR[3].ToString();
                connection.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            Fill_dgv();
        }

        public void Fill_dgv()
        {
            try
            {
                connection.Open();
                string cmd = "select NumOrdonnace,dateOrdonnace from Ordonnace where NumMedecin=" + Convert.ToInt32(Num1) + "";
                SqlCommand command = new SqlCommand(cmd, connection);
                SDR2 = command.ExecuteReader();
                DT.Load(SDR2);
                dataGridView1.DataSource = DT;
                connection.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
