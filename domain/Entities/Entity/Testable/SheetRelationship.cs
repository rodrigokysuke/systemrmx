using System.ComponentModel.DataAnnotations.Schema;

namespace domain.Entities
{
    public abstract class SheetRelationship : Testable
    {
        [ForeignKey("RMX")]
        public int? RMXId { get; set; }
        public RMX RMX { get; set; }
    }
}
