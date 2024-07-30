namespace Dream_Housing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Stablishing_One_2_Many_relationship_between_Clients_and_Appointments : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Appointments", "Client_ID", c => c.Int(nullable: false));
            CreateIndex("dbo.Appointments", "Client_ID");
            AddForeignKey("dbo.Appointments", "Client_ID", "dbo.Clients", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Appointments", "Client_ID", "dbo.Clients");
            DropIndex("dbo.Appointments", new[] { "Client_ID" });
            DropColumn("dbo.Appointments", "Client_ID");
        }
    }
}
