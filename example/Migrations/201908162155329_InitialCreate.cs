namespace example.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Album",
                c => new
                    {
                        id = c.Guid(nullable: false),
                        albumName = c.String(),
                        albumPicture = c.String(),
                        albumArtist = c.String(),
                        albumYear = c.DateTime(nullable: false),
                        date_created = c.DateTime(nullable: false),
                        isActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.reviews",
                c => new
                    {
                        id = c.Guid(nullable: false),
                        albumID = c.Guid(nullable: false),
                        review = c.String(),
                        name = c.String(),
                        date_created = c.DateTime(nullable: false),
                        isActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.reviews");
            DropTable("dbo.Album");
        }
    }
}
