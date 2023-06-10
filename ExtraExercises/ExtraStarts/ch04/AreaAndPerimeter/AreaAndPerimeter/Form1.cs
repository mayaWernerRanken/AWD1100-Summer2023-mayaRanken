namespace AreaAndPerimeter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal inputLength = Convert.ToDecimal(txtLength.Text);
            decimal inputWidth = Convert.ToDecimal(txtWidth.Text);

            decimal outputArea = inputLength * inputWidth;
            decimal outputPerimeter = (2 * inputWidth) + (2 * inputLength);

            txtArea.Text = outputArea.ToString();
            txtPerimeter.Text = outputPerimeter.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}