using System;
using System.Collections.Generic;
using System.Text;

namespace domain.Entities
{
    public class Weapon : Difficulty
    {
        public int Damage { get; set; }
        public RMX RMX { get; set; }
    }
}
