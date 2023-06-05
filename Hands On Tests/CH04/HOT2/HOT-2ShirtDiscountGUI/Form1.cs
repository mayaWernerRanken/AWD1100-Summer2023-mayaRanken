namespace HOT_2ShirtDiscountGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const decimal shirtPrice = 13.75M;
        const decimal salesTax = 0.08M;

        private void button3_Click(object sender, EventArgs e)
        {
            int shirtNum = Convert.ToInt32(textBox1.Text);
            decimal subTotal = shirtNum * shirtPrice;
            decimal taxedMoney = subTotal * salesTax;
            decimal grandTotal = subTotal + taxedMoney;
            

        }

        public string CheckDiscountCode(string[] discountCode)
        {
            discountCode = new string[]
            {
                "8264",
                "5679",
                "6483"
            };

            decimal[] discountPercent = new decimal[]
            {
                0.30M,
                0.20M,
                0.10M
            };


            return 
        }
    }
}