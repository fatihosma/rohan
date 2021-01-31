using YourAppName.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace YourAppName.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class YourAppNamePageModel : AbpPageModel
    {
        protected YourAppNamePageModel()
        {
            LocalizationResourceType = typeof(YourAppNameResource);
        }
    }
}