using Hexagonal.Application.Mediator.Results.AppUserResults.QueryResults;
using MediatR;

namespace Hexagonal.Application.Mediator.Commands.AppUserCommands
{
    public class UpdateAppUserCommand : IRequest<GetAppUserByIdQueryResult>
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
