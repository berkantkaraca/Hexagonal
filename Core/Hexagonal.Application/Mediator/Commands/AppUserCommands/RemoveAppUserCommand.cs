using Hexagonal.Application.Mediator.Results.AppUserResults.QueryResults;
using MediatR;

namespace Hexagonal.Application.Mediator.Commands.AppUserCommands
{
    public class RemoveAppUserCommand : IRequest<GetAppUserByIdQueryResult>
    {
        public int Id { get; set; }

        public RemoveAppUserCommand(int id)
        {
            Id = id;
        }
    }
}
