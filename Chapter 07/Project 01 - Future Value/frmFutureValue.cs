using System.Transactions;

namespace The_Future_value_
{
    public partial class FrmFutureValue : Form
    {
        public FrmFutureValue()
        {
            InitializeComponent();
        }

        private void FrmFuture_V_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private decimal CalculateFutureValue(decimal monthlyInvestment, int months, decimal monthlyInterestRate)
        {
            decimal futureValue = 0m;
            for (int i= 0;i< months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }
            return futureValue;
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {

                    decimal monthlyInvestment = Convert.ToDecimal(txtMonthlyInvestment.Text);
                    decimal yearlyInterestRate = Convert.ToDecimal(txtInteresetRate.Text);
                    int years = Convert.ToInt32(txtYears.Text);

                    int months = years * 12;
                    decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;

                    decimal futureValue = CalculateFutureValue(monthlyInvestment, months, monthlyInterestRate);

                    txtFutureValue.Text = futureValue.ToString("c");
                    txtMonthlyInvestment.Focus();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                    ex.GetType().ToString() + "\n" +
                    ex.StackTrace, "Exception" );
            }
        }
        
        public bool IsValidData()
        {
            return
                IsPresent(txtMonthlyInvestment, "Monthly Investment") &&
                IsDecimal(txtMonthlyInvestment, "Monthly Investment") &&
                IsWithinRange(txtMonthlyInvestment, "Monthly Invesment", 1, 1000) &&

                IsPresent(txtInteresetRate, "Yearly Interest Rate") &&
                IsDecimal(txtInteresetRate, "Yearly Interest Rate") &&
                IsWithinRange(txtInteresetRate, "Yearly Interest Rate", 1, 20) &&

                IsPresent(txtYears, "Number of Years") &&
                IsInt32(txtYears, "Number of Years") &&
                IsWithinRange(txtYears, "Number of Years", 1, 40);
        }
        public bool IsPresent(TextBox textBox, string name)
        {
            if(textBox.Text == "") 
            {
                MessageBox.Show(name + " is a required field.","Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }
        public bool IsDecimal(TextBox textBox, string name)
        {
            try
            {
                Convert.ToDecimal(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(name + " is a required field.","Entry Error");
                textBox.Focus(); 
                return false;

            }
        }
        public bool IsInt32(TextBox textBox, string name)
        {
            try
            {
                Convert.ToInt32(textBox.Text);
                return true;
            }
            catch(FormatException)
            {
                MessageBox.Show(name + " is a requied field.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }
        public bool IsWithinRange(TextBox textBox, string name, decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if(number < min || number > max)
            {
                MessageBox.Show(name + " must be between " + min + " and " + max + "!", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }
        private void txtMonthlyInvestment_TextChanged(object sender, EventArgs e)
        {

        }
        private void ClearFutureValue(object sender, EventArgs e)
        {
            txtFutureValue.Text = ""; 
        }
    }
}