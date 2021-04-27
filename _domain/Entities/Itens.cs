using System;
using System.Collections.Generic;
using System.Text;

namespace domain.Entities
{
    public class Itens
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public int Peso { get; set; }
        public int Dano { get; set; }
        public Ficha Ficha { get; set; }


    }
}
