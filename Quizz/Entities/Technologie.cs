using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz.Entities
{
    public partial class Technologie : BaseTable
    {
        #region Getters/Setters
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TechnologieId { get; set; }
        [ForeignKey("CandidatQuizz")]
        public int QuizzId { get; set; }
        public string NameTechnologie { get; set; }

        public virtual Quizz CandidatQuizz { get; set; }
        #endregion;
    }
}
