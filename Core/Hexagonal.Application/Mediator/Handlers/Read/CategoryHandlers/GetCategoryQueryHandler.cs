using AutoMapper;
using Hexagonal.Application.Mediator.Queries.CategoryQueries;
using Hexagonal.Application.Mediator.Results.CategoryResults.QueryResults;
using MediatR;
using Hexagonal.Domain.SecondaryPorts;
using Hexagonal.Domain.Entities;

namespace Hexagonal.Application.Mediator.Handlers.Read.CategoryHandlers
{
    public class GetCategoryQueryHandler : IRequestHandler<GetCategoryQuery, List<GetCategoryQueryResult>>
    {
        private readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;

        public GetCategoryQueryHandler(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetCategoryQueryResult>> Handle(GetCategoryQuery request, CancellationToken cancellationToken)
        {
            List<Category> values = await _repository.GetAllAsync();
            return _mapper.Map<List<GetCategoryQueryResult>>(values);
        }
    }
}
