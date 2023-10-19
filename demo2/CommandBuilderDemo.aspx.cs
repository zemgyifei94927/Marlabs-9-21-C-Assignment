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
    public partial class CommandBuilderDemo : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetStudent_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(cs);
            string sqlQuery = "SELECT * FROM tblStudents WHERE ID=" + txtStudentID.Text;
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, sqlConnection); 
            DataSet dataSet = new DataSet();
            da.Fill(dataSet, "Students");

            ViewState["SQL_QUERY"] = sqlQuery;
            ViewState["DATASET"] = dataSet;

            if (dataSet.Tables[0].Rows.Count > 0)
            {
                DataRow dataRow = dataSet.Tables[0].Rows[0];
                txtStudentName.Text = dataRow["Name"].ToString().Trim();
                txtGender.Text = dataRow["Gender"].ToString().Trim();
                txtTotalMarks.Text = dataRow["TotalMarks"].ToString().Trim();

                lblStatus.ForeColor = System.Drawing.Color.Green;
                lblStatus.Text = "Student records with ID " + txtStudentID.Text + " is shown above!";
            }
            else
            {   

                lblStatus.ForeColor = System.Drawing.Color.Red;
                lblStatus.Text = "No Student records Found with ID "+txtStudentID.Text;

            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(cs);
            SqlDataAdapter da = new SqlDataAdapter((string)ViewState["SQL_QUERY"], sqlConnection);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(da);
            DataSet dataSet = (DataSet)ViewState["DATASET"];

            DataRow dataRow = dataSet.Tables[0].Rows[0];
            dataRow["Name"] = txtStudentName.Text;
            dataRow["Gender"] = txtGender.Text;
            dataRow["TotalMarks"] = txtTotalMarks.Text;

            int rowsUpdated = da.Update(dataSet, "Students");
            if(rowsUpdated > 0)
            {
                lblStatus.ForeColor = System.Drawing.Color.Green;
                lblStatus.Text = "Student's records with ID " + txtStudentID.Text + " is updated!";
            }
            else
            {

                lblStatus.ForeColor = System.Drawing.Color.Red;
                lblStatus.Text = "Student's records with ID " + txtStudentID.Text + " is not updated successfully!";
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(cs);
            SqlDataAdapter da = new SqlDataAdapter((string)ViewState["SQL_QUERY"], sqlConnection);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(da);
            DataSet dataSet = (DataSet)ViewState["DATASET"];
            DataRow dataRow = dataSet.Tables[0].Rows[0];
            dataRow.Delete();

            int rowsUpdated = da.Update(dataSet, "Students");
            if (rowsUpdated > 0)
            {
                lblStatus.ForeColor = System.Drawing.Color.Green;
                lblStatus.Text = "Student's records with ID " + txtStudentID.Text + " is deleted!";
                txtStudentID.Text = "";
                txtGender.Text = "";
                txtStudentName.Text = "";
                txtTotalMarks.Text = "";
            }
            else
            {

                lblStatus.ForeColor = System.Drawing.Color.Red;
                lblStatus.Text = "Student's records with ID " + txtStudentID.Text + " is not deleted successfully!";
            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {   
            // Create sql connection and initialize insert command for sqlDataAdapter
            SqlConnection sqlConnection = new SqlConnection(cs);
            SqlDataAdapter da = new SqlDataAdapter((string)ViewState["SQL_QUERY"], sqlConnection);

            string strInsertCommand = "Insert into tblStudents Values(@Name, @Gender, @TotalMarks)";
            SqlCommand insertCommand = new SqlCommand(strInsertCommand, sqlConnection);
            insertCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 50, "Name");
            insertCommand.Parameters.Add("@Gender", SqlDbType.NVarChar, 50, "Gender");
            insertCommand.Parameters.Add("@TotalMarks", SqlDbType.Int, 0, "TotalMarks");

            da.InsertCommand = insertCommand;

            // Create datatable from user input textbox 
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn() { ColumnName = "Name" });
            dt.Columns.Add(new DataColumn() { ColumnName = "Gender" });
            dt.Columns.Add(new DataColumn() { ColumnName = "TotalMarks" });
            DataRow dataRow = dt.NewRow();
            dataRow["Name"] = txtStudentName.Text;
            dataRow["Gender"] = txtGender.Text;
            dataRow["TotalMarks"] = txtTotalMarks.Text;
            dt.Rows.Add(dataRow);


            // Insert data
            da.Update(dt);
        }
    }
}