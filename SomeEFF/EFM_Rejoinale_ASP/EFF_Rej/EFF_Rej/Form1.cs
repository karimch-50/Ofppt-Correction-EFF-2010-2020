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

namespace EFF_Rej
{
    public partial class Form1 : Form
    {
        public static string cnx = @"Data Source = DESKTOP-AT90UN0\SQLEXPRESS;Initial Catalog = EFM_Rej; Integrated Security = True";
        public SqlConnection connection = new SqlConnection(cnx);
        public SqlDataAdapter SDA;
        public DataRow DR;
        public DataSet DS = new DataSet();
        public DataSet DS1 = new DataSet();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filDS();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DR = DS.Tables[0].NewRow();
            DR[0] = textBox1.Text;
            DR[1] = textBox2.Text;
            DR[2] = textBox3.Text;
            DR[3] = textBox4.Text;
            DR[4] = textBox5.Text;
            DS.Tables[0].Rows.Add(DR);
            MessageBox.Show("Ajout bien fait !!");
        }

        public void filDS()
        {
            string cmd = "select*from PROPEIETAIRE";
            SDA = new SqlDataAdapter(cmd, connection);
            SDA.Fill(DS);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DS.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                if (DS.Tables[0].Rows[i][0].ToString() == textBox1.Text)
                {
                    DS.Tables[0].Rows[i].Delete();
                }
            }
            MessageBox.Show("Suprission bient Fait!!");
        }

        public static int pos;
        public void Navigation()
        {
            textBox1.Text = DS.Tables[0].Rows[pos][0].ToString();
            textBox2.Text = DS.Tables[0].Rows[pos][1].ToString();
            textBox3.Text = DS.Tables[0].Rows[pos][2].ToString();
            textBox4.Text = DS.Tables[0].Rows[pos][3].ToString();
            textBox5.Text = DS.Tables[0].Rows[pos][4].ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pos = 0;
            Navigation();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pos =DS.Tables[0].Rows.Count-1;
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
                MessageBox.Show("Premier Elemet!!");
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
                MessageBox.Show("Dernier Elemet!!");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DS.WriteXml("test.xml");
            MessageBox.Show("Expotation bient Fait!!");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DS1.ReadXml("test.xml");
            dataGridView1.DataSource = DS1.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count ; i++)
                {
                    if (DS.Tables[0].Rows[i][0].ToString() == textBox1.Text)
                    {
                        DS.Tables[0].Rows[i][1] = textBox2.Text.ToString();
                        DS.Tables[0].Rows[i][2] = textBox3.Text.ToString();
                        DS.Tables[0].Rows[i][3] = textBox4.Text.ToString();
                        DS.Tables[0].Rows[i][4] = textBox5.Text.ToString();
                    }
                }
                MessageBox.Show("Modification bient Fait!!");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            bool ok = false;
             for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
             {
                 if (DS.Tables[0].Rows[i][0].ToString() == textBox1.Text)
                 {
                    textBox2.Text = DS.Tables[0].Rows[i][1].ToString();
                    textBox3.Text = DS.Tables[0].Rows[i][2].ToString();
                    textBox4.Text = DS.Tables[0].Rows[i][3].ToString();
                    textBox5.Text = DS.Tables[0].Rows[i][4].ToString();
                    ok = true;
                 }
             }
            if (ok==false)
            {
                MessageBox.Show("Element inotrouvable!!");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder SCB = new SqlCommandBuilder(SDA);
            SDA.Update(DS.Tables[0]);
            MessageBox.Show("Enregistrement bient fait!!");
        }
    }
}
