using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace YourAppName.Web
{
    [Dependency(ReplaceServices = true)]
    public class YourAppNameBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "YourAppName";
    }
}
