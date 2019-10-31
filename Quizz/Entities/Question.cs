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
        public int QuizzQuestionsId { get; set; }
        public string QuestionStr { get; set; }
        public string Type { get; set; }

        [ForeignKey("QuestionSkillId")]
        public int QuestionSkill { get; set; }
        [ForeignKey("QuestionTechnoId")]
        public int QuestionTechno { get; set; }

        public virtual SkillLevel QuestionSkillId { get; set; }
        public virtual Technology QuestionTechnoId { get; set; }
        
    }
}
