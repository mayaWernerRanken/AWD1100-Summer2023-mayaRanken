namespace HOT1_ConverterGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float CM_PER_IN = 2.54f;
        float inputInches;
        float outputCm;

        private void btnConvert_Click(object sender, EventArgs e)
        {
            inputInches = Convert.ToSingle(txtInches.Text);
            outputCm = inputInches * CM_PER_IN;
            lblResult.Text = $"{inputInches} inches is {outputCm} centimeters.";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInches.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}