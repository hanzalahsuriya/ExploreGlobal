using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using ExploreLuxury.Business.Domain.Entities;
using ExploreLuxury.Business.Domain.Entities.Membership;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ExploreLuxury.Infrastructure.Data.Context
{
    public class AppDbContext : IdentityDbContext<UserProfile> 
    {

        public AppDbContext() : base("DbContext")
        { }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<TestTable> TestTable { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<City>().HasRequired(c => c.Country).WithMany(t => t.Cities).HasForeignKey(c=>c.CountryId).WillCascadeOnDelete(false);

        }
    }
}
