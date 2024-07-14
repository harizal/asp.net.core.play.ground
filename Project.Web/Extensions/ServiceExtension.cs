using Project.Core.Interfaces.IServices;
using Project.Core.Services;

namespace Project.Web.Extensions
{
    public static class ServiceExtension
    {
        public static IServiceCollection RegisterService(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();

            return services;
        }
    }
}
