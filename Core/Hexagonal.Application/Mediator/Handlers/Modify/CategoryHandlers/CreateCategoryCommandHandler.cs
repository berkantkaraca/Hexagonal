using AutoMapper;
using MediatR;
using Hexagonal.Application.Mediator.Commands.CategoryCommands;
using Hexagonal.Application.Mediator.Results.CategoryResults.QueryResults;
using Hexagonal.Domain.Entities;
using Hexagonal.Domain.SecondaryPorts;

namespace Hexagonal.Application.Mediator.Handlers.Modify.CategoryHandlers
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, GetCategoryByIdQueryResult>
    {
        private readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;

        public CreateCategoryCommandHandler(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetCategoryByIdQueryResult> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            Category category = _mapper.Map<Category>(request);
            await _repository.CreateAsync(category);
            return _mapper.Map<GetCategoryByIdQueryResult>(category);
        }
    }
}
