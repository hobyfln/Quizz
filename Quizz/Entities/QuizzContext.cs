using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz.Entities
{
    public partial class QuizzContext : DbContext
    {
        public QuizzContext() : base()
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToOneConstraintIntroductionConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<QuizzClass> Quizzs { get; set; }
        public DbSet<Question> Questions { get; set; }

        public DbSet<QuizzLinkQuestions> QuizzLinkQuestions { get; set; }

        public DbSet<Technologie> Technologies { get; set; }
        public DbSet<SkillLevel> SkillLevels { get; set; }
        public DbSet<Percent> Percents { get; set; }


    }
}
