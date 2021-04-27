using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace domain.Entities
{
    public class SheetGenericAdvantage : SheetRelationship
    {
        [ForeignKey("GenericAdvantage")]
        public int GenericAdvantageId { get; set; }
        public GenericAdvantage GenericAdvantage { get; set; }
    }
}
