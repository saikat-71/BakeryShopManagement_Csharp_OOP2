using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BakeryShop
{
    public partial class Cashier : Form
    {
        SqlConnection conn = new SqlConnection(
        @"Data Source=HP-Victus;Initial Catalog=BakeryDB;Integrated Security=True;");

        public Cashier()
        {
            InitializeComponent();
            this.Load += Cashier_Load_1;
        }

        private void Cashier_Load_1(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + Login.LoggedInName;
            conn.Open();

            string query = "SELECT Name, Gender, DOB, Email, Contact, Address FROM UserInfo WHERE UserName='" + Login.LoggedInUsername + "'";

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txtName.Text = dr["Name"].ToString();
                txtGender.Text = dr["Gender"].ToString();
                txtDOB.Text = Convert.ToDateTime(dr["DOB"]).ToString("yyyy-MM-dd");
                txtEmail.Text = dr["Email"].ToString();
                txtContact.Text = dr["Contact"].ToString();
                txtAddress.Text = dr["Address"].ToString();
            }
            conn.Close();
        }
        private void btnProduct_Click_1(object sender, EventArgs e)
        {
            ProductList pl = new ProductList();
            pl.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}