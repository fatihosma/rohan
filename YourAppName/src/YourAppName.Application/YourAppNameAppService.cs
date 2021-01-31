using System;
using System.Collections.Generic;
using System.Text;
using YourAppName.Localization;
using Volo.Abp.Application.Services;

namespace YourAppName
{
    /* Inherit your application services from this class.
     */
    public abstract class YourAppNameAppService : ApplicationService
    {
        protected YourAppNameAppService()
        {
            LocalizationResource = typeof(YourAppNameResource);
        }
    }
}
