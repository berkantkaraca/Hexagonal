using Hexagonal.Application.Mediator.Results.OrderResults.QueryResults;
using MediatR;

namespace Hexagonal.Application.Mediator.Commands.OrderCommands
{
    public class CreateOrderCommand : IRequest<GetOrderByIdQueryResult>
    {
        public string ShippingAddress { get; set; }
        public int? AppUserId { get; set; }
    }
}
