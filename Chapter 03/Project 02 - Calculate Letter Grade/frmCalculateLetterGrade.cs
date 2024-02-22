namespace Calculate_Letter_Grade
{
    public partial class frmCalculaterLetterGrade : Form
    {
        public frmCalculaterLetterGrade()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal numerice = Convert.ToDecimal(txtNumericGrade.Text);
            numerice = numerice + 10;
            lblLetterGrade.Text = numerice.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCalculaterLetterGrade_Load(object sender, EventArgs e)
        {

        }
    }
}