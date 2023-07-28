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
    public partial class WebForm11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection con = new SqlConnection("Initial catalog=practice; integrated security=true;server=VDILEWVPNTH518");
                fillgrid(0);
            }

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void fillgrid(int pno)
        {
            SqlConnection con = new SqlConnection("Initial catalog=practice; integrated security=true;server=VDILEWVPNTH518");
            SqlDataAdapter da = new SqlDataAdapter("Select * from emp", con);
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            da.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.PageIndex = pno;
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection con = new SqlConnection("Initial catalog=practice; integrated security=true;server=VDILEWVPNTH518");
            Response.Write(e.RowIndex);
            string pid = GridView1.Rows[e.RowIndex].Cells[1].Text;

            int empno = int.Parse(pid);
            cmd.CommandText = "delete from emp where empno = " + empno;

            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            fillgrid(0);
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            fillgrid(e.NewPageIndex);

        }
    }
}