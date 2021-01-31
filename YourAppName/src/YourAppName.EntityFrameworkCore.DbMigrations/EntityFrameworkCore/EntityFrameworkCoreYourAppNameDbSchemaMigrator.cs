using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using YourAppName.Data;
using Volo.Abp.DependencyInjection;

namespace YourAppName.EntityFrameworkCore
{
    public class EntityFrameworkCoreYourAppNameDbSchemaMigrator
        : IYourAppNameDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreYourAppNameDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the YourAppNameMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<YourAppNameMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}