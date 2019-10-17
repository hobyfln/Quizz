namespace Quizz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
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
            
            CreateTable(
                "dbo.Question",
                c => new
                    {
                        QuestionId = c.Int(nullable: false, identity: true),
                        QuestionStr = c.String(),
                        Type = c.String(),
                        QuestionSkill = c.Int(nullable: false),
                        QuestionTechno = c.Int(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedOn = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.QuestionId)
                .ForeignKey("dbo.SkillLevel", t => t.QuestionSkill)
                .ForeignKey("dbo.Technologie", t => t.QuestionTechno)
                .Index(t => t.QuestionSkill)
                .Index(t => t.QuestionTechno);
            
            CreateTable(
                "dbo.SkillLevel",
                c => new
                    {
                        SkillLevelId = c.Int(nullable: false, identity: true),
                        QuestionId = c.Int(nullable: false),
                        NameSkillLevel = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedOn = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.SkillLevelId);
            
            CreateTable(
                "dbo.Technologie",
                c => new
                    {
                        TechnologieId = c.Int(nullable: false, identity: true),
                        NameTechnologie = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedOn = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.TechnologieId);
            
            CreateTable(
                "dbo.Candidate",
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
                .ForeignKey("dbo.QuizzClass", t => t.QuizzId)
                .Index(t => t.QuizzId)
                .Index(t => t.AnswerId);
            
            CreateTable(
                "dbo.QuizzClass",
                c => new
                    {
                        QuizzId = c.Int(nullable: false, identity: true),
                        QuestionId = c.Int(nullable: false),
                        CandidateId = c.Int(nullable: false),
                        SkillLevelId = c.Int(nullable: false),
                        TechnoId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        CreatorId = c.String(),
                        Creator = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedOn = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.QuizzId)
                .ForeignKey("dbo.Candidate", t => t.CandidateId)
                .ForeignKey("dbo.SkillLevel", t => t.SkillLevelId)
                .ForeignKey("dbo.Technologie", t => t.TechnoId)
                .ForeignKey("dbo.User", t => t.UserId)
                .Index(t => t.CandidateId)
                .Index(t => t.SkillLevelId)
                .Index(t => t.TechnoId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        IsAdmin = c.Boolean(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedOn = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.QuizzLinkQuestions",
                c => new
                    {
                        LinkId = c.Int(nullable: false, identity: true),
                        QuizzId = c.Int(nullable: false),
                        QuestionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LinkId)
                .ForeignKey("dbo.Question", t => t.QuestionId)
                .ForeignKey("dbo.QuizzClass", t => t.QuizzId)
                .Index(t => t.QuizzId)
                .Index(t => t.QuestionId);
            
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
            DropForeignKey("dbo.QuizzLinkQuestions", "QuizzId", "dbo.QuizzClass");
            DropForeignKey("dbo.QuizzLinkQuestions", "QuestionId", "dbo.Question");
            DropForeignKey("dbo.QuizzAnswer", "QuizzId", "dbo.QuizzClass");
            DropForeignKey("dbo.QuizzClass", "UserId", "dbo.User");
            DropForeignKey("dbo.QuizzClass", "TechnoId", "dbo.Technologie");
            DropForeignKey("dbo.QuizzClass", "SkillLevelId", "dbo.SkillLevel");
            DropForeignKey("dbo.QuizzClass", "CandidateId", "dbo.Candidate");
            DropForeignKey("dbo.QuizzAnswer", "AnswerId", "dbo.Answer");
            DropForeignKey("dbo.Answer", "QuestionId", "dbo.Question");
            DropForeignKey("dbo.Question", "QuestionTechno", "dbo.Technologie");
            DropForeignKey("dbo.Question", "QuestionSkill", "dbo.SkillLevel");
            DropIndex("dbo.Result", new[] { "Quizz", "Answer" });
            DropIndex("dbo.QuizzLinkQuestions", new[] { "QuestionId" });
            DropIndex("dbo.QuizzLinkQuestions", new[] { "QuizzId" });
            DropIndex("dbo.QuizzClass", new[] { "UserId" });
            DropIndex("dbo.QuizzClass", new[] { "TechnoId" });
            DropIndex("dbo.QuizzClass", new[] { "SkillLevelId" });
            DropIndex("dbo.QuizzClass", new[] { "CandidateId" });
            DropIndex("dbo.QuizzAnswer", new[] { "AnswerId" });
            DropIndex("dbo.QuizzAnswer", new[] { "QuizzId" });
            DropIndex("dbo.Question", new[] { "QuestionTechno" });
            DropIndex("dbo.Question", new[] { "QuestionSkill" });
            DropIndex("dbo.Answer", new[] { "QuestionId" });
            DropTable("dbo.Result");
            DropTable("dbo.QuizzLinkQuestions");
            DropTable("dbo.User");
            DropTable("dbo.QuizzClass");
            DropTable("dbo.QuizzAnswer");
            DropTable("dbo.Candidate");
            DropTable("dbo.Technologie");
            DropTable("dbo.SkillLevel");
            DropTable("dbo.Question");
            DropTable("dbo.Answer");
        }
    }
}
