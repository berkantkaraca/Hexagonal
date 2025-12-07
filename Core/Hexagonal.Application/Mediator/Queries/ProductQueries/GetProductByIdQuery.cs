using Hexagonal.Application.Mediator.Results.ProductResults.QueryResults;
using MediatR;

namespace Hexagonal.Application.Mediator.Queries.ProductQueries
{
    public class GetProductByIdQuery : IRequest<GetProductByIdQueryResult>
    {
        public int Id { get; set; }

        public GetProductByIdQuery(int id)
        {
            Id = id;
        }
    }
}
