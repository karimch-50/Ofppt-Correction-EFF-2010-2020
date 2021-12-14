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
    public partial class MAJ_AutoCares : Form
    {
        public static string cnx=@"Data Source=DESKTOP-SQH9NT6\SQLEXPRESS;Initial Catalog=EFF2011_TP_V01;Integrated Security=True";
        public SqlConnection connection = new SqlConnection(cnx);
        public SqlDataAdapter SDA;
        public DataSet DS = new DataSet();
        public DataRow DR;

        public MAJ_AutoCares()
        {
            InitializeComponent();
        }

        private void MAJ_AutoCares_Load(object sender, EventArgs e)
        {
            fill_ds();
        }

        public void fill_ds()
        {
            string cmd = "select*from Autocar";
            SDA = new SqlDataAdapter(cmd,connection);
            SDA.Fill(DS);
            
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                comboBox1.Items.Add(DS.Tables[0].Rows[i][4].ToString());
            }
        }

        public int pos;
        public void Navigation()
        {
            textBox1.Text = DS.Tables[0].Rows[pos][0].ToString();
            textBox2.Text = DS.Tables[0].Rows[pos][1].ToString();
            dateTimePicker1.Value = Convert.ToDateTime(DS.Tables[0].Rows[pos][2].ToString());
            textBox4.Text = DS.Tables[0].Rows[pos][3].ToString();
            comboBox1.Text = DS.Tables[0].Rows[pos][4].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pos=0;
            Navigation();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                pos -= 1;
                Navigation();
            }
            catch
            {
                MessageBox.Show("Premier Element!!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pos = DS.Tables[0].Rows.Count-1;
            Navigation();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                DR = DS.Tables[0].NewRow();
                DR[0] = textBox1.Text;
                DR[1] = textBox2.Text;
                DR[2] = dateTimePicker1.Value;
                DR[3] = textBox4.Text;
                DR[4] = comboBox1.Text;
                DS.Tables[0].Rows.Add(DR);
                MessageBox.Show("Ajout bien fait!!");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder SCB = new SqlCommandBuilder(SDA);
            SDA.Update(DS);
            MessageBox.Show("Enregistrement bien fait!!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                bool ok = false;
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    if (DS.Tables[0].Rows[i][0].ToString() == textBox1.Text)
                    {
                        ok = true;
                        DS.Tables[0].Rows[i].Delete();
                        MessageBox.Show("Suppretion bient fait !!");
                        break;
                    }
                }
                if (ok == false)
                {
                    MessageBox.Show("Element introuvable");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
