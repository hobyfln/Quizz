using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz.Entities
{
    public partial class QuizzLinkQuestions
    {
        [ForeignKey("QuizzId")]
        public int QuizzId;
        [ForeignKey("QuestionId")]
        public int QuestionId;

    }
}
