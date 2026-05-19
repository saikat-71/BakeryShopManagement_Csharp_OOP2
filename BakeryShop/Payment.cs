using System;
using System.Windows.Forms;

namespace BakeryShop
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }
        private void btnCash_Click(object sender, EventArgs e)
        {
            if (Cart.cartTable.Rows.Count == 0)
            {
                MessageBox.Show("Cart is empty!");
                return;
            }
            MakePayment mp = new MakePayment();
            mp.Show();
            this.Hide();
        }
        private void btnCard_Click_1(object sender, EventArgs e)
        {
            if (Cart.cartTable.Rows.Count == 0)
            {
                MessageBox.Show("Cart is empty!");
                return;
            }
            MakePayment mp = new MakePayment();
            mp.Show();
            this.Hide();
        }
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.Show();
            this.Hide();
        }
    }
}