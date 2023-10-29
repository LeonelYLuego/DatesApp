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
        public required string Password { get; set; }

        [Required]
        public DateOnly DateOfBirth { get; set; }

        [Required]
        public required string KnownAs { get; set; }

        [Required]
        public required string Gender { get; set; }

        [Required]
        public required string Introduction { get; set; }

        [Required]
        public required string LookingFor { get; set; }

        [Required]
        public required string Interests { get; set; }

        [Required]
        public required string City { get; set; }

        [Required]
        public required string Country { get; set; }
    }
}
