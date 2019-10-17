namespace Quizz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PercentSkill : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Percent",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        NameDifficulty = c.String(),
                        EasyPercent = c.Int(nullable: false),
                        MediumPercent = c.Int(nullable: false),
                        HardPercent = c.Int(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedOn = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SkillLevel", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Percent", "Id", "dbo.SkillLevel");
            DropIndex("dbo.Percent", new[] { "Id" });
            DropTable("dbo.Percent");
        }
    }
}
