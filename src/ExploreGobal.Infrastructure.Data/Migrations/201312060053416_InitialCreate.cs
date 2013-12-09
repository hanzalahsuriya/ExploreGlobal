namespace ExploreGlobal.Infrastructure.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Address",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Line1 = c.String(),
                        Line2 = c.String(),
                        Line3 = c.String(),
                        Line4 = c.String(),
                        Line5 = c.String(),
                        Code = c.String(),
                        CountryId = c.Guid(nullable: false),
                        CityId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.City", t => t.CityId, cascadeDelete: true)
                .ForeignKey("dbo.Country", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CityId)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.City",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Country_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Country", t => t.Country_Id)
                .Index(t => t.Country_Id);
            
            CreateTable(
                "dbo.Country",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Hotel",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        HotelRatingCategory = c.Int(nullable: false),
                        Name = c.String(),
                        ShortDescription = c.String(),
                        AddressId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Address", t => t.AddressId, cascadeDelete: true)
                .Index(t => t.AddressId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Hotel", "AddressId", "dbo.Address");
            DropForeignKey("dbo.Address", "CountryId", "dbo.Country");
            DropForeignKey("dbo.City", "Country_Id", "dbo.Country");
            DropForeignKey("dbo.Address", "CityId", "dbo.City");
            DropIndex("dbo.Hotel", new[] { "AddressId" });
            DropIndex("dbo.Address", new[] { "CountryId" });
            DropIndex("dbo.City", new[] { "Country_Id" });
            DropIndex("dbo.Address", new[] { "CityId" });
            DropTable("dbo.Hotel");
            DropTable("dbo.Country");
            DropTable("dbo.City");
            DropTable("dbo.Address");
        }
    }
}
