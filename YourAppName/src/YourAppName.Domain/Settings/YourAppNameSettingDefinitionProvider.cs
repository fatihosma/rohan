using Volo.Abp.Settings;

namespace YourAppName.Settings
{
    public class YourAppNameSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(YourAppNameSettings.MySetting1));
        }
    }
}
