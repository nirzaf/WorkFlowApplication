namespace WorkFlowApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class entity3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EntityModels",
                c => new
                    {
                        EntityID = c.Int(nullable: false, identity: true),
                        EntityOwner = c.Int(nullable: false),
                        EntityCriteria = c.String(),
                        ActionRequired = c.String(),
                        ExitCriteria = c.String(),
                        EntityCreatedDate = c.DateTime(),
                        EntityCloseDate = c.DateTime(),
                        EntityAge = c.Int(nullable: false),
                        EntityApproved = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EntityID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EntityModels");
        }
    }
}
