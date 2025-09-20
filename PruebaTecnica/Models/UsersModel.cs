using System.ComponentModel.DataAnnotations;

namespace PruebaTecnica.Models
{
    public class UsersModel
    {
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
