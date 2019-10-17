namespace Quizz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDb1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Answer",
                c => new
                    {
                        AnswerId = c.Int(nullable: false, identity: true),
                        QuestionId = c.Int(nullable: false),
                        RightAnswer = c.Boolean(nullable: false),
                        AboutAnswer = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedOn = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.AnswerId)
                .ForeignKey("dbo.Question", t => t.QuestionId)
                .Index(t => t.QuestionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Answer", "QuestionId", "dbo.Question");
            DropIndex("dbo.Answer", new[] { "QuestionId" });
            DropTable("dbo.Answer");
        }
    }
}
