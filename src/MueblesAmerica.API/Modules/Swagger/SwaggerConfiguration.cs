using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

namespace MueblesAmerica.API.Modules.Swagger
{
    public static class SwaggerConfiguration
    {
        public static IServiceCollection AddCustomSwagger(this IServiceCollection services)
        {
            return services;
        }
    }
}
