using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    public interface IRability
    {
        //instance fields vs. static fields
        //static fields aka SHARED 
        private static int _name;
        public string Ultimate();
    }
}
