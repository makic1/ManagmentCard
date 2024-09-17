using System.ComponentModel.DataAnnotations;

namespace WineCardVersionFive.Entities
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }

        [Required, MinLength(3), MaxLength(30)]
        public string Username { get; set; }

        [Required]
        public string HashPassword { get; set; }
    }
}
