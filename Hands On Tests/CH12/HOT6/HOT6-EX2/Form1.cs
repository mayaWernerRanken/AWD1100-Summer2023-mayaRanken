using System.ComponentModel.DataAnnotations;
using System.Net;

namespace HOT6_EX2
{
    public partial class Form1 : Form
    {

        List<Computer> compList = new List<Computer>()
        {
            //new Computer ("", "", new int[]),
            new Computer ("My-Desktop", "127.0.0.1", new int[0]),

        };

        public Form1()
        {
            InitializeComponent();
        }

        public Computer ScanIPAddress(string ipAddress)
        {
            string userInput = txtIP.Text;
            bool scan = false;

            for (int i = 0; i < compList.Count; i++)
            {
                if (compList[i].IpAddress.Equals (userInput))
                {
                    scan = true;
                    compList[i].Name = ipAddress;
                    break;
                }
                else
                {
                    scan = false;
                    lblCompName.Text = "Request timed out";
                }
            }

            return ipAddress;
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            
        }
    }
}