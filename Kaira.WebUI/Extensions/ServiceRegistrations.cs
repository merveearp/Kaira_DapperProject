using Kaira.WebUI.Repositories.CategoryRepositories;

namespace Kaira.WebUI.Extensions
{
    public static class ServiceRegistrations
    {
        public static void AddRepository(this IServiceCollection services)
        {
            services.AddScoped<ICategoryRepository , CategoryRepository>();
        }
    }
}
