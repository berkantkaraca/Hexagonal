using Hexagonal.Application.Mediator.Results.CategoryResults.QueryResults;
using MediatR;

namespace Hexagonal.Application.Mediator.Commands.CategoryCommands
{
    public class CreateCategoryCommand : IRequest<GetCategoryByIdQueryResult>
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
