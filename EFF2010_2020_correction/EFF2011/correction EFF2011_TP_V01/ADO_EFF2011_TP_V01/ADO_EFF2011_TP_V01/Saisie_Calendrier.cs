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
    public partial class Saisie_Calendrier : Form
    {
        public static string cnx = @"Data Source=DESKTOP-SQH9NT6\SQLEXPRESS;Initial Catalog=EFF2011_TP_V01;Integrated Security=True";
        public SqlConnection connection = new SqlConnection(cnx);
        public SqlDataAdapter SDA;
        public DataSet DS = new DataSet();
        public DataRow DR;

        public Saisie_Calendrier()
        {
            InitializeComponent();
        }

        private void Saisie_Calendrier_Load(object sender, EventArgs e)
        {
            fill_combobox();
            fill_dgv();
        }

        public void fill_combobox()
        {
            string cmd = "select code_ligne from Ligne";
            SDA = new SqlDataAdapter(cmd,connection);
            SDA.Fill(DS,"code_ligne");
            for (int i = 0; i < DS.Tables["code_ligne"].Rows.Count; i++)
            {
                comboBox1.Items.Add(DS.Tables["code_ligne"].Rows[i][0].ToString());
            }
        }
        public void fill_dgv()
        {
            string cmd = "select*from Calendrier";
            SDA = new SqlDataAdapter(cmd, connection);
            SDA.Fill(DS, "Calendrier");
            dataGridView1.Columns.Add("code_calendrier", "code_calendrier");
            dataGridView1.Columns.Add("jour_voyage", "jour_voyage");
            dataGridView1.Columns.Add("heur_depart", "heur_depart");
            dataGridView1.Columns.Add("heur_arrivee", "heur_arrivee");
            dataGridView1.Columns.Add("code_ligne", "code_ligne");
            for (int i = 0; i < DS.Tables["Calendrier"].Rows.Count;i++)
            {
                dataGridView1.Rows.Add(DS.Tables["Calendrier"].Rows[i][0],
                                       DS.Tables["Calendrier"].Rows[i][1],
                                       DS.Tables["Calendrier"].Rows[i][2],
                                       DS.Tables["Calendrier"].Rows[i][3],
                                       DS.Tables["Calendrier"].Rows[i][4]);
            }
            dataGridView1.Rows.Add();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DR = DS.Tables["Calendrier"].NewRow();
            DR[0] =  dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells["code_calendrier"].Value;
            DR[1] =  dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells["jour_voyage"].Value;
            DR[2] =  dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells["heur_depart"].Value;
            DR[3] =  dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells["heur_arrivee"].Value;
            DR[4] = comboBox1.SelectedItem;
            DS.Tables["Calendrier"].Rows.Add(DR);
            MessageBox.Show("Ajout bien fait!!");
            //SqlCommandBuilder SCB = new SqlCommandBuilder(SDA);
            //SDA.Update(DS.Tables["Calendrier"]);
            dataGridView1.Rows.Add();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
