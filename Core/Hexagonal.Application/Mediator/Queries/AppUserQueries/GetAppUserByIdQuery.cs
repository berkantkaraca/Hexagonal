using Hexagonal.Application.Mediator.Results.AppUserResults.QueryResults;
using MediatR;

namespace Hexagonal.Application.Mediator.Queries.AppUserQueries
{
    public class GetAppUserByIdQuery : IRequest<GetAppUserByIdQueryResult>
    {
        public int Id { get; set; }

        public GetAppUserByIdQuery(int id)
        {
            Id = id;
        }
    }
}
