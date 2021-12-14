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

namespace Certificat
{
    public partial class Form1 : Form
    {
        int pos = 0;
        SqlConnection cnx;
        SqlCommand cmd;
        SqlDataReader cr;
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            cmd = new SqlCommand("insert into certificat values(" + textBox1.Text + ",'" + textBox2.Text + "','" + dateTimePicker1.Value + "'," +
                "'" + dateTimePicker2.Value + "',"+comboBox1.SelectedValue+","+comboBox2.SelectedValue+")",cnx);

            
            cnx.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Ajoutée avec succés !");
            vider();
            cnx.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cnx = new SqlConnection("data source = DESKTOP-L2AE833;database=eff2017;integrated security = true");
            cmd = new SqlCommand("select * from Auteur", cnx);
            dt = new DataTable();
            cnx.Open();
            dt.Load(cmd.ExecuteReader());
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "nom";
            comboBox1.ValueMember = "num_auteur";
            comboBox1.SelectedIndex = -1;
            cnx.Close();
            cmd = new SqlCommand("select * from Innovation", cnx);
            dt = new DataTable();
            cnx.Open();
            dt.Load(cmd.ExecuteReader());
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "descriptif";
            comboBox2.ValueMember = "num_Innovation";
            comboBox2.SelectedIndex = -1;
            cnx.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new  SqlCommand("delete from Certificat where num_Certificat=" + textBox1.Text + "", cnx);
            cnx.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Supprimer avec succés !");
            vider();
            cnx.Close();
        }
        void vider()
        {
            textBox1.Clear();
            textBox2.Clear();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("update Certificat set description='" + textBox2.Text + "',date_depot='" + dateTimePicker1.Value + "',date_validation='" + dateTimePicker2.Value + "'" +
                ",num_auteur=" + comboBox1.SelectedValue + ",num_innovation=" + comboBox2.SelectedValue + "");
            cnx.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Modifier avec succés !");
            cnx.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pos = 0;
            getpos();
        }
        void getpos()
        {
            cmd = new SqlCommand("select * from Certificat", cnx);
            cnx.Open();
            cr = cmd.ExecuteReader();
            for (int i = 0; i <= pos; i++)
            {
                if (cr.Read())
                {
                    textBox1.Text = cr[0].ToString();
                    textBox2.Text = cr[1].ToString();
                    dateTimePicker1.Value = DateTime.Parse(cr[2].ToString());
                    dateTimePicker2.Value = DateTime.Parse(cr[3].ToString());
                    comboBox1.SelectedValue = int.Parse(cr[4].ToString());
                    comboBox2.SelectedValue = int.Parse(cr[5].ToString());
                }
                
            }
            cnx.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pos++;
            if(pos < cpt())
            {
                getpos();
            }
            else
            {
                MessageBox.Show("vous avez deppassé la limite !");
            }
            
        }
        int cpt()
        {
            int count = 0;
            cmd = new SqlCommand("select count(*) from Certificat", cnx);
            cnx.Open();
            cr = cmd.ExecuteReader();
            if (cr.Read())
            {
                count = int.Parse(cr[0].ToString());
            }
            cnx.Close();

            return count;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pos--;
            if (pos >= 0)
            {
                getpos();
            }
            else
            {
                MessageBox.Show("vous avez deppassé la limite !");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pos = cpt();
            getpos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from certificat",cnx);
            dt = new DataTable("Certificats");
            cnx.Open();
            cr = cmd.ExecuteReader();
            dt.Load(cr);
            dt.WriteXml("eff2017.xml");
            dt.WriteXmlSchema("eff2017shema.xml");
            cnx.Close();
        }
    }
}
