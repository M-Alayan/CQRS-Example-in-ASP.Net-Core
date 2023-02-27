using CQRSExample.Core.Enum;

namespace CQRSExample.Domain.DTOs.Request
{
    public class CreateMovieRequest
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public MovieGenre? Genre { get; set; }
        public int? Rating { get; set; }
    }
}
