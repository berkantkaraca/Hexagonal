using AutoMapper;
using Hexagonal.Application.Mediator.Commands.AppUserCommands;
using Hexagonal.Application.Mediator.Commands.AppUserProfileCommands;
using Hexagonal.Application.Mediator.Commands.CategoryCommands;
using Hexagonal.Application.Mediator.Commands.OrderCommands;
using Hexagonal.Application.Mediator.Commands.OrderDetailCommands;
using Hexagonal.Application.Mediator.Commands.ProductCommands;
using Hexagonal.Application.Mediator.Results.AppUserProfileResults.CommandResults;
using Hexagonal.Application.Mediator.Results.AppUserProfileResults.QueryResults;
using Hexagonal.Application.Mediator.Results.AppUserResults.CommandResults;
using Hexagonal.Application.Mediator.Results.AppUserResults.QueryResults;
using Hexagonal.Application.Mediator.Results.CategoryResults.CommandResults;
using Hexagonal.Application.Mediator.Results.CategoryResults.QueryResults;
using Hexagonal.Application.Mediator.Results.OrderDetailResults.CommandResults;
using Hexagonal.Application.Mediator.Results.OrderDetailResults.QueryResults;
using Hexagonal.Application.Mediator.Results.OrderResults.CommandResults;
using Hexagonal.Application.Mediator.Results.OrderResults.QueryResults;
using Hexagonal.Application.Mediator.Results.ProductResults.CommandResults;
using Hexagonal.Application.Mediator.Results.ProductResults.QueryResults;
using Hexagonal.Domain.Entities;

namespace Hexagonal.Application.MappingProfiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //AppUser
            CreateMap<CreateAppUserCommand, AppUser>();
            CreateMap<UpdateAppUserCommand, AppUser>();
            CreateMap<AppUser, GetAppUserCommandResult>();
            CreateMap<AppUser, GetAppUserQueryResult>();
            CreateMap<AppUser, GetAppUserByIdQueryResult>();

            //AppUserProfile
            CreateMap<CreateAppUserProfileCommand, AppUserProfile>();
            CreateMap<UpdateAppUserProfileCommand, AppUserProfile>();
            CreateMap<AppUserProfile, GetAppUserProfileCommandResult>();
            CreateMap<AppUserProfile, GetAppUserProfileQueryResult>();
            CreateMap<AppUserProfile, GetAppUserProfileByIdQueryResult>();

            //Category
            CreateMap<CreateCategoryCommand, Category>();
            CreateMap<UpdateCategoryCommand, Category>();
            CreateMap<Category, GetCategoryCommandResult>();
            CreateMap<Category, GetCategoryQueryResult>();
            CreateMap<Category, GetCategoryByIdQueryResult>();

            //Order
            CreateMap<CreateOrderCommand, Order>();
            CreateMap<UpdateOrderCommand, Order>();
            CreateMap<Order, GetOrderCommandResult>();
            CreateMap<Order, GetOrderQueryResult>();
            CreateMap<Order, GetOrderByIdQueryResult>();

            //OrderDetail
            CreateMap<CreateOrderDetailCommand, OrderDetail>();
            CreateMap<UpdateOrderDetailCommand, OrderDetail>();
            CreateMap<OrderDetail, GetOrderDetailCommandResult>();
            CreateMap<OrderDetail, GetOrderDetailQueryResult>();
            CreateMap<OrderDetail, GetOrderDetailByIdQueryResult>();

            //Product
            CreateMap<CreateProductCommand, Product>();
            CreateMap<UpdateProductCommand, Product>();
            CreateMap<Product, GetProductCommandResult>();
            CreateMap<Product, GetProductQueryResult>();
            CreateMap<Product, GetProductByIdQueryResult>();
        }
    }
}
