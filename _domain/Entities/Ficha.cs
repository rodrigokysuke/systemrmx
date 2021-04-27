using System;

namespace domain.Entities
{
    public class Ficha : Entity
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Raca { get; set; }
        public int Experiencia { get; set; }
        public int Adre { get; set; }
        public int EfeicienciaAdre { get; set; }
        public int Ataq { get; set; }
        public int EfeicienciaAtaq { get; set; }
        public int Def { get; set; }
        public int EfeicienciaDef { get; set; }
        public int Dest { get; set; }
        public int EfeicienciaDest { get; set; }
        public int Forc { get; set; }
        public int EfeicienciaForc { get; set; }
        public int Inte { get; set; }
        public int EfeicienciaInte { get; set; }
        public int Resi { get; set; }
        public int EfeicienciaResi { get; set; }
        public int Sabe { get; set; }
        public int EfeicienciaSabe { get; set; }
        public int Velo { get; set; }
        public int EfeicienciaVelo { get; set; }
        public int Sorte { get; set; }
        public int Vital { get; set; }
        public int EfeicienciaVital { get; set; }
        private const int Pesovital = 2;
        public Capacidade[] Capacidade { get; set; }
        public int Calcularnivelteste()
        {
            return (Adre + Ataq + Def + Dest + Inte + Resi + Sabe + Velo + (Vital * Pesovital)) / (9 + Pesovital);
        }
        public int CalcularNivel()
        {
            return (int)((Math.Sqrt(25 + (8 * Experiencia * 5)) / 10) + 0.5);
        }
        public Pericia[] Pericias { get; set; }
        public Desvantagens[] Desvantagens { get; set; }
        public Itens[] Itens { get; set; }
        public PraticasMovimentos[] PraticasMovimentos { get; set; }
        public Propriedades[] Propriedades { get; set; }

    }
}
