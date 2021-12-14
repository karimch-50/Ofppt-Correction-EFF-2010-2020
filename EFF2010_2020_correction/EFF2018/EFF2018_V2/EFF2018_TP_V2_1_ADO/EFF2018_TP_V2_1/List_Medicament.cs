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
    public partial class List_Medicament : Form
    {
        public static string cnx = @"Data Source=DESKTOP-AT90UN0\SQLEXPRESS;Initial Catalog=EFF2018_TP_V2_1;Integrated Security=True";
        public SqlConnection connection = new SqlConnection(cnx);
        public SqlDataAdapter SDA = new SqlDataAdapter();
        public DataSet DS = new DataSet();

        public List_Medicament()
        {
            InitializeComponent();
        }

        private void List_Medicament_Load(object sender, EventArgs e)
        {
            fill_combobox();
        }

        public void fill_combobox()
        {
            comboBox1.Items.Add("comprimes");
            comboBox1.Items.Add("gelules");
            comboBox1.Items.Add("sirop");
            comboBox1.Items.Add("pommade");
        }

        public void fill_dgv()
        {
            try
            {
                string cmd = "select NumMedicament,designation,datePeremptin,StockActuel,StockMin from Medicament where forme='" + comboBox1.SelectedItem+"'";
                SDA = new SqlDataAdapter(cmd,connection);
                SDA.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    TimeSpan difference = Convert.ToDateTime(DS.Tables[0].Rows[i][2].ToString()) - DateTime.Now;
                    if (difference.Days < 30)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                     if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value.ToString())== Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value.ToString()))
                     {
                         dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                     }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fill_dgv();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
