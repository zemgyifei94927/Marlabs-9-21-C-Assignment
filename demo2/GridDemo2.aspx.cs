using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace demo2
{
    public partial class GridDemo2 : System.Web.UI.Page
    {
        string CS = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindData();
            }
        }

        protected void BindData()
        {
            
            SqlConnection conn = new SqlConnection(CS);
            DataSet ds = new DataSet();
            SqlCommand sqlCommand = new SqlCommand("Select * From Products", conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            sqlDataAdapter.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
        }

        protected void GridView1_PageIndexChanged(object sender, EventArgs e)
        {
            BindData();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            BindData();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            BindData();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Int32.Parse(GridView1.DataKeys[e.RowIndex].Value.ToString());

            TextBox Name = GridView1.Rows[e.RowIndex].Cells[0].Controls[0] as TextBox;
            string name = Name.Text.Trim();

            TextBox Description = GridView1.Rows[e.RowIndex].FindControl("DescriptionTB") as TextBox;
            string description = Description.Text.Trim();

            TextBox UnitPrice = GridView1.Rows[e.RowIndex].Cells[2].Controls[0] as TextBox;
            string unitPrice = UnitPrice.Text.Trim();

            TextBox QtyAvailable = GridView1.Rows[e.RowIndex].FindControl("QtyAvailableTB") as TextBox;
            string qtyAvailable = QtyAvailable.Text.Trim();


            SqlConnection sqlConnection = new SqlConnection(CS);
            SqlCommand sqlCommand = new SqlCommand("Update Products set Name=@Name, Description=@Description, UnitPrice=@UnitPrice, QtyAvailable=@QtyAvailable Where Id=@Id", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Id", id);
            sqlCommand.Parameters.AddWithValue("@Name", name);
            sqlCommand.Parameters.AddWithValue ("UnitPrice", unitPrice);
            sqlCommand.Parameters.AddWithValue ("@Description", description);
            sqlCommand.Parameters.AddWithValue("@QtyAvailable", qtyAvailable);

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            GridView1.EditIndex = -1;
            BindData();
        }
    }
}