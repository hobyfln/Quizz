using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz.Entities
{
    public partial class Answer : BaseTable
    {
        #region Get/Set
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AnswerId { get; set; }
        [ForeignKey("AnswerQuestionId")]
        public int QuizzQuestionsId { get; set; }
        public bool RightAnswer { get; set; }
        public string AboutAnswer { get; set; }


        public virtual Question AnswerQuestionId { get; set; }
        //public virtual ICollection<QuizzAnswer> QuizzAnswers { get; set; }

        #endregion;
    }
}
