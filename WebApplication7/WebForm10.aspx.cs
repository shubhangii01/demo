using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MyComponent obj = new MyComponent();
            DataSet ds = obj.getdata("select * from assign");
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)

        {
            string g;
            if (RadioButton1.Checked)
                g = RadioButton1.Text;
            else
                g = RadioButton2.Text;
            SqlConnection con = new SqlConnection("uid = sa; password = 123; database = practice; server = VDILEWVPNTH518");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into assign values('"+TextBox1.Text+"','"+TextBox2.Text+"',"+TextBox3.Text+",'"+g +"','"+TextBox4.Text+"')", con);
            int i = cmd.ExecuteNonQuery();
            Response.Write(i);
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            RadioButton1.Checked = false;
            RadioButton2.Checked = false;

        }
    }
}