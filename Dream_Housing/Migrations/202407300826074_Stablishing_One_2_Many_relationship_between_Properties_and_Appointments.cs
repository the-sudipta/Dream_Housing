namespace Dream_Housing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Stablishing_One_2_Many_relationship_between_Properties_and_Appointments : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Appointments", "Property_ID", c => c.Int(nullable: false));
            CreateIndex("dbo.Appointments", "Property_ID");
            AddForeignKey("dbo.Appointments", "Property_ID", "dbo.Properties", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Appointments", "Property_ID", "dbo.Properties");
            DropIndex("dbo.Appointments", new[] { "Property_ID" });
            DropColumn("dbo.Appointments", "Property_ID");
        }
    }
}
