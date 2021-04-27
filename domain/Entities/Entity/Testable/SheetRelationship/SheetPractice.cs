using System.ComponentModel.DataAnnotations.Schema;

namespace domain.Entities
{
    public class SheetPractice : SheetRelationship
    {
        [ForeignKey("Practice")]
        public int PracticeId { get; set; }
        public Practice Practice { get; set; }
    }
}