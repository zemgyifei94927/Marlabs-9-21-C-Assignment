using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace demo2
{
    public partial class NextResultDemo : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["CS"].ConnectionString; 
        protected void Page_Load(object sender, EventArgs e)
        {
            try {
                using (SqlConnection conn = new SqlConnection(cs))
                {   
                    SqlCommand cmd = new SqlCommand("Select * from Products; Select * From Students", conn);
                    conn.Open();
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        GridView1.DataSource = reader;
                        GridView1.DataBind();
                        while (reader.NextResult()) {
                            GridView2.DataSource = reader;
                            GridView2.DataBind();
                        }
                    }
                }            

            }
            catch { }
        }
    }
}