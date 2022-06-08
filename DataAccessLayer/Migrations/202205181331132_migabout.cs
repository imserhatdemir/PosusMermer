namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migabout : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Abouts", "Keywords", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Abouts", "Keywords");
        }
    }
}
