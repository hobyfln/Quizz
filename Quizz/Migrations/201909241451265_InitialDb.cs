namespace Quizz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDb : DbMigration
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
                    })
                .PrimaryKey(t => t.CandidateId);
            
            CreateTable(
                "dbo.Quizzs",
                c => new
                    {
                        QuizzId = c.Int(nullable: false, identity: true),
                        QuestionsId = c.Int(nullable: false),
                        CandidateId = c.Int(nullable: false),
                        CreatorId = c.String(),
                        Creator = c.String(),
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
            DropTable("dbo.Candidates");
        }
    }
}
