using System.Data.Entity.Migrations;

namespace ExploreLuxury.Infrastructure.Data.Migrations
{
    public partial class AddRoomType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RoomType",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RoomType");
        }
    }
}
