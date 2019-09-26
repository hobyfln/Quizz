namespace Quizz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Candidates",
                c => new
                    {
                        CandidateId = c.Int(nullable: false, identity: true),
                        QuizzId = c.Int(nullable: false),
                        Name = c.String(),
                        Mail = c.String(),
                        SkillLevel = c.Int(nullable: false),
                        Age = c.Int(nullable: false),
                        Techno = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedOn = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.CandidateId);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        QuestionId = c.Int(nullable: false, identity: true),
                        QuestionStr = c.String(),
                        Type = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedOn = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.QuestionId);
            
            CreateTable(
                "dbo.QuizzLinkQuestions",
                c => new
                    {
                        LinkId = c.Int(nullable: false, identity: true),
                        QuizzId = c.Int(nullable: false),
                        QuestionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LinkId);
            
            CreateTable(
                "dbo.Quizzs",
                c => new
                    {
                        QuizzId = c.Int(nullable: false, identity: true),
                        QuestionId = c.Int(nullable: false),
                        CandidateId = c.Int(nullable: false),
                        CreatorId = c.String(),
                        Creator = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedOn = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.QuizzId)
                .ForeignKey("dbo.Candidates", t => t.CandidateId, cascadeDelete: true)
                .Index(t => t.CandidateId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Quizzs", "CandidateId", "dbo.Candidates");
            DropIndex("dbo.Quizzs", new[] { "CandidateId" });
            DropTable("dbo.Quizzs");
            DropTable("dbo.QuizzLinkQuestions");
            DropTable("dbo.Questions");
            DropTable("dbo.Candidates");
        }
    }
}
