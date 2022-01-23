#region
using Microsoft.Extensions.DependencyInjection;
using REAccess.Mobile.Api.Controllers.Attributes;
using REAccess.Mobile.Common.Interfaces;
using REAccess.Mobile.Common.Services;
#endregion

namespace REAccess.Mobile.Api.Extensions
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IUtilService, UtilService>();
            services.AddScoped<IRankService, RankService>();
            services.AddScoped<IIndustryService, IndustryService>();
            services.AddScoped<LoggingExceptionFilterAttribute>();
        }
    }
}
