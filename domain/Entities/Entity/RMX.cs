using domain.Attributes.Validations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace domain.Entities
{
    public class RMX : Entity
    {
        [NotEqual(0, ErrorMessage = "É necessário que a ficha pertença a um jogador.")]
        [ForeignKey("User")]
        public int PlayerId { get; set; }
        public User Player { get; set; }

        public string CharacterName { get; set; }
        public int Age { get; set; }
        public string Class { get; set; }
        public string Race { get; set; }
        public int Level { get; set; }

        public int Adrenaline { get; set; }
        public int AdrenalineEfficiencyLimit { get; set; }

        public int Attack { get; set; }
        public int AttackEfficiencyLimit { get; set; }

        public int Defense { get; set; }
        public int DefenseEfficiencyLimit { get; set; }

        public int Dexterity { get; set; }
        public int DexterityEfficiencyLimit { get; set; }

        public int Strength { get; set; }
        public int StrengthEfficiencyLimit { get; set; }

        public int Intelligence { get; set; }
        public int IntelligenceEfficiencyLimit { get; set; }

        public int Resistance { get; set; }
        public int ResistanceEfficiencyLimit { get; set; }

        public int Sapience { get; set; }
        public int SapienceEfficiencyLimit { get; set; }

        public int Velocity { get; set; }
        public int VelocityEfficiencyLimit { get; set; }

        public IList<SheetCapabilitie> Capabilities { get; set; }
        public IList<SheetSkill> Skills { get; set; }
        public IList<SheetDisadvantage> Disadvantages { get; set; }
        public IList<SheetPractice> Practices { get; set; }
        public IList<SheetEnhancedMove> EnhancedMoves { get; set; }

        public IList<SheetPropertyAndRiche> PropertiesAndRiches { get; set; }
        public IList<SheetItem> Items { get; set; }
        public IList<SheetWeapon> Weapons { get; set; }

        public string Annotations { get; set; }

        public int ExperiencePoints { get; set; }
        public int ExperienceLevel { get; set; }

        public IList<SheetArmor> Armors { get; set; }

        [ForeignKey("Table")]
        public int? TableId { get; set; }
        public bool IsAttached { get; set; }
        public Table Table { get; set; }
    }
}