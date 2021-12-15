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

namespace EFM_theme
{
    public partial class AfficherCommentaire : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JJRVRIH\YOUSSEFSQL;Initial Catalog=EFM_theme;Integrated Security=True");
        DataSet ds = new DataSet();
        SqlDataAdapter sda = new SqlDataAdapter();
        public AfficherCommentaire()
        {
            InitializeComponent();
        }

        private void AfficherCommentaire_Load(object sender, EventArgs e)
        {
            con.Open();

            sda = new SqlDataAdapter("select * from Membre",con);
            sda.Fill(ds,"Membre");
            comboBox1.DataSource = ds.Tables["Membre"];
            comboBox1.DisplayMember = "nom";

            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("select c.* from Membre m, Commentaire c where c.loginn = m.login and m.nom = '"
                + comboBox1.Text + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                dr.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR : " + ex.Message);
            }
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            con.Open();
            int index = dataGridView1.CurrentRow.Index;
            int code_id = int.Parse( dataGridView1.Rows[index].Cells[3].Value.ToString());
                SqlCommand cmd = new SqlCommand("select description_id from IdeeDeco"
                + " where code_id =" + code_id, con);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            MessageBox.Show("Description :" + dr[0].ToString());
            con.Close();
        }
    }
}
