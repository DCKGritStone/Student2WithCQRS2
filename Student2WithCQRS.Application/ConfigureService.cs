using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Student2WithCQRS.Application
{
    public static class ConfigureService
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            }
            );

            return services;
        }
    }
}
