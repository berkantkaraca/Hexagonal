using Hexagonal.Application.Mediator.Results.CategoryResults.QueryResults;
using MediatR;

namespace Hexagonal.Application.Mediator.Commands.CategoryCommands
{
    public class UpdateCategoryCommand : IRequest<GetCategoryByIdQueryResult>
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
