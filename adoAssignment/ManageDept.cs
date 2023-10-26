using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace adoAssignment
{
    public partial class ManageDept : Form
    {

        public ManageDept()
        {

            InitializeComponent();
            bindGridView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=(localdb)\\ProjectModels;Initial Catalog=EmpSearchDB;Integrated Security=True";
            try
            {
                using (SqlConnection conn = new SqlConnection(cs))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Insert into Department (DeptName, IsActive) VALUES(@DName, @IsActive)", conn);
                    cmd.Parameters.AddWithValue("@DName", txtDeptName.Text);
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
                    SqlCommand cmd = new SqlCommand("Update Department Set IsActive = @IsActive Where DeptName = @DName", conn);
                    cmd.Parameters.AddWithValue("@DName", txtDeptName.Text);
                    cmd.Parameters.AddWithValue("@IsActive", ChkIsActive.Checked);
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

        private void bindGridView()
        {
            string cs = "Data Source=(localdb)\\ProjectModels;Initial Catalog=EmpSearchDB;Integrated Security=True";
            try
            {
                using (SqlConnection conn = new SqlConnection(cs))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Select DeptName, IsActive from Department", conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgDept.DataSource = dt;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=(localdb)\\ProjectModels;Initial Catalog=EmpSearchDB;Integrated Security=True";
            try
            {
                using (SqlConnection conn = new SqlConnection(cs))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Delete From Department where DeptName=@DName", conn);
                    cmd.Parameters.AddWithValue("@DName", dgDept.SelectedRows[0].Cells[0].Value.ToString());
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // TODO: Not sure what the function requires at this point. 
  
        }
    }
}