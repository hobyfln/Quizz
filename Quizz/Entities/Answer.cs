using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz.Entities
{
    public partial class Answer
    {
        #region Fields
            //[ForeignKey(Answer)]
            private int _idAnswer;
            private string _idQuestion;
            private string _type;

        #endregion

        #region Getters/Setters

        public int IdAnswer { get => _idAnswer; set => IdAnswer = value; }
        public string IdQuestion { get => _idQuestion; set => IdQuestion= value ; }
        public string Type { get => _idQuestion; set => Type= value ; }

        #endregion;
    }
}
