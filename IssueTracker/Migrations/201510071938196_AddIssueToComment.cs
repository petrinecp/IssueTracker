namespace IssueTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIssueToComment : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Comments", "Issue_Id", "dbo.Issues");
            DropIndex("dbo.Comments", new[] { "Issue_Id" });
            RenameColumn(table: "dbo.Comments", name: "Issue_Id", newName: "IssueId");
            AlterColumn("dbo.Comments", "IssueId", c => c.Guid(nullable: false));
            CreateIndex("dbo.Comments", "IssueId");
            AddForeignKey("dbo.Comments", "IssueId", "dbo.Issues", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "IssueId", "dbo.Issues");
            DropIndex("dbo.Comments", new[] { "IssueId" });
            AlterColumn("dbo.Comments", "IssueId", c => c.Guid());
            RenameColumn(table: "dbo.Comments", name: "IssueId", newName: "Issue_Id");
            CreateIndex("dbo.Comments", "Issue_Id");
            AddForeignKey("dbo.Comments", "Issue_Id", "dbo.Issues", "Id");
        }
    }
}
