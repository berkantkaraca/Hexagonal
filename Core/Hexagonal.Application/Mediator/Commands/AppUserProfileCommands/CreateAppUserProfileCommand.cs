using Hexagonal.Application.Mediator.Results.AppUserProfileResults.QueryResults;
using MediatR;

namespace Hexagonal.Application.Mediator.Commands.AppUserProfileCommands
{
    public class CreateAppUserProfileCommand : IRequest<GetAppUserProfileByIdQueryResult>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int AppUserId { get; set; }
    }
}
