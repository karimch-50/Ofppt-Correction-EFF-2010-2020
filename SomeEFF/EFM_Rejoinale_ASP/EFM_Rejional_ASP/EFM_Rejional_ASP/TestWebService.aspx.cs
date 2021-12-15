using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EFM_Rejional_ASP
{
    public partial class TestWebService : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            localhost.WebService1 C1 = new localhost.WebService1();
            GridView1.DataSource = C1.chifr_aff(Convert.ToInt32(TextBox1.Text));
            GridView1.DataBind();
        }
    }
}