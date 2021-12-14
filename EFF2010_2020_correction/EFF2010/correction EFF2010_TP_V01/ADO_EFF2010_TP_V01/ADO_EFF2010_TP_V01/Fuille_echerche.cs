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

namespace ADO_EFF2010_TP_V01
{
    public partial class Fuille_echerche : Form
    {
        public static string con = @"Data Source=DESKTOP-SQH9NT6\SQLEXPRESS;Initial Catalog=EFF2010_TP_V01;Integrated Security=True";
        public SqlConnection connection = new SqlConnection(con);
        public SqlDataAdapter SDA;
        public DataSet DS = new DataSet();
        public Fuille_echerche()
        {
            InitializeComponent();
        }

        private void Fuille_echerche_Load(object sender, EventArgs e)
        {
            combobox_Nom_hopital();
        }

        public void combobox_Nom_hopital()
        {
            string cmd = "select IdHopital from Hopital";
            SDA = new SqlDataAdapter(cmd,connection);
            SDA.Fill(DS);
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                comboBox1.Items.Add(DS.Tables[0].Rows[i][0]);
            }
        }

        public void Affiche_dgv()
        {
            string cmd = "select H.Nom,count(S.NBLits),count(M.IdMedecin),S.IdService from Servicee S,Hopital H,Medecin M where S.IdService=M.IdService and H.IdHopital=M.IdService and H.Nom =(select Nom from Hopital where IdHopital=" + comboBox1.SelectedItem + ") group by S.IdService,H.Nom";
            SDA = new SqlDataAdapter(cmd, connection);
            SDA.Fill(DS, "T1");
            dataGridView1.DataSource = DS.Tables["T1"];
        }

        public void Affiche_dgv_Patient()
        {
            string cmd = "select P.* from Sejourne S,Patient p where S.IdPatient=P.IdPatient and DateSortie='" + dateTimePicker1.Value + "'";
            SDA = new SqlDataAdapter(cmd, connection);
            SDA.Fill(DS, "T2");
            dataGridView1.DataSource = DS.Tables["T2"];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Affiche_dgv();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Affiche_dgv_Patient();
        }
    }
}
