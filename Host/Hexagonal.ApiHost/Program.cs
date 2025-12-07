using Hexagonal.Application.DependencyResolvers;
using Hexagonal.Persistence.DependencyResolvers;
using Hexagonal.WebApi.Controllers;

namespace Hexagonal.ApiHost
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers().AddApplicationPart(typeof(CategoryController).Assembly); 
            //Controller'larin bulundugu assembly'i tanýtýyoruz ki API cagrýlarýnda Controller'lar nerede bulunabilsin. Burada Asp .Net Core'a sunu demiþ oluyoruz : "Hexagonal.WebApi icindeki Controllerlarý da kullan"

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddHandlerService();
            builder.Services.AddMapperService();
            builder.Services.AddDbContextServices();
            builder.Services.AddRepositoryServices();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
