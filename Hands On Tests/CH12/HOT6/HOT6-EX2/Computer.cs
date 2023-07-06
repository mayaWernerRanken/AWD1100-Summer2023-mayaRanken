using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOT6_EX2
{
    public class Computer
    {
        public string _name;
        public string _ipAddress;
        public int[] _services = new int[] { 20, 21, 23, 25, 53, 80, 123, 389, 443 };

        public Computer(string name, string ipAddress, int[] services)
        {
            _name = name;
            _ipAddress = ipAddress;
            _services = services;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string IpAddress
        {
            get { return _ipAddress; }
            set { _ipAddress = value; }
        }

        public int[] Services
        {
            get { return _services; }
            set { _services = value; }
        }

        public string CompName() => $"Name";
        public string CompIP() => $"_ipAddress";
    }
}
