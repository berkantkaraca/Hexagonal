using Hexagonal.Application.Mediator.Results.OrderResults.QueryResults;
using MediatR;

namespace Hexagonal.Application.Mediator.Queries.OrderQueries
{
    public class GetOrderQuery : IRequest<List<GetOrderQueryResult>>
    {

    }
}
