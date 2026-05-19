using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BakeryShop
{
    public partial class MakePayment : Form
    {
        SqlConnection conn = new SqlConnection(
        @"Data Source=HP-Victus;Initial Catalog=BakeryDB;Integrated Security=True;");

        public MakePayment()
        {
            InitializeComponent();

            this.Load += MakePayment_Load;
        }

        private void MakePayment_Load(object sender, EventArgs e)
        {
            conn.Open();

            string invoiceQuery = "SELECT ISNULL(MAX(InvoiceNo),0)+1 FROM OrderInvoice";

            SqlCommand invoiceCmd = new SqlCommand(invoiceQuery, conn);

            txtInvoiceNo.Text = invoiceCmd.ExecuteScalar().ToString();

            conn.Close();

            decimal total = 0;

            for (int i = 0; i < Cart.cartTable.Rows.Count; i++)
            {
                total += Convert.ToDecimal(
                Cart.cartTable.Rows[i]["Total"]);
            }

            txtTotalBill.Text = total.ToString();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == "" ||
                txtCustomerPhoneNo.Text == "")
            {
                MessageBox.Show("Please fill customer information!");
                return;
            }

            conn.Open();

            string query = "INSERT INTO OrderInvoice " +
                           "(OrderDate, CustomerName, CustomerPhone, TotalAmount, UserId) VALUES ('"
                           + dtpOrderDate.Value.ToString("yyyy-MM-dd") + "','"
                           + txtCustomerName.Text + "','"
                           + txtCustomerPhoneNo.Text + "',"
                           + txtTotalBill.Text + ",11)";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.ExecuteNonQuery();

            string getIdQuery = "SELECT MAX(InvoiceNo) FROM OrderInvoice";

            SqlCommand getIdCmd = new SqlCommand(getIdQuery, conn);

            string invoiceNo = getIdCmd.ExecuteScalar().ToString();

            for (int i = 0; i < Cart.cartTable.Rows.Count; i++)
            {
                string detailQuery = "INSERT INTO OrderDetails " +
                                     "(InvoiceNo, ProductId, Quantity, UnitPrice) VALUES ("
                                     + invoiceNo + ","
                                     + Convert.ToInt32(Cart.cartTable.Rows[i]["ProductId"]) + ","
                                     + Convert.ToInt32(Cart.cartTable.Rows[i]["Quantity"]) + ","
                                     + Convert.ToDecimal(Cart.cartTable.Rows[i]["Price"]) + ")";

                SqlCommand detailCmd = new SqlCommand(detailQuery, conn);

                detailCmd.ExecuteNonQuery();

                string stockQuery = "UPDATE Product SET StockQuantity = StockQuantity - "
                                    + Convert.ToInt32(Cart.cartTable.Rows[i]["Quantity"])
                                    + " WHERE ProductId = "
                                    + Convert.ToInt32(Cart.cartTable.Rows[i]["ProductId"]);

                SqlCommand stockCmd = new SqlCommand(stockQuery, conn);

                stockCmd.ExecuteNonQuery();
            }

            conn.Close();

            MessageBox.Show("Order Confirmed.");

            Cart.cartTable.Clear();

            Cashier cashier = new Cashier();
            cashier.Show();
            this.Hide();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.Show();
            this.Hide();
        }
    }
}