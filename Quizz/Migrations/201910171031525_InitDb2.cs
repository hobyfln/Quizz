namespace Quizz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDb2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.QuizzAnswer",
                c => new
                    {
                        QuizzId = c.Int(nullable: false),
                        AnswerId = c.Int(nullable: false),
                        AnswerFree = c.String(),
                        Comments = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedOn = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => new { t.QuizzId, t.AnswerId })
                .ForeignKey("dbo.Answer", t => t.AnswerId)
                .ForeignKey("dbo.Quizz", t => t.QuizzId)
                .Index(t => t.QuizzId)
                .Index(t => t.AnswerId);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        IsAdmin = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
            AddColumn("dbo.Quizz", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Quizz", "UserId");
            AddForeignKey("dbo.Quizz", "UserId", "dbo.User", "UserId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Quizz", "UserId", "dbo.User");
            DropForeignKey("dbo.QuizzAnswer", "QuizzId", "dbo.Quizz");
            DropForeignKey("dbo.QuizzAnswer", "AnswerId", "dbo.Answer");
            DropIndex("dbo.Quizz", new[] { "UserId" });
            DropIndex("dbo.QuizzAnswer", new[] { "AnswerId" });
            DropIndex("dbo.QuizzAnswer", new[] { "QuizzId" });
            DropColumn("dbo.Quizz", "UserId");
            DropTable("dbo.User");
            DropTable("dbo.QuizzAnswer");
        }
    }
}
