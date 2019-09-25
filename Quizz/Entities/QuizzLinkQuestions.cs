using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz.Entities
{
    public partial class QuizzLinkQuestions
    {
        [Key, Column(Order = 0)]
        [ForeignKey("Quizz")]
        public int QuizzId { get; set; }
        [Key, Column(Order = 1)]
        public int QuestionId { get; set; }

        public virtual Quizz Quizz { get; set; }
    }
}
