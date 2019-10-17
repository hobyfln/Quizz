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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int QuestionId { get; set; }
        [ForeignKey("QuestionAnswerId")]
        public int AnswerId { get; set; }
        public string QuestionStr { get; set; }
        public string Type { get; set; }

        [ForeignKey("QuestionSkillId")]
        public int QuestionSkill { get; set; }
        [ForeignKey("QuestionTechnoId")]
        public int QuestionTechno { get; set; }

        public virtual SkillLevel QuestionSkillId { get; set; }
        public virtual Technologie QuestionTechnoId { get; set; }
        public virtual Answer QuestionAnswerId { get; set; }

        //public List Answers<Answer> QuestionAnswers{ get; set; }
    }
}
