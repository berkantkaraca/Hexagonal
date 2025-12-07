using Hexagonal.Application.Mediator.Results.ProductResults.QueryResults;
using MediatR;

namespace Hexagonal.Application.Mediator.Commands.ProductCommands
{
    public class RemoveProductCommand : IRequest<GetProductByIdQueryResult>
    {
        public int Id { get; set; }

        public RemoveProductCommand(int id)
        {
            Id = id;
        }
    }
}
