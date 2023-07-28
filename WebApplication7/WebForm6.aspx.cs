using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.WebSockets;

namespace WebApplication7
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        SqlConnection con;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                fillgrid(0);
        }

        private void fillgrid(int pno) {

            MyComponent obj = new MyComponent();
            DataSet ds = obj.getdata("select * from emp");
            GridView1.DataSource = ds.Tables[0];
            GridView1.PageIndex = pno;
            GridView1.DataBind();
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            fillgrid(e.NewPageIndex);
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int n = e.NewEditIndex;
            GridView1.EditIndex = n;

            this.fillgrid(0);
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            this.fillgrid(0);
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            SqlConnection con = new SqlConnection("uid = sa; pwd = 123; database = practice; server = VDILEWVPNTH518");
            SqlCommand cmd = new SqlCommand();

            string empno = ((TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0]).Text.Trim();

            string ename = ((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text.Trim();
            string job = ((TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).Text.Trim();

            string strSqlCommand = "Update emp set ename ='" + ename + "', job = '" + job + "' where empno = " + empno;

            con.Open();
            cmd = new SqlCommand(strSqlCommand,con);

            if(cmd.ExecuteNonQuery()> 0)
            {
                Response.Write("<H2><MARQUEE>Employee Data Updated Successfully</MARQUEE></H2>");
                GridView1.EditIndex = -1;
                this.fillgrid(0);
            }
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if(e.Row.RowType == DataControlRowType.DataRow)
            {
                if (e.Row.Cells[8].Text == "10")
                {
                    e.Row.BackColor = System.Drawing.Color.Orange;
                }
                else if (e.Row.Cells[8].Text == "20")
                {
                    e.Row.BackColor = System.Drawing.Color.FloralWhite;
                }
                else
                {
                    e.Row.BackColor= System.Drawing.Color.Green;
                }
            }
        }
    }
}