using System;
using System.Collections.Generic;
using System.Text;

namespace domain.Entities
{
    public abstract class Equip : Decriped
    {
        public string Type{ get; set; }
        public string Weight { get; set; }
    }
}
