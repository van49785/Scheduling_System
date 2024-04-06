using System.Data;
using System.Data.SqlClient;

namespace ASM2_DDD
{
    public partial class Login : Form
    {
        SqlConnection connection;
        public Login()
        {
            InitializeComponent();
            connection = new SqlConnection("Server= localhost; Database= Scheduling_System; Integrated Security=True;");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = tbxEmail.Text;
            string password = tbxPass.Text;
            string query = "SELECT * FROM users WHERE email = @email AND password = @password";

            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add("@email", SqlDbType.VarChar);
            cmd.Parameters["@email"].Value = email;
            cmd.Parameters.Add("@password", SqlDbType.VarChar);
            cmd.Parameters["@password"].Value = password;

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string role = reader["role"].ToString();

                if (role.Equals("Student"))  // student@gmail.com, student
                {
                    this.Hide();
                    StudentForm studentForm = new StudentForm();
                    studentForm.ShowDialog();
                    this.Dispose();
                }
                else if (role.Equals("Administrator"))  // admin@gmail.com, admin
                {
                    this.Hide();
                    AdminForm admin = new AdminForm();
                    admin.ShowDialog();
                    this.Dispose();
                }
                else if (role.Equals("FPT Manager"))  // fptmanager@gmail.com, fptmanager
                {
                    this.Hide();
                    FPTManagerForm fPT = new FPTManagerForm();
                    fPT.ShowDialog();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("You are not allowed to access!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Wrong email or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();
        }

        private void kbxPass_CheckedChanged(object sender, EventArgs e)
        {
            if (kbxPass.Checked == true)
            {
                tbxPass.UseSystemPasswordChar = false;
            }
            else
            {
                tbxPass.UseSystemPasswordChar = true;
            }
        }
    }
}