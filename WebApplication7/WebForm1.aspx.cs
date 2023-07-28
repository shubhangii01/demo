using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("uid = sa; password = 123; database = practice; server = VDILEWVPNTH518");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into emp values(" + TextBox1.Text + ",'" + TextBox2.Text + "','" + TextBox3.Text + "'," + TextBox4.Text + ",'" + TextBox5.Text + "'," + TextBox6.Text + "," + TextBox7.Text + "," + TextBox8.Text + ")", con);
            cmd.ExecuteNonQuery();
            Response.Write("1 ROW INSERTED");
            con.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //doubt in this feature.
        }
    }
}