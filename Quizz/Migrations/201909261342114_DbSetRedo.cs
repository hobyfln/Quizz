namespace Quizz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbSetRedo : DbMigration
    {
        public override void Up()
        {
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
            
            AddColumn("dbo.Questions", "QuestionSkill", c => c.Int(nullable: false));
            CreateIndex("dbo.Questions", "QuestionSkill");
            AddForeignKey("dbo.Questions", "QuestionSkill", "dbo.SkillLevels", "SkillLevelId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Technologies", "QuizzId", "dbo.Quizzs");
            DropForeignKey("dbo.Questions", "QuestionSkill", "dbo.SkillLevels");
            DropForeignKey("dbo.SkillLevels", "QuizzId", "dbo.Quizzs");
            DropIndex("dbo.Technologies", new[] { "QuizzId" });
            DropIndex("dbo.SkillLevels", new[] { "QuizzId" });
            DropIndex("dbo.Questions", new[] { "QuestionSkill" });
            DropColumn("dbo.Questions", "QuestionSkill");
            DropTable("dbo.Technologies");
            DropTable("dbo.SkillLevels");
        }
    }
}
