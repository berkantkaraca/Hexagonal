using AutoMapper;
using Hexagonal.Application.Mediator.Commands.OrderDetailCommands;
using Hexagonal.Application.Mediator.Results.OrderDetailResults.QueryResults;
using Hexagonal.Domain.Entities;
using Hexagonal.Domain.SecondaryPorts;
using MediatR;

namespace Hexagonal.Application.Mediator.Handlers.Modify.OrderDetailHandlers
{
    public class CreateOrderDetailCommandHandler : IRequestHandler<CreateOrderDetailCommand, GetOrderDetailByIdQueryResult>
    {
        private readonly IOrderDetailRepository _repository;
        private readonly IMapper _mapper;

        public CreateOrderDetailCommandHandler(IOrderDetailRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetOrderDetailByIdQueryResult> Handle(CreateOrderDetailCommand request, CancellationToken cancellationToken)
        {
            OrderDetail orderDetail = _mapper.Map<OrderDetail>(request);
            await _repository.CreateAsync(orderDetail);
            return _mapper.Map<GetOrderDetailByIdQueryResult>(orderDetail);
        }
    }
}
