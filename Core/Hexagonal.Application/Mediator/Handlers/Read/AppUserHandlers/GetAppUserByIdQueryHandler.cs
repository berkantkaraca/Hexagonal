using AutoMapper;
using Hexagonal.Application.Mediator.Queries.AppUserQueries;
using Hexagonal.Application.Mediator.Results.AppUserResults.QueryResults;
using MediatR;
using Hexagonal.Domain.SecondaryPorts;
using Hexagonal.Domain.Entities;

namespace Hexagonal.Application.Mediator.Handlers.Read.AppUserHandlers
{
    public class GetAppUserByIdQueryHandler : IRequestHandler<GetAppUserByIdQuery, GetAppUserByIdQueryResult>
    {
        private readonly IAppUserRepository _repository;
        private readonly IMapper _mapper;

        public GetAppUserByIdQueryHandler(IAppUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetAppUserByIdQueryResult> Handle(GetAppUserByIdQuery request, CancellationToken cancellationToken)
        {
            AppUser value = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<GetAppUserByIdQueryResult>(value);
        }
    }
}
