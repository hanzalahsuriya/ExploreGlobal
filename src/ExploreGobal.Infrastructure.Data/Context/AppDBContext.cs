using ExploreGobal.Business.Domain.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Entity = ExploreGobal.Business.Domain.Entities.Membership;
using System.Linq;
using System.Text;

namespace ExploreGlobal.Infrastructure.Data.Context
{
    public class AppDbContext : IdentityDbContext<Entity.UserProfile> 
    {

        public AppDbContext() : base("DbContext")
        { }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<City> City { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
