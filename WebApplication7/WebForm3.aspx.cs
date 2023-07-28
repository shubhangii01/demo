using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {

            

        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {
            TextBox6.Text = (int.Parse(TextBox3.Text) + int.Parse(TextBox4.Text) + int.Parse(TextBox5.Text)).ToString();

            TextBox7.Text = (int.Parse(TextBox6.Text) / 3).ToString();
            if (int.Parse(TextBox6.Text) > 40)
                TextBox8.Text = "Pass";
            else
            {
                TextBox8.Text = "Fail";
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("uid=sa;password=123;database=practice;server=VDILEWVPNTH518");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into st values(" + TextBox1.Text + ",'" + TextBox2.Text + "'," + TextBox3.Text + "," + TextBox4.Text + ", " + TextBox5.Text + "," + TextBox6.Text + "," + (TextBox7.Text) + ",'" + (TextBox8.Text) + "')", con);
            
            int i = cmd.ExecuteNonQuery();
            Response.Write("1 row inserted");
            con.Close();
        }
    }
}