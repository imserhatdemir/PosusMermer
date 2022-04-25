namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class projectaddcolumnsmig : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Projects", "About1", c => c.String(maxLength: 500));
            AddColumn("dbo.Projects", "About2", c => c.String(maxLength: 500));
            AlterColumn("dbo.Projects", "Map", c => c.String(maxLength: 800));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Projects", "Map", c => c.String(maxLength: 300));
            DropColumn("dbo.Projects", "About2");
            DropColumn("dbo.Projects", "About1");
        }
    }
}
