using System.ComponentModel.DataAnnotations.Schema;

namespace domain.Entities
{
    public class SheetArmor : SheetRelationship
    {
        [ForeignKey("Armor")]
        public int ArmorId { get; set; }
        public Armor Armor { get; set; }

        public string ImpactedTestLabel { get; set; }
        public bool Equipped { get; set; }
    }
}