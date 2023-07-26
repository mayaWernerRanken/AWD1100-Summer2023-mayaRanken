using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOT6_EX1
{
    public interface ILoan
    {
        string Name { get; }
        string Type { get; }
        double Balance { get; set; }

        void MakePayment();
        void ApplyInterest();
    }
}
