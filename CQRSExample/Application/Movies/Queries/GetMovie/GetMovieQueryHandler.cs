using CQRSExample.Domain.DTOs.Response;
using CQRSExample.Repository.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CQRSExample.Application.Movies.Queries.GetMovie
{
    public class GetMovieQueryHandler : IRequestHandler<GetMovieQuery, GetMovieDTOs>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetMovieQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<GetMovieDTOs> Handle(GetMovieQuery request, CancellationToken cancellationToken)
        {
            var movie = await _dbContext.Movies.Where(x => x.Id == request.Id).FirstOrDefaultAsync();

            if (movie != null)
            {
                var movieItem = movie.MapTo();
                return movieItem;
            }
            return null;
        }
    }
}
