namespace Dream_Housing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatingPropertiesAgentsAppointmentsFeedbacksTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Agents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        User_ID = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        ContactInfo = c.String(nullable: false),
                        CreatedAt = c.String(nullable: false),
                        UpdatedAt = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Property_ID = c.Int(nullable: false),
                        Client_ID = c.Int(nullable: false),
                        Date = c.String(nullable: false),
                        Time = c.String(nullable: false),
                        Status = c.String(nullable: false),
                        CreatedAt = c.String(nullable: false),
                        UpdatedAt = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
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
            
            CreateTable(
                "dbo.Properties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Agent_ID = c.Int(nullable: false),
                        Title = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        Location = c.String(nullable: false),
                        Price = c.Double(nullable: false),
                        Status = c.String(nullable: false),
                        CreatedAt = c.String(nullable: false),
                        UpdatedAt = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Properties");
            DropTable("dbo.Feedbacks");
            DropTable("dbo.Appointments");
            DropTable("dbo.Agents");
        }
    }
}
