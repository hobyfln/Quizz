﻿using System;
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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LinkId { get; set; }
        public int QuizzId { get; set; }
        [ForeignKey("Question")]
        public int QuizzQuestionsId { get; set; }

        public virtual Question Question { get; set; }
    }
}
