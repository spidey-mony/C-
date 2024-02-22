namespace Slipping_and_Handing
{
    public partial class frmShippingAndHandling : Form
    {
        public frmShippingAndHandling()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal ordertotal = Convert.ToDecimal(txtOrderTotal.Text);
            ordertotal = ordertotal + 10;
            txtCustomerType.Text = ordertotal.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShippingAndHandling_Load(object sender, EventArgs e)
        {

        }
    }
}