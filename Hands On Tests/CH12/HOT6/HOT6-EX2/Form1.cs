using System.ComponentModel.DataAnnotations;

namespace HOT6_EX2
{
    public partial class Form1 : Form
    {

        List<Computer> compList = new List<Computer>()
        {
            //new Computer ("", "", new int[]),
            new Computer ("My-Desktop", "127.0.0.1", new int[]),

        };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {

        }
    }
}