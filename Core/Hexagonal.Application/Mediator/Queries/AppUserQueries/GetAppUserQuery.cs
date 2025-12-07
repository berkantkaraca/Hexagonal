using Hexagonal.Application.Mediator.Results.AppUserResults.QueryResults;
using MediatR;

namespace Hexagonal.Application.Mediator.Queries.AppUserQueries
{
    //IRequest isteğin ne türden döneceğini bildirir
    public class GetAppUserQuery : IRequest<List<GetAppUserQueryResult>>   
    {

    }
}
