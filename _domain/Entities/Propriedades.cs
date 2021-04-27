using System;
using System.Collections.Generic;
using System.Text;

namespace domain.Entities
{
    public class Propriedades
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public Ficha Ficha { get; set; }
    }
}
