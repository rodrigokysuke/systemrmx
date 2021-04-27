using System.ComponentModel.DataAnnotations.Schema;

namespace domain.Entities
{
    public class SheetCapabilitie : SheetRelationship
    {
        [ForeignKey("Capabilitie")]
        public int CapabilitieId { get; set; }
        public Capabilitie Capabilitie { get; set; }
    }
}