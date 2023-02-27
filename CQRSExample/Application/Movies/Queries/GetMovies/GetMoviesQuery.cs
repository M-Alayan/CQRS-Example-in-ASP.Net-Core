using CQRSExample.Domain.DTOs.Response;
using MediatR;

namespace CQRSExample.Application.Movies.Queries.GetMovies
{
    public class GetMoviesQuery: IRequest<IList<GetMovieDTOs>>
    {
    }
}
