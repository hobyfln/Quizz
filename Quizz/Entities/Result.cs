using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz.Entities
{
    public class Result : BaseTable
    {
        [Key, Column(Order = 0)]
        [ForeignKey ("QuizzId")]
        public int Quizz { get; set; }
        [Key, Column(Order = 1)]
        [ForeignKey("QuizzId")]
        public int Answer { get; set; }
        public int Answered { get; set; }
        public bool IsCorrect { get; set; }
        public bool IsOpen { get; set; }

        //[ForeignKey("ResultAnswer")]
        //public int QuizzAnswerId { get; set; }

        public virtual QuizzAnswer QuizzId { get; set; }



    }
}
