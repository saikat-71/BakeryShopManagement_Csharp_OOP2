using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BakeryShop
{
    public partial class ProductManagement : Form
    {
        string id;
        public ProductManagement()
        {
            InitializeComponent();

            dataGridViewProduct.CellClick += dataGridViewProduct_CellClick;
            btnViewProduct.Click += btnViewProduct_Click;
        }
        private void ProductManagement_Load(object sender, EventArgs e)
        {

        }
        private void btnViewProduct_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=HP-Victus;Initial Catalog=BakeryDB;Integrated Security=True;");
            conn.Open();

            string query = "SELECT Product.ProductId, Product.ProductName, Product.CategoryId, Category.CategoryName, Product.Price, Product.StockQuantity, Product.ExpiryDate, Product.LastUpdatedBy, Product.LastUpdatedDate FROM Product INNER JOIN Category ON Product.CategoryId = Category.CategoryId";

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];

            dataGridViewProduct.DataSource = dt;
            dataGridViewProduct.AutoGenerateColumns = true;

            conn.Close();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "" &&
                txtCategoryID.Text == "" &&
                txtCategoryName.Text == "")
            {
                MessageBox.Show("Please fill Product Name or Category information!");
                return;
            }

            SqlConnection conn = new SqlConnection(@"Data Source=HP-Victus;Initial Catalog=BakeryDB;Integrated Security=True;");
            conn.Open();

            string query = "SELECT Product.ProductId, Product.ProductName, Product.CategoryId, Category.CategoryName, Product.Price, Product.StockQuantity, Product.ExpiryDate, Product.LastUpdatedBy, Product.LastUpdatedDate FROM Product INNER JOIN Category ON Product.CategoryId = Category.CategoryId WHERE Product.ProductName LIKE '%" + txtProductName.Text + "%' AND Product.CategoryId LIKE '%" + txtCategoryID.Text + "%' AND Category.CategoryName LIKE '%" + txtCategoryName.Text + "%'";

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No product found!");
                dataGridViewProduct.DataSource = null;
            }
            else
            {
                dataGridViewProduct.DataSource = dt;
                dataGridViewProduct.AutoGenerateColumns = true;
            }

            conn.Close();
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "" ||
                txtCategoryID.Text == "" ||
                txtPrice.Text == "" ||
                txtStock.Text == "" ||
                txtExpiryDate.Text == "" ||
                txtLastUpdatedBy.Text == "")
            {
                MessageBox.Show("Please fill the information!");
                return;
            }

            SqlConnection conn = new SqlConnection(@"Data Source=HP-Victus;Initial Catalog=BakeryDB;Integrated Security=True;");
            conn.Open();

            string query = "INSERT INTO Product (ProductName, CategoryId, Price, StockQuantity, ExpiryDate, LastUpdatedBy, LastUpdatedDate) VALUES('" + txtProductName.Text + "'," + Convert.ToInt32(txtCategoryID.Text) + "," + Convert.ToDecimal(txtPrice.Text) + "," + Convert.ToInt32(txtStock.Text) + ",'" + Convert.ToDateTime(txtExpiryDate.Text).ToString("yyyy-MM-dd") + "'," + Convert.ToInt32(txtLastUpdatedBy.Text) + ",'" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Inserted Successfully!");
            Clear();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (id == "" || id == null)
            {
                MessageBox.Show("Please select a product!");
                return;
            }

            if (txtProductName.Text == "" ||
                txtCategoryID.Text == "" ||
                txtPrice.Text == "" ||
                txtStock.Text == "" ||
                txtExpiryDate.Text == "" ||
                txtLastUpdatedBy.Text == "")
            {
                MessageBox.Show("Please fill all required fields!");
                return;
            }

            SqlConnection conn = new SqlConnection(@"Data Source=HP-Victus;Initial Catalog=BakeryDB;Integrated Security=True;");
            conn.Open();

            string query = "UPDATE Product SET ProductName='" + txtProductName.Text + "',CategoryId=" + Convert.ToInt32(txtCategoryID.Text) + ",Price=" + Convert.ToDecimal(txtPrice.Text) + ",StockQuantity=" + Convert.ToInt32(txtStock.Text) + ",ExpiryDate='" + Convert.ToDateTime(txtExpiryDate.Text).ToString("yyyy-MM-dd") + "',LastUpdatedBy=" + Convert.ToInt32(txtLastUpdatedBy.Text) + ",LastUpdatedDate='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE ProductId=" + Convert.ToInt32(id);

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Updated Successfully!");
            Clear();
        }
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (id == "" || id == null)
            {
                MessageBox.Show("Please select a product!");
                return;
            }

            SqlConnection conn = new SqlConnection(@"Data Source=HP-Victus;Initial Catalog=BakeryDB;Integrated Security=True;");
            conn.Open();

            string query = "DELETE FROM Product WHERE ProductId=" + Convert.ToInt32(id);

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Deleted Successfully!");
            Clear();
        }
        private void Clear()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=HP-Victus;Initial Catalog=BakeryDB;Integrated Security=True;");
            conn.Open();

            string query = "SELECT Product.ProductId, Product.ProductName, Product.CategoryId, Category.CategoryName, Product.Price, Product.StockQuantity, Product.ExpiryDate, Product.LastUpdatedBy, Product.LastUpdatedDate FROM Product INNER JOIN Category ON Product.CategoryId = Category.CategoryId";

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];

            dataGridViewProduct.DataSource = dt;
            dataGridViewProduct.AutoGenerateColumns = true;

            conn.Close();

            id = "";

            txtProductName.Text = "";
            txtCategoryID.Text = "";
            txtCategoryName.Text = "";
            txtPrice.Text = "";
            txtStock.Text = "";
            txtExpiryDate.Text = "";
            txtLastUpdatedBy.Text = "";
            txtLastUpdatedDate.Text = "";
        }
        private void dataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id = dataGridViewProduct.Rows[e.RowIndex].Cells[0].Value.ToString();

                txtProductName.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtCategoryID.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtCategoryName.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPrice.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtStock.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtExpiryDate.Text = Convert.ToDateTime(dataGridViewProduct.Rows[e.RowIndex].Cells[6].Value).ToString("yyyy-MM-dd");
                txtLastUpdatedBy.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtLastUpdatedDate.Text = Convert.ToDateTime(
                dataGridViewProduct.Rows[e.RowIndex].Cells[8].Value).ToString("yyyy-MM-dd");
            }
        }
        private void label1_Click_1(object sender, EventArgs e) {}
        private void label5_Click(object sender, EventArgs e) {}
        private void dataGridView1_CellContentClick(object sender, EventArgs e) {}
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            ManagerDashboard md = new ManagerDashboard();
            md.Show();
            this.Hide();
        }
    }
}