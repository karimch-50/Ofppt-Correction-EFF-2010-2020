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

namespace ADO_EFF2011_TP_V01
{
    public partial class List_Voyage_Assurer : Form
    {
        public static string cnx = @"Data Source=DESKTOP-SQH9NT6\SQLEXPRESS;Initial Catalog=EFF2011_TP_V01;Integrated Security=True";
        public SqlConnection connection = new SqlConnection(cnx);
        public SqlDataAdapter SDA;
        public DataSet DS = new DataSet();
        public DataRow DR;

        public List_Voyage_Assurer()
        {
            InitializeComponent();
        }

        private void List_Voyage_Assurer_Load(object sender, EventArgs e)
        {
            fill_combobo();
        }

        public void fill_combobo()
        {
            string cmd = "select nom from Personne";
            SDA = new SqlDataAdapter(cmd, connection);
            SDA.Fill(DS, "nom");
            for (int i = 0; i < DS.Tables["nom"].Rows.Count; i++)
            {
                comboBox1.Items.Add(DS.Tables["nom"].Rows[i][0].ToString());
            }
        }

        public void fill_dgv()
        {
            string cmd = "select V.* from Voyage V,Personne P where V.matricule=P.Matricule and P.Matricule=(select Matricule from Personne where nom='" + comboBox1.SelectedItem + "')";
            SDA = new SqlDataAdapter(cmd, connection);
            SDA.Fill(DS, "Voyage");
            dataGridView1.DataSource = DS.Tables["Voyage"];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fill_dgv();
        }
    }
}
