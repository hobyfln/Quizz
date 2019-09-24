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
        [ForeignKey("Questions")]
        public int IdQuestions { get; set; }
        [ForeignKey("Candidate")]
        public int IdCandidate { get; set; }
        [ForeignKey("User")]
        public string IdCreator { get; set; }
        public string Creator { get; set; }

        #endregion
    }
}
