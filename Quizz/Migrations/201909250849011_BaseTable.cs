namespace Quizz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BaseTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Candidates", "CreatedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.Candidates", "CreatedBy", c => c.String());
            AddColumn("dbo.Candidates", "ModifiedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.Candidates", "ModifiedBy", c => c.String());
            AddColumn("dbo.Quizzs", "CreatedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.Quizzs", "CreatedBy", c => c.String());
            AddColumn("dbo.Quizzs", "ModifiedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.Quizzs", "ModifiedBy", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Quizzs", "ModifiedBy");
            DropColumn("dbo.Quizzs", "ModifiedOn");
            DropColumn("dbo.Quizzs", "CreatedBy");
            DropColumn("dbo.Quizzs", "CreatedOn");
            DropColumn("dbo.Candidates", "ModifiedBy");
            DropColumn("dbo.Candidates", "ModifiedOn");
            DropColumn("dbo.Candidates", "CreatedBy");
            DropColumn("dbo.Candidates", "CreatedOn");
        }
    }
}
