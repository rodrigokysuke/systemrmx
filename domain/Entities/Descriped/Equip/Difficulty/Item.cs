using System;
using System.Collections.Generic;
using System.Text;

namespace domain.Entities
{
    public class Item : Difficulty
    {
        public int EffectValue { get; set; }
        public RMX RMX { get; set; }
    }
}
