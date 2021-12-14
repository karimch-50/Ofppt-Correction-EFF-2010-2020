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
    public partial class Medecin : Form
    {
        public static string con = @"Data Source=DESKTOP-SQH9NT6\SQLEXPRESS;Initial Catalog=EFF2010_TP_V01;Integrated Security=True";
        public SqlConnection connection = new SqlConnection(con);
        public SqlDataAdapter SDA;
        public DataSet DS = new DataSet();
        public DataRow DR;
        public DataRow DR1;

        public Medecin()
        {
            InitializeComponent();
        }

        private void Medecin_Load(object sender, EventArgs e)
        {
            contenu_Medecin();
        }


        public void contenu_Medecin()
        {
            string cmd = "select*from Medecin";
            SDA = new SqlDataAdapter(cmd, connection);
            SDA.Fill(DS);
        }

        public int position;
        public void Navigation()
        {
            textBox1.Text = DS.Tables[0].Rows[position][0].ToString();
            textBox2.Text = DS.Tables[0].Rows[position][1].ToString();
            textBox3.Text = DS.Tables[0].Rows[position][2].ToString();
            textBox4.Text = DS.Tables[0].Rows[position][3].ToString();
            textBox5.Text = DS.Tables[0].Rows[position][4].ToString();
            textBox6.Text = DS.Tables[0].Rows[position][5].ToString();
            textBox7.Text = DS.Tables[0].Rows[position][6].ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            position = 0;
            Navigation();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                position -= 1;
                Navigation();
            }
            catch
            {
                MessageBox.Show("Premier Element!!");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                position += 1;
                Navigation();
            }
            catch
            {
                MessageBox.Show("Dernier Element!!");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            position = DS.Tables[0].Rows.Count-1;
            Navigation();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu m = new Menu();
            m.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder SCB = new SqlCommandBuilder(SDA);
            SDA.Update(DS);
            MessageBox.Show("Enregistrement bien fait !!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DR = DS.Tables[0].NewRow();
            DR[0] = textBox1.Text;
            DR[1] = textBox2.Text;
            DR[2] = textBox3.Text;
            DR[3] = textBox4.Text;
            DR[4] = textBox5.Text;
            DR[5] = textBox6.Text;
            DR[6] = textBox7.Text;
            DS.Tables[0].Rows.Add(DR);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int pos = -1;
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    if (textBox1.Text == DS.Tables[0].Rows[i][0].ToString())
                    {
                        pos = i;
                    }
                }
                if (pos > -1)
                {
                    DS.Tables[0].Rows[pos].Delete();
                }
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
                int pos = -1;
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    if (textBox1.Text == DS.Tables[0].Rows[i][0].ToString())
                    {
                        pos = i;
                    }
                }
                if (pos > -1)
                {
                    if (!(String.IsNullOrEmpty(textBox2.Text)) && !(String.IsNullOrEmpty(textBox3.Text)) && !(String.IsNullOrEmpty(textBox4.Text)) && !(String.IsNullOrEmpty(textBox5.Text)) && !(String.IsNullOrEmpty(textBox6.Text)))
                    {
                        DS.Tables[0].Rows[pos][1] = textBox2.Text;
                        DS.Tables[0].Rows[pos][2] = textBox3.Text;
                        DS.Tables[0].Rows[pos][3] = textBox4.Text;
                        DS.Tables[0].Rows[pos][4] = textBox5.Text;
                        DS.Tables[0].Rows[pos][5] = textBox6.Text;
                        DS.Tables[0].Rows[pos][6] = textBox7.Text;
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
