using System;
using System.Data;
using System.Windows.Forms;

namespace BakeryShop
{
    public partial class Cart : Form
    {
        public static DataTable cartTable = new DataTable();
        public Cart()
        {
            InitializeComponent();
            this.Load += Cart_Load;
        }
        private void Cart_Load(object sender, EventArgs e)
        {
            dataGridViewCart.DataSource = cartTable;
            dataGridViewCart.AutoGenerateColumns = true;
            CalculateTotal();
        }
        private void CalculateTotal()
        {
            decimal total = 0;

            for (int i = 0; i < cartTable.Rows.Count; i++)
            {
                total += Convert.ToDecimal(cartTable.Rows[i]["Total"]);
            }
            lblTotal.Text = "Total : " + total.ToString();
        }
        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (cartTable.Rows.Count == 0)
            {
                MessageBox.Show("Cart is empty!");
                return;
            }
            Payment payment = new Payment();
            payment.Show();
            this.Hide();
        }
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            ProductList pl = new ProductList();
            pl.Show();
            this.Hide();
        }

        private void dataGridViewCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}