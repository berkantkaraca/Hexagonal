using Hexagonal.Application.Mediator.Results.AppUserProfileResults.QueryResults;
using MediatR;

namespace Hexagonal.Application.Mediator.Queries.AppUserProfileQueries
{
    public class GetAppUserProfileQuery : IRequest<List<GetAppUserProfileQueryResult>>
    {

    }
}
