namespace Quizz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SkillLevelLink : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SkillLevels", "QuizzId", "dbo.Quizzs");
            DropIndex("dbo.SkillLevels", new[] { "QuizzId" });
            AddColumn("dbo.Quizzs", "SkillLevelId", c => c.Int(nullable: false));
            CreateIndex("dbo.Quizzs", "SkillLevelId");
            AddForeignKey("dbo.Quizzs", "SkillLevelId", "dbo.SkillLevels", "SkillLevelId", cascadeDelete: true);
            DropColumn("dbo.SkillLevels", "QuizzId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SkillLevels", "QuizzId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Quizzs", "SkillLevelId", "dbo.SkillLevels");
            DropIndex("dbo.Quizzs", new[] { "SkillLevelId" });
            DropColumn("dbo.Quizzs", "SkillLevelId");
            CreateIndex("dbo.SkillLevels", "QuizzId");
            AddForeignKey("dbo.SkillLevels", "QuizzId", "dbo.Quizzs", "QuizzId", cascadeDelete: true);
        }
    }
}
