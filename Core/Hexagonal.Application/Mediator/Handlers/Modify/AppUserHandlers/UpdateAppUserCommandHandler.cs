using AutoMapper;
using Hexagonal.Application.Mediator.Commands.AppUserCommands;
using Hexagonal.Application.Mediator.Results.AppUserResults.QueryResults;
using Hexagonal.Domain.Entities;
using Hexagonal.Domain.Enums;
using Hexagonal.Domain.SecondaryPorts;
using MediatR;

namespace Hexagonal.Application.Mediator.Handlers.Modify.AppUserHandlers
{
    public class UpdateAppUserCommandHandler : IRequestHandler<UpdateAppUserCommand, GetAppUserByIdQueryResult>
    {
        private readonly IAppUserRepository _repository;
        private readonly IMapper _mapper;

        public UpdateAppUserCommandHandler(IAppUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetAppUserByIdQueryResult> Handle(UpdateAppUserCommand request, CancellationToken cancellationToken)
        {
            AppUser value = await _repository.GetByIdAsync(request.Id);

            value.UserName = request.UserName;
            value.Password = request.Password;
            value.Status = DataStatus.Updated;
            value.UpdatedDate = DateTime.Now;

            await _repository.SaveChangesAsync();
            return _mapper.Map<GetAppUserByIdQueryResult>(value);
        }
    }
}
