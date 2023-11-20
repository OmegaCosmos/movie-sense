using System.ComponentModel.DataAnnotations;

namespace MovieSense_API.DTO
{
    public class Review
    {
        public int Id { get; set; }
        [Required] public int AuthorId { get; set; }
        [Required] public float Rating { get; set; }
        [Required] public string? Title { get; set; }
        [Required] public string? Description { get; set; }
    }
}
