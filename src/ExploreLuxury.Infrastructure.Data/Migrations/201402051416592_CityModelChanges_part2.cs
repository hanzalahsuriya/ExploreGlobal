namespace ExploreLuxury.Infrastructure.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CityModelChanges_part2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.City", "Country_Id", c => c.Guid());
            AddColumn("dbo.City", "Country_Id1", c => c.Guid(nullable: false));
            CreateIndex("dbo.City", "Country_Id");
            CreateIndex("dbo.City", "Country_Id1");
            AddForeignKey("dbo.City", "Country_Id", "dbo.Country", "Id");
            AddForeignKey("dbo.City", "Country_Id1", "dbo.Country", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.City", "Country_Id1", "dbo.Country");
            DropForeignKey("dbo.City", "Country_Id", "dbo.Country");
            DropIndex("dbo.City", new[] { "Country_Id1" });
            DropIndex("dbo.City", new[] { "Country_Id" });
            DropColumn("dbo.City", "Country_Id1");
            DropColumn("dbo.City", "Country_Id");
        }
    }
}
