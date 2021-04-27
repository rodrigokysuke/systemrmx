using domain.Attributes.Validations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace domain.Entities
{
    public class MS : Entity
    {
        [NotEqual(0, ErrorMessage = "É necessário que a ficha pertença a um jogador.")]
        [ForeignKey("User")]
        public int PlayerId { get; set; }
        public User Player { get; set; }

        public string CharacterName { get; set; }
        public int Age { get; set; }
        public string Archetype { get; set; }
        public string Description { get; set; }

        public string LevelLabel { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public string ExperienceLabel { get; set; }

        public int? PhysicalTestDiceQuantity { get; set; }
        public int? PhysicalTestDiceFaceQuantity { get; set; }

        public int? MentalTestDiceQuantity { get; set; }
        public int? MentalTestDiceFaceQuantity { get; set; }

        public string GenericTestDiceLabel { get; set; }
        public int? GenericTestDiceQuantity { get; set; }
        public int? GenericTestDiceFaceQuantity { get; set; }

        public IList<SheetCapabilitie> PhysicalCapabilities { get; set; }
        public IList<SheetSkill> MentalSkills { get; set; }

        public string GenericAdvantagesLabel { get; set; }
        public IList<SheetGenericAdvantage> GenericAdvantages { get; set; }

        public IList<SheetDisadvantage> Disadvantages { get; set; }

        public int WeightCapacity { get; set; }
        public int HealthPoints { get; set; }

        public IList<SheetWeapon> Weapons { get; set; }
        public IList<SheetArmor> Armors { get; set; }
        public IList<SheetItem> Items { get; set; }

        public string Annotations { get; set; }

        [ForeignKey("Table")]
        public int? TableId { get; set; }
        public bool IsAttached { get; set; }
        public Table Table { get; set; }
    }
}