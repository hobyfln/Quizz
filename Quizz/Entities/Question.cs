using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz.Entities
{
    public partial class Questions
    {
        #region Getters/Setters
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdQuestion { get; set; }
        public string Question { get; set; }
        public string Type { get; set; }
        //public List Answers<Answer> QuestionAnswers{ get; set; }
        #endregion
    }
}
