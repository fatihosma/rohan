using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace YourAppName.Data
{
    /* This is used if database provider does't define
     * IYourAppNameDbSchemaMigrator implementation.
     */
    public class NullYourAppNameDbSchemaMigrator : IYourAppNameDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}