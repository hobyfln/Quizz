using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz.Entities
{
    public partial class SkillLevel : BaseTable
    {
        #region Getters/Setters
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SkillLevelId { get; set; }
        [ForeignKey("CandidatQuizz")]
        public int QuizzId { get; set; }
        public int QuestionId { get; set; }
        public string NameSkillLevel { get; set; }
        public virtual Quizz CandidatQuizz { get; set; }
        

        #endregion

    }
}
