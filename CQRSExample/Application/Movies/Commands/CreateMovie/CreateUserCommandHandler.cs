using CQRSExample.Domain.DTOs.Response;
using CQRSExample.Repository.Context;
using MediatR;

namespace CQRSExample.Application.Movies.Commands.CreateMovie
{
    public class CreateUserCommandHandler:IRequestHandler<CreateMovieCommand,CreateMovieDto>
    {
        private readonly ApplicationDbContext _dbContext;

        public CreateUserCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<CreateMovieDto> Handle(CreateMovieCommand request, CancellationToken cancellationToken)
        {
            var movie = request.CreateMovie();
            await _dbContext.Movies.AddAsync(movie);
            await _dbContext.SaveChangesAsync();

            return new CreateMovieDto(movie.Id);
        }
    }
}
