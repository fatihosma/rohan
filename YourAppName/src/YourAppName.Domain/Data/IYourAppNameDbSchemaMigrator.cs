using System.Threading.Tasks;

namespace YourAppName.Data
{
    public interface IYourAppNameDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
