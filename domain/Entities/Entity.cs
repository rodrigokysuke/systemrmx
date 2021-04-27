using System;
using System.Collections.Generic;
using System.Text;

namespace domain.Entities
{
    public abstract class Entity
    {
        public int Id { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime UpdateDate { get; set; }

    }
}
