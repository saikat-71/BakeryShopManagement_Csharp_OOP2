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

namespace BakeryShop
{
    public partial class AccountStatus : Form
    {
        string userId;
        public AccountStatus()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=HP-Victus;Initial Catalog=BakeryDB;Integrated Security=True;");
            conn.Open();

            string query = "SELECT * FROM UserInfo WHERE Role!='Admin'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            dataGridViewAccountStatus.DataSource = ds.Tables[0];
            dataGridViewAccountStatus.AutoGenerateColumns = true;
            conn.Close();
        }

        private void dataGridViewAccountStatus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                userId = dataGridViewAccountStatus.Rows[e.RowIndex].Cells[0].Value.ToString();
                textName.Text = dataGridViewAccountStatus.Rows[e.RowIndex].Cells[1].Value.ToString();
                textRole.Text = dataGridViewAccountStatus.Rows[e.RowIndex].Cells[7].Value.ToString();
                textStatus.Text = dataGridViewAccountStatus.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=HP-Victus;Initial Catalog=BakeryDB;Integrated Security=True;");
            conn.Open();

            string query = "UPDATE UserInfo SET Status='Active' WHERE UserId=" + Convert.ToInt32(userId);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Account Enabled Successfully!");
            textStatus.Text = "Active";
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=HP-Victus;Initial Catalog=BakeryDB;Integrated Security=True;");
            conn.Open();

            string query = "UPDATE UserInfo SET Status='Inactive' WHERE UserId=" + Convert.ToInt32(userId);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Account Disabled Successfully!");
            textStatus.Text = "Inactive";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
