using System;
using System.Collections.Generic;
using System.Text;

namespace domain.Entities
{
   public class Armor : Equip
    {
        public string BonusDescription { get; set; }
        public int BonusValue { get; set; }
        public string PenaltDescription { get; set; }
        public int PenaltyValue { get; set; }
        public RMX RMX { get; set; }
    }
}

//  public string DifficultyDescription { get; set; }
//public int DifficultyValue { get; set; }
