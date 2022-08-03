namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newmig1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Blogs", "Title", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Blogs", "Image", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Blogs", "Image", c => c.String(maxLength: 50));
            AlterColumn("dbo.Blogs", "Title", c => c.String(maxLength: 50));
        }
    }
}
