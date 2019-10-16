using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz.Entities
{
    public partial class Question : BaseTable
    {
        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ForeignKey("QuizzId")]
        public int QuestionId { get; set; }
        [Key, Column(Order = 1)]
        [ForeignKey("QuizzId")]
        public int QuestionsQuizz { get; set; }
        public string QuestionStr { get; set; }
        public string Type { get; set; }
        [ForeignKey("QuizzQuestions")]
        public int QuestionSkill { get; set; }

        public virtual SkillLevel QuizzQuestions { get; set; }
        public virtual QuizzLinkQuestions QuizzId { get; set; }
        //public List Answers<Answer> QuestionAnswers{ get; set; }
    }
}
