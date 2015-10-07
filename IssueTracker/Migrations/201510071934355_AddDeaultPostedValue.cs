namespace IssueTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDeaultPostedValue : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Comments", "Posted", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Comments", "Posted", c => c.DateTime(nullable: false));
        }
    }
}
