using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz
{
    public class Quizz
    {
        #region Getters/Setters
        [Key]
        public int IdQuizz { get; set; }
        [ForeignKey("QuizzQuestions")]
        public int IdQuestions { get; set; }
        [ForeignKey("QuizzCandidate")]
        public int IdCandidate { get; set; }
        [ForeignKey("QuizzCreator")]
        public string IdCreator { get; set; }
        public string Creator { get; set; }

        //public virtual Questions QuizzQuestions { get; set; }
        //public virtual User QuizzUser { get; set; }
        public virtual Candidate QuizzCandidate { get; set; }

    #endregion
}
}
