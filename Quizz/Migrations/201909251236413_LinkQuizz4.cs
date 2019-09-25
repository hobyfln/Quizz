namespace Quizz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LinkQuizz4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.QuizzLinkQuestions", "QuestionId", "dbo.Questions");
            DropIndex("dbo.QuizzLinkQuestions", new[] { "QuestionId" });
            DropPrimaryKey("dbo.Questions");
            AddColumn("dbo.Questions", "QuestionsQuizz", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Questions", new[] { "QuestionId", "QuestionsQuizz" });
            CreateIndex("dbo.Questions", new[] { "QuestionId", "QuestionsQuizz" });
            AddForeignKey("dbo.Questions", new[] { "QuestionId", "QuestionsQuizz" }, "dbo.QuizzLinkQuestions", new[] { "QuizzId", "QuestionId" });
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Questions", new[] { "QuestionId", "QuestionsQuizz" }, "dbo.QuizzLinkQuestions");
            DropIndex("dbo.Questions", new[] { "QuestionId", "QuestionsQuizz" });
            DropPrimaryKey("dbo.Questions");
            DropColumn("dbo.Questions", "QuestionsQuizz");
            AddPrimaryKey("dbo.Questions", "QuestionId");
            CreateIndex("dbo.QuizzLinkQuestions", "QuestionId");
            AddForeignKey("dbo.QuizzLinkQuestions", "QuestionId", "dbo.Questions", "QuestionId", cascadeDelete: true);
        }
    }
}
