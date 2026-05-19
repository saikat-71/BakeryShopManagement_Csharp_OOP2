using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BakeryShop
{
    public partial class Login : Form
    {
      
        public static string LoggedInName = "";
        public static string LoggedInUsername = "";

        public Login()
        {
            InitializeComponent();
        }

      
        SqlConnection conn = new SqlConnection(
            @"Data Source=HP-Victus;Initial Catalog=BakeryDB;Integrated Security=True;"
        );

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //login button
        private void btnLogin_Click(object sender, EventArgs e)
        {
         
            if (textUsername.Text == "" || textPassword.Text == "")
            {
                MessageBox.Show("Please enter Username and Password!");
                return;
            }

            try
            {
                conn.Open();

                string query = "SELECT * FROM UserInfo WHERE UserName=@username AND Password=@password AND Status='Active'";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@username", textUsername.Text);
                cmd.Parameters.AddWithValue("@password", textPassword.Text);

                SqlDataReader dr = cmd.ExecuteReader();

                //login by role name match
                if (dr.Read())
                {
                    LoggedInName = dr["Name"].ToString();
                    LoggedInUsername = dr["UserName"].ToString();

                    string role = dr["Role"].ToString();

                    //open admin form
                    if (role == "Admin")
                    {
                        Admin admin = new Admin();
                        admin.Show();
                        this.Hide();
                    }

                    //manager form open
                    else if (role == "Manager")
                    {
                        ManagerDashboard manager = new ManagerDashboard();
                        manager.Show();
                        this.Hide();
                    }

                    //cashier form open
                    
                    else if (role == "Cashier")
                    {
                        Cashier ca = new Cashier();
                        ca.Show();
                        this.Hide();
                    }

                    else
                    {
                        MessageBox.Show("Invalid Role!");
                    }
                }

                //log in fail
                else
                {
                    MessageBox.Show("Wrong Username or Password!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

    
        private void btnSignup_Click(object sender, EventArgs e)
        {
            Regestration reg = new Regestration();
            reg.Show();
            this.Hide();
        }

        // skow/hide pass
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
                textPassword.PasswordChar = '\0';
            else
                textPassword.PasswordChar = '*';
        }

        // pass forget? button
        private void btnForgetPassword_Click(object sender, EventArgs e)
        {
            if (textUsername.Text == "")
            {
                MessageBox.Show("Please enter your Username first!");
                return;
            }

            try
            {
                conn.Open();

                string query = "SELECT Password FROM UserInfo WHERE UserName=@username";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@username", textUsername.Text);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Your Password is : " + dr["Password"].ToString());
                }
                else
                {
                    MessageBox.Show("Username not found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}