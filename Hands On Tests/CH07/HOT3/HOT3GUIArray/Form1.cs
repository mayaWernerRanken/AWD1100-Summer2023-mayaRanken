namespace HOT3GUIArray //This is actually HOT3GUILists
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> firstNames = new List<string>();
        List<string> lastNames = new List<string>();
        List<string> salaries = new List<string>();


        private void btnFirstName_Click(object sender, EventArgs e)
        {
            //Adds first names to firstName list
            firstNames.Add("Markel");
            firstNames.Add("Luizia");
            firstNames.Add("Byrony");
            firstNames.Add("Giraldo");
            firstNames.Add("Lowri");
            string userSearchString = txtInput.Text;
            bool dataFound = false;

            for (int i = 0; i < firstNames.Count && dataFound == false; i++)
            {
                if (firstNames[i].ToLower().Contains(userSearchString.ToLower()) || firstNames[i].ToLower().Contains(userSearchString))
                {
                    txtFirstName.Text = firstNames[i];
                    //txtLastName.Text = lastNames[i];
                    //txtSalary.Text = $"{salaries[i]:c}";
                }
            }


        }
    }
}