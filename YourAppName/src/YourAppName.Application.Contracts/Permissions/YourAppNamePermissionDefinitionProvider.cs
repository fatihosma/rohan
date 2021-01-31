using YourAppName.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace YourAppName.Permissions
{
    public class YourAppNamePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(YourAppNamePermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(YourAppNamePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<YourAppNameResource>(name);
        }
    }
}
