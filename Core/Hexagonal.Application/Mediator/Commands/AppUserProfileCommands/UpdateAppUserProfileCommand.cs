using Hexagonal.Application.Mediator.Results.AppUserProfileResults.QueryResults;
using MediatR;

namespace Hexagonal.Application.Mediator.Commands.AppUserProfileCommands
{
    public class UpdateAppUserProfileCommand : IRequest<GetAppUserProfileByIdQueryResult>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int AppUserId { get; set; }
    }
}
