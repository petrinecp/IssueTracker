namespace IssueTracker.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class AddUserIdToIssue : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Issues", "AssignedToId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Issues", "AssignedToId");
        }
    }
}
