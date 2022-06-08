namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migup2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Blogs", "Title", c => c.String(maxLength: 50));
            AlterColumn("dbo.Blogs", "Description", c => c.String(maxLength: 300));
            AlterColumn("dbo.Blogs", "Image", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Blogs", "Image", c => c.String(maxLength: 100));
            AlterColumn("dbo.Blogs", "Description", c => c.String(maxLength: 500));
            AlterColumn("dbo.Blogs", "Title", c => c.String(maxLength: 100));
        }
    }
}
