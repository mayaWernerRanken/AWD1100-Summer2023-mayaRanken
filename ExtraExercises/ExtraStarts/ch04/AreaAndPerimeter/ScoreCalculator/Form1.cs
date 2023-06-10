namespace ScoreCalculator
{
    public partial class Form1 : Form
    {
        static int inputScore;
        static int outputScoreNum;
        int sumScore;
        int average;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            inputScore = Convert.ToInt32(txtScore.Text);

            if (inputScore > 0)
            {
                outputScoreNum = outputScoreNum + 1;
                txtScoreNum.Text = outputScoreNum.ToString();
                sumScore = sumScore + inputScore;
                txtScoreTotal.Text = sumScore.ToString();
                average = sumScore / outputScoreNum;
                txtAverage.Text = average.ToString();
            }

            txtScore.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            inputScore = 0;
            outputScoreNum = 0;
            sumScore = 0;
            average = 0;

            txtScore.Text = "";
            txtScoreTotal.Text = "";
            txtScoreNum.Text = "";
            txtAverage.Text = "";
        }
    }
}