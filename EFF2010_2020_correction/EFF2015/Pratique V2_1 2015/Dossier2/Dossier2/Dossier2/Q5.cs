using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dossier2
{
    public partial class Q5 : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=.;Initial Catalog=EFF_PRATIQUE_2015_V2_1;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        public Q5()
        {
            InitializeComponent();
        }

        private void Q5_Load(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select SUM(C.qte),A.idAbonnement from Consommation C,Abonnement A where C.idAbonnement=A.idAbonnement and year(C.periode)='2014' GROUP BY A.idAbonnement", Con);

            Con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if(int.Parse(dr[1].ToString())>3600)
                {

                    dataGridView1.Rows.Add(dr[2].ToString(), dr[1].ToString());
                }
                else
                {
                    
        e.Row.Cells[0].BackColor = System.Drawing.Color.LightCyan; //first col
     

                      DataGridViewCellStyle style = new DataGridViewCellStyle();
                         style.BackColor = Color.Red;
   
                         row.Cells[color.Index].Style = style;
                        dataGridView1.cell
                    dataGridView1.Rows.Add(dr[2].ToString(), dr[1].ToString());
                }

            }
            dr.Close();
            Con.Close();
        }
    }
}
