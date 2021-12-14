using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;

namespace Dossier3
{
    /// <summary>
    /// Description résumée de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        SqlConnection Con = new SqlConnection("Data Source=.;Initial Catalog=EFF_PRATIQUE_2015_V2_1;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public int valeurMaximum(int idAbonnement)
        {
            cmd = new SqlCommand("", Con);
            int a;
            a = (int)cmd.ExecuteScalar();
            return a;
        }
    }
}
