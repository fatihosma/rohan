using YourAppName.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace YourAppName
{
    [DependsOn(
        typeof(YourAppNameEntityFrameworkCoreTestModule)
        )]
    public class YourAppNameDomainTestModule : AbpModule
    {

    }
}