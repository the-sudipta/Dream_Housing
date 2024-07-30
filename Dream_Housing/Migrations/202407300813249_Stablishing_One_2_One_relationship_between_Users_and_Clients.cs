namespace Dream_Housing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Stablishing_One_2_One_relationship_between_Users_and_Clients : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Clients");
            AlterColumn("dbo.Clients", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Clients", "Id");
            CreateIndex("dbo.Clients", "Id");
            AddForeignKey("dbo.Clients", "Id", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "Id", "dbo.Users");
            DropIndex("dbo.Clients", new[] { "Id" });
            DropPrimaryKey("dbo.Clients");
            AlterColumn("dbo.Clients", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Clients", "Id");
        }
    }
}
