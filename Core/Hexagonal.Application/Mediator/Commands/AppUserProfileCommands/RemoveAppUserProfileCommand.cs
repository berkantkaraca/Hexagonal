using Hexagonal.Application.Mediator.Results.AppUserProfileResults.QueryResults;
using MediatR;

namespace Hexagonal.Application.Mediator.Commands.AppUserProfileCommands
{
    public class RemoveAppUserProfileCommand : IRequest<GetAppUserProfileByIdQueryResult>
    {
        public int Id { get; set; }

        public RemoveAppUserProfileCommand(int id)
        {
            Id = id;
        }
    }
}
