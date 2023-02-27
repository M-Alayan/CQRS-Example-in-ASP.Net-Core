namespace CQRSExample.Domain.DTOs.Response
{
    public class CreateMovieDto
    {
        public CreateMovieDto(long id)
        {
            Id = id;
        }

        public long Id { get; set; }
    }
}
