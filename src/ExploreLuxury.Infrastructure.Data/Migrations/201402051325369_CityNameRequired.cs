namespace ExploreLuxury.Infrastructure.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CityNameRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Country", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Country", "Name", c => c.String());
        }
    }
}
