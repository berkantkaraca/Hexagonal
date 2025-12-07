using AutoMapper;
using Hexagonal.Application.Mediator.Queries.AppUserProfileQueries;
using Hexagonal.Application.Mediator.Results.AppUserProfileResults.QueryResults;
using Hexagonal.Domain.Entities;
using Hexagonal.Domain.SecondaryPorts;
using MediatR;

namespace Hexagonal.Application.Mediator.Handlers.Read.AppUserProfileHandlers
{
    public class GetAppUserProfileQueryHandler : IRequestHandler<GetAppUserProfileQuery, List<GetAppUserProfileQueryResult>>
    {
        private readonly IAppUserProfileRepository _repository;
        private readonly IMapper _mapper;

        public GetAppUserProfileQueryHandler(IAppUserProfileRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetAppUserProfileQueryResult>> Handle(GetAppUserProfileQuery request, CancellationToken cancellationToken)
        {
            List<AppUserProfile> values = await _repository.GetAllAsync();
            return _mapper.Map<List<GetAppUserProfileQueryResult>>(values);
        }
    }
}
