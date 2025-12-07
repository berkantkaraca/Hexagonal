using AutoMapper;
using MediatR;
using Hexagonal.Application.Mediator.Commands.OrderCommands;
using Hexagonal.Application.Mediator.Results.OrderResults.QueryResults;
using Hexagonal.Domain.Entities;
using Hexagonal.Domain.Enums;
using Hexagonal.Domain.SecondaryPorts;

namespace Hexagonal.Application.Mediator.Handlers.Modify.OrderHandlers
{
    public class UpdateOrderCommandHandler : IRequestHandler<UpdateOrderCommand, GetOrderByIdQueryResult>
    {
        private readonly IOrderRepository _repository;
        private readonly IMapper _mapper;

        public UpdateOrderCommandHandler(IOrderRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetOrderByIdQueryResult> Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
        {
            Order value = await _repository.GetByIdAsync(request.Id);

            value.ShippingAddress = request.ShippingAddress;
            value.AppUserId = request.AppUserId;
            value.Status = DataStatus.Updated;
            value.UpdatedDate = DateTime.Now;

            await _repository.SaveChangesAsync();
            return _mapper.Map<GetOrderByIdQueryResult>(value);
        }
    }
}
