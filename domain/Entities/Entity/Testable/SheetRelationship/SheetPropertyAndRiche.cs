using System.ComponentModel.DataAnnotations.Schema;

namespace domain.Entities
{
    public class SheetPropertyAndRiche : SheetRelationship
    {
        [ForeignKey("PropertyAndRiche")]
        public int PropertyAndRicheId { get; set; }
        public PropertyAndRiche PropertyAndRiche { get; set; }
    }
}