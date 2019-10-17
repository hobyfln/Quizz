using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz.Entities
{
    public partial class Percent : BaseTable
    {
        [Key]
        [ForeignKey("SkillLevelId")]
        public int Id { get; set; }
        public string NameDifficulty { get; set; }
        public int EasyPercent { get; set; }
        public int MediumPercent { get; set; }
        public int HardPercent { get; set; }

        public virtual SkillLevel SkillLevelId { get; set; }
    }
}
