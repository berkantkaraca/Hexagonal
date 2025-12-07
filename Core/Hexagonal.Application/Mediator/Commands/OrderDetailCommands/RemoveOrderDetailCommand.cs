using Hexagonal.Application.Mediator.Results.OrderDetailResults.QueryResults;
using MediatR;

namespace Hexagonal.Application.Mediator.Commands.OrderDetailCommands
{
    public class RemoveOrderDetailCommand : IRequest<GetOrderDetailByIdQueryResult>
    {
        public int Id { get; set; }

        public RemoveOrderDetailCommand(int id)
        {
            Id = id;
        }
    }
}
