namespace project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migr : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        ImageLink = c.String(),
                        Favourites = c.Boolean(nullable: false),
                        Transport = c.String(),
                        Hotels = c.String(),
                        Restaurants = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CityId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cities");
        }
    }
}
