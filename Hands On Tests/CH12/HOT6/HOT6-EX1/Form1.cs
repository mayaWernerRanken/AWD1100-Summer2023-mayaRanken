using System.Security.AccessControl;

namespace HOT6_EX1
{
    public partial class PasswordCracker : Form
    {
        List<Password> passwordList = new List<Password>()
        {
            //new Password("", ""),
            new Password("123456", "e10adc3949ba59abbe56e057f20f883e"),
            new Password("123456789", "25f9e794323b453885f5181f1b624d0b"),
            new Password("qwerty", "d8578edf8458ce06fbc5bb76a58c5ca4"),
            new Password("111111", "96e79218965eb72c92a549dd5a330112"),
            new Password("password", "5f4dcc3b5aa765d61d8327deb882cf99"),
            new Password("qwertyuiop", "6eea9b7ef19179a06954edd0f6c05ceb"),
            new Password("123321", "c8837b23ff8aaa8a2dde915473ce0991"),
            new Password("google", "c822c1b63853ed273b89687ac505f9fa"),
            new Password("P@ssw0rd", "161ebd7d45089b3446ee4e0d86dbcf92"),
            new Password("Tr0ub4dor&3", "4ece57a61323b52ccffdbef021956754")
        };

        public PasswordCracker()
        {
            InitializeComponent();
        }

        public string CrackPassword(string hash)
        {
            string userInput = txtHash.Text;
            bool crack = false;

            for (int i = 0; i < passwordList.Count; i++)
            {
                if (passwordList[i].Hash.Equals(userInput))
                {
                    crack = true;
                    lblPassword.Text = passwordList[i].ToString();
                    passwordList[i].Raw = hash;
                    break;
                }
                else
                {
                    crack = false;
                    lblPassword.Text = "* FAIL *";
                }
            }

            return hash;
        }

        private void btnCrack_Click(object sender, EventArgs e)
        {
            CrackPassword(txtHash.Text);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}