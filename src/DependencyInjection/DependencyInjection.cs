using Microsoft.Extensions.DependencyInjection;
using SampleArchi.Core.Application.Services.ProductService;
using SampleArchi.Core.Domain.Interfaces;

namespace SampleArchi.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationDependencies(this IServiceCollection services)
        {
            // Register Repositories
            services.AddScoped<IProductRepository, ProductRepository>();

            // Register Services
            services.AddScoped<ProductService>();

            return services;
        }
    }
}
