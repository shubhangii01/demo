using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace WebApplication7
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("uid = sa; password = 123; database = practice; server = VDILEWVPNTH518");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into dept values("+TextBox1.Text+",'"+TextBox2.Text + "','" + TextBox3.Text +"')",con);
            cmd.ExecuteNonQuery();
            Response.Write("1 Row Inserted");
            con.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("uid = sa; password = 123; database = practice; server = VDILEWVPNTH518");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from dept where dname ='"+TextBox1.Text+"'",con);
            cmd.ExecuteNonQuery();
            Response.Write("1 Row Deleted");
            con.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
          

        }
    }
}