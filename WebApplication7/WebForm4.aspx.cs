using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {



        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("uid=sa;password=123;database=practice;server=VDILEWVPNTH518");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into salgrade values(" + TextBox1.Text + "," + TextBox2.Text + "," + TextBox3.Text + ")", con);

            int i = cmd.ExecuteNonQuery();
            Response.Write("1 row inserted");
            con.Close();

        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("uid=sa;password=123;database=practice;server=VDILEWVPNTH518");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from SALGRADE where GRADE=" + TextBox1.Text, con);
            int i = cmd.ExecuteNonQuery();
            Response.Write("1 row deleted");
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