using Microsoft.Extensions.DependencyInjection;
using REAccess_Mobile_Api.Interfaces;
using REAccess_Mobile_Api.Services;

namespace REAccess_Mobile_Api.Extensions
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IUtilService, UtilService>();
            services.AddScoped<IRankService, RankService>();
            services.AddScoped<IIndustryService, IndustryService>();
        }
    }
}
