using AutoMapper;
using Hexagonal.Application.Mediator.Commands.AppUserProfileCommands;
using Hexagonal.Application.Mediator.Results.AppUserProfileResults.QueryResults;
using Hexagonal.Domain.Entities;
using Hexagonal.Domain.SecondaryPorts;
using MediatR;

namespace Hexagonal.Application.Mediator.Handlers.Modify.AppUserProfileHandlers
{
    public class CreateAppUserProfileCommandHandler : IRequestHandler<CreateAppUserProfileCommand, GetAppUserProfileByIdQueryResult>
    {
        private readonly IAppUserProfileRepository _repository;
        private readonly IMapper _mapper;

        public CreateAppUserProfileCommandHandler(IAppUserProfileRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetAppUserProfileByIdQueryResult> Handle(CreateAppUserProfileCommand request, CancellationToken cancellationToken)
        {
            AppUserProfile appUserProfile = _mapper.Map<AppUserProfile>(request);
            await _repository.CreateAsync(appUserProfile);
            return _mapper.Map<GetAppUserProfileByIdQueryResult>(appUserProfile);
        }
    }
}
