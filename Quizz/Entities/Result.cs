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
        [Key]
        public int ResultId { get; set; }

        public int ResultQuizzId { get; set; }
        public int ResultAnswerId { get; set; }
        public bool Answered { get; set; }
        public bool IsCorrect { get; set; }
        public bool IsOpen { get; set; }
        


    }
}
