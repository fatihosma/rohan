using YourAppName.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace YourAppName.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class YourAppNameController : AbpController
    {
        protected YourAppNameController()
        {
            LocalizationResource = typeof(YourAppNameResource);
        }
    }
}