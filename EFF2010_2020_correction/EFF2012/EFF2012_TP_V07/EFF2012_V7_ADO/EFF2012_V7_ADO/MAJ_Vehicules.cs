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
    public partial class MAJ_Vehicules : Form
    {
        public static string cnx = @"Data Source=DESKTOP-AT90UN0\SQLEXPRESS;Initial Catalog=EFF2012_V7;Integrated Security=True";
        public SqlConnection connection = new SqlConnection(cnx);
        public SqlDataReader SDR;
        public SqlDataAdapter SDA;
        public DataSet DS = new DataSet();
        public DataRow DR ;

        public MAJ_Vehicules()
        {
            InitializeComponent();
        }

        public void fillDS()
        {
            string cmd = "select*from Vehicule";
            SDA = new SqlDataAdapter(cmd, connection);
            SDA.Fill(DS);
        }

        public void fillCmbo()
        {
            try
            {
                connection.Open();
                string cmd = "select idconducteur from Conducteur";
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DR = DS.Tables[0].NewRow();
                DR[0] = textBox1.Text;
                DR[1] = textBox2.Text;
                DR[2] = textBox3.Text;
                DR[3] = textBox4.Text;
                DR[4] = textBox5.Text;
                DR[5] = dateTimePicker1.Text;
                DR[6] = textBox6.Text;
                DR[7] = comboBox1.Text;
                DS.Tables[0].Rows.Add(DR);
                MessageBox.Show("Ajout bien fait!!");
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
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    if (DS.Tables[0].Rows[i][0].ToString() == textBox1.Text)
                    {
                        DS.Tables[0].Rows[i][1] = textBox2.Text;
                        DS.Tables[0].Rows[i][2] = textBox3.Text;
                        DS.Tables[0].Rows[i][3] = textBox4.Text;
                        DS.Tables[0].Rows[i][4] = textBox5.Text;
                        DS.Tables[0].Rows[i][5] = dateTimePicker1.Text;
                        DS.Tables[0].Rows[i][6] = textBox6.Text;
                        DS.Tables[0].Rows[i][7] = comboBox1.Text;
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void MAJ_Vehicules_Load(object sender, EventArgs e)
        {
            fillCmbo();
            fillDS();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    if (DS.Tables[0].Rows[i][0].ToString() == textBox1.Text)
                    {
                        DS.Tables[0].Rows[i].Delete();
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder SCB = new SqlCommandBuilder(SDA);
            SDA.Update(DS);
        }

        public static int pos;
        public void Navigation()
        {
            textBox1.Text = DS.Tables[0].Rows[pos][0].ToString();
            textBox2.Text = DS.Tables[0].Rows[pos][1].ToString();
            textBox3.Text = DS.Tables[0].Rows[pos][2].ToString();
            textBox4.Text = DS.Tables[0].Rows[pos][3].ToString();
            textBox5.Text = DS.Tables[0].Rows[pos][4].ToString();
            dateTimePicker1.Text = DS.Tables[0].Rows[pos][5].ToString();
            textBox6.Text = DS.Tables[0].Rows[pos][6].ToString();
            comboBox1.Text = DS.Tables[0].Rows[pos][7].ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pos = 0;
            Navigation();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                pos -= 1;
                Navigation();
            }
            catch
            {
                MessageBox.Show("Premier Element !!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                pos += 1;
                Navigation();
            }
            catch
            {
                MessageBox.Show("Dernier Element!!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pos = DS.Tables[0].Rows.Count-1;
            Navigation();
        }
    }
}