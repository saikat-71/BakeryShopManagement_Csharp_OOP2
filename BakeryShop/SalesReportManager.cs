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
    public partial class SalesReportManager : Form
    {
        string id;
        public SalesReportManager()
        {
            InitializeComponent();
            dataGridViewSalesReport.CellClick += dataGridViewSalesReport_CellClick;
            this.Load += SalesReportManager_Load;
        }
        private void SalesReportManager_Load(object sender, EventArgs e)
        {
            ViewSalesReport();
        }
        private void ViewSalesReport()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=HP-Victus;Initial Catalog=BakeryDB;Integrated Security=True;");

            conn.Open();
            string query = "SELECT OrderInvoice.InvoiceNo, OrderInvoice.OrderDate, OrderInvoice.CustomerName, OrderInvoice.CustomerPhone, OrderInvoice.TotalAmount, UserInfo.Name FROM OrderInvoice, UserInfo WHERE OrderInvoice.UserId = UserInfo.UserId";

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];

            dataGridViewSalesReport.DataSource = dt;
            dataGridViewSalesReport.AutoGenerateColumns = true;

            conn.Close();
        }
        private void dataGridViewSalesReport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id = dataGridViewSalesReport.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtInvoiceNo.Text = dataGridViewSalesReport.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtOrderDate.Text = Convert.ToDateTime(dataGridViewSalesReport.Rows[e.RowIndex].Cells[1].Value).ToString("yyyy-MM-dd");
                txtCustomerName.Text = dataGridViewSalesReport.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtCustpmerPhone.Text = dataGridViewSalesReport.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtTotalAmount.Text = dataGridViewSalesReport.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtCashierName.Text = dataGridViewSalesReport.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (txtInvoiceNo.Text == "")
            {
                MessageBox.Show("Please enter Invoice No!");
                return;
            }

            SqlConnection conn = new SqlConnection(
            @"Data Source=HP-Victus;Initial Catalog=BakeryDB;Integrated Security=True;");

            conn.Open();

            string query = "SELECT OrderInvoice.InvoiceNo, OrderInvoice.OrderDate, OrderInvoice.CustomerName, OrderInvoice.CustomerPhone, OrderInvoice.TotalAmount, UserInfo.Name FROM OrderInvoice, UserInfo WHERE OrderInvoice.UserId = UserInfo.UserId AND OrderInvoice.InvoiceNo LIKE '%" + txtInvoiceNo.Text + "%'";

            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            adp.Fill(ds);

            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No sales report found!");
                dataGridViewSalesReport.DataSource = null;
            }
            else
            {
                dataGridViewSalesReport.DataSource = dt;
                dataGridViewSalesReport.AutoGenerateColumns = true;
            }

            conn.Close();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            ManagerDashboard md = new ManagerDashboard();
            md.Show();
            this.Hide();
        }
        private void textBox2_TextChanged(object sender, EventArgs e) {}
    }
}