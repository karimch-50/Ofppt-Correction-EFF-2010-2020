using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EFM_Rejional_ASP
{
    public partial class AjouterBienImobilier : System.Web.UI.Page
    {
        public static string cnx = @"Data Source=DESKTOP-AT90UN0\SQLEXPRESS;Initial Catalog=EFM_Rej;Integrated Security=True";
        public SqlConnection connection = new SqlConnection(cnx);

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["NUM_PROP"]==null)
            {
                Response.Redirect("Connection.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string cmd = "INSERT INTO BIENIMMOBILIER VALUES("+TextBox1.Text+",'"+TextBox2.Text+"','"+TextBox3.Text+"',"+TextBox4.Text+","+TextBox5.Text+")";
                SqlCommand command = new SqlCommand(cmd, connection);
                command.ExecuteNonQuery();
                connection.Close();
                Response.Write("<script> alert('Ajout bien fait!!')</script>");
            }
            catch (Exception Ex)
            {
                Response.Write("<script> alert(Ex.Message)</script>");
            }
        }
    }
}