using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EFM_Rejional_ASP
{
    public partial class Connection : System.Web.UI.Page
    {
        public static string cnx = @"Data Source=DESKTOP-AT90UN0\SQLEXPRESS;Initial Catalog=EFM_Rej;Integrated Security=True";
        public SqlConnection connection = new SqlConnection(cnx);
        public SqlDataReader SDR;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            try
            {
                connection.Open();
                string cmd = "select*from PROPEIETAIRE where LOGINN='"+Login1.UserName+ "' and PASSWORDD='"+ Login1.Password+"'";
                SqlCommand command = new SqlCommand(cmd,connection);
                SDR = command.ExecuteReader();
                if (SDR.Read())
                {
                    Session["NUM_PROP"] = SDR[0].ToString();
                    Response.Redirect("AjouterBienImobilier.aspx");
                }
                else
                {
                    Login1.FailureText = "Mot de pass ou login incorrect!!";
                    Response.Write("<script> alert('Mot de pass ou login incorrect!!')</script>");
                }
                connection.Close();
            }
            catch (Exception Ex)
            {
                Login1.FailureText = Ex.Message;
                Response.Write("<script> alert(Ex.Message)</script>");
            }
        }
    }
}