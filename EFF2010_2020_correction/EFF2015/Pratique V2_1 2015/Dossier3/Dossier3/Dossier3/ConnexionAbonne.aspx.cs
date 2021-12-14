using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Dossier3
{
    public partial class ConnexionAbonne : System.Web.UI.Page
    {
        SqlConnection Con = new SqlConnection("Data Source=.;Initial Catalog=EFF_PRATIQUE_2015_V2_1;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select idAbonne,Pass from Abonne where=" + TextBox1.Text + "and Pass='" + TextBox2.Text + "'", Con);
            Con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                Session["Abonne"] = TextBox1.Text;
                Response.Redirect("");
            }
            else
                Label1.Text = "Id ou le mot de passe est incorrect";

        }
    }
}