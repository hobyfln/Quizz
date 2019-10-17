namespace Quizz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QuestionLinkFix4 : DbMigration
    {
        public override void Up()
        {
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
                "dbo.QuizzLinkQuestions",
                c => new
                    {
                        LinkId = c.Int(nullable: false, identity: true),
                        QuizzId = c.Int(nullable: false),
                        QuestionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LinkId)
                .ForeignKey("dbo.Question", t => t.QuestionId)
                .ForeignKey("dbo.Quizz", t => t.QuizzId)
                .Index(t => t.QuizzId)
                .Index(t => t.QuestionId);
            
            CreateTable(
                "dbo.Quizz",
                c => new
                    {
                        QuizzId = c.Int(nullable: false, identity: true),
                        QuestionId = c.Int(nullable: false),
                        CandidateId = c.Int(nullable: false),
                        SkillLevelId = c.Int(nullable: false),
                        TechnoId = c.Int(nullable: false),
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
                .Index(t => t.CandidateId)
                .Index(t => t.SkillLevelId)
                .Index(t => t.TechnoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.QuizzLinkQuestions", "QuizzId", "dbo.Quizz");
            DropForeignKey("dbo.Quizz", "TechnoId", "dbo.Technologie");
            DropForeignKey("dbo.Quizz", "SkillLevelId", "dbo.SkillLevel");
            DropForeignKey("dbo.Quizz", "CandidateId", "dbo.Candidate");
            DropForeignKey("dbo.QuizzLinkQuestions", "QuestionId", "dbo.Question");
            DropForeignKey("dbo.Question", "QuestionTechno", "dbo.Technologie");
            DropForeignKey("dbo.Question", "QuestionSkill", "dbo.SkillLevel");
            DropIndex("dbo.Quizz", new[] { "TechnoId" });
            DropIndex("dbo.Quizz", new[] { "SkillLevelId" });
            DropIndex("dbo.Quizz", new[] { "CandidateId" });
            DropIndex("dbo.QuizzLinkQuestions", new[] { "QuestionId" });
            DropIndex("dbo.QuizzLinkQuestions", new[] { "QuizzId" });
            DropIndex("dbo.Question", new[] { "QuestionTechno" });
            DropIndex("dbo.Question", new[] { "QuestionSkill" });
            DropTable("dbo.Quizz");
            DropTable("dbo.QuizzLinkQuestions");
            DropTable("dbo.Technologie");
            DropTable("dbo.SkillLevel");
            DropTable("dbo.Question");
            DropTable("dbo.Candidate");
        }
    }
}
