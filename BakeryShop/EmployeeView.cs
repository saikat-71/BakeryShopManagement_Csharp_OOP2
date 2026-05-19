using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BakeryShop
{
    public partial class EmployeeView : Form
    {
        string id;
        public EmployeeView()
        {
            InitializeComponent();
            dataGridViewEmployee.CellClick += dataGridViewEmployee_CellClick;
        }
        private void EmployeeView_Load(object sender, EventArgs e)
        {
            ViewEmployee();
        }
        private void ViewEmployee()
        {
            SqlConnection conn = new SqlConnection(
            @"Data Source=HP-Victus;Initial Catalog=BakeryDB;Integrated Security=True;");

            conn.Open();

            string query = "SELECT UserId, Name, Contact, Gender, Email, DOB, Role, Address FROM UserInfo WHERE Role!='Admin'";

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];

            dataGridViewEmployee.DataSource = dt;
            dataGridViewEmployee.AutoGenerateColumns = true;

            conn.Close();
        }
        private void dataGridViewEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtUserId.Text = dataGridViewEmployee.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = dataGridViewEmployee.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtContact.Text = dataGridViewEmployee.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtGender.Text = dataGridViewEmployee.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtEmail.Text = dataGridViewEmployee.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtDOB.Text = Convert.ToDateTime(dataGridViewEmployee.Rows[e.RowIndex].Cells[5].Value).ToString("yyyy-MM-dd");
                txtRole.Text = dataGridViewEmployee.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtAddress.Text = dataGridViewEmployee.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
        }
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(
            @"Data Source=HP-Victus;Initial Catalog=BakeryDB;Integrated Security=True;");

            conn.Open();

            string query = "SELECT UserId, Name, Contact, Gender, Email, DOB, Role, Address FROM UserInfo WHERE Role!='Admin' AND Name LIKE '%"
                           + txtName.Text + "%'";

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];

            dataGridViewEmployee.DataSource = dt;
            dataGridViewEmployee.AutoGenerateColumns = true;

            conn.Close();
        }
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            ManagerDashboard md = new ManagerDashboard();
            md.Show();
            this.Hide();
        }
        private void lblGender_Click(object sender, EventArgs e) {}
    }
}