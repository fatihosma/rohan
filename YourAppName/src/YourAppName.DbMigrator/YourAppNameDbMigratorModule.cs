using YourAppName.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace YourAppName.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(YourAppNameEntityFrameworkCoreDbMigrationsModule),
        typeof(YourAppNameApplicationContractsModule)
        )]
    public class YourAppNameDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
