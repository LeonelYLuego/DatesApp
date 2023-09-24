using System.ComponentModel.DataAnnotations;

namespace DatesApp.Dto
{
    public class RegisterDto
    {
        [Required]
        [MaxLength(128)]
        public required string Username { get; set; }

        [Required]
        [MaxLength(128)]
        [EmailAddress]
        public required string Email { get; set; }

        [Required]
        [MaxLength(128)]
        public required string Password { get; set; }
    }
}
