namespace CalculateLetterGrade
{
    public partial class frmCalculateGrade : Form
    {
        public frmCalculateGrade()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Identifies number grade variable as numGrade; assigns txtNumberGrade.Text to numGrade
            decimal numGrade = Convert.ToDecimal(txtNumberGrade.Text);

            //Identifies letter grade variable as letterGrade
            string letterGrade = "";

            //Determines what letter the user's input falls in (i.e. user enters 75, program pumps out "C")
            if (numGrade < 60)
            {
                letterGrade = "F";
            }
            else if (numGrade >= 60 && numGrade <= 67)
            {
                letterGrade = "D";
            }
            else if (numGrade >= 68 && numGrade <= 79)
            {
                letterGrade = "C";
            }
            else if (numGrade >= 80 && numGrade <= 87)
            {
                letterGrade = "B";
            }
            else if (numGrade >= 88)
            {
                letterGrade = "A";
            }

            //Assigns txtLetterGrade.Text to letterGrade
            txtLetterGrade.Text = letterGrade;

            //Focuses back to txtNumberGrade text box after button click
            txtNumberGrade.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exits the program
            this.Close();
        }
    }
}