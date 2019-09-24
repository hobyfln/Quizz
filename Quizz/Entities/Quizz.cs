using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz
{
    public class Quizz
    {
        #region Fields

        private int _idQuizz;
        private int _idQuestions;
        private int _idCandidate;
        private string _creator;
        private string _url;

        #endregion

        #region Constructor
        public Quizz(int idQuizz, int idQuestions, int idCandidate, string creator, string url)
        {
            _idQuizz = idQuizz;
            _idQuestions = idQuestions;
            _idCandidate = idCandidate;
            _creator = creator;
            _url = url;
        }
        #endregion

        #region Getters/Setters
        public int IdQuizz { get => _idQuizz; set => _idQuizz = value; }
        public int IdQuestions { get => _idQuestions; set => _idQuestions = value; }
        public int IdCandidate { get => _idCandidate; set => _idCandidate = value; }
        public string Creator { get => _creator; set => _creator = value; }
        #endregion
    }
}
