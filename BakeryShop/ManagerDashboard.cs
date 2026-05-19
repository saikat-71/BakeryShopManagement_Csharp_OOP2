using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BakeryShop
{
    public partial class ManagerDashboard : Form
    {
        SqlConnection conn = new SqlConnection(
        @"Data Source=HP-Victus;Initial Catalog=BakeryDB;Integrated Security=True;");

        public ManagerDashboard()
        {
            InitializeComponent();
        }

        private void ManagerDashboard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + Login.LoggedInName;
            LoadProfile();
        }

        private void LoadProfile()
        {
            conn.Open();

            string query = "SELECT * FROM UserInfo WHERE UserName=@username";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", Login.LoggedInUsername);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                txtName.Text = reader["Name"].ToString();
                txtGender.Text = reader["Gender"].ToString();
                txtDOB.Text = Convert.ToDateTime(
                reader["DOB"]).ToString("dd-MM-yyyy");

                txtEmail.Text = reader["Email"].ToString();
                txtContact.Text = reader["Contact"].ToString();
                txtAddress.Text = reader["Address"].ToString();
            }

            conn.Close();
        }

        private void lblWelcome_Click(object sender, EventArgs e) {}
        private void label3_Click(object sender, EventArgs e) {}

        private void btnStaffManagement_Click(object sender, EventArgs e)
        {
            EmployeeView emp = new EmployeeView();
            emp.Show();
            this.Hide();
        }

        private void btnProductManagement_Click_1(object sender, EventArgs e)
        {
            ProductManagement pro = new ProductManagement();
            pro.Show();
            this.Hide();
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            SalesReportManager sr = new SalesReportManager();
            sr.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}