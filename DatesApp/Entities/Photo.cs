namespace DatesApp.Entities
{
    public class Photo
    {
        public required int Id { get; set; }

        public required string Url { get; set; }

        public required bool IsMain { get; set; }

        public required string PublicId { get; set; }
    }
}
