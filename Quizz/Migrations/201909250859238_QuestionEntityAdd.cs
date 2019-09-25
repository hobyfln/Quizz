namespace Quizz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QuestionEntityAdd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        IdQuestion = c.Int(nullable: false, identity: true),
                        QuestionStr = c.String(),
                        Type = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedOn = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.IdQuestion);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Questions");
        }
    }
}
