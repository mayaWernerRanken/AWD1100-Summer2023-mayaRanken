namespace HOT1_TShirtsGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string userName;
        string userAddress;
        string userCity;
        string userState;
        string userZip;
        int shirtNum;
        const decimal shirtPrice = 14.99M;
        decimal subTotal;
        float salesTax;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            userName = txtName.Text;
            userAddress = txtAddress.Text;
            userCity = txtCity.Text;
            userState = txtState.Text;
            userZip = txtZip.Text;
            shirtNum = Convert.ToInt32(txtShirtNum.Text);
            subTotal = 0.00M;
            salesTax = 1.08f;

            if (userName.Length > 0 && userAddress.Length > 0 && userCity.Length > 0 && userState.Length > 0 && userZip.Length > 0 && shirtNum >= 0)
            {
                txtName.ReadOnly = true;
                txtAddress.ReadOnly = true;
                txtCity.ReadOnly = true;
                txtState.ReadOnly = true;
                txtZip.ReadOnly = true;
                txtShirtNum.ReadOnly = true;

                subTotal = shirtPrice * shirtNum;


                txtSubTotal.Text = $"{subTotal:c}";
                txtTaxTotal.Text = $"{subTotal * 0.08M:c}";
                txtGrandTotal.Text = $"{subTotal * 1.08M:c}";

            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            userName = null;
            userAddress = null;
            userCity = null;
            userState = null;
            userZip = null;
            shirtNum = 0;
            subTotal = 0.00M;

            txtName.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtState.Text = "";
            txtZip.Text = "";
            txtShirtNum.Text = "";
            txtSubTotal.Text = "";
            txtTaxTotal.Text = "";
            txtGrandTotal.Text = "";

            txtName.ReadOnly = false;
            txtAddress.ReadOnly = false;
            txtCity.ReadOnly = false;
            txtState.ReadOnly = false;
            txtZip.ReadOnly = false;
            txtShirtNum.ReadOnly = false;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}