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
        public int AnswerId { get; set; }

        //[ForeignKey("QuestionAnswer")]
        //public int QuestionId { get; set; }

        //Réponses correctes
        public bool AnswerRight { get; set; }

        //Reponses vides non repondues
        public string AnswerVoid { get; set; }

        //Commentaires sur la réponses
        public string AnswerCom { get; set; }

        //Reponse à corriger manuellement
        public string AnswerQuestion { get; set; }

        

        #endregion;
    }
}
