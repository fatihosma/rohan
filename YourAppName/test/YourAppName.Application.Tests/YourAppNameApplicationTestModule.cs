using Volo.Abp.Modularity;

namespace YourAppName
{
    [DependsOn(
        typeof(YourAppNameApplicationModule),
        typeof(YourAppNameDomainTestModule)
        )]
    public class YourAppNameApplicationTestModule : AbpModule
    {

    }
}