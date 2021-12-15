using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace EFM_Rejional_ASP
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        public static string cnx = @"Data Source=DESKTOP-AT90UN0\SQLEXPRESS;Initial Catalog=EFM_Rej;Integrated Security=True";
        public SqlConnection connection = new SqlConnection(cnx);
        public SqlDataAdapter SDA;
        public DataSet DS = new DataSet();

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public DataTable chifr_aff(int NUM_PROP)
        {
            connection.Open();
            string cmd = "SELECT*FROM PROPEIETAIRE where NUM_PROP="+ NUM_PROP;
            SDA= new SqlDataAdapter(cmd, connection);
            SDA.Fill(DS);
            return DS.Tables[0];
            connection.Close();
        }
    }
}
