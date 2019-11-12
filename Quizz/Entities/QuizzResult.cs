using Quizz.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz.Entities
{
    public class QuizzResult : BaseTable
    {
        #region Accessors
        [Key, Column(Order = 0)]
        public int QuizzId { get; set; }

        [Key, Column(Order = 1)]
        public int AnswerId { get; set; }

        [Key, Column(Order = 2)]
        public int ResultId { get; set; }

        //Commentaires
        public string Comments { get; set; }

        public virtual Quizz Quizz { get; set; }
        public virtual Answer Answer { get; set; }
        public virtual Result Result { get; set; }
        #endregion
    }
}
