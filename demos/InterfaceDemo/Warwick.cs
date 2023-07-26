using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    public class Warwick : Champion, IRability
    {
        public string Ultimate()
        {
            return "Infinite Duress";
        }
    }
}
