using Hexagonal.Application.Mediator.Handlers.Read.CategoryHandlers;
using Microsoft.Extensions.DependencyInjection;

namespace Hexagonal.Application.DependencyResolvers
{
    public static class HandlerResolver
    {
        public static void AddHandlerService(this IServiceCollection services)
        {
            services.AddMediatR(x => x.RegisterServicesFromAssembly(typeof(GetCategoryByIdQueryHandler).Assembly));
        }
    }
}
