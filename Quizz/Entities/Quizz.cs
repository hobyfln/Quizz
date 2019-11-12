using Quizz.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz
{
    public partial class Quizz : BaseTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int QuizzId { get; set; }
        [ForeignKey("QuizzQuestions")]
        public int QuizzQuestionsId { get; set; }
        [ForeignKey("QuizzCandidate")]
        public int QuizzCandidateId { get; set; }
        [ForeignKey("QuizzSkillLevel")]
        public int QuizzSkillLevelId { get; set; }
        [ForeignKey("QuizzTechno")]
        public int QuizzTechnoId { get; set; }
        [ForeignKey("QuizzUser")]
        public int QuizzUserId { get; set; }

        public virtual QuizzLinkQuestions QuizzQuestions { get; set; }
        public virtual Candidate QuizzCandidate { get; set; }
        public virtual SkillLevel QuizzSkillLevel { get; set; }
        public virtual Technology QuizzTechno { get; set; }
        public virtual User QuizzUser { get; set; }
    }
}
