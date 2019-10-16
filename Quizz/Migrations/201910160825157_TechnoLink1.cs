namespace Quizz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TechnoLink1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Quizzs", "TechnoId", c => c.Int(nullable: false));
            CreateIndex("dbo.Quizzs", "TechnoId");
            AddForeignKey("dbo.Quizzs", "TechnoId", "dbo.Technologies", "TechnologieId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Quizzs", "TechnoId", "dbo.Technologies");
            DropIndex("dbo.Quizzs", new[] { "TechnoId" });
            DropColumn("dbo.Quizzs", "TechnoId");
        }
    }
}
