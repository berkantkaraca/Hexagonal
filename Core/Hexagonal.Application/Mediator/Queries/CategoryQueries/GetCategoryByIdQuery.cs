using Hexagonal.Application.Mediator.Results.CategoryResults.QueryResults;
using MediatR;

namespace Hexagonal.Application.Mediator.Queries.CategoryQueries
{
    public class GetCategoryByIdQuery : IRequest<GetCategoryByIdQueryResult>
    {
        public int Id { get; set; }

        public GetCategoryByIdQuery(int id)
        {
            Id = id;
        }
    }
}
