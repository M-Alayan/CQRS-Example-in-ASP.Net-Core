using CQRSExample.Domain.DTOs.Response;
using MediatR;

namespace CQRSExample.Application.Movies.Queries.GetMovie
{
    public class GetMovieQuery: IRequest<GetMovieDTOs>
    {
        public GetMovieQuery(long? id)
        {
            Id = id;
        }

        public long? Id { get; set; }
    }
}
