namespace IssueTracker.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class AddStringUserIdToIssue : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Issues", new[] { "ApplicationUser_Id" });
            DropColumn("dbo.Issues", "ApplicationUserId");
            RenameColumn(table: "dbo.Issues", name: "ApplicationUser_Id", newName: "ApplicationUserId");
            AlterColumn("dbo.Issues", "ApplicationUserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Issues", "ApplicationUserId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Issues", new[] { "ApplicationUserId" });
            AlterColumn("dbo.Issues", "ApplicationUserId", c => c.Guid(nullable: false));
            RenameColumn(table: "dbo.Issues", name: "ApplicationUserId", newName: "ApplicationUser_Id");
            AddColumn("dbo.Issues", "ApplicationUserId", c => c.Guid(nullable: false));
            CreateIndex("dbo.Issues", "ApplicationUser_Id");
        }
    }
}
