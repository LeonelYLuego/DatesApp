using DatesApp.Entities;

namespace DatesApp.Dto
{
    public class MemberDto
    {
        public int Id { get; set; }

        public required string Username { get; set; }

        public required string PhotoUrl { get; set; }

        public int Age { get; set; }

        public required string KnownAs { get; set; }

        public DateTime Created { get; set; } = DateTime.UtcNow;

        public DateTime LastActive { get; set; } = DateTime.UtcNow;

        public required string Gender { get; set; }

        public required string Introduction { get; set; }

        public required string LookingFor { get; set; }

        public required string Interests { get; set; }

        public required string City { get; set; }

        public required string Country { get; set; }

        // public List<PhotoDto> Photos { get; set; } = new();
    }
}
