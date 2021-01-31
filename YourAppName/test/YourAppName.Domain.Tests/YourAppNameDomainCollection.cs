using YourAppName.EntityFrameworkCore;
using Xunit;

namespace YourAppName
{
    [CollectionDefinition(YourAppNameTestConsts.CollectionDefinitionName)]
    public class YourAppNameDomainCollection : YourAppNameEntityFrameworkCoreCollectionFixtureBase
    {

    }
}
