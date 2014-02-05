using System.Data.Entity.Migrations;

namespace ExploreLuxury.Infrastructure.Data.Migrations
{
    public partial class HotelEntryModification : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Hotel", "AddressId", "dbo.Address");
            DropIndex("dbo.Hotel", new[] { "AddressId" });
            DropColumn("dbo.Hotel", "AddressId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Hotel", "AddressId", c => c.Guid(nullable: false));
            CreateIndex("dbo.Hotel", "AddressId");
            AddForeignKey("dbo.Hotel", "AddressId", "dbo.Address", "Id", cascadeDelete: true);
        }
    }
}
