using Hexagonal.Application.Mediator.Results.ProductResults.QueryResults;
using MediatR;

namespace Hexagonal.Application.Mediator.Commands.ProductCommands
{
    public class CreateProductCommand : IRequest<GetProductByIdQueryResult>
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int? CategoryId { get; set; }
    }
}
