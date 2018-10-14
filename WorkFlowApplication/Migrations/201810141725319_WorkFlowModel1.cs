namespace WorkFlowApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WorkFlowModel1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WorkFlows",
                c => new
                    {
                        WorkFlowID = c.Int(nullable: false, identity: true),
                        WorkFlowName = c.String(),
                        WfPrimaryOwner = c.String(),
                        WfEntryCriteria = c.String(),
                        TotalEntities = c.Int(nullable: false),
                        WfStatus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.WorkFlowID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WorkFlows");
        }
    }
}
