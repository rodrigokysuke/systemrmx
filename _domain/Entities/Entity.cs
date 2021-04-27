using System;
using System.Collections.Generic;
using System.Text;

namespace domain.Entities
{
    public abstract class Entity
    {
        public int Id { get; set; }
        public DateTime DataRegistro { get; set; }
        public DateTime DataAtualizacao { get; set; }

    }
}
