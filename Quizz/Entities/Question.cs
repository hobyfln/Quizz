using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz.Entities
{
    class Questions
    {
        #region Fields

        private int _idQuestion;
        private string _question;
        private string _type;

        #endregion

        #region Constructor

        public Questions(int idQuestion, string question, string type)
        {
            _idQuestion = idQuestion;
            _question = question;
            _type = type;
        }

        #endregion

        #region Getters/Setters

        public int IdQuestion { get => _idQuestion; set => _idQuestion = value; }
        public string Question { get => _question; set => _question = value; }
        public string Type { get => _type; set => _type = value; }

        #endregion
    }
}
