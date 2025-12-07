using Hexagonal.Application.Mediator.Results.OrderDetailResults.QueryResults;
using MediatR;

namespace Hexagonal.Application.Mediator.Commands.OrderDetailCommands
{
    public class UpdateOrderDetailCommand : IRequest<GetOrderDetailByIdQueryResult>
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
    }
}
