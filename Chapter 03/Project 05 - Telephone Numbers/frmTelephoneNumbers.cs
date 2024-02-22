namespace Telephone_Numbers
{
    public partial class FrmTelephoneNumber : Form
    {
        public FrmTelephoneNumber()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertToNumericOnly_Click(object sender, EventArgs e)
        {
            txtNumericOnly.Text = txtAlphanumericNumbers.Text;


        }

        private void FrmTelephoneNumber_Load(object sender, EventArgs e)
        {

        }
    }
}