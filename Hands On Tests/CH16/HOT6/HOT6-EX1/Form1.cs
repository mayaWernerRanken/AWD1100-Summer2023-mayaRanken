namespace HOT6_EX1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Triggers ClearTop() and ClearBottom()
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTop();
            ClearBottom();
        }

        //Clears form's top functions
        private void ClearTop()
        {
            txtName.Text = "";
            txtAmount.Text = "";
            rdoShortLoan.Checked = false;
            rdoLongLoan.Checked = false;
            btnCreate.Enabled = true;
        }

        //Clears form's bottom functions
        private void ClearBottom()
        {
            lblName.Text = "";
            lblAmount.Text = "";
            lblPayment.Text = "";
            lblInterestResult.Text = "";
            btnPay.Enabled = false;
            btnClear.Enabled = true;
            btnExit.Enabled = true;
        }

        //exits program
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Arrays for ShortTermLoan and LongTermLoan
        ShortTermLoan[] stl = new ShortTermLoan[1];
        LongTermLoan[] ltl = new LongTermLoan[1];

        private void btnCreate_Click(object sender, EventArgs e)
        {
            
            //Validate inputs
            if (IsValidData())
            {
                lblName.Text = txtName.Text;

                //Create new ShortTermLoan object if rdoShortLoan is checked
                if (rdoShortLoan.Checked)
                {
                    stl[0] = new ShortTermLoan(txtName.Text, Convert.ToDouble(txtAmount.Text));
                    lblAmount.Text = $"Short-term loan of {stl[0].Balance.ToString("C")}";
                }
                //Create new LongTermLoan object if rdoLongLoan is checked
                else if (rdoLongLoan.Checked)
                {
                    ltl[0] = new LongTermLoan(txtName.Text, Convert.ToDouble(txtAmount.Text));
                    lblAmount.Text = $"Long-term loan of {ltl[0].Balance.ToString("C")}";
                }

                //Enable and disable functions for any loan type created
                btnCreate.Enabled = false;
                btnPay.Enabled = true;
                btnClear.Enabled = true;
            }

        }

        private bool IsValidData()
        {
            bool success = true;
            string errMsg = "";

            //Checks if loan name is present
            errMsg += Validator.IsPresent(txtName.Text, txtName.Tag.ToString());

            //Checks if loan amount is present
            errMsg += Validator.IsPresent(txtAmount.Text, txtAmount.Tag.ToString());

            //checks if value of txtAmount is a decimal
            errMsg += Validator.IsDecimal(txtAmount.Text, txtAmount.Tag.ToString());

            //Checks if loan amount is positive and greater than 0
            errMsg += Validator.IsPositive(txtAmount.Text, txtAmount.Tag.ToString());

            //Checks if either radio button is checked
            if ((!rdoShortLoan.Checked) && (!rdoLongLoan.Checked))
            {
                errMsg += "Please choose a radio button.";
            }

            //If either of the validator lines above don't pass, display an error message box
            if (errMsg != "")
            {
                MessageBox.Show(errMsg, "INPUT ERROR(s)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                success = false;
            }

            return success;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (rdoShortLoan.Checked) { MakeSTLPayment(); }
            else if (rdoLongLoan.Checked) { MakeLTLPayment(); }

        }

        private void MakeSTLPayment()
        {
            stl[0].MakePayment();
            if (stl[0].Balance == 0)
            {
                lblPayment.Text = "Loan has been paid off.";
                lblInterestResult.Text = "";
                btnPay.Enabled = false;
                return;
            }
            //Display loan after payment
            lblPayment.Text = $"After payment, your loan is now {stl[0].Balance.ToString("C")}";

            stl[0].ApplyInterest();

            //Display loan after applying interest
            lblInterestResult.Text = $"After interest, your loan is now {stl[0].Balance.ToString("C")}";
        }

        private void MakeLTLPayment()
        {
            ltl[0].MakePayment();
            if (ltl[0].Balance == 0)
            {
                lblPayment.Text = "Loan has been paid off.";
                lblInterestResult.Text = "";
                return;
            }
            //Display loan after payment
            lblPayment.Text = $"After payment, your loan is now {ltl[0].Balance.ToString("C")}";

            ltl[0].ApplyInterest();

            //Display loan after applying interest
            lblInterestResult.Text = $"After interest, your loan is now {ltl[0].Balance.ToString("C")}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnExit.Enabled = true;
            btnPay.Enabled = false;
            btnClear.Enabled = false;
        }
    }
}