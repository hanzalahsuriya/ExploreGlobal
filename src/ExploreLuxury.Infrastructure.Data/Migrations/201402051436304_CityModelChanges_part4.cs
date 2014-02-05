namespace ExploreLuxury.Infrastructure.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CityModelChanges_part4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.City", "Country_Id", "dbo.Country");
            DropIndex("dbo.City", new[] { "Country_Id" });
            RenameColumn(table: "dbo.City", name: "Country_Id1", newName: "CountryId");
            CreateIndex("dbo.City", "CountryId");
            AddForeignKey("dbo.City", "CountryId", "dbo.Country", "Id");
            DropColumn("dbo.City", "Country_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.City", "Country_Id", c => c.Guid());
            DropForeignKey("dbo.City", "CountryId", "dbo.Country");
            DropIndex("dbo.City", new[] { "CountryId" });
            RenameColumn(table: "dbo.City", name: "CountryId", newName: "Country_Id1");
            CreateIndex("dbo.City", "Country_Id");
            AddForeignKey("dbo.City", "Country_Id", "dbo.Country", "Id");
        }
    }
}
