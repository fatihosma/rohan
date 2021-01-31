using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace YourAppName
{
    public class YourAppNameWebTestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<YourAppNameWebTestModule>();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.InitializeApplication();
        }
    }
}