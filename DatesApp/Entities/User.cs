using DatesApp.Extensions;

namespace DatesApp.Entities
{
    public class User
    {
        public int Id { get; set; }

        public required string Username { get; set; }

        public byte[]? PasswordHash { get; set; }

        public byte[]? PasswordSalt { get; set; }

        public DateOnly DateOfBirth { get; set; }

        public required string KnownAs { get; set; }

        public DateTime Created { get; set; } = DateTime.UtcNow;

        public DateTime LastActive { get; set; } = DateTime.UtcNow;

        public required string Gender { get; set; }

        public required string Introduction { get; set; }

        public required string LookingFor { get; set; }

        public required string Interests { get; set; }

        public required string City { get; set; }

        public required string Country { get; set; }

        // public List<Photo> Photos { get; set; } = new List<Photo>();

        public int GetAge()
        {
            return DateOfBirth.CalculateAge();
        }
    }
}
