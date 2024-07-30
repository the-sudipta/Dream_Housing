namespace Dream_Housing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Creating_Appointments_Table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.String(nullable: false),
                        Time = c.String(nullable: false),
                        Status = c.String(nullable: false),
                        CreatedAt = c.String(nullable: false),
                        UpdatedAt = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Appointments");
        }
    }
}
