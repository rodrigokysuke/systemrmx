using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace domain.Entities
{
    public class User : Entity
    {
        [Required(ErrorMessage = "Nome de usuário obrigatório.")]
        public string Username { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }

        public IList<PlayerTable> PlayerTables { get; set; }
        public IList<RMX> RMXs { get; set; }

        [NotMapped]
        public string Token { get; set; }
        [NotMapped]
        public string CurrentPassword { get; set; }

        [NotMapped]
        public bool IsTheMaster { get; set; }
    }
}
