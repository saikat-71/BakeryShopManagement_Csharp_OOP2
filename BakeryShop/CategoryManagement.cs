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
    public partial class CategoryManagement : Form
    {
        String categoryId;
        public CategoryManagement()
        {
            InitializeComponent();
        }

        private void CategoryManagement_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=HP-Victus;Initial Catalog=BakeryDB;Integrated Security=True;");
            conn.Open();

            string query = "SELECT * FROM Category";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            dataGridViewCategory.DataSource = ds.Tables[0];
            dataGridViewCategory.AutoGenerateColumns = true;

            conn.Close();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=HP-Victus;Initial Catalog=BakeryDB;Integrated Security=True;");
            conn.Open();

            string query = "SELECT * FROM Product";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            dataGridViewProduct.DataSource = ds.Tables[0];
            dataGridViewProduct.AutoGenerateColumns = true;

            conn.Close();
        }

        private void dataGridViewCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (textCategory.Text == "")
            {
                MessageBox.Show("Please enter Category Name!");
                return;
            }

            SqlConnection conn = new SqlConnection(@"Data Source=HP-Victus;Initial Catalog=BakeryDB;Integrated Security=True;");
            conn.Open();

            string query = "SELECT * FROM Category WHERE CategoryName LIKE '%" + textCategory.Text + "%'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No category found!");
                dataGridViewCategory.DataSource = null;
            }
            else
            {
                dataGridViewCategory.DataSource = dt;
                dataGridViewCategory.AutoGenerateColumns = true;
            }

            conn.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (textCategory.Text == "")
            {
                MessageBox.Show("Please enter Category Name!");
                return;
            }

            SqlConnection conn = new SqlConnection(@"Data Source=HP-Victus;Initial Catalog=BakeryDB;Integrated Security=True;");
            conn.Open();

            string query = "INSERT INTO Category (CategoryName) VALUES('" + textCategory.Text + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Category Inserted Successfully!");
            textCategory.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=HP-Victus;Initial Catalog=BakeryDB;Integrated Security=True;");
            conn.Open();

            string query = "DELETE FROM Category WHERE CategoryId=" + Convert.ToInt32(categoryId);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Deleted Successfully!");
            textCategory.Text = "";
        }

        private void dataGridViewCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                categoryId = dataGridViewCategory.Rows[e.RowIndex].Cells[0].Value.ToString();
                textCategory.Text = dataGridViewCategory.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }
    }
}
