using Hexagonal.Application.Mediator.Results.CategoryResults.QueryResults;
using MediatR;

namespace Hexagonal.Application.Mediator.Commands.CategoryCommands
{
    public class RemoveCategoryCommand : IRequest<GetCategoryByIdQueryResult>
    {
        public int Id { get; set; }

        public RemoveCategoryCommand(int id)
        {
            Id = id;
        }
    }
}
