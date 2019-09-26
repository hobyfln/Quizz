namespace Quizz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LinkQuizz3 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.QuizzLinkQuestions", "QuizzId");
            CreateIndex("dbo.QuizzLinkQuestions", "QuestionId");
            AddForeignKey("dbo.QuizzLinkQuestions", "QuestionId", "dbo.Questions", "QuestionId", cascadeDelete: true);
            AddForeignKey("dbo.QuizzLinkQuestions", "QuizzId", "dbo.Quizzs", "QuizzId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.QuizzLinkQuestions", "QuizzId", "dbo.Quizzs");
            DropForeignKey("dbo.QuizzLinkQuestions", "QuestionId", "dbo.Questions");
            DropIndex("dbo.QuizzLinkQuestions", new[] { "QuestionId" });
            DropIndex("dbo.QuizzLinkQuestions", new[] { "QuizzId" });
        }
    }
}
