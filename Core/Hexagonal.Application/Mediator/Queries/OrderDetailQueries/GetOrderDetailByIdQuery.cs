using Hexagonal.Application.Mediator.Results.OrderDetailResults.QueryResults;
using MediatR;

namespace Hexagonal.Application.Mediator.Queries.OrderDetailQueries
{
    public class GetOrderDetailByIdQuery : IRequest<GetOrderDetailByIdQueryResult>
    {
        public int Id { get; set; }

        public GetOrderDetailByIdQuery(int id)
        {
            Id = id;
        }
    }
}
