namespace Student_Population
{
    public partial class FrmStudentPopulation : Form
    {
        public FrmStudentPopulation()
        {
            InitializeComponent();
        }

        private void FrmStudentPopulation_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProjectStudentPopulation_Click(object sender, EventArgs e)
        {
            decimal NumberofStudentsToday = Convert.ToDecimal(txtNumberOfStudents.Text);
            decimal AnnualGrowthRate = Convert.ToDecimal(txtAnnualGrowthRate.Text);
            int years = Convert.ToInt32(txtNumberOfYears.Text);

                decimal totalStudents = NumberofStudentsToday;
                for (int i = 1; i <= years; i++)
                {
                    totalStudents += (totalStudents * AnnualGrowthRate);
                }

            txtProjectNumberOfStudents.Text = totalStudents.ToString("n1");
            txtNumberOfStudents.Focus();
            }
        }
    }

