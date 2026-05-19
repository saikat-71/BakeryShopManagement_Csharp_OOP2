using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BakeryShop
{
    public partial class ProductList : Form
    {
        string productId;

        SqlConnection conn = new SqlConnection(
        @"Data Source=HP-Victus;Initial Catalog=BakeryDB;Integrated Security=True;");

        public ProductList()
        {
            InitializeComponent();
            dataGridViewProduct.CellClick += dataGridViewProduct_CellClick;
            this.Load += ProductList_Load;
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            ViewProduct();
        }

        private void ViewProduct()
        {
            conn.Open();

            string query = "SELECT ProductId, ProductName, Price, StockQuantity, ExpiryDate FROM Product";

            SqlDataAdapter adp = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();

            adp.Fill(dt);

            dataGridViewProduct.DataSource = dt;
            conn.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            conn.Open();

            string query = "SELECT ProductId, ProductName, Price, StockQuantity, ExpiryDate FROM Product WHERE ProductName LIKE '%" + txtSearch.Text + "%'";

            SqlDataAdapter adp = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();

            adp.Fill(dt);

            dataGridViewProduct.DataSource = dt;

            conn.Close();
        }

        private void dataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 &&
                dataGridViewProduct.Rows[e.RowIndex].Cells[0].Value != null)
            {
                productId = dataGridViewProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (productId == null)
            {
                MessageBox.Show("Please select a product first!");
                return;
            }

            if (numQuantity.Value <= 0)
            {
                MessageBox.Show("Please select quantity!");
                return;
            }

            if (Cart.cartTable.Columns.Count == 0)
            {
                Cart.cartTable.Columns.Add("ProductId");
                Cart.cartTable.Columns.Add("ProductName");
                Cart.cartTable.Columns.Add("Price");
                Cart.cartTable.Columns.Add("Quantity");
                Cart.cartTable.Columns.Add("Total");
            }

            string name = dataGridViewProduct.CurrentRow.Cells[1].Value.ToString();
            decimal price = Convert.ToDecimal(dataGridViewProduct.CurrentRow.Cells[2].Value);
            int quantity = Convert.ToInt32(numQuantity.Value);
            decimal total = price * quantity;

            Cart.cartTable.Rows.Add(productId, name, price, quantity, total);

            MessageBox.Show("Product added to cart!");
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            Cashier cd = new Cashier();
            cd.Show();
            this.Hide();
        }

        private void numQuantity_ValueChanged(object sender, EventArgs e) {}
        private void btnOrder_Click_1(object sender, EventArgs e)
        {
            if (Cart.cartTable.Rows.Count == 0)
            {
                MessageBox.Show("Please add product to cart first!");
                return;
            }

            Cart cart = new Cart();
            cart.Show();
            this.Hide();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}