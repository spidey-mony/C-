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


        int numberOfInvoices = 0;
        decimal totalOfInvoices = 0m;
        decimal invoiceAverage = 0m;
        private void btnCal_Click(object sender, EventArgs e)
        {
            decimal subtotal = Convert.ToDecimal(txtEnterSubtotal.Text);
            decimal discountpercent = .25m;
            decimal discountamount = Math.Round(subtotal * discountpercent, 2);
            decimal invoiceTotal = subtotal - discountamount;

            txtSubtotal.Text = subtotal.ToString("c");
            txtDiscountAmount.Text = discountamount.ToString("c");
            txtDiscountPercent.Text = discountpercent.ToString("p1");
            txtTotal.Text = totalOfInvoices.ToString("c");

            numberOfInvoices++;
            totalOfInvoices += invoiceTotal;
            invoiceAverage = totalOfInvoices / numberOfInvoices;

            txtNumberofInvoices.Text = numberOfInvoices.ToString();
            txttotalOfInvoices.Text = totalOfInvoices.ToString("c");
            txtInvoiceAverages.Text = invoiceAverage.ToString("c");

            txtEnterSubtotal.Text = "";
            txtEnterSubtotal.Focus();


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblsub_Click(object sender, EventArgs e)
        {

        }

        private void frmtotal2_Load(object sender, EventArgs e)
        {

        }

        private void lblEnterSub_Click(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            numberOfInvoices = 0;
            totalOfInvoices = 0m;
            invoiceAverage = 0m;

            txtNumberofInvoices.Text = "";
            txttotalOfInvoices.Text = "";
            txtInvoiceAverages.Text = "";

            txtEnterSubtotal.Focus();

        }

        private void txtEnterSub_TextChanged(object sender, EventArgs e)
        {

        }
    }
}