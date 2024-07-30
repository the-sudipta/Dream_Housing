namespace Dream_Housing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Creating_Feedbacks_Table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Feedbacks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Property_ID = c.Int(nullable: false),
                        Client_ID = c.Int(nullable: false),
                        Rating = c.String(nullable: false),
                        Comments = c.String(nullable: false),
                        SubmittedAt = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Feedbacks");
        }
    }
}
