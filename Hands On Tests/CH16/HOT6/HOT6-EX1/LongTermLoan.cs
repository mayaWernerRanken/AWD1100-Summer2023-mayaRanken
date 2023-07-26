using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOT6_EX1
{
    public class LongTermLoan : ILoan
    {
        public string Name { get; }
        public string Type { get; }
        public double Balance { get; set; }

        //full-arg constructor
        public LongTermLoan(string loanName, double loanBalance)
        {
            this.Name = loanName;
            this.Balance = loanBalance;
        }

        public void MakePayment()
        {
            Balance -= 200;

            //makes sure payment won't bounce in the negatives
            if (Balance < 0)
            {
                Balance = 0;
            }
        }

        public void ApplyInterest()
        {
            //"Balance * 1.05" adds the 5% to the balance
            double interest = Balance * 1.05; Balance = interest;
        }
    }
}
