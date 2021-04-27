using System.ComponentModel.DataAnnotations.Schema;

namespace domain.Entities
{
    public abstract class CompetenceRelationship : Descripted
    {
        [ForeignKey("SheetCapabilitie")]
        public int? SheetCapabilitieId { get; set; }

        [ForeignKey("SheetSkill")]
        public int? SheetSkillId { get; set; }
        public SheetSkill SheetSkill { get; set; }

        [ForeignKey("SheetGenericAdvantage")]
        public int? SheetGenericAdvantageId { get; set; }

        [ForeignKey("SheetDisadvantage")]
        public int? SheetDisadvantageId { get; set; }
    }
}