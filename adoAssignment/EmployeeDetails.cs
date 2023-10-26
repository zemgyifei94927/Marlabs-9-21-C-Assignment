using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adoAssignment
{
    public partial class EmployeeDetails : Form
    {
        public EmployeeDetails()
        {
            InitializeComponent();
            bindGridView();
            bindcbDeptName();
            bindcbDepartment();
            bindcbIsActive();
        }

        private void bindcbIsActive()
        {
            DataTable dt = new DataTable();
            DataColumn dtcol = new DataColumn();
            dtcol.ColumnName = "bol";
            dt.Columns.Add(dtcol);
            DataRow dr = dt.NewRow();
            dr["bol"] = "--SELECT--";
            dt.Rows.Add(dr);
            DataRow dr2 = dt.NewRow();
            dr2["bol"] = "true";
            dt.Rows.Add(dr2);
            DataRow dr3 = dt.NewRow();
            dr3["bol"] = "false";
            dt.Rows.Add(dr3);
            cbIsActive.DisplayMember = "bol";
            cbIsActive.ValueMember = "bol";
            cbIsActive.DataSource = dt;
        }
        private void bindcbDepartment()
        {
            string cs = "Data Source=(localdb)\\ProjectModels;Initial Catalog=EmpSearchDB;Integrated Security=True";
            try
            {
                using (SqlConnection conn = new SqlConnection(cs))
                {

                    String cmdString = "Select PKDeptId, DeptName from Department";
                    SqlDataAdapter adapter = new SqlDataAdapter(cmdString, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    DataRow newRow = dt.NewRow();
                    newRow["DeptName"] = "--SELECT--";
                    newRow["PKDeptId"] = 0;
                    dt.Rows.InsertAt(newRow, 0);
                    cbDepartment.DisplayMember = "DeptName";
                    cbDepartment.ValueMember = "PKDeptId";
                    cbDepartment.DataSource = dt;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void bindcbDeptName()
        {
            string cs = "Data Source=(localdb)\\ProjectModels;Initial Catalog=EmpSearchDB;Integrated Security=True";
            try
            {
                using (SqlConnection conn = new SqlConnection(cs))
                {

                    String cmdString = "Select PKDeptId, DeptName from Department";
                    SqlDataAdapter adapter = new SqlDataAdapter(cmdString, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    DataRow newRow = dt.NewRow();
                    newRow["DeptName"] = "--SELECT--";
                    newRow["PKDeptId"] = 0;
                    dt.Rows.InsertAt(newRow, 0);
                    cbDeptName.DisplayMember = "DeptName";
                    cbDeptName.ValueMember = "PKDeptId";
                    cbDeptName.DataSource = dt;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void bindGridView()
        {
            string cs = "Data Source=(localdb)\\ProjectModels;Initial Catalog=EmpSearchDB;Integrated Security=True";
            try
            {
                using (SqlConnection conn = new SqlConnection(cs))
                {
                    conn.Open();
                    string cmdString = "Select EmpName, DeptName, EmpSalary, EmpDetails.IsActive from EmpDetails join Department on EmpDetails.FKDeptId = Department.PKDeptId";
                    SqlCommand cmd = new SqlCommand(cmdString, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgEmp.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // TODO: Not Sure required functionality at this moment.
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            string cs = "Data Source=(localdb)\\ProjectModels;Initial Catalog=EmpSearchDB;Integrated Security=True";
            try
            {
                using (SqlConnection conn = new SqlConnection(cs))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Delete From EmpDetails where EmpName=@EName", conn);
                    cmd.Parameters.AddWithValue("@EName", dgEmp.SelectedRows[0].Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    bindGridView();
                    MessageBox.Show("Delete Successfully!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=(localdb)\\ProjectModels;Initial Catalog=EmpSearchDB;Integrated Security=True";
            try
            {
                using (SqlConnection conn = new SqlConnection(cs))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Insert into EmpDetails (FKDeptId, EmpName, EmpSalary, IsActive) VALUES(@FK, @Name, @Salary, @IsActive)", conn);
                    cmd.Parameters.AddWithValue("@Name", txtEmpName.Text);
                    cmd.Parameters.AddWithValue("@FK", cbDeptName.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@Salary", txtSalary.Text);
                    cmd.Parameters.AddWithValue("@IsActive", ChkIsActive.Checked);
                    cmd.ExecuteNonQuery();
                    bindGridView();
                    MessageBox.Show("Save Successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=(localdb)\\ProjectModels;Initial Catalog=EmpSearchDB;Integrated Security=True";
            try
            {
                using (SqlConnection conn = new SqlConnection(cs))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Update EmpDetails Set IsActive = @IsActive, FKDeptId = @FK, EmpSalary = @Salary Where EmpName = @EName", conn);
                    cmd.Parameters.AddWithValue("@EName", txtEmpName.Text);
                    cmd.Parameters.AddWithValue("@IsActive", ChkIsActive.Checked);
                    cmd.Parameters.AddWithValue("@FK", cbDeptName.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@Salary", txtSalary.Text);
                    cmd.ExecuteNonQuery();
                    bindGridView();
                    MessageBox.Show("Update Successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string cs = "Data Source=(localdb)\\ProjectModels;Initial Catalog=EmpSearchDB;Integrated Security=True";
            try
            {
                using (SqlConnection conn = new SqlConnection(cs))
                {
                    conn.Open();
                    string cmdString = "Select EmpName, DeptName, EmpSalary, EmpDetails.IsActive from EmpDetails join Department on EmpDetails.FKDeptId = Department.PKDeptId Where Department.PKDeptId = @DPK and EmpDetails.IsActive=@IsActive";
                    SqlCommand cmd = new SqlCommand(cmdString, conn);
                    cmd.Parameters.AddWithValue("@DPK", cbDepartment.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@IsActive", cbIsActive.SelectedValue.ToString());
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No Result Found!");
                    }
                    else
                    {
                        dgEmp.DataSource = dt;
                        MessageBox.Show($"{dt.Rows.Count} Result Found!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
