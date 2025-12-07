using Hexagonal.Application.Mediator.Results.ProductResults.QueryResults;
using MediatR;

namespace Hexagonal.Application.Mediator.Queries.ProductQueries
{
    public class GetProductQuery : IRequest<List<GetProductQueryResult>>
    {

    }
}
