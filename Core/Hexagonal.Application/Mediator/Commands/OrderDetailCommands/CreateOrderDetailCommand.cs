using Hexagonal.Application.Mediator.Results.OrderDetailResults.QueryResults;
using MediatR;

namespace Hexagonal.Application.Mediator.Commands.OrderDetailCommands
{
    public class CreateOrderDetailCommand : IRequest<GetOrderDetailByIdQueryResult>
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
    }
}
