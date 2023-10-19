using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace demo2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string cs = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;
            //if(!Page.IsPostBack) {
            //    try
            //    {
            //        using (SqlConnection con = new SqlConnection(cs)) {

            //            SqlCommand cmd = new SqlCommand("Select * From Products", con);
            //            con.Open();
            //            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            //            GridView1.DataSource = sqlDataReader;
            //            GridView1.DataBind();

            //            SqlCommand cmd = new SqlCommand("INSERT INTO Products Values(4, 'Alienware', 'Dell Super Line', 1000, 10)", con);
            //            con.Open();
            //            int rows = (int)cmd.ExecuteNonQuery();
            //            Response.Write("Total rows: " + rows);

            //        } 
            //    }
            //    catch (Exception ex)
            //    {

            //    }
                
                
            //}
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand("Select * From Products Where Name Like @ProductName", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@ProductName",TextBox1.Text + '%');
                    SqlDataReader sqlDataReader = cmd.ExecuteReader();
                    GridView1.DataSource = sqlDataReader;
                    GridView1.DataBind();

                    

                }
            }
            catch (Exception ex) { }
        }
    }
}