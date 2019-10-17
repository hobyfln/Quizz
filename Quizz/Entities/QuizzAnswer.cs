using Quizz.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Entities
{

    public partial class QuizzAnswer : BaseTable
    {
        #region Accessors
        [Key, Column(Order = 0)]
        public int QuizzId { get; set; }

        [Key, Column(Order =1)]
        public int AnswerId { get; set; }

        //Questions libres
        public string AnswerFree{ get; set; }

        //Commentaires
        public string Comments { get; set; }

        //Virtual
        public virtual QuizzAnswer Quizzs { get; set; }
        public virtual Answer Answers { get; set; }
        #endregion

    }
}
