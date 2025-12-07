using AutoMapper;
using Hexagonal.Application.Mediator.Queries.AppUserQueries;
using Hexagonal.Application.Mediator.Results.AppUserResults.QueryResults;
using MediatR;
using Hexagonal.Domain.SecondaryPorts;
using Hexagonal.Domain.Entities;

namespace Hexagonal.Application.Mediator.Handlers.Read.AppUserHandlers
{
    public class GetAppUserQueryHandler : IRequestHandler<GetAppUserQuery, List<GetAppUserQueryResult>>
    {
        private readonly IAppUserRepository _repository;
        private readonly IMapper _mapper;

        public GetAppUserQueryHandler(IAppUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetAppUserQueryResult>> Handle(GetAppUserQuery request, CancellationToken cancellationToken)
        {
            List<AppUser> values = await _repository.GetAllAsync();
            return _mapper.Map<List<GetAppUserQueryResult>>(values);
        }
    }
}
