namespace HOT1_TShirtsGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e) 
        {
            string userName = txtName.Text;
            string userAddress = txtAddress.Text;
            string userCity = txtCity.Text;
            string userState = txtState.Text;
            string userZip = txtZip.Text;
            int shirtNum = Convert.ToInt32(txtShirtNum.Text);
            const decimal shirtPrice = 14.99M;
            decimal subTotal = 0.00M;
            float salesTax = 1.08f;

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
    }
}