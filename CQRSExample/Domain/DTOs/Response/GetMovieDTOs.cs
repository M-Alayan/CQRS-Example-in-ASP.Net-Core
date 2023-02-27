using CQRSExample.Core.Enum;

namespace CQRSExample.Domain.DTOs.Response
{
    public class GetMovieDTOs
    {
        public long Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public MovieGenre? Genre { get; set; }
        public int? Rating { get; set; }
    }
}
