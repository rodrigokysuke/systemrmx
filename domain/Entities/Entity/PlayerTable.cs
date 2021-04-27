using System.ComponentModel.DataAnnotations.Schema;

namespace domain.Entities
{
    public class PlayerTable : Entity
    {
        [ForeignKey("Player")]
        public int PlayerId { get; set; }
        public User Player { get; set; }

        [ForeignKey("Table")]
        public int TableId { get; set; }
        public Table Table { get; set; }
    }
}
