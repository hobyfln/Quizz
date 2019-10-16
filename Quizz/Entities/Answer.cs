using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz.Entities
{
    public partial class Answer
    {
        #region Get/Set
        //[ForeignKey("QuestionAnswer")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int QuestionId { get; set; }
        public int AnswerId { get; set; }
        [ForeignKey("AnswerQuizz")]
        public bool RightAnswer { get; set; }
        public string AboutAnswer { get; set; }


        //public virtual Questions QuestionAnswer { get; set; }

        #endregion;
    }
}
