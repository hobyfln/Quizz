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
        [Key]
        public int UserId { get; set; }
        public int QuizzId { get; set; }
        [ForeignKey("UserQuizz")]
        private string Email { get; set; }
        private string Passwd { get; set; }
        public bool IsAdmin { get; set; }
        #region
              
        #endregion
    }
}
