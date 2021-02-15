using JobsCatalog.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Repository;

namespace JobsCatalog.Extensions
{
    public static class CustomService
    {
        public static void ServiceExtension(this IServiceCollection services)
        {
          
            services.AddTransient<HttpContextAccessor>();
            // services.AddRouting(options => options.LowercaseUrls = true);
            services.AddTransient<IUnitOfWork, UnitOfWork>();
           // services.AddSingleton<IWorker, Worker>();
            services.AddAuthentication().AddFacebook(facebookOptions =>
             {
                      facebookOptions.AppId = "610566302931847";
                      facebookOptions.AppSecret = "281d461746bccdef9bbdb0925c57e558";
             });
        }
    }
}