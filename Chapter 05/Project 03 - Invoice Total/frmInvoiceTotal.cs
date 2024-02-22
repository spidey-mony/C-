namespace Invoicetoal2
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            String customerType = txtCustomerType.Text;
            decimal subTotal = Convert.ToDecimal(txtSubtotal.Text);
            decimal discountPercent = .0m;

            if (customerType == "R")
            {
                if (subTotal < 100)
                    discountPercent = .0m;
                else if (subTotal >= 100 && subTotal < 250)
                    discountPercent = .1m;
                else if (subTotal >= 250)
                    discountPercent = .25m;
            }
            else if (customerType == "C")
            {
                if (subTotal < 250)
                    discountPercent = .2m;
                else
                    discountPercent = .3m;
            }
            else
            {
                discountPercent = .4m;
            }

            decimal discountAmount = subTotal * discountPercent;
            decimal invoiceTotal = subTotal - discountAmount;

            txtDiscountPercent.Text = discountPercent.ToString("p1");
            txtDiscountAmount.Text = discountAmount.ToString("c");
            txtTotal.Text = invoiceTotal.ToString("c");

            txtCustomerType.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmtotal2_Load(object sender, EventArgs e)
        {

        }

        private void txtDiscountPercent_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiscountAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}