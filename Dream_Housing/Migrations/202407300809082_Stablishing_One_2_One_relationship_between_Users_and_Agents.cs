namespace Dream_Housing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Stablishing_One_2_One_relationship_between_Users_and_Agents : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Agents");
            AlterColumn("dbo.Agents", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Agents", "Id");
            CreateIndex("dbo.Agents", "Id");
            AddForeignKey("dbo.Agents", "Id", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Agents", "Id", "dbo.Users");
            DropIndex("dbo.Agents", new[] { "Id" });
            DropPrimaryKey("dbo.Agents");
            AlterColumn("dbo.Agents", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Agents", "Id");
        }
    }
}
