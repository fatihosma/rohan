using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace YourAppName.Pages
{
    [Collection(YourAppNameTestConsts.CollectionDefinitionName)]
    public class Index_Tests : YourAppNameWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
