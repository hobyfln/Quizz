using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Quizz> Quizzs { get; set; }
        public DbSet<Question> Questions { get; set; }

        public DbSet<QuizzLinkQuestions> QuizzLinkQuestions { get; set; }

        public DbSet<Technologie> Technologies { get; set; }
        public DbSet<SkillLevel> SkillLevels { get; set; }

        //public DbSet<SkillLevel> SkillLevels { get; set; }



    }
}
