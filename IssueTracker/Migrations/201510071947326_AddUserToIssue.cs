namespace IssueTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserToIssue : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Issues", "AssignedTo_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Issues", "AssignedTo_Id");
            AddForeignKey("dbo.Issues", "AssignedTo_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Issues", "AssignedTo_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Issues", new[] { "AssignedTo_Id" });
            DropColumn("dbo.Issues", "AssignedTo_Id");
        }
    }
}
