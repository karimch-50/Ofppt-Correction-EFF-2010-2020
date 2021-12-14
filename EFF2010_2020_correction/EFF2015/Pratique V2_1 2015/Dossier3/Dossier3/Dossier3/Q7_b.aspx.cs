using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Dossier3
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Abonne"] == null)
            {
                Response.Redirect("Q1.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Q7_a ws = new Q7_a();
            lblMax.Text=ws.valeurMaximum(int.Parse(TextBox1.Text)).ToString();

        }
    }
}