namespace Quizz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Result : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Result",
                c => new
                    {
                        Quizz = c.Int(nullable: false),
                        Answer = c.Int(nullable: false),
                        Answered = c.Int(nullable: false),
                        IsCorrect = c.Boolean(nullable: false),
                        IsOpen = c.Boolean(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedOn = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => new { t.Quizz, t.Answer })
                .ForeignKey("dbo.QuizzAnswer", t => new { t.Quizz, t.Answer })
                .Index(t => new { t.Quizz, t.Answer });
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Result", new[] { "Quizz", "Answer" }, "dbo.QuizzAnswer");
            DropIndex("dbo.Result", new[] { "Quizz", "Answer" });
            DropTable("dbo.Result");
        }
    }
}
