using Hexagonal.Application.Mediator.Results.OrderResults.QueryResults;
using MediatR;

namespace Hexagonal.Application.Mediator.Queries.OrderQueries
{
    public class GetOrderByIdQuery : IRequest<GetOrderByIdQueryResult>
    {
        public int Id { get; set; }

        public GetOrderByIdQuery(int id)
        {
            Id = id;
        }
    }
}
