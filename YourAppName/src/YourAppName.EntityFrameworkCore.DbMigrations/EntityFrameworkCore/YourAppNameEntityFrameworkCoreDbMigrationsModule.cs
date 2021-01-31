using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace YourAppName.EntityFrameworkCore
{
    [DependsOn(
        typeof(YourAppNameEntityFrameworkCoreModule)
        )]
    public class YourAppNameEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<YourAppNameMigrationsDbContext>();
        }
    }
}
