namespace Factorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt16(txtNum.Text);
            int factorial = 1;

            for (int counter = num; counter >= 1; counter--)
            {
                factorial = factorial * counter;
            }
            txtFact.Text = $"{factorial:d}";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}