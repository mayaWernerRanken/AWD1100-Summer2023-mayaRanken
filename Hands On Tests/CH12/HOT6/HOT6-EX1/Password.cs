using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOT6_EX1
{
    public class Password
    {
        private string _raw;
        private string _hash;

        public Password() { }

        public Password(string raw, string hash)
        {
            _raw = raw;
            _hash = hash;
        }

        public string Raw
        {
            get { return _raw; }
            set { _raw = value; }
        }

        public string Hash
        {
            get { return _hash; }
            set { _hash = value; }
        }

        public override string ToString()
        {
            return $"{Raw}";
        }

    }
}
