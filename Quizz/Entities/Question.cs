using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz.Entities
{
    class Questions
    {

        #region Getters/Setters
        //[Key]
        public int IdQuestion { get; set; }
        public string Question { get; set; }
        public string Type { get; set; }

        #endregion
    }
}
