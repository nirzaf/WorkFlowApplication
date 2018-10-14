namespace WorkFlowApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateworkflow : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.WorkFlows");
            DropColumn("dbo.WorkFlows", "WorkFlowID");
            AddColumn("dbo.WorkFlows", "Work_Flow_ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.WorkFlows", "Work_Flow_ID");
            DropColumn("dbo.WorkFlows", "WorkFlowName");
            DropColumn("dbo.WorkFlows", "WfPrimaryOwner");
            DropColumn("dbo.WorkFlows", "WfEntryCriteria");
            DropColumn("dbo.WorkFlows", "TotalEntities");

            DropColumn("dbo.WorkFlows", "WfStatus");

            AddColumn("dbo.WorkFlows", "Work_FlowName", c => c.String());
            AddColumn("dbo.WorkFlows", "Work_Flow_Primary_Owner", c => c.String());
            AddColumn("dbo.WorkFlows", "Work_Flow_Entry_Criteria", c => c.String());
            AddColumn("dbo.WorkFlows", "Total_Entities", c => c.Int(nullable: false));
            AddColumn("dbo.WorkFlows", "Work_Flow_Status", c => c.Int(nullable: false));
           

        }
        
        public override void Down()
        {
            DropColumn("dbo.WorkFlows", "Work_Flow_Status");
            DropColumn("dbo.WorkFlows", "Total_Entities");
            DropColumn("dbo.WorkFlows", "Work_Flow_Entry_Criteria");
            DropColumn("dbo.WorkFlows", "Work_Flow_Primary_Owner");
            DropColumn("dbo.WorkFlows", "Work_FlowName");
            DropColumn("dbo.WorkFlows", "Work_Flow_ID");
            AddColumn("dbo.WorkFlows", "WfStatus", c => c.Int(nullable: false));
            AddColumn("dbo.WorkFlows", "TotalEntities", c => c.Int(nullable: false));
            AddColumn("dbo.WorkFlows", "WfEntryCriteria", c => c.String());
            AddColumn("dbo.WorkFlows", "WfPrimaryOwner", c => c.String());
            AddColumn("dbo.WorkFlows", "WorkFlowName", c => c.String());
            AddColumn("dbo.WorkFlows", "WorkFlowID", c => c.Int(nullable: false, identity: true));


            AddPrimaryKey("dbo.WorkFlows", "WorkFlowID");
        }
    }
}
