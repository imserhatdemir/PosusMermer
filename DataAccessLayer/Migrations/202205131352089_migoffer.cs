namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migoffer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Offers",
                c => new
                    {
                        OfferID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                        Location = c.String(maxLength: 100),
                        Date = c.DateTime(nullable: false),
                        No = c.String(maxLength: 100),
                        Mail = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.OfferID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Offers");
        }
    }
}
