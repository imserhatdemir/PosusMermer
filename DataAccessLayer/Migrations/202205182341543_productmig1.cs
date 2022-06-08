namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class productmig1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Renk", c => c.String(maxLength: 15));
            AddColumn("dbo.Products", "KullanımAlanı", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "KullanımAlanı");
            DropColumn("dbo.Products", "Renk");
        }
    }
}
