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
        public int QuestionId { get; set; }
        [ForeignKey("QuizzCandidate")]
        public int CandidateId { get; set; }
        //[ForeignKey("QuizzCreator")]
        public string CreatorId { get; set; }
        public string Creator { get; set; }

        //public virtual User QuizzCreator { get; set; }
        public virtual Candidate QuizzCandidate { get; set; }
    }
}
