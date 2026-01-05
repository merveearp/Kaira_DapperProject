using Kaira.WebUI.Repositories.AboutRepositories;
using Kaira.WebUI.Repositories.BannerRepositories;
using Kaira.WebUI.Repositories.BlogRepositories;
using Kaira.WebUI.Repositories.CategoryRepositories;
using Kaira.WebUI.Repositories.CollectionRepositories;
using Kaira.WebUI.Repositories.ContactRepositories;
using Kaira.WebUI.Repositories.CoverImageRepositories;
using Kaira.WebUI.Repositories.FAQRepositories;
using Kaira.WebUI.Repositories.LogoRepositories;
using Kaira.WebUI.Repositories.ServiceRepositories;
using Kaira.WebUI.Repositories.TestimonialRepositories;
using Kaira.WebUI.Repositories.VideoRepositories;

namespace Kaira.WebUI.Extensions
{
    public static class ServiceRegistrations
    {
        public static void AddRepository(this IServiceCollection services)
        {
            services.AddScoped<ICategoryRepository , CategoryRepository>();
            services.AddScoped<ICollectionRepository , CollectionRepository>();
            services.AddScoped<IAboutRepository , AboutRepository>();
            services.AddScoped<IBlogRepository , BlogRepository>();
            services.AddScoped<IContactRepository , ContactRepository>();
            services.AddScoped<ICoverImageRepository , CoverImageRepository>();
            services.AddScoped<IFAQRepository , FAQRepository>();
            services.AddScoped<IServiceRepository , ServiceRepository>();
            services.AddScoped<IVideoRepository , VideoRepository>();
            services.AddScoped<ITestimonialRepository , TestimonialRepository>();
            services.AddScoped<IBannerRepository , BannerRepository>();
            services.AddScoped<ILogoRepository , LogoRepository>();
        }
    }
}
