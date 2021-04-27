using System.ComponentModel.DataAnnotations.Schema;

namespace domain.Entities
{
    public class SheetWeapon : SheetRelationship
    {
        [ForeignKey("Weapon")]
        public int WeaponId { get; set; }
        public Weapon Weapon { get; set; }

        public string ImpactedTestLabel { get; set; }
        public bool Equipped { get; set; }
    }
}