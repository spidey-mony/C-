namespace Slipping_and_Handing
{
    public partial class frmSlippingAndHandling : Form
    {

        public frmSlippingAndHandling()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void frmSlippingAndHandling_Load(object sender, EventArgs e)
        {
         
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal orderTotal = Convert.ToDecimal(txtOrderTotal.Text);
            string customerType = txtCustomer.Text;

            decimal shippingCost;
            if (customerType == "P")
            {
                shippingCost = 0.00m;
            }
            else
            {
                if (orderTotal <= 25.00m)
                {
                    shippingCost = 5.00m;
                }
                else if (orderTotal <= 500.00m)
                {
                    shippingCost = 8.00m;
                }
                else if (orderTotal <= 1000.00m)
                {
                    shippingCost = 10.00m;
                }
                else if (orderTotal <= 5000.00m)
                {
                    shippingCost = 15.00m;
                }
                else
                {
                    shippingCost = 20.00m;
                }
            }

            decimal salesTax = 0.07m * (orderTotal + shippingCost);
            decimal grandTotal = orderTotal + shippingCost + salesTax;

            lblShipping.Text = shippingCost.ToString("c");
            lblSale.Text = salesTax.ToString("c");
            lblGrandTotal1.Text = grandTotal.ToString("c");
        }
        
        private void txtCustomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOrderTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblShopping_Click(object sender, EventArgs e)
        {

        }

        private void lblSale_Click(object sender, EventArgs e)
        {

        }
    }
}
