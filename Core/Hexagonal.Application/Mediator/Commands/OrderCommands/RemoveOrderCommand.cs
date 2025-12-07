using Hexagonal.Application.Mediator.Results.OrderResults.QueryResults;
using MediatR;

namespace Hexagonal.Application.Mediator.Commands.OrderCommands
{
    public class RemoveOrderCommand : IRequest<GetOrderByIdQueryResult>
    {
        public int Id { get; set; }

        public RemoveOrderCommand(int id)
        {
            Id = id;
        }
    }
}
