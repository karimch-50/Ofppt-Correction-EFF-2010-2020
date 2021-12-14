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
    public partial class Imprimer_Calendrier : Form
    {
        CrystalReport1 C1 = new CrystalReport1();
        public static string cnx = @"Data Source=DESKTOP-SQH9NT6\SQLEXPRESS;Initial Catalog=EFF2011_TP_V01;Integrated Security=True";
        public SqlConnection connection = new SqlConnection(cnx);
        public SqlDataAdapter SDA;
        public DataSet DS = new DataSet();

        public Imprimer_Calendrier()
        {
            InitializeComponent();
        }

        private void Imprimer_Calendrier_Load(object sender, EventArgs e)
        {
            fill_comboboxs();
        }

        public void fill_comboboxs()
        {
            string cmd = "select*from Ligne";
            SDA = new SqlDataAdapter(cmd, connection);
            SDA.Fill(DS, "Ligne");
            for (int i = 0; i < DS.Tables["Ligne"].Rows.Count; i++)
            {
                comboBox1.Items.Add(DS.Tables["Ligne"].Rows[i][0].ToString());
                comboBox2.Items.Add(DS.Tables["Ligne"].Rows[i][2].ToString());
                comboBox3.Items.Add(DS.Tables["Ligne"].Rows[i][3].ToString());
            }

        }

        public void combobox_selected()
        {
            if (comboBox1.SelectedIndex > -1 && comboBox2.SelectedIndex > -1 && comboBox3.SelectedIndex > -1 )
            {
                C1.SetParameterValue("code_ligne", comboBox1.SelectedItem);
                C1.SetParameterValue("#code_ville_depart", comboBox2.SelectedItem);
                C1.SetParameterValue("#code_ville_arrivee", comboBox3.SelectedItem);
                crystalReportViewer1.ReportSource = C1;
                crystalReportViewer1.Refresh();
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            combobox_selected();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            combobox_selected();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            combobox_selected();
        }

    }
}
