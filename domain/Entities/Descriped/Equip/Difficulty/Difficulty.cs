using System;
using System.Collections.Generic;
using System.Text;

namespace domain.Entities
{
    public class Difficulty : Equip
    {
        public string DifficultyDescription { get; set; }
        public int DifficultyValue { get; set; }

    }
}