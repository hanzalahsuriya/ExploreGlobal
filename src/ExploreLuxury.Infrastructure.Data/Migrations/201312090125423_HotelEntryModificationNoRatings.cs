using System.Data.Entity.Migrations;

namespace ExploreLuxury.Infrastructure.Data.Migrations
{
    public partial class HotelEntryModificationNoRatings : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Hotel", "HotelRatingCategory", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Hotel", "HotelRatingCategory", c => c.Int(nullable: false));
        }
    }
}
