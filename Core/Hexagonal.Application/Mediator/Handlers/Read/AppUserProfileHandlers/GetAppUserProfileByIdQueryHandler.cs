using AutoMapper;
using Hexagonal.Application.Mediator.Queries.AppUserProfileQueries;
using Hexagonal.Application.Mediator.Results.AppUserProfileResults.QueryResults;
using Hexagonal.Domain.Entities;
using Hexagonal.Domain.SecondaryPorts;
using MediatR;

namespace Hexagonal.Application.Mediator.Handlers.Read.AppUserProfileHandlers
{
    public class GetAppUserProfileByIdQueryHandler : IRequestHandler<GetAppUserProfileByIdQuery, GetAppUserProfileByIdQueryResult>
    {
        private readonly IAppUserProfileRepository _repository;
        private readonly IMapper _mapper;

        public GetAppUserProfileByIdQueryHandler(IAppUserProfileRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetAppUserProfileByIdQueryResult> Handle(GetAppUserProfileByIdQuery request, CancellationToken cancellationToken)
        {
            AppUserProfile value = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<GetAppUserProfileByIdQueryResult>(value);
        }
    }
}
