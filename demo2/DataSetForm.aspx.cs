using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace demo2
{
    public partial class DataSetForm : System.Web.UI.Page
    {
        DataSet ds = new DataSet();
        String cs = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            try {
                using (SqlConnection conn = new SqlConnection(cs)) {
                    SqlCommand cmd = new SqlCommand("Select * From Products", conn);
                    conn.Open();
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable("Products");
                        dt.Columns.Add(new DataColumn("Id"));
                        dt.Columns.Add(new DataColumn("Name"));
                        dt.Columns.Add(new DataColumn("Description"));
                        dt.Columns.Add(new DataColumn("UnitPrice"));
                        dt.Columns.Add(new DataColumn("QtyAvailable"));
                        dt.Columns.Add(new DataColumn("DiscountedPrice"));
                        while (reader.Read())
                        {
                            DataRow dataRow = dt.NewRow();
                            dataRow["Id"] = reader["Id"];
                            dataRow["Name"] = reader["Name"];
                            dataRow["Description"] = reader["Description"];
                            dataRow["QtyAvailable"] = reader["QtyAvailable"];
                            dataRow["UnitPrice"] = reader["UnitPrice"];
                            dataRow["DiscountedPrice"] = 0.9 * Convert.ToInt32(reader["UnitPrice"]);
                            dt.Rows.Add(dataRow);
                        }
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                    }
                }
            } 
            catch(Exception ex) { }   
            //if (!Page.IsPostBack) {
            //    ds.Tables.Add(new DataTable("Student"));
            //    ds.Tables["Student"].Columns.Add(new DataColumn("ID"));
            //    ds.Tables["Student"].Columns.Add(new DataColumn("Name"));
            //    ds.Tables["Student"].Columns.Add(new DataColumn("Department"));

            //    ds.Tables["Student"].Rows.Add(new object[] { "1", "Sam Smith", "Dell" });
            //    GridView1.DataSource = ds;
            //    GridView1.DataBind();
            //}
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ds.Tables["Student"].Rows.Add(new object[] { "2", "Peter Pan", "Apple" });
            //GridView1.DataSource = ds; 已经绑定了 不用再次绑定
            GridView1.DataBind(); //每次想要显示新的数据都要call一次
        }
    }
}