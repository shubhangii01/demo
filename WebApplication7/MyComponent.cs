using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace WebApplication7
{
    public class MyComponent
    {
        public DataSet getdata(string s)
        {

            SqlConnection con = new SqlConnection
          ("Initial catalog=practice; integrated security=true;server=VDILEWVPNTH518");

            SqlDataAdapter da = new SqlDataAdapter(s, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return (ds);
        }
    }
}