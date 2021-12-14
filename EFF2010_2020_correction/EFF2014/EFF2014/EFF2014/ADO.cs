using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace EFF2014
{
    class ADO
    {
       public  SqlConnection con = new SqlConnection();
       public SqlCommand cmd = new SqlCommand();
       public SqlDataReader dr;
       public DataRow ligne;
       public SqlDataAdapter dap;
       public DataSet ds = new DataSet();
       public DataTable dt = new DataTable();
       public SqlCommandBuilder cb;
        //##############################################""
        public void Connecter()
        {
            if (con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
            {
                con.ConnectionString = @"Data Source=LENOVO-PC\SQLEXPRESS;Initial Catalog=EFF2014;Integrated Security=True";
                con.Open();
            }
        }
        //##############################################""
        public void Deonnecter()
        {
            if (con.State == ConnectionState.Open)
            {
               
                con.Close();
            }
        }
    }
}
