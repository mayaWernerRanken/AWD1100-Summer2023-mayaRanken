using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    public abstract class Champion
    {
        public int Health { get; set; }
        public int HealthRegen { get; set; }
        public int Armor { get; set; }
        public int MagicResist { get; set; }
        public int MoveSpeed { get; set; }

        public override string ToString()
        {
            return $"{GetType()} has a health of {Health}, Health Regen of {HealthRegen}, Armor of {Armor}, Magic Resist of {MagicResist} and movement speed of {MoveSpeed}\n";
        }
    }
}
