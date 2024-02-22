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

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal monthlyInvestment = Convert.ToDecimal(txtMonthlyInvestment.Text);
            decimal yearlyInterestRate = Convert.ToDecimal(txtInteresetRate.Text);
            int years = Convert.ToInt32(txtYears.Text);

            int months = years * 12;
            decimal monthlyInterestraRate = yearlyInterestRate / 12 / 100;

            decimal futureValue = 0m;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestraRate);
            }
            txtFutureVulue.Text = futureValue.ToString("c");
            txtMonthlyInvestment.Focus();
        }
    }
}