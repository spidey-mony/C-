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

        private void btnProjectStudentPopulation_Click(object sender, EventArgs e)
        {
            decimal NumberofStudents = Convert.ToDecimal(txtNumberOfStudentsToday.Text);
            NumberofStudents = NumberofStudents + 10;
            txtProjectNumberOfStudents.Text = NumberofStudents.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}