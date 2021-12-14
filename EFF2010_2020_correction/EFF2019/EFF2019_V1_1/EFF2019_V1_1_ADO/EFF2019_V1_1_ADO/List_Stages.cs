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
using System.IO;

namespace EFF2019_V1_1_ADO
{
    public partial class List_Stages : Form
    {
        public static string cnx = @"Data Source=DESKTOP-AT90UN0\SQLEXPRESS;Initial Catalog=EFF2019_V1_1;Integrated Security=True";
        public SqlConnection connection = new SqlConnection(cnx);
        public SqlDataReader SDR;
        public SqlDataAdapter SDA1;
        public SqlDataAdapter SDA2;
        public DataTable DT = new DataTable();
        public DataSet DS = new DataSet();
        public DataSet DS2 = new DataSet();
        public BindingManagerBase BMB;

        public List_Stages()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                try
                {
                    connection.Open();
                    string com = "select*from Stage where Date_Debut='" + textBox1.Text + "' and date_Fin='" + textBox2.Text + "'";
                    SDA1 = new SqlDataAdapter(com, connection);
                    SDA1.Fill(DS, "Stage");
                    dataGridView1.DataSource = DS.Tables[0];
                    BMB = this.BindingContext[DS.Tables[0]];
                    connection.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
               
            }
            if (radioButton2.Checked == true)
            {
                try
                {
                    connection.Open();
                    string cmd = "select*from Stage where Id_Association=" + comboBox1.Text + "";
                    SDA1 = new SqlDataAdapter(cmd, connection);
                    SDA1.Fill(DS, "Stage");
                    dataGridView1.DataSource = DS.Tables[0];
                    BMB = this.BindingContext[DS.Tables[0]];
                    connection.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void List_Stages_Load(object sender, EventArgs e)
        {
            Fillcombo();
        }

        public void Fillcombo()
        {
            try
            {
                connection.Open();
                string cmd = "select Id_Ass from Association";
                SqlCommand command = new SqlCommand(cmd, connection);
                SDR = command.ExecuteReader();
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string cmd = "select*from Association where Id_Ass=" + comboBox1.Text + "";
                SDA2 = new SqlDataAdapter(cmd, connection);
                SDA2.Fill(DS2);
                DS2.WriteXml("test.xml");
                connection.Close();
                MessageBox.Show("Exportation bien fait!!");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            string id = dataGridView1.Rows[index].Cells[0].Value.ToString();
            try
            {
                DS2.Clear();
                connection.Open();
                string cmd = "select D.Id_Inscription,D.date_Demende,D.Id_Volentaire,D.Id_Stage,V.Nom_Vlt,V.Prenom_Vlt,D.Etat from Demende_Inscription D,Volontaire V where D.Id_Volentaire=V.Id_Vlt and D.Id_Stage="+ id + "";
                SDA2 = new SqlDataAdapter(cmd, connection);
                SDA2.Fill(DS2);
                dataGridView2.DataSource = DS2.Tables[0];
                connection.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
