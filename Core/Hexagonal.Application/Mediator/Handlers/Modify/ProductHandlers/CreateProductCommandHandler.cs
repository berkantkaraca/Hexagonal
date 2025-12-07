using AutoMapper;
using MediatR;
using Hexagonal.Application.Mediator.Results.ProductResults.QueryResults;
using Hexagonal.Application.Mediator.Commands.ProductCommands;
using Hexagonal.Domain.Entities;
using Hexagonal.Domain.SecondaryPorts;

namespace Hexagonal.Application.Mediator.Handlers.Modify.ProductHandlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, GetProductByIdQueryResult>
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public CreateProductCommandHandler(IProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetProductByIdQueryResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            Product product = _mapper.Map<Product>(request);
            await _repository.CreateAsync(product);

            return _mapper.Map<GetProductByIdQueryResult>(product);
        }
    }
}
