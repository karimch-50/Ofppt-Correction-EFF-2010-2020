using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EFM_Rejional_ASP
{
    public partial class MAJ_CONTRAT : System.Web.UI.Page
    {
        public static string cnx = @"Data Source=DESKTOP-AT90UN0\SQLEXPRESS;Initial Catalog=EFM_Rej;Integrated Security=True";
        public SqlConnection connection = new SqlConnection(cnx);
        public SqlDataReader SDR;
        public DataTable DT = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["NUM_PROP"] == null)
            {
                Response.Redirect("Connection.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string cmd = "SELECT C.* FROM CONTRAT C ,BIENIMMOBILIER B where C.NUM_BIEN=B.NUM_BIEN and B.NUM_PROP=" + Convert.ToInt32(Session["NUM_PROP"].ToString()) + "";
                SqlCommand command = new SqlCommand(cmd, connection);
                SDR = command.ExecuteReader();
                DT.Load(SDR);
                GridView1.DataSource = DT;
                GridView1.DataBind();
                connection.Close();
            }
            catch (Exception Ex)
            {
                Response.Write("<script> alert(Ex.Message)</script>");
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Supprimer")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                int value = Convert.ToInt32(GridView1.Rows[index].Cells[0].Text);
                connection.Open();
                string cmd = "delete from CONTRAT where NUM_CONTRAT ="+ value + "";
                SqlCommand command = new SqlCommand(cmd, connection);
                SDR = command.ExecuteReader();
                connection.Close();
                Response.Write("<script> alert('Supprission bien fait!!')</script>");
            }
            if (e.CommandName == "Modifier")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                int value = Convert.ToInt32(GridView1.Rows[index].Cells[0].Text);
                connection.Open();
                string cmd = "Update CONTRAT set DATE_CONTRAT='"+TextBox1.Text+"',NUM_BIEN="+TextBox2.Text+",DUREE="+TextBox3.Text+" where NUM_CONTRAT =" + value + "";
                SqlCommand command = new SqlCommand(cmd, connection);
                SDR = command.ExecuteReader();
                connection.Close();
                Response.Write("<script> alert('Modification bien fait!!')</script>");
            }

        }
    }
}