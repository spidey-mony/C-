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
            txtNumericOnly.Text = "";

            string alphanumericNumber = txtAlphanumericNumbers.Text.ToUpper();
            int length = alphanumericNumber.Length;

            for ( int i = 0; i < length; i++ )
            {
                string character = alphanumericNumber.Substring(i, 1);

                switch(character)
                {
                    case "A":
                    case "B":
                    case "C":
                        txtNumericOnly.Text += "2";
                        break;
                    case "D":
                    case "E":
                    case "F":
                        txtNumericOnly.Text += "3";
                        break;
                    case "G":
                    case "H":
                    case "I":
                        txtNumericOnly.Text += "4";
                        break;
                    case "J":
                    case "K":
                    case "L":
                        txtNumericOnly.Text += "5";
                        break;
                    case "M":
                    case "N":
                    case "O":
                        txtNumericOnly.Text += "6";
                        break;
                    case "P":
                    case "Q":
                    case "R":
                    case "S":
                        txtNumericOnly.Text += "7";
                        break;
                    case "T":
                    case "U":
                    case "V":
                        txtNumericOnly.Text += "8";
                        break;
                    case "W":
                    case "X":
                    case "Y":
                    case "Z":
                        txtNumericOnly.Text += "9";
                        break;
                    default:
                        txtNumericOnly.Text += character;
                        break;
                }
            }
        }

        private void FrmTelephoneNumber_Load(object sender, EventArgs e)
        {

        }
    }
}