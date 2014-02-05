namespace ExploreLuxury.Infrastructure.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CityModelChanges : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.City", "Country_Id", "dbo.Country");
            DropIndex("dbo.City", new[] { "Country_Id" });
            AddColumn("dbo.City", "Country_Id1", c => c.Guid(nullable: false));
            AlterColumn("dbo.City", "Name", c => c.String(nullable: false));
            CreateIndex("dbo.City", "Country_Id1");
            AddForeignKey("dbo.City", "Country_Id1", "dbo.Country", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.City", "Country_Id1", "dbo.Country");
            DropIndex("dbo.City", new[] { "Country_Id1" });
            AlterColumn("dbo.City", "Name", c => c.String());
            DropColumn("dbo.City", "Country_Id1");
            CreateIndex("dbo.City", "Country_Id");
            AddForeignKey("dbo.City", "Country_Id", "dbo.Country", "Id");
        }
    }
}
