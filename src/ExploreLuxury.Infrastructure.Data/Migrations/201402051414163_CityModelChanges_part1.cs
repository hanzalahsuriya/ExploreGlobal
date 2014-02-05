namespace ExploreLuxury.Infrastructure.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CityModelChanges_part1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.City", "Country_Id", "dbo.Country");
            DropForeignKey("dbo.City", "Country_Id1", "dbo.Country");
            DropIndex("dbo.City", new[] { "Country_Id" });
            DropIndex("dbo.City", new[] { "Country_Id1" });
            DropColumn("dbo.City", "Country_Id");
            DropColumn("dbo.City", "Country_Id1");
        }
        
        public override void Down()
        {
            AddColumn("dbo.City", "Country_Id1", c => c.Guid(nullable: false));
            AddColumn("dbo.City", "Country_Id", c => c.Guid());
            CreateIndex("dbo.City", "Country_Id1");
            CreateIndex("dbo.City", "Country_Id");
            AddForeignKey("dbo.City", "Country_Id1", "dbo.Country", "Id");
            AddForeignKey("dbo.City", "Country_Id", "dbo.Country", "Id");
        }
    }
}
