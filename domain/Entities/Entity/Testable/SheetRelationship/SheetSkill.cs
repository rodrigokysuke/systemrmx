using System.ComponentModel.DataAnnotations.Schema;

namespace domain.Entities
{
    public class SheetSkill : SheetRelationship
    {
        [ForeignKey("Skill")]
        public int SkillId { get; set; }
        public Skill Skill { get; set; }
    }
}