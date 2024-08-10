using MueblesAmerica.Domain.Ports.In.Category;
using MueblesAmerica.Domain.Ports.In.OrderItem;
using MueblesAmerica.Domain.Ports.Out.Category;
using MueblesAmerica.Domain.Ports.Out.Order;
using MueblesAmerica.Domain.Ports.Out.OrderItem;
using MueblesAmerica.Domain.Ports.Out.Product;
using MueblesAmerica.Domain.Ports.Out.User;
using MueblesAmerica.Infrastructure.Adapters.Category;
using MueblesAmerica.Infrastructure.Adapters.Order;
using MueblesAmerica.Infrastructure.Adapters.OrderItem;
using MueblesAmerica.Infrastructure.Adapters.Product;
using MueblesAmerica.Infrastructure.Adapters.User;
using MueblesAmerica.Infrastructure.Factories;
using MueblesAmerica.Infrastructure.Interface;

namespace MueblesAmerica.API.Modules.Injection
{
    public static class InjectionConfiguration
    {
        public static IServiceCollection AddCustomInjection(this IServiceCollection services, IConfiguration configuration)
        {
            // Dependency Injection for Factories
            services.AddScoped<ISqlConnectionFactory, SqlConnectionFactory>();

            // Dependency Injection for Adapters (Repositories)
            services.AddScoped<IUserRepositoryPort, UserRepositoryAdapter>();
            services.AddScoped<IProductRepositoryPort, ProductRepositoryAdapter>();
            services.AddScoped<IOrderRepositoryPort, OrderRepositoryAdapter>();
            services.AddScoped<IOrderItemRepositoryPort, OrderItemRepositoryAdapter>();
            services.AddScoped<ICategoryRepositoryPort, CategoryRepositoryAdapter>();

            // Dependency Injection for Commands at the Domain Layer
            services.AddScoped<CreateCategoryCommand>();
            services.AddScoped<DeleteCategoryCommand>();
            services.AddScoped<GetAllCategoriesCommand>();
            services.AddScoped<GetCategoryByIdCommand>();
            services.AddScoped<UpdateCategoryCommand>();

            //services.AddScoped<CreateOrderItemCommand>();
            //services.AddScoped<DeleteOrderItemCommand>();
            //services.AddScoped<GetAllOrderItemsCommand>();
            //services.AddScoped<GetOrderItemByIdCommand>();
            //services.AddScoped<UpdateOrderItemCommand>();

            // Dependency Injection for Use Cases at the Application Layer
            services.AddScoped<Application.UseCases.Category.CreateCategoryUseCase>();
            services.AddScoped<Application.UseCases.Category.DeleteCategoryUseCase>();
            services.AddScoped<Application.UseCases.Category.GetAllCategoriesUseCase>();
            services.AddScoped<Application.UseCases.Category.GetCategoryByIdUseCase>();
            services.AddScoped<Application.UseCases.Category.UpdateCategoryUseCase>();

            //services.AddScoped<Application.UseCases.User.CreateUserUseCase>();
            //services.AddScoped<Application.UseCases.User.DeleteUserUseCase>();
            //services.AddScoped<Application.UseCases.User.GetAllUsersUseCase>();
            //services.AddScoped<Application.UseCases.User.GetUserByIdUseCase>();
            //services.AddScoped<Application.UseCases.User.UpdateUserUseCase>();


            return services;
        }
    }
}
