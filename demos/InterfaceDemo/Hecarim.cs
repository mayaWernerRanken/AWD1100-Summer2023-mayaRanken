using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    public class Hecarim : Champion, IRability, ICloneable, IComparable<Hecarim>
    {
        public Hecarim() 
        {
            _instanceCount++;
        }

        private static int _instanceCount;
        public object Clone()
        {
            return new Hecarim() { Health = this.Health, Armor = this.Armor, HealthRegen = this.HealthRegen, MoveSpeed = this.MoveSpeed, MagicResist = this.MagicResist};
        }

        public string Ultimate()
        {
            return "ONSLAUGHT OF SHADOWS";
        }

        public int CompareTo(Hecarim? other)
        {
            if(this.Health > other.Health)
            {
                return 1;
            }
            else if(this.Health < other.Health)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
