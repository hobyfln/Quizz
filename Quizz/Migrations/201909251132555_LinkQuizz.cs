namespace Quizz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LinkQuizz : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Quizzs", "QuestionId");
            AddForeignKey("dbo.Quizzs", "QuestionId", "dbo.QuizzLinkQuestions", "LinkId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Quizzs", "QuestionId", "dbo.QuizzLinkQuestions");
            DropIndex("dbo.Quizzs", new[] { "QuestionId" });
        }
    }
}
