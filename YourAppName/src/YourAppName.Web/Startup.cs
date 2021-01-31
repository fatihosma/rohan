using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace YourAppName.Web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<YourAppNameWebModule>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.InitializeApplication();
        }
    }
}
