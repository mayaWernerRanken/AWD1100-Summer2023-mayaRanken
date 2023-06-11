namespace HOT3GUILists //This is actually HOT3GUIArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] firstNames = { "Markel", "Luizia", "Byrony", "Giraldo", "Lowri" };
        string[] lastNames = { "Diggory", "Gunnar", "Hester", "Addy", "Hari" };
        decimal[] salaries = { 54321.00M, 88732.00M, 66778.00M, 33445.00M, 99883.00M };

        private void button1_Click(object sender, EventArgs e)
        {
            string userSearchString = txtInput.Text;
            bool dataFound = false;

            for (int i = 0; i < firstNames.Length && dataFound == false; i++)
            {
                if (firstNames[i].ToLower().Contains(userSearchString.ToLower()) || firstNames[i].ToLower().Contains(userSearchString))
                {
                    txtFirstName.Text = firstNames[i];
                    txtLastName.Text = lastNames[i];
                    txtSalary.Text = $"{salaries[i]:c}";
                }
            }
        }

        private void btnLastName_Click(object sender, EventArgs e)
        {
            string userSearchString = txtInput.Text;
            bool dataFound = false;

            for (int i = 0; i < lastNames.Length && dataFound == false; i++)
            {
                if (lastNames[i].ToLower().Contains(userSearchString.ToLower()) || lastNames[i].ToLower().Contains(userSearchString))
                {
                    txtFirstName.Text = firstNames[i];
                    txtLastName.Text = lastNames[i];
                    txtSalary.Text = $"{salaries[i]:c}";
                }
            }
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            decimal userSearchDecimal = Convert.ToDecimal(txtInput.Text);
            bool dataFound = false;

            if (userSearchDecimal >= 25000M && userSearchDecimal <= 100000M)
            {
                for (int i = 0; i < salaries.Length && dataFound == false; i++)
                {
                    if (salaries[i].ToString().Contains(userSearchDecimal.ToString()))
                    {
                        txtFirstName.Text = firstNames[i];
                        txtLastName.Text = lastNames[i];
                        txtSalary.Text = $"{salaries[i]:c}";
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtSalary.Text = "";
        }
    }
}