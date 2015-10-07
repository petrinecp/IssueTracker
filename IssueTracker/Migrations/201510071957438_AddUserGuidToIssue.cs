namespace IssueTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserGuidToIssue : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Issues", name: "AssignedTo_Id", newName: "ApplicationUser_Id");
            RenameIndex(table: "dbo.Issues", name: "IX_AssignedTo_Id", newName: "IX_ApplicationUser_Id");
            AddColumn("dbo.Issues", "ApplicationUserId", c => c.Guid(nullable: false));
            DropColumn("dbo.Issues", "AssignedToId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Issues", "AssignedToId", c => c.Int(nullable: false));
            DropColumn("dbo.Issues", "ApplicationUserId");
            RenameIndex(table: "dbo.Issues", name: "IX_ApplicationUser_Id", newName: "IX_AssignedTo_Id");
            RenameColumn(table: "dbo.Issues", name: "ApplicationUser_Id", newName: "AssignedTo_Id");
        }
    }
}
