namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbcreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abouts",
                c => new
                    {
                        AboutID = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 150),
                        Image = c.String(maxLength: 150),
                        Desc = c.String(maxLength: 500),
                        Map = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.AboutID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 150),
                        Desc = c.String(maxLength: 300),
                        Image = c.String(maxLength: 200),
                        CategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductID)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ContactID = c.Int(nullable: false, identity: true),
                        ContactName = c.String(maxLength: 100),
                        ContactMail = c.String(maxLength: 100),
                        City = c.String(maxLength: 100),
                        Title = c.String(maxLength: 100),
                        Message = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.ContactID);
            
            CreateTable(
                "dbo.Plates",
                c => new
                    {
                        PlatesID = c.Int(nullable: false, identity: true),
                        PlatesName = c.String(maxLength: 150),
                        PlatesAbout = c.String(maxLength: 300),
                        Image = c.String(maxLength: 300),
                    })
                .PrimaryKey(t => t.PlatesID);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ProjectID = c.Int(nullable: false, identity: true),
                        ProjectName = c.String(maxLength: 100),
                        Image = c.String(maxLength: 300),
                        Map = c.String(maxLength: 300),
                    })
                .PrimaryKey(t => t.ProjectID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "CategoryID" });
            DropTable("dbo.Projects");
            DropTable("dbo.Plates");
            DropTable("dbo.Contacts");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
            DropTable("dbo.Abouts");
        }
    }
}
