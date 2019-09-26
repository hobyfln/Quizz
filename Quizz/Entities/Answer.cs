using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz.Entities
{
    public partial class Answer
    {


        #region Get/Set
        //[ForeignKey("QuestionAnswer")]
        public int idQuestion { get; set; }
        public int IdAnswer { get; set; }
        public string IdQuestion { get; set; }
        public string Type { get; set; }

        //public virtual Questions QuestionAnswer { get; set; }

        #endregion;
    }
}
