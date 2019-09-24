using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz.Entities
{
    public partial class User
    {

        public int userId { get; set; }
        public int idQuizz { get; set; }
        public bool isAdmin { get; set; }

    }
}
