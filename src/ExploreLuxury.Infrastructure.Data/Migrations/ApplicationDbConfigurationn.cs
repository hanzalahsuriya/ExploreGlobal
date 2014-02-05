using System.Data.Entity.Migrations;
using ExploreLuxury.Infrastructure.Data.Context;

namespace ExploreLuxury.Infrastructure.Data.Migrations
{
    internal sealed class ApplicationDbConfiguration : DbMigrationsConfiguration<AppDbContext>
    {
        public ApplicationDbConfiguration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ExploreLuxury.Infrastructure.Data.Context.AppDbContext";
        }

        protected override void Seed(AppDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
