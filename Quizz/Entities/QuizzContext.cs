using Microsoft.AspNet.Identity.EntityFramework;
using Quizz.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz.Entities
{
    public partial class QuizzContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Quizz> Quizzs { get; set; }
        public DbSet<Question> Questions { get; set; }

        public DbSet<QuizzLinkQuestions> QuizzLinkQuestions { get; set; }

        public DbSet<Technology> Technologies { get; set; }
        public DbSet<SkillLevel> SkillLevels { get; set; }
        public DbSet<Answer> Answers { get; set; }

        public DbSet<QuizzResult> QuizzResults { get; set; }
        public DbSet<Result> Results { get; set; }

        public QuizzContext()
            : base("QuizzConnection", throwIfV1Schema: false)
        {
            InitializeDatabase();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToOneConstraintIntroductionConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);

        }

        protected virtual void InitializeDatabase()
        {
            if (!Database.Exists())
            {
                Database.Initialize(false);
                new DatabaseInitializer().InitializeDatabase(this);
            }
        }

        //Ctor
        public static QuizzContext Create()
        {
            return new QuizzContext();
        }
    }
    public class DatabaseInitializer : CreateDatabaseIfNotExists<QuizzContext>
    {
        public override void InitializeDatabase(QuizzContext context)
        {
            base.InitializeDatabase(context);
            Seed(context);
        }
    }
}
