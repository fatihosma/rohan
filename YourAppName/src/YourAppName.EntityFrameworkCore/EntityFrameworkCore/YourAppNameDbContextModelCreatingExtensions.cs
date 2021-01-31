using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace YourAppName.EntityFrameworkCore
{
    public static class YourAppNameDbContextModelCreatingExtensions
    {
        public static void ConfigureYourAppName(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(YourAppNameConsts.DbTablePrefix + "YourEntities", YourAppNameConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}