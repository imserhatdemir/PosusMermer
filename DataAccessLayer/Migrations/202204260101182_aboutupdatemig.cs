namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aboutupdatemig : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Abouts", "ShortAbout", c => c.String(maxLength: 200));
            AddColumn("dbo.Abouts", "Instagram", c => c.String(maxLength: 200));
            AddColumn("dbo.Abouts", "Facebook", c => c.String(maxLength: 200));
            AddColumn("dbo.Abouts", "Twitter", c => c.String(maxLength: 200));
            AddColumn("dbo.Abouts", "Whatsapp", c => c.String(maxLength: 200));
            AddColumn("dbo.Abouts", "Mail", c => c.String(maxLength: 200));
            AlterColumn("dbo.Abouts", "Map", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Abouts", "Map", c => c.String(maxLength: 200));
            DropColumn("dbo.Abouts", "Mail");
            DropColumn("dbo.Abouts", "Whatsapp");
            DropColumn("dbo.Abouts", "Twitter");
            DropColumn("dbo.Abouts", "Facebook");
            DropColumn("dbo.Abouts", "Instagram");
            DropColumn("dbo.Abouts", "ShortAbout");
        }
    }
}
