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
    public partial class StudentForm : Form
    {
        SqlConnection con;
        
        public StudentForm()
        {
            InitializeComponent();
            con = new SqlConnection("Server= localhost; Database= Scheduling_System; Integrated Security=True;");
            
        }
       

        private void StudentForm_Load(object sender, EventArgs e)
        
        {
            con.Open();
            FillData();
        }
        public void FillData()
        {
            string query = "select * from Schedule";
            DataTable dataTable = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(query, con);
            ad.Fill(dataTable);
            dgvStudentTab.DataSource = dataTable;
            con.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Dispose();
        }
    }
}
