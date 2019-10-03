namespace Quizz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDb : DbMigration
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
                        QuestionsQuizz = c.Int(nullable: false),
                        QuestionStr = c.String(),
                        Type = c.String(),
                        QuestionSkill = c.Int(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedOn = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => new { t.QuestionId, t.QuestionsQuizz })
                .ForeignKey("dbo.SkillLevels", t => t.QuestionSkill, cascadeDelete: true)
                .ForeignKey("dbo.QuizzLinkQuestions", t => new { t.QuestionId, t.QuestionsQuizz })
                .Index(t => new { t.QuestionId, t.QuestionsQuizz })
                .Index(t => t.QuestionSkill);
            
            CreateTable(
                "dbo.SkillLevels",
                c => new
                    {
                        SkillLevelId = c.Int(nullable: false, identity: true),
                        QuizzId = c.Int(nullable: false),
                        QuestionId = c.Int(nullable: false),
                        NameSkillLevel = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedOn = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.SkillLevelId)
                .ForeignKey("dbo.Quizzs", t => t.QuizzId, cascadeDelete: true)
                .Index(t => t.QuizzId);
            
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
            
            CreateTable(
                "dbo.QuizzLinkQuestions",
                c => new
                    {
                        QuizzId = c.Int(nullable: false),
                        QuestionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.QuizzId, t.QuestionId })
                .ForeignKey("dbo.Quizzs", t => t.QuizzId, cascadeDelete: true)
                .Index(t => t.QuizzId);
            
            CreateTable(
                "dbo.Technologies",
                c => new
                    {
                        TechnologieId = c.Int(nullable: false, identity: true),
                        QuizzId = c.Int(nullable: false),
                        NameTechnologie = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedOn = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.TechnologieId)
                .ForeignKey("dbo.Quizzs", t => t.QuizzId, cascadeDelete: true)
                .Index(t => t.QuizzId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Technologies", "QuizzId", "dbo.Quizzs");
            DropForeignKey("dbo.Questions", new[] { "QuestionId", "QuestionsQuizz" }, "dbo.QuizzLinkQuestions");
            DropForeignKey("dbo.QuizzLinkQuestions", "QuizzId", "dbo.Quizzs");
            DropForeignKey("dbo.Questions", "QuestionSkill", "dbo.SkillLevels");
            DropForeignKey("dbo.SkillLevels", "QuizzId", "dbo.Quizzs");
            DropForeignKey("dbo.Quizzs", "CandidateId", "dbo.Candidates");
            DropIndex("dbo.Technologies", new[] { "QuizzId" });
            DropIndex("dbo.QuizzLinkQuestions", new[] { "QuizzId" });
            DropIndex("dbo.Quizzs", new[] { "CandidateId" });
            DropIndex("dbo.SkillLevels", new[] { "QuizzId" });
            DropIndex("dbo.Questions", new[] { "QuestionSkill" });
            DropIndex("dbo.Questions", new[] { "QuestionId", "QuestionsQuizz" });
            DropTable("dbo.Technologies");
            DropTable("dbo.QuizzLinkQuestions");
            DropTable("dbo.Quizzs");
            DropTable("dbo.SkillLevels");
            DropTable("dbo.Questions");
            DropTable("dbo.Candidates");
        }
    }
}
