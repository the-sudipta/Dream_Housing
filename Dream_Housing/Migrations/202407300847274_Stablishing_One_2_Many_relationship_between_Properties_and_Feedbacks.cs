namespace Dream_Housing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Stablishing_One_2_Many_relationship_between_Properties_and_Feedbacks : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Feedbacks", "Property_ID");
            AddForeignKey("dbo.Feedbacks", "Property_ID", "dbo.Properties", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Feedbacks", "Property_ID", "dbo.Properties");
            DropIndex("dbo.Feedbacks", new[] { "Property_ID" });
        }
    }
}
