namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addblogtable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        BlogID = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 100),
                        Description = c.String(maxLength: 500),
                        Image = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.BlogID);
            
            AddColumn("dbo.Abouts", "Description", c => c.String(maxLength: 500));
            AddColumn("dbo.Products", "Description", c => c.String(maxLength: 300));
            DropColumn("dbo.Abouts", "Desc");
            DropColumn("dbo.Products", "Desc");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Desc", c => c.String(maxLength: 300));
            AddColumn("dbo.Abouts", "Desc", c => c.String(maxLength: 500));
            DropColumn("dbo.Products", "Description");
            DropColumn("dbo.Abouts", "Description");
            DropTable("dbo.Blogs");
        }
    }
}
