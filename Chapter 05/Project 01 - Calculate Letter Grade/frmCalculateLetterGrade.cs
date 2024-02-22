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
            decimal numericGrade = Convert.ToDecimal(txtNumericGrade.Text);
            string letterGrade = "";

            if (numericGrade >= 90)
            {
                letterGrade = "A";
            }
            else if (numericGrade >= 80)
            {
                letterGrade = "B";
            }
            else if (numericGrade >= 70)
            {
                letterGrade = "C";
            }
            else if (numericGrade >= 60)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }

            lblLetterGrade.Text = letterGrade.ToString();
        }
    

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNumericGrade_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCalculaterLetterGrade_Load(object sender, EventArgs e)
        {

        }
        
        private void lblLetterGrade_Click(object sender, EventArgs e)
        {

        }
    }
}