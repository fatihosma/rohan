using Xunit;

namespace YourAppName.EntityFrameworkCore
{
    [CollectionDefinition(YourAppNameTestConsts.CollectionDefinitionName)]
    public class YourAppNameEntityFrameworkCoreCollection : ICollectionFixture<YourAppNameEntityFrameworkCoreFixture>
    {

    }
}
