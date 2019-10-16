using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz.Entities
{
    class Admin : User
    {
        #region fields
        public int AdminId { get; set; }
        public int NameAdmin { get; set; }
        #endregion
    }
}
