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
    public partial class EmployeeManagement : Form
    {
        string id;
        public EmployeeManagement()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }

        private void btnViewInfo_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=HP-Victus;Initial Catalog=BakeryDB;Integrated Security=True;");
            conn.Open();

            string query = "SELECT * FROM UserInfo WHERE Role!='Admin'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridViewEmployee.DataSource = dt;
            dataGridViewEmployee.AutoGenerateColumns = true;

            conn.Close();

        }

 // Search employee by name and role
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //if both are empty
            if (textName.Text == "" && textRole.Text == "")
            {
                MessageBox.Show("Please fill Name or Role!");
                return;
            }

            // Search query
            SqlConnection conn = new SqlConnection(@"Data Source=HP-Victus;Initial Catalog=BakeryDB;Integrated Security=True;");
            conn.Open();

            string query = "SELECT * FROM UserInfo WHERE Role!='Admin' AND (Name LIKE '%" + textName.Text + "%' AND Role LIKE '%" + textRole.Text + "%')";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No employee found!");
                dataGridViewEmployee.DataSource = null;
            }
            else
            {
                dataGridViewEmployee.DataSource = dt;
                dataGridViewEmployee.AutoGenerateColumns = true;
            }

            conn.Close();
        }

        
        private void dataGridViewEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id = dataGridViewEmployee.Rows[e.RowIndex].Cells[0].Value.ToString();
                textName.Text = dataGridViewEmployee.Rows[e.RowIndex].Cells[1].Value.ToString();
                textPassword.Text = dataGridViewEmployee.Rows[e.RowIndex].Cells[3].Value.ToString();
                dtpDOB.Text = dataGridViewEmployee.Rows[e.RowIndex].Cells[4].Value.ToString();
                textContact.Text = dataGridViewEmployee.Rows[e.RowIndex].Cells[5].Value.ToString();
                textEmail.Text = dataGridViewEmployee.Rows[e.RowIndex].Cells[6].Value.ToString();
                textRole.Text = dataGridViewEmployee.Rows[e.RowIndex].Cells[7].Value.ToString();
                textGender.Text = dataGridViewEmployee.Rows[e.RowIndex].Cells[9].Value.ToString();
                textAddress.Text = dataGridViewEmployee.Rows[e.RowIndex].Cells[10].Value.ToString();
            }
    }
        //Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (textName.Text == "" || textRole.Text == "")
            {
                MessageBox.Show("Please fill all required fields!");
                return;
            }

            SqlConnection conn = new SqlConnection(@"Data Source=HP-Victus;Initial Catalog=BakeryDB;Integrated Security=True;");
            conn.Open();

            string query = "UPDATE UserInfo SET Name='" + textName.Text + "',Password='" + textPassword.Text + "',Contact='" + textContact.Text + "',Email='" + textEmail.Text + "',Role='" + textRole.Text + "',DOB='" + dtpDOB.Value.ToString("yyyy-MM-dd") + "',Gender='" + textGender.Text + "',Address='" + textAddress.Text + "' WHERE UserId=" + Convert.ToInt32(id); 
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Updated Successfully!");
            Clear();
        }
        private void Clear()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=HP-Victus;Initial Catalog=BakeryDB;Integrated Security=True;");
            conn.Open();

            string query = "SELECT * FROM UserInfo WHERE Role!='Admin'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridViewEmployee.DataSource = dt;
            dataGridViewEmployee.AutoGenerateColumns = true;
            conn.Close();
            textName.Text = textPassword.Text = textContact.Text = textEmail.Text = textRole.Text = textGender.Text = textAddress.Text = "";
        }



        //Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=HP-Victus;Initial Catalog=BakeryDB;Integrated Security=True;");
            conn.Open();

            string query = "DELETE FROM UserInfo WHERE UserId=" + Convert.ToInt32(id);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Deleted Successfully!");
            Clear();
        }



        //Insert
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (textName.Text == "" || textPassword.Text == "" || textRole.Text == "")
            {
                MessageBox.Show("Please fill the information!");
                return;
            }

            SqlConnection conn = new SqlConnection(@"Data Source=HP-Victus;Initial Catalog=BakeryDB;Integrated Security=True;");
            conn.Open();

           // string query = "INSERT INTO UserInfo (Name, UserName, Password, DOB, Contact, Email, Role, Status, Gender, Address) VALUES('" + textName.Text + "','" + textName.Text + "','" + textPassword.Text + "','" + textDOB.Text + "','" + textContact.Text + "','" + textEmail.Text + "','" + textRole.Text + "','Active','" + textGender.Text + "','" + textAddress.Text + "')";
            string query = "INSERT INTO UserInfo (Name, UserName, Password, DOB, Contact, Email, Role, Status, Gender, Address) VALUES('" + textName.Text + "','" + textName.Text + "','" + textPassword.Text + "','" + dtpDOB.Value.ToString("yyyy-MM-dd") + "','" + textContact.Text + "','" + textEmail.Text + "','" + textRole.Text + "','Active','" + textGender.Text + "','" + textAddress.Text + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Inserted Successfully!");
            Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
