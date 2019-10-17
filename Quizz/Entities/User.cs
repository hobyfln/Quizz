using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz.Entities
{
    public partial class User
    {

        #region fields
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        //[ForeignKey("UserQuizzId")]
        //public int QuizzId { get; set; }

        private string Email { get; set; }
        private string Passwd { get; set; }
        public bool IsAdmin { get; set; }

        public virtual ICollection<QuizzClass> Quizzs { get; set; }
        #endregion

        #region login
        //Login

        #endregion
    }
}
