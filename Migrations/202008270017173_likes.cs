namespace LsSocialWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class likes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "likes", c => c.Int(nullable: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "likes");
        }
    }
}
