namespace Quizz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LinkQuizz2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Quizzs", "QuestionId", "dbo.QuizzLinkQuestions");
            DropIndex("dbo.Quizzs", new[] { "QuestionId" });
            DropPrimaryKey("dbo.QuizzLinkQuestions");
            AddPrimaryKey("dbo.QuizzLinkQuestions", new[] { "QuizzId", "QuestionId" });
            DropColumn("dbo.QuizzLinkQuestions", "LinkId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.QuizzLinkQuestions", "LinkId", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.QuizzLinkQuestions");
            AddPrimaryKey("dbo.QuizzLinkQuestions", "LinkId");
            CreateIndex("dbo.Quizzs", "QuestionId");
            AddForeignKey("dbo.Quizzs", "QuestionId", "dbo.QuizzLinkQuestions", "LinkId", cascadeDelete: true);
        }
    }
}
