namespace WorkFlowApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateworkflow1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.WorkFlows");
            AlterColumn("dbo.WorkFlows", "Work_Flow_ID", c => c.Int(nullable: false));
            AlterColumn("dbo.WorkFlows", "Work_FlowName", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.WorkFlows", "Work_FlowName");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.WorkFlows");
            AlterColumn("dbo.WorkFlows", "Work_FlowName", c => c.String());
            AlterColumn("dbo.WorkFlows", "Work_Flow_ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.WorkFlows", "Work_Flow_ID");
        }
    }
}
