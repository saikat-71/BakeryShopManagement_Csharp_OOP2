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
    public partial class SalesReport : Form
    {
        public SalesReport()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=HP-Victus;Initial Catalog=BakeryDB;Integrated Security=True;");
            conn.Open();

            string query = "SELECT OrderInvoice.InvoiceNo, OrderInvoice.OrderDate, OrderInvoice.CustomerName, OrderInvoice.CustomerPhone, OrderInvoice.TotalAmount, UserInfo.Name FROM OrderInvoice, UserInfo WHERE OrderInvoice.UserId = UserInfo.UserId";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            dataGridViewSalesReport.DataSource = ds.Tables[0];
            dataGridViewSalesReport.AutoGenerateColumns = true;

            conn.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }

        private void dataGridViewSalesReport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textInvoiceno.Text = dataGridViewSalesReport.Rows[e.RowIndex].Cells[0].Value.ToString();
                textOrderdate.Text = dataGridViewSalesReport.Rows[e.RowIndex].Cells[1].Value.ToString();
                textCustomername.Text = dataGridViewSalesReport.Rows[e.RowIndex].Cells[2].Value.ToString();
                textCustomerphone.Text = dataGridViewSalesReport.Rows[e.RowIndex].Cells[3].Value.ToString();
                textTotalamount.Text = dataGridViewSalesReport.Rows[e.RowIndex].Cells[4].Value.ToString();
                textCashiername.Text = dataGridViewSalesReport.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
