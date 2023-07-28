using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                fillgrid(0);
        }

        private void fillgrid(int pno)
        { 
            MyComponent obj = new MyComponent();
            DataSet ds = obj.getdata("select * from emp ");
            GridView1.DataSource = ds.Tables[0];
            GridView1.PageIndex = pno;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            fillgrid(e.NewPageIndex);

        }
    }
}