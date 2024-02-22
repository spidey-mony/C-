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
            decimal subTotal = Convert.ToDecimal(txtSubtotal.Text);
            decimal discountPercent = .0m;

            if (subTotal >= 500)
            {
                discountPercent = .2m;
            }
            else if (subTotal >= 250 && subTotal < 500)
            {
                discountPercent = .15m;
            }
            else if (subTotal >= 100 && subTotal < 250)
            {
                discountPercent = .1m;
            }

            decimal discountAmount = subTotal * discountPercent;
            decimal invoiceTotal = subTotal - discountAmount;

            txtDiscountPercent.Text = discountPercent.ToString("p1");
            txtDiscountAmount.Text = discountAmount.ToString("c");
            txtTotal.Text = invoiceTotal.ToString("c");

            txtSubtotal.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInvoiceTotal_Load(object sender, EventArgs e)
        {

        }

        private void lblsub_Click(object sender, EventArgs e)
        {

        }
    }
}