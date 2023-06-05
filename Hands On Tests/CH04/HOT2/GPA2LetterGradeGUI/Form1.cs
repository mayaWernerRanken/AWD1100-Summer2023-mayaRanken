namespace GPA2LetterGradeGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double numGrade = Convert.ToDouble(txtNumGrade.Text);

            if (numGrade > 3.2 && numGrade <= 4.0)
            {
                lblResult.Text = "Your letter grade is: A";
            }
            else if (numGrade > 2.5 && numGrade <= 3.2)
            {
                lblResult.Text = "Your letter grade is: B";
            }
            else if (numGrade > 1.5 && numGrade <= 2.5)
            {
                lblResult.Text = "Your letter grade is: C";
            }
            else if (numGrade > 0.0 && numGrade <= 1.5)
            {
                lblResult.Text = "Your letter grade is: D";
            }
            else if (numGrade == 0.0)
            {
                lblResult.Text = "Your letter grade is: F";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblResult.Text = string.Empty;
            txtNumGrade.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}