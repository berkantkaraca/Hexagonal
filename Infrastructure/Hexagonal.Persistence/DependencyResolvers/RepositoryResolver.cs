using Hexagonal.Domain.SecondaryPorts;
using Hexagonal.Persistence.EFRepositories;
using Microsoft.Extensions.DependencyInjection;

namespace Hexagonal.Persistence.DependencyResolvers
{
    public static class RepositoryResolver
    {
        public static void AddRepositoryServices(this IServiceCollection services)
        {
            services.AddScoped<IAppUserRepository, AppUserRepository>();
            services.AddScoped<IAppUserProfileRepository, AppUserProfileRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();

            //BaseRepository abstract değilse ve generic ise aşağıdaki satır kullanılabilir.
            //services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
        }
    }
}
