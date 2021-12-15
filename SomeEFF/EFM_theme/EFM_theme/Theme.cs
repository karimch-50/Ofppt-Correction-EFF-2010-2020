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

namespace EFM_theme
{
    public partial class Theme : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JJRVRIH\YOUSSEFSQL;Initial Catalog=EFM_theme;Integrated Security=True");
        DataSet ds = new DataSet();
        SqlDataAdapter sda;
        public Theme()
        {
            InitializeComponent();
        }

        private void Theme_Load(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                sda = new SqlDataAdapter("select * from Theme", con);
                sda.Fill(ds,"Theme");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            DataRow dr = ds.Tables["Theme"].NewRow();
            dr[0] = txtCode.Text;
            dr[1] = txtNom.Text;
            dr[2] = txtDescription.Text;

            ds.Tables["Theme"].Rows.Add(dr);
            MessageBox.Show("Bien ajouter!");
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                int pos = -1;
                for (int i = 0; i < ds.Tables["Theme"].Rows.Count; i++)
                {
                    if (txtCode.Text == ds.Tables["Theme"].Rows[i][0].ToString())
                    {
                        pos = i;
                        break;
                    }
                }
                if (pos > 0)
                {
                    ds.Tables["Theme"].Rows[pos].Delete();
                    MessageBox.Show("Suppression");
                }
                else if (pos == -1)
                {
                    MessageBox.Show("Theme n'existe pas!");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            sda.Update(ds.Tables["Theme"]);
            MessageBox.Show("Enregistrement bien fait");
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
            MENU m = new MENU();
            m.Show();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                int pos = -1;
                for (int i = 0; i < ds.Tables["Theme"].Rows.Count; i++)
                {
                    if (txtCode.Text == ds.Tables["Theme"].Rows[i][0].ToString())
                    {
                        if (!string.IsNullOrEmpty(txtNom.Text) )
                            ds.Tables["Theme"].Rows[i][1] = txtNom.Text;
                        if(!string.IsNullOrEmpty(txtDescription.Text))
                            ds.Tables["Theme"].Rows[i][2] = txtDescription.Text;
                        
                        MessageBox.Show("Modification bien fait!");
                        pos = i;
                    }
                }
                if (pos == -1)
                    MessageBox.Show("aucun element");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public int position;
        public void Navigation()
        {
            txtCode.Text = ds.Tables["Theme"].Rows[position][0].ToString();
            txtNom.Text = ds.Tables["Theme"].Rows[position][1].ToString();
            txtDescription.Text = ds.Tables["Theme"].Rows[position][2].ToString();
        }

        private void btnPremier_Click(object sender, EventArgs e)
        {
            position = 0;
            Navigation();
        }

        private void btnDernier_Click(object sender, EventArgs e)
        {
            position = ds.Tables["Theme"].Rows.Count - 1;
            Navigation();
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            position--;
            if (position <= -1 )
            {
                MessageBox.Show("Le Premier Element");
                position++;
            }
                Navigation();

            
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            position++;
            if (position >= ds.Tables["Theme"].Rows.Count - 1)
            {
                MessageBox.Show("Le dernier Element!!");
                position--;
            }
            Navigation();
        }
    }
}
