using CQRSExample.Domain.DTOs.Response;
using CQRSExample.Domain.Entities;

namespace CQRSExample.Application.Movies.Queries.GetMovies
{
    public static class GetMoviesQueryExtensions
    {
        public static GetMovieDTOs MapTo(this Movie movie)
        {
            return new GetMovieDTOs
            {
                Id = movie.Id,
                Title = movie.Title,
                Description = movie.Description,
                Genre = movie.Genre,
                Rating = movie.Rating
            };
        }
    }
}
