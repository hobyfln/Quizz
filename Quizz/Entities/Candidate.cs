using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz
{
    public class Candidate
    {
        //Fields not required with Db

        #region Fields
        private int _candidateId;
        private string _name;
        private int _age;
        private string _techno;
        private int _level;

        #endregion

        #region Constructor

        public Candidate(int candidateId, string name, int age, string techno, int level)
        {
            _candidateId = candidateId;
            _name = name;
            _age = age;
            _techno = techno;
            _level = level;
        }

        #endregion

        #region Getters/Setters

        public int CandidateId { get => _candidateId; set => _candidateId = value; }
        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        public string Techno { get => _techno; set => _techno = value; }
        public int Level { get => _level; set => _level = value; }

        #endregion;
    }
}
