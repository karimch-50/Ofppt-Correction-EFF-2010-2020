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
    public partial class Rechercher : Form
    {
        SqlConnection cnx;
        SqlCommand cmd;
        SqlDataReader cr;
        DataTable dt;
        public Rechercher()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                groupBox1.Visible = true;
            }
            if (checkBox1.Checked == false)
            {
                groupBox1.Visible = false;
            }
        }

        private void Rechercher_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            cnx = new SqlConnection("data source = HaithamJelfaoui;database=EFF2017;integrated security = true;");

            cmd = new SqlCommand("select * from Innovation", cnx);
            dt = new DataTable();
            cnx.Open();
            dt.Load(cmd.ExecuteReader());
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "descriptif";
            comboBox2.ValueMember = "num_Innovation";
            comboBox2.SelectedIndex = -1;
            cnx.Close();
            cmd = new SqlCommand("select * from Auteur", cnx);
            dt = new DataTable();
            cnx.Open();
            dt.Load(cmd.ExecuteReader());
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "nom";
            comboBox1.ValueMember = "num_auteur";
            comboBox1.SelectedIndex = -1;
            cnx.Close();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                groupBox2.Visible = true;
            }
            if (checkBox2.Checked == false)
            {
                groupBox2.Visible = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                groupBox3.Visible = true;
            }
            if (checkBox3.Checked == false)
            {
                groupBox3.Visible = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                groupBox4.Visible = true;
            }
            if (checkBox4.Checked == false)
            {
                groupBox4.Visible = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                groupBox5.Visible = true;
            }
            if (checkBox5.Checked == false)
            {
                groupBox5.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false && checkBox5.Checked == false)
            {
                MessageBox.Show("Choisissez un critaure");
            }
            else
            {
                string commande = "select * from Certificat where num_certificat is not null ";
                if (checkBox1.Checked)
                {
                    commande += " and num_certificat=" + textBox1.Text + " ";
                }
                if (checkBox2.Checked)
                {
                    commande += "and date_validation='" + dateTimePicker1.Value + "' ";
                }
                if (checkBox3.Checked)
                {
                    commande += "and date_depot='" + dateTimePicker2.Value + "' ";
                }
                if (checkBox4.Checked)
                {
                    commande += "and num_auteur=" + comboBox1.SelectedValue + "";
                }
                if (checkBox5.Checked)
                {
                    commande += "and num_innovation=" + comboBox2.SelectedValue + "";
                }
                cmd = new SqlCommand(commande, cnx);
                cnx.Open();
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dt;
                cnx.Close();
            }
            
        }
    }
}
