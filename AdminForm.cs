using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ASM2_DDD
{
    public partial class AdminForm : Form
    {
        SqlConnection connection;
        public AdminForm()
        {
            InitializeComponent();
            connection = new SqlConnection("Server= localhost; Database= Scheduling_System; Integrated Security=True;");
        }

        private void StudentTab_Click(object sender, EventArgs e)
        {
            connection.Open();
            FillData();
            GetDepartment();
        }
        private void FillData()
        {
            string query = "select * from Students";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(dt);
            dgvStudentTab.DataSource = dt;
            connection.Close();

        }

        private void GetDepartment()
        {
            string query = "SELECT DepartmentID, DepartmentName FROM Departments";
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(table);
            cbxMajor.DataSource = table;
            cbxMajor.DisplayMember = "DepartmentName";
            cbxMajor.ValueMember = "DepartmentName";

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Dispose();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            if (cbxMajor.SelectedItem != null)
            {

                string depname = cbxMajor.SelectedValue.ToString();


                int id = int.Parse(tbxSID.Text);
                string name = tbxSName.Text;
                string email = textBox3.Text;

                string insert = "insert into Students (StudentID, studentName, Email, Major) values (@id, @name, @email, @major)";

                connection.Open();
                SqlCommand cmd = new SqlCommand(insert, connection);
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = id;
                cmd.Parameters.Add("@name", SqlDbType.VarChar);
                cmd.Parameters["@name"].Value = name;
                cmd.Parameters.Add("@email", SqlDbType.VarChar);
                cmd.Parameters["@email"].Value = email;
                cmd.Parameters.Add("@major", SqlDbType.VarChar);
                cmd.Parameters["@major"].Value = depname;
                cmd.ExecuteNonQuery();

                FillData();

                tbxSID.Text = "";
                tbxSName.Text = "";
                textBox3.Text = "";

                MessageBox.Show("Insert successful!");
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbxSID.Text = "";
            tbxSName.Text = "";
            textBox3.Text = "";
            cbxMajor.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to edit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = int.Parse(tbxSID.Text);
                string name = tbxSName.Text;
                string email = textBox3.Text; // Chuyển đổi email thành kiểu dữ liệu string



                connection.Open();

                string update = "UPDATE Students SET studentName = @name, Email = @email WHERE StudentID = @id";
                SqlCommand cmd = new SqlCommand(update, connection);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@id", id);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    FillData();
                    MessageBox.Show(this, "Update successfully!", "Result!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void dgvStudentTab_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudentTab.Rows[e.RowIndex];
                tbxSID.Text = row.Cells["studentID"].Value.ToString();
                tbxSName.Text = row.Cells["StudentName"].Value.ToString();
                textBox3.Text = row.Cells["Email"].Value.ToString();
                cbxMajor.SelectedItem = row.Cells["Major"].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                connection.Open();
                string delete = "delete from Students where StudentID = @id";
                SqlCommand cmd = new SqlCommand(delete, connection);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = tbxSID.Text;
                cmd.ExecuteNonQuery();
                FillData();
                MessageBox.Show(this, "Delete successfully!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = tbxSearch.Text;
            string query = "SELECT * FROM Students WHERE StudentID = @id";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = int.Parse(searchValue);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            reader.Close();
            connection.Close();
            dgvStudentTab.DataSource = dt;
        }

        private void CoursesTab_Click(object sender, EventArgs e)
        {
            connection.Open();
            FillCourseData();
            GetCourse();

        }
        private void FillCourseData()
        {
            string query = "select * from Courses";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(dt);
            dgvCourse.DataSource = dt;
            connection.Close();
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
                string depid = cbxDep.SelectedValue.ToString();


                connection.Open();

                // Select query
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

                // Insert query
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
                // Handle and display any exceptions that occurred
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
                string update = "UPDATE Courses SET CourseName = @name, Credits = @credit WHERE CourseID = @id";
                connection.Open();
                SqlCommand cmd = new SqlCommand(update, connection);
                cmd.Parameters.Add("@name", SqlDbType.VarChar);
                cmd.Parameters["@name"].Value = tbxCName.Text;
                cmd.Parameters.Add("@credit", SqlDbType.Int);
                cmd.Parameters["@credit"].Value = tbxCredit.Text;
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = tbxCID.Text;

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    FillCourseData();
                    MessageBox.Show(this, "Update successfully!!!", "Result!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                cbxDep.SelectedItem = row.Cells["DepartmentID"].Value.ToString();
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

        private void ClassroomTab_Click(object sender, EventArgs e)
        {
            connection.Open();
            FillClassroomData();
        }

        private void FillClassroomData()
        {
            string query = "select * from Classrooms";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(dt);
            dgvClassroom.DataSource = dt;
            connection.Close();
        }
        private void GetClassroom()
        {

        }

        private void btnRInsert_Click(object sender, EventArgs e)
        {

            string roomname = tbxRName.Text;
            int capacity = int.Parse(tbxCap.Text);

            connection.Open();
            string insert = "INSERT INTO Classrooms (ClassroomName, Capacity) VALUES (@roomname, @capacity)";
            SqlCommand cmd = new SqlCommand(insert, connection);
            cmd.Parameters.AddWithValue("@roomname", roomname);
            cmd.Parameters.AddWithValue("@capacity", capacity);
            cmd.ExecuteNonQuery();
            connection.Close();

            FillClassroomData();
            tbxRName.Text = "";
            tbxCap.Text = "";

            MessageBox.Show("Insert successful!");

        }

        private void btnRCancel_Click(object sender, EventArgs e)
        {

            tbxRName.Text = "";
            tbxCap.Text = "";
        }

        private void btnRUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to edit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                string roomname = tbxRName.Text;
                int capacity = int.Parse(tbxCap.Text);
                connection.Open();
                string update = "update Classrooms set Capacity =@cap where ClassroomName = @roomname";
                SqlCommand cmd = new SqlCommand(update, connection);
                cmd.Parameters.AddWithValue("@cap", capacity);
                cmd.Parameters.AddWithValue("@roomname", roomname);

                int rowsAffected = cmd.ExecuteNonQuery();
                connection.Close();

                if (rowsAffected > 0)
                {
                    FillClassroomData();
                    MessageBox.Show(this, "Update successfully!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
        }

        private void dgvClassroom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvClassroom.Rows[e.RowIndex];
                tbxRName.Text = row.Cells["ClassroomName"].Value.ToString();
                tbxCap.Text = row.Cells["Capacity"].Value.ToString();

            }
        }

        private void btnRDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                connection.Open();
                string delete = "delete from Classrooms where ClassroomName = @roomname";
                SqlCommand cmd = new SqlCommand(delete, connection);
                cmd.Parameters.Add("@roomname", SqlDbType.VarChar).Value = tbxRName.Text;
                cmd.ExecuteNonQuery();
                FillClassroomData();
                MessageBox.Show(this, "Delete successfully!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnRSearch_Click(object sender, EventArgs e)
        {
            string searchValue = tbxRSearch.Text;
            string query = "SELECT * FROM Classrooms WHERE ClassroomName = @roomname";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add("@roomname", SqlDbType.VarChar).Value = searchValue;
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();

            if (reader.HasRows)
            {
                dt.Load(reader);
            }

            reader.Close();
            connection.Close();
            dgvClassroom.DataSource = dt;
        }

        private void ScheduleTab_Click(object sender, EventArgs e)
        {
            connection.Open();
            FillScheduleData();

        }
        private void FillScheduleData()
        {
            string query = "SELECT * FROM Schedule";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(dt);
            dgvSchedule.DataSource = dt;
            connection.Close();
        }
        public void GetCourseName()
        {


        }
        private void tbxECID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEInsert_Click(object sender, EventArgs e)
        {
            if (cbxDay.SelectedItem != null)
            {
                string day = cbxDay.SelectedItem.ToString();
                string room = tbxERoom.Text;
                string stime = tbxSTime.Text;
                string etime = tbxETime.Text;
                string ins = tbxInstructor.Text;
                int id = int.Parse(tbxEID.Text);
                int cid = int.Parse(tbxECID.Text);

                string insert = "INSERT INTO Schedule (ScheduleID, CourseID, ClassroomName, StartTime, EndTime, Instructor, Day_Of_Week) VALUES (@id, @cid, @room, @stime, @etime, @ins, @day)";
                connection.Open();
                SqlCommand command = new SqlCommand(insert, connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@cid", cid);
                command.Parameters.AddWithValue("@room", room);
                command.Parameters.AddWithValue("@stime", stime);
                command.Parameters.AddWithValue("@etime", etime);
                command.Parameters.AddWithValue("@ins", ins);
                command.Parameters.AddWithValue("@day", day);
                command.ExecuteNonQuery();
                connection.Close();

                FillScheduleData();
                tbxEID.Text = "";
                tbxECID.Text = "";
                tbxERoom.Text = "";
                tbxSTime.Text = "";
                tbxETime.Text = "";
                tbxInstructor.Text = "";

                MessageBox.Show("Insert successful");
            }
        }

        private void btnEUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to edit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string day = cbxDay.SelectedItem.ToString();
                string room = tbxERoom.Text;
                string stime = tbxSTime.Text;
                string etime = tbxETime.Text;
                string ins = tbxInstructor.Text;
                int id = int.Parse(tbxEID.Text);
                int cid = int.Parse(tbxECID.Text); ;

                connection.Open();

                string update = "UPDATE Schedule SET CourseID = @cid, ClassroomName = @room, StartTime = @stime, EndTime = @etime, Instructor = @ins, Day_Of_Week = @day WHERE ScheduleID = @id";
                SqlCommand cmd = new SqlCommand(update, connection);
                cmd.Parameters.AddWithValue("@cid", cid);
                cmd.Parameters.AddWithValue("@room", room);
                cmd.Parameters.AddWithValue("@stime", stime);
                cmd.Parameters.AddWithValue("@etime", etime);
                cmd.Parameters.AddWithValue("@ins", ins);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@day", day);
                int rowsAffected = cmd.ExecuteNonQuery();
                connection.Close();

                if (rowsAffected > 0)
                {
                    FillScheduleData();
                    MessageBox.Show(this, "Update successfully!", "Result!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgvSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvSchedule.Rows[e.RowIndex];
                tbxEID.Text = row.Cells["ScheduleID"].Value.ToString();
                tbxECID.Text = row.Cells["CourseN"].Value.ToString();
                tbxRName.Text = row.Cells["ClassroomN"].Value.ToString();
                cbxDay.SelectedItem = row.Cells["DayOfWeek"].Value.ToString();
                tbxSTime.Text = row.Cells["StartTime"].Value.ToString();
                tbxETime.Text = row.Cells["EndTime"].Value.ToString();
                tbxInstructor.Text = row.Cells["Instructor"].Value.ToString();
            }
        }

        private void btnEDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Lấy giá trị từ TextBox
                int scheduleID;
                if (int.TryParse(tbxEID.Text, out scheduleID))
                {
                    // Tạo câu truy vấn DELETE
                    string deleteQuery = "DELETE FROM Schedule WHERE ScheduleID = @id";

                    // Tạo đối tượng SqlCommand và thực thi câu truy vấn DELETE
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", scheduleID);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }

                    // Cập nhật DataGridView
                    FillScheduleData();
                    MessageBox.Show("Delete successfully!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Invalid Schedule ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnECancel_Click(object sender, EventArgs e)
        {
            tbxEID.Text = "";
            tbxECID.Text = "";
            tbxRName.Text = "";
            cbxDay.Text = "";
            tbxSTime.Text = "";
            tbxETime.Text = "";
            tbxInstructor.Text = "";
        }

        private void btnESearch_Click(object sender, EventArgs e)
        {
            string searchValue = textBox1.Text;
            string query = "SELECT * FROM Schedule WHERE ScheduleID = @id OR CourseID = @cid";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = searchValue;
            cmd.Parameters.Add("@cid", SqlDbType.Int).Value = searchValue;
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();

            if (reader.HasRows)
            {
                dt.Load(reader);
            }

            reader.Close();
            connection.Close();
            dgvSchedule.DataSource = dt;
        }
    }
}
