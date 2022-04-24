namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class detailsproductmig : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Details", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Details");
        }
    }
}
