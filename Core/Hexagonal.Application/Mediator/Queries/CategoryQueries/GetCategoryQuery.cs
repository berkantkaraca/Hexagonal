using Hexagonal.Application.Mediator.Results.CategoryResults.QueryResults;
using MediatR;

namespace Hexagonal.Application.Mediator.Queries.CategoryQueries
{
    public class GetCategoryQuery : IRequest<List<GetCategoryQueryResult>>
    {

    }
}
