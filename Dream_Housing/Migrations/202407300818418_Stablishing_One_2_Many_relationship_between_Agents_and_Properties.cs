namespace Dream_Housing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Stablishing_One_2_Many_relationship_between_Agents_and_Properties : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Properties", "Agent_ID", c => c.Int(nullable: false));
            CreateIndex("dbo.Properties", "Agent_ID");
            AddForeignKey("dbo.Properties", "Agent_ID", "dbo.Agents", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Properties", "Agent_ID", "dbo.Agents");
            DropIndex("dbo.Properties", new[] { "Agent_ID" });
            DropColumn("dbo.Properties", "Agent_ID");
        }
    }
}
