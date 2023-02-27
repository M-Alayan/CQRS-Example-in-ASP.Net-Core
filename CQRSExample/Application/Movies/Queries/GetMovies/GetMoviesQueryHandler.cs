using CQRSExample.Domain.DTOs.Response;
using CQRSExample.Repository.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CQRSExample.Application.Movies.Queries.GetMovies
{
    public class GetMoviesQueryHandler : IRequestHandler<GetMoviesQuery, IList<GetMovieDTOs>>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetMoviesQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IList<GetMovieDTOs>> Handle(GetMoviesQuery request, CancellationToken cancellationToken)
        {
            var movies = await _dbContext.Movies.ToListAsync();
            var movieList = new List<GetMovieDTOs>();
            foreach (var movieItem in movies)
            {
                var movie = movieItem.MapTo();
                movieList.Add(movie);
            }

            return movieList;
        }
    }
}
