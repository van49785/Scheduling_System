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

namespace ASM2_DDD
{
    public partial class FPTManagerForm : Form
    {
        SqlConnection connection;
        public FPTManagerForm()
        {
            InitializeComponent();
            connection = new SqlConnection("Server= localhost; Database= Scheduling_System; Integrated Security=True;");
        }

        private void FPTManagerForm_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            connection.Open();
            FillUserData();

        }
        private void FillUserData()
        {
            string query = "select * from users";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(dt);
            dgvUser.DataSource = dt;
            connection.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (cbxRole.SelectedItem != null)
            {
                string role = cbxRole.SelectedItem.ToString();
                int id = int.Parse(tbxUID.Text);
                string name = tbxUName.Text;
                string email = tbxEmail.Text;
                string pass = tbxPass.Text;

                string insert = "INSERT INTO users (user_id, userName, email, password, role) VALUES (@id, @name, @email, @pass, @role)";
                connection.Open();
                SqlCommand command = new SqlCommand(insert, connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@pass", pass);
                command.Parameters.AddWithValue("@role", role);
                command.ExecuteNonQuery();
                connection.Close();

                FillUserData();
                tbxUID.Text = "";
                tbxUName.Text = "";
                tbxEmail.Text = "";
                tbxPass.Text = "";

                MessageBox.Show("Insert successful");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbxUID.Text = "";
            tbxUName.Text = "";
            tbxEmail.Text = "";
            tbxPass.Text = "";
            cbxRole.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to edit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string role = cbxRole.SelectedItem.ToString();
                int id = int.Parse(tbxUID.Text);
                string name = tbxUName.Text;
                string email = tbxEmail.Text;
                string pass = tbxPass.Text;
                connection.Open();

                string update = "UPDATE users SET userName = @name, email = @email, password = @pass, role = @role WHERE user_id = @id";
                SqlCommand cmd = new SqlCommand(update, connection);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@pass", pass);
                cmd.Parameters.AddWithValue("@role", role);
                cmd.Parameters.AddWithValue("@id", id);

                int rowsAffected = cmd.ExecuteNonQuery();
                connection.Close();

                if (rowsAffected > 0)
                {
                    FillUserData();
                    MessageBox.Show(this, "Update successfully!", "Result!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Lấy giá trị từ TextBox
                int uid;
                if (int.TryParse(tbxUID.Text, out uid))
                {
                    // Tạo câu truy vấn DELETE
                    string deleteQuery = "DELETE FROM users WHERE user_id = @id";

                    // Tạo đối tượng SqlCommand và thực thi câu truy vấn DELETE
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", uid);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }

                    // Cập nhật DataGridView
                    FillUserData();
                    MessageBox.Show("Delete successfully!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Invalid User ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvUser.Rows[e.RowIndex];
                tbxUID.Text = row.Cells["userID"].Value.ToString();
                tbxUName.Text = row.Cells["userName"].Value.ToString();
                tbxEmail.Text = row.Cells["email"].Value.ToString();
                tbxPass.Text = row.Cells["password"].Value.ToString();
                cbxRole.SelectedItem = row.Cells["role"].Value.ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = tbxSearch.Text;
            string query = "SELECT * FROM users WHERE user_id = @id";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = int.Parse(searchValue);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            reader.Close();
            connection.Close();
            dgvUser.DataSource = dt;
        }

        private void DepartmentTab_Click(object sender, EventArgs e)
        {
            connection.Open();
            FillDepartmentData();
        }
        private void FillDepartmentData()
        {
            string query = "select * from Departments";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(dt);
            dgvDepartment.DataSource = dt;
            connection.Close();

        }

        private void btnDInsert_Click(object sender, EventArgs e)
        {
            string name = tbxDepN.Text;
            int id = int.Parse(tbxDepID.Text);

            connection.Open();
            string insert = "INSERT INTO Departments (DepartmentID, DepartmentName) VALUES (@id, @name)";
            SqlCommand cmd = new SqlCommand(insert, connection);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.ExecuteNonQuery();
            connection.Close();

            FillDepartmentData();
            tbxDepID.Text = "";
            tbxDepN.Text = "";

            MessageBox.Show("Insert successful!");
        }

        private void btnDUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to edit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                string name = tbxDepN.Text;
                int id = int.Parse(tbxDepID.Text);
                connection.Open();
                string update = "update Departments set DepartmentName =@name where DepartmentID = @id";
                SqlCommand cmd = new SqlCommand(update, connection);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@id", id);

                int rowsAffected = cmd.ExecuteNonQuery();
                connection.Close();

                if (rowsAffected > 0)
                {
                    FillDepartmentData();
                    MessageBox.Show(this, "Update successfully!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
        }

        private void dgvDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvDepartment.Rows[e.RowIndex];
                tbxDepID.Text = row.Cells["DepartmentID"].Value.ToString();
                tbxDepN.Text = row.Cells["DepartmentName"].Value.ToString();

            }
        }

        private void btnDCancel_Click(object sender, EventArgs e)
        {
            tbxDepID.Text = "";
            tbxDepN.Text = "";

        }

        private void btnDDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                connection.Open();
                string delete = "delete from Departments where DepartmentID = @id";
                SqlCommand cmd = new SqlCommand(delete, connection);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = tbxDepID.Text;
                cmd.ExecuteNonQuery();
                FillDepartmentData();
                MessageBox.Show(this, "Delete successfully!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnDSearch_Click(object sender, EventArgs e)
        {
            string searchValue = tbxSearch.Text;
            string query = "SELECT * FROM Departments WHERE DepartmentID = @id";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = int.Parse(searchValue);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            reader.Close();
            connection.Close();
            dgvDepartment.DataSource = dt;
        }

        private void CourseTab_Click(object sender, EventArgs e)
        {
            connection.Open();
            FillCourseData();
            GetCourse();
            connection.Close();
        }
        private void FillCourseData()
        {
            string query = "select * from Courses";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(dt);
            dgvCourse.DataSource = dt;
        }

        private void GetCourse()
        {
            string query = "SELECT DepartmentID, DepartmentName FROM Departments";
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(table);
            cbxDep.DataSource = table;
            cbxDep.DisplayMember = "DepartmentName";
            cbxDep.ValueMember = "DepartmentID";
        }

        private void btnCInsert_Click(object sender, EventArgs e)
        {
            try
            {
                string id = tbxCID.Text;
                string name = tbxCName.Text;
                string credit = tbxCredit.Text;
                string depid = cbxDep.SelectedValue?.ToString();

                connection.Open();
                string selectQuery = "SELECT * FROM Courses WHERE CourseID = @id";
                using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                {
                    selectCommand.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            MessageBox.Show(this, "Course already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                string insertQuery = "INSERT INTO Courses (CourseID, DepartmentID, CourseName, Credits) VALUES (@id, @depid, @name, @credit)";
                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);

                insertCommand.Parameters.AddWithValue("@id", id);
                insertCommand.Parameters.AddWithValue("@depid", depid);
                insertCommand.Parameters.AddWithValue("@name", name);
                insertCommand.Parameters.AddWithValue("@credit", credit);

                int rowsAffected = insertCommand.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    FillCourseData();
                    MessageBox.Show(this, "Inserted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, $"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCCancel_Click(object sender, EventArgs e)
        {
            tbxCID.Text = "";
            tbxCName.Text = "";
            tbxCredit.Text = "";
            cbxDep.Text = "";
        }

        private void btnCUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to edit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = int.Parse(tbxCID.Text);
                string name = tbxCName.Text;
                int credit = int.Parse(tbxCredit.Text);

                connection.Open();

                string update = "UPDATE Courses SET CourseName = @name, Credits = @credit WHERE CourseID = @id";
                SqlCommand cmd = new SqlCommand(update, connection);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@credit", credit);
                cmd.Parameters.AddWithValue("@id", id);
                int rowsAffected = cmd.ExecuteNonQuery();
                connection.Close();

                if (rowsAffected > 0)
                {
                    FillCourseData();
                    MessageBox.Show(this, "Update successfully!", "Result!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgvCourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvCourse.Rows[e.RowIndex];
                tbxCID.Text = row.Cells["CourseID"].Value.ToString();
                tbxCName.Text = row.Cells["CourseName"].Value.ToString();
                tbxCredit.Text = row.Cells["Credits"].Value.ToString();
                cbxDep.SelectedItem = row.Cells["depID"].Value.ToString();
            }
        }

        private void btnCDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                connection.Open();
                string delete = "delete from Courses where CourseID = @id";
                SqlCommand cmd = new SqlCommand(delete, connection);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = tbxCID.Text;
                cmd.ExecuteNonQuery();
                FillCourseData();
                MessageBox.Show(this, "Delete successfully!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnCSearch_Click(object sender, EventArgs e)
        {
            string searchValue = tbxCSearch.Text;
            string query = "SELECT * FROM Courses WHERE CourseID = @id";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = int.Parse(searchValue);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            reader.Close();
            connection.Close();
            dgvCourse.DataSource = dt;
        }
    }
}
