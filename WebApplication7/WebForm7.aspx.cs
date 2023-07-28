using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        
        protected void Button1_Click(object sender, EventArgs e)
        {
                MyComponent obj = new MyComponent();
                DataSet ds = obj.getdata("select * from bank_master");
                GridView1.DataSource = ds.Tables[0];              
                GridView1.DataBind(); 
                
        }

        protected void Button2_Click(object sender, EventArgs e) { 
      MyComponent obj = new MyComponent();
        DataSet ds = obj.getdata("select * from bank_transaction");
        GridView1.DataSource = ds.Tables[0];              
                GridView1.DataBind(); 

        }
    }
}