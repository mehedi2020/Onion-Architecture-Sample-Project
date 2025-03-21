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
