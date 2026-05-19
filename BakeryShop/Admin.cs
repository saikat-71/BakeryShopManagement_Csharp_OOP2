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
using System.Xml.Linq;

namespace BakeryShop
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + Login.LoggedInName;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnShowadmininfo_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=HP-Victus;Initial Catalog=BakeryDB;Integrated Security=True;");
            conn.Open();

            string query = "SELECT * FROM UserInfo WHERE Role='Admin'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridViewAdmin.DataSource = dt;
            dataGridViewAdmin.AutoGenerateColumns = true;
            conn.Close();
        }

        private void dataGridViewAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textName.Text = dataGridViewAdmin.Rows[e.RowIndex].Cells[1].Value.ToString();
                textPassword.Text = dataGridViewAdmin.Rows[e.RowIndex].Cells[3].Value.ToString();
                textDOB.Text = dataGridViewAdmin.Rows[e.RowIndex].Cells[4].Value.ToString();
                textContact.Text = dataGridViewAdmin.Rows[e.RowIndex].Cells[5].Value.ToString();
                textEmail.Text = dataGridViewAdmin.Rows[e.RowIndex].Cells[6].Value.ToString();
                textRole.Text = dataGridViewAdmin.Rows[e.RowIndex].Cells[7].Value.ToString();
                textGender.Text = dataGridViewAdmin.Rows[e.RowIndex].Cells[9].Value.ToString();
                textAddress.Text = dataGridViewAdmin.Rows[e.RowIndex].Cells[10].Value.ToString();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnEmployeemanagement_Click(object sender, EventArgs e)
        {
    //employee management from
            EmployeeManagement emp = new EmployeeManagement();
            emp.Show();
            this.Hide();

        }

        private void btnCategoryManagement_Click(object sender, EventArgs e)
        {
            //catagory management from
            CategoryManagement cat = new CategoryManagement();
            cat.Show();
            this.Hide();
        }

        private void btnSalesreport_Click(object sender, EventArgs e)
        {
            SalesReport sr = new SalesReport();
            sr.Show();
            this.Hide();
        }

        private void btnAccountstatus_Click(object sender, EventArgs e)
        {
            AccountStatus ac = new AccountStatus();
            ac.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
