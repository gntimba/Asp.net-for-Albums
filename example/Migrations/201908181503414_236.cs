namespace example.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _236 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Album");
            DropPrimaryKey("dbo.reviews");
            AlterColumn("dbo.Album", "id", c => c.Guid(nullable: false, identity: true));
            AlterColumn("dbo.reviews", "id", c => c.Guid(nullable: false, identity: true));
            AddPrimaryKey("dbo.Album", "id");
            AddPrimaryKey("dbo.reviews", "id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.reviews");
            DropPrimaryKey("dbo.Album");
            AlterColumn("dbo.reviews", "id", c => c.Guid(nullable: false));
            AlterColumn("dbo.Album", "id", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.reviews", "id");
            AddPrimaryKey("dbo.Album", "id");
        }
    }
}
