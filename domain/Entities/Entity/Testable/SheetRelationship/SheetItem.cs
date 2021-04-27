using System.ComponentModel.DataAnnotations.Schema;

namespace domain.Entities
{
    public class SheetItem : SheetRelationship
    {
        [ForeignKey("Item")]
        public int ItemId { get; set; }
        public Item Item { get; set; }

        public string ImpactedTestLabel { get; set; }
        public bool Equipped { get; set; }
    }
}