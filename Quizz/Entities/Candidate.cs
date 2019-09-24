﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz
{
    public partial class Candidate
    {
        //Fields not required with Db

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CandidateId { get; set; }
        //[ForeignKey("CandidatQuizz")]
        public int QuizzId { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public int SkillLevel { get; set; }
        public int Age { get; set; }
        public string Techno { get; set; }

        //public virtual Quizz CandidatQuizz { get; set; }
    }
}
