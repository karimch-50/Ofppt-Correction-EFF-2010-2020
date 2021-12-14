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
    public partial class MAJ_Medicament : Form
    {
        public static string cnx = @"Data Source=DESKTOP-AT90UN0\SQLEXPRESS;Initial Catalog=EFF2018_TP_V2_1;Integrated Security=True";
        public SqlConnection connection = new SqlConnection(cnx);
        public SqlDataAdapter SDA = new SqlDataAdapter();
        public DataSet DS = new DataSet();
        public DataRow DR;

        public MAJ_Medicament()
        {
            InitializeComponent();
        }

        public static int pos;
        public void Navigation()
        {
            textBox1.Text = DS.Tables[0].Rows[pos][0].ToString();
            textBox2.Text = DS.Tables[0].Rows[pos][1].ToString();
            comboBox1.Text= DS.Tables[0].Rows[pos][2].ToString();
            dateTimePicker1.Text= DS.Tables[0].Rows[pos][3].ToString();
            textBox3.Text= DS.Tables[0].Rows[pos][4].ToString();
            textBox4.Text= DS.Tables[0].Rows[pos][5].ToString();
        }

        public void fill_dataset()
        {
            try
            {
                string cmd = "select*from Medicament";
                SDA = new SqlDataAdapter(cmd,connection);
                SDA.Fill(DS, "Medicament");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        public void fill_combobox()
        {
            comboBox1.Items.Add("comprimes");
            comboBox1.Items.Add("gelules");
            comboBox1.Items.Add("sirop");
            comboBox1.Items.Add("pommade");
        }

        private void MAJ_Medicament_Load(object sender, EventArgs e)
        {
            fill_dataset();
            fill_combobox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DR = DS.Tables[0].NewRow();
                DR[0] = textBox1.Text;
                DR[1] = textBox2.Text;
                DR[2] = comboBox1.SelectedItem.ToString();
                DR[3] = dateTimePicker1.Value.ToString();
                DR[4] = textBox3.Text;
                DR[5] = textBox4.Text;
                DS.Tables[0].Rows.Add(DR);
                MessageBox.Show("Ajout bien fait!!");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder SCB = new SqlCommandBuilder(SDA);
                SDA.Update(DS.Tables[0]);
                MessageBox.Show("Enregistrement bien fait!!");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pos = 0;
            Navigation();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                pos -= 1;
                Navigation();
            }
            catch
            {
                MessageBox.Show("Premier Element");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                pos += 1;
                Navigation();
            }
            catch
            {
                MessageBox.Show("Dernier Element");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pos = DS.Tables[0].Rows.Count-1;
            Navigation();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                bool ok = false;
                for (int i = 0; i < DS.Tables[0].Rows.Count - 1; i++)
                {
                    if (DS.Tables[0].Rows[i][1].ToString() == textBox1.Text)
                    {
                        ok = true;
                        DS.Tables[0].Rows[i].Delete();
                        break;
                    }
                }
                if (ok == false)
                {
                    MessageBox.Show("Element inotrovable");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                bool ok = false;
                for (int i = 0; i < DS.Tables[0].Rows.Count - 1; i++)
                {
                    if (DS.Tables[0].Rows[i][1].ToString() == textBox1.Text)
                    {
                        ok= true;
                        DS.Tables[0].Rows[i][1] = textBox2.Text;
                        DS.Tables[0].Rows[i][2] = comboBox1.SelectedItem;
                        DS.Tables[0].Rows[i][3] = dateTimePicker1.Value.ToString();
                        DS.Tables[0].Rows[i][4] = textBox3.Text;
                        DS.Tables[0].Rows[i][5] = textBox4.Text;
                    }
                }
                if (ok == false)
                {
                    MessageBox.Show("Element inotrovable");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
