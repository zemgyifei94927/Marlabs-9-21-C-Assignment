using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace demo2
{
    public partial class Disconnected : System.Web.UI.Page
    {   
        string cs = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                GetDataFromDB();
            }
        }

        private void GetDataFromDB()
        {
            SqlConnection conn = new SqlConnection(cs);
            string query = "SELECT * FROM tblStudents";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, conn);

            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds, "Students");

            ds.Tables["Students"].PrimaryKey = new DataColumn[] { ds.Tables["Students"].Columns[0] };
            Cache.Insert("DATASET", ds, null, DateTime.Now.AddHours(24), System.Web.Caching.Cache.NoSlidingExpiration);


            gvStudents.DataSource = ds;
            gvStudents.DataBind();

            DropDownList1.DataSource = ds.Tables[0];
            //DropDownList1.DataTextField = ds.Tables[0].Columns["Name"].ToString();
            //DropDownList1.DataValueField = ds.Tables[0].Columns["Id"].ToString();
            DropDownList1.DataTextField ="Name";
            DropDownList1.DataValueField = "Id";
            DropDownList1.DataBind();

            lblMessage.Text = "Retrieve Data from DataBase successfully!";
        }

        protected void btnGetDataFromDB_Click(object sender, EventArgs e)
        {
            GetDataFromDB();
        }

        private void GetDataFromCache()
        {
            DataSet ds = (DataSet)Cache["DATASET"];
            gvStudents.DataSource = ds;
            gvStudents.DataBind();
        }

        protected void gvStudents_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvStudents.EditIndex = e.NewEditIndex; 
            GetDataFromCache();
        }

        protected void gvStudents_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            if (Cache["DATASET"] != null)
            {
                DataSet ds = (DataSet)Cache["DATASET"];
                DataRow dr = ds.Tables[0].Rows.Find(e.Keys["Id"]);
                dr["Name"] = e.NewValues["Name"];
                dr["Gender"] = e.NewValues["Gender"];
                dr["TotalMarks"] = e.NewValues["TotalMarks"];

                Cache.Insert("DATASET", ds, null, DateTime.Now.AddHours(24), System.Web.Caching.Cache.NoSlidingExpiration);
                GetDataFromCache() ;
            }
        }

        protected void gvStudents_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvStudents.EditIndex = -1;
            GetDataFromCache();
        }

        protected void gvStudents_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            if (Cache["DATASET"] != null)
            {
                DataSet ds = (DataSet)Cache["DATASET"];
                DataRow dr = ds.Tables[0].Rows.Find(e.Keys["Id"]);
                dr.Delete();

                Cache.Insert("DATASET", ds, null, DateTime.Now.AddHours(24), System.Web.Caching.Cache.NoSlidingExpiration);
                GetDataFromCache();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(cs);
            string query = "Select * From tblStudents";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

            DataSet ds = (DataSet)Cache["DATASET"];


            string strUpdateCommand = "Update tblStudents set Name=@Name, Gender=@Gender, TotalMarks=@TotalMarks where ID=@ID";
            SqlCommand updateCommand = new SqlCommand(strUpdateCommand, sqlConnection);
            updateCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 50, "Name");
            updateCommand.Parameters.Add("@Gender", SqlDbType.NVarChar, 10, "Gender");
            updateCommand.Parameters.Add("@TotalMarks", SqlDbType.Int, 0, "TotalMarks");
            updateCommand.Parameters.Add("@ID", SqlDbType.Int, 0, "ID");
            sqlDataAdapter.UpdateCommand = updateCommand;

            string strDeleteCommand = "Delete from tblStudents where ID=@ID";
            SqlCommand deleteCommand = new SqlCommand(strDeleteCommand, sqlConnection);
            deleteCommand.Parameters.Add("@ID", SqlDbType.Int, 0, "ID");
            sqlDataAdapter.DeleteCommand = deleteCommand;

            sqlDataAdapter.Update(ds, "Students");


        }
    }
}