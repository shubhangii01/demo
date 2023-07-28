using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7
{
    public partial class WebForm12 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("uid = sa; password = 123; database = practice; server = VDILEWVPNTH518");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into camp values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')", con);
            int i = cmd.ExecuteNonQuery();
            Response.Write(i + " Rows inserted");
            con.Close();
        }
    }
}