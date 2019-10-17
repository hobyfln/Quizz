namespace Quizz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "FullName", c => c.String());
            AddColumn("dbo.User", "CreatedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.User", "CreatedBy", c => c.String());
            AddColumn("dbo.User", "ModifiedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.User", "ModifiedBy", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.User", "ModifiedBy");
            DropColumn("dbo.User", "ModifiedOn");
            DropColumn("dbo.User", "CreatedBy");
            DropColumn("dbo.User", "CreatedOn");
            DropColumn("dbo.User", "FullName");
        }
    }
}
