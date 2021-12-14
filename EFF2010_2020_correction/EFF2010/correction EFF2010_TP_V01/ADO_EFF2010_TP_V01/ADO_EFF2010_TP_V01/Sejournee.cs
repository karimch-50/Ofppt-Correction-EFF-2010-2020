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
    public partial class Sejournee : Form
    {
        public static string con = @"Data Source=DESKTOP-SQH9NT6\SQLEXPRESS;Initial Catalog=EFF2010_TP_V01;Integrated Security=True";
        public SqlConnection connection = new SqlConnection(con);
        public SqlDataAdapter SDA;
        public DataSet DS = new DataSet();
        public DataRow DR;
        public DataRow DR1;

        public Sejournee()
        {
            InitializeComponent();
        }

        private void Sejournee_Load(object sender, EventArgs e)
        {

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
            DR[3] = dateTimePicker1.Value;
            DR[4] = dateTimePicker2.Value;
            DS.Tables[0].Rows.Add(DR);
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
                    if (!(String.IsNullOrEmpty(textBox2.Text)) && !(String.IsNullOrEmpty(textBox3.Text)) && !(String.IsNullOrEmpty(dateTimePicker1.Value.ToString())) && !(String.IsNullOrEmpty(dateTimePicker2.Value.ToString())))
                    {
                        DS.Tables[0].Rows[pos][1] = textBox2.Text;
                        DS.Tables[0].Rows[pos][2] = textBox3.Text;
                        DS.Tables[0].Rows[pos][3] = dateTimePicker1.Value;
                        DS.Tables[0].Rows[pos][4] = dateTimePicker2.Value;
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
