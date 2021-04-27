using System;

namespace domain.Entities
{
    public class RMX
    {
        public class Record : Entity
        {
            public string Name { get; set; }               //nome
            public int Age { get; set; }                  //idade
            public string Race { get; set; }             // raça
            public int Experience { get; set; }          // experiencia
            public int Adrenaline { get; set; }         //  adrenalina
            public int EfficiencyAdre { get; set; }
            public int Attack { get; set; }            // ataque
            public int Efficiency { get; set; }
            public int Defense { get; set; }           // defesa
            public int EfficiencyDefe { get; set; }
            public int Dexterity { get; set; }          //destreza
            public int Efficiencydexterity { get; set; }
            public int Strength { get; set; }          // força
            public int EfficiencyStrength { get; set; }
            public int Intelligence { get; set; }     // inteligencia
            public int EfficiencyIntelligence { get; set; }
            public int Endurance { get; set; }       // resistencia
            public int EfficiencyEndurance { get; set; }
            public int Knowledge { get; set; }    // sabedoria
            public int EfficiencyKnowledge { get; set; }
            public int Velocity { get; set; }       // velocidade
            public int EfficiencyVelocity { get; set; }
            public int Fate { get; set; }         // sorte/destino
            public int Vitality { get; set; }     // vitalidade
            public int EfficiencyVitality { get; set; }
            private const int PesoVital = 2;      //peso vitalidade no teste de nivel
            public int Calcularnivelteste()
            {
                return (Adrenaline + Attack + Defense + Dexterity + Strength + Intelligence + Endurance + Knowledge
                    + Velocity + (Vitality * PesoVital)) / (9 + PesoVital);
            }
            public int CalcularNivel()
            {
                return (int)((Math.Sqrt(25 + (8 * Experience * 5)) / 10) + 0.5);
            }
            public Capabilitie[] Capabilitie { get; set; } // capacidade
            public Skill[] Skill { get; set; } // pericia
            public Disadvantage[] Desvantagens { get; set; }  // desvantagem 
            public Item[] Item { get; set; }     // itens
            public Pratice[] Pratice { get; set; }     // praticas
            public PropertyAndRiche[] PropertyAndRiche { get; set; }      // propriedades e riquezas
            public Armor[] Armor { get; set; }       //armaduras 
        }
    }
}
