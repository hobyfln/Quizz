using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz.Entities
{
    public partial class User :BaseTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string FullName { get; set; }
        private string Email { get; set; }
        private string Password { get; set; }
        public bool IsAdmin { get; set; }
        public virtual ICollection<QuizzClass> Quizzs { get; set; }

        #region methode
        
        #endregion
    }
}
