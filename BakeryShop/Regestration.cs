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
    public partial class Regestration : Form
    {
        public Regestration()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
   // Check if fields are empty
            if (textName.Text == "" || textUsername.Text == "" || textPassword.Text == "" || textContact.Text == "" || comboBoxRole.Text == "" || comboBoxStatus.Text == "")
            {
                MessageBox.Show("Please fill all required fields!");
                return;
            }

            // Check gender
            string gender = "";
            if (btnMale.Checked)
                gender = "Male";
            else if (btnFemale.Checked)
                gender = "Female";
            else
            {
                MessageBox.Show("Please select Gender!");
                return;
            }

            SqlConnection conn = new SqlConnection(@"Data Source=HP-Victus;Initial Catalog=BakeryDB;Integrated Security=True;");
            conn.Open();

            //insert database
            string query = "INSERT INTO UserInfo (Name, UserName, Password, Contact, Email, Role, Status, DOB, Gender, Address) VALUES('" + textName.Text + "','" + textUsername.Text + "','" + textPassword.Text + "','" + textContact.Text + "','" + textEmail.Text + "','" + comboBoxRole.Text + "','" + comboBoxStatus.Text + "','" + dateTimePickerDOB.Value.ToString("yyyy-MM-dd") + "','" + gender + "','" + richTextBoxAddress.Text + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Registration Successful!");

    //back to login page
            Login login = new Login();
            login.Show();
            this.Hide();
        
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
