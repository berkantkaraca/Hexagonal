using Hexagonal.Application.Mediator.Results.OrderDetailResults.QueryResults;
using MediatR;

namespace Hexagonal.Application.Mediator.Queries.OrderDetailQueries
{
    public class GetOrderDetailQuery : IRequest<List<GetOrderDetailQueryResult>>
    {

    }
}
